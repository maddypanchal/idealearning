using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using DataAccess;
using BusinessLogic.Admin;

public partial class Employee_StudentDetails : System.Web.UI.Page
{
    #region "Variable Decleration"
    private clsStudent obj_Student = new clsStudent();
    private clsMaster obj_Master = new clsMaster();
    private DataSet DS;
    private int RecordStatus;
    private static int AdminRegistrationId;
    #endregion
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            FillStudent();

            FillClass();
        }
    }


    #region "Fill FillClass"
    protected void FillClass()
    {
        try
        {
            DS = obj_Master.FillClassDdl();
            ddlClass.DataSource = DS;
            DS.Tables[0].Merge(DS.Tables[1]);
            ddlClass.DataTextField = DS.Tables[0].Columns[1].ToString();
            ddlClass.DataValueField = DS.Tables[0].Columns[0].ToString();
            ddlClass.DataBind();
            ddlClass.Dispose();
        }
        catch (Exception ex)
        {
            lblmsg.Text = ex.ToString();
        }
    }
    #endregion


    #region " Fill User Grid View"
    public void FillStudent()
    {
        DS = obj_Student.DisplayStudent();
        gvDetail1.DataSource = DS;
        gvDetail1.DataBind();
        if (gvDetail1.Rows.Count == 0)
        {
            lblmsg.Visible = true;
            lblmsg.Text = "Record not Found pleases try again";

        }
    }
    #endregion "End Fill User GridView"

    #region "Active / Inactive Pack Type Data"
    public void IS_LOCKED_Activate_Deactivate(object sender, CommandEventArgs e) //ACTIVE\DAECTIVE
    {
        try
        {
            obj_Student.StudentId = Convert.ToInt32(e.CommandArgument.ToString());
            obj_Student.AccountActiveInactiveAccount();
            FillStudent();
        }
        catch (System.Exception ex)
        {
            //  lblMsg.Text = ex.ToString(); //LABEL ERROR MSG
            // lblMsg.Visible = true;
        }
    }
    #endregion


    protected void gvDetail1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {

    }
    protected void gvDetail1_RowEditing(object sender, GridViewEditEventArgs e)
    {

    }
    protected void gvDetail1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        obj_Student.StudentId = Convert.ToInt32(gvDetail1.DataKeys[e.RowIndex].Values["StudentId"].ToString());
        RecordStatus = obj_Student.DeleteStudent();
        FillStudent();
    }
    protected void gvDetail1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {

    }

    protected void gvDetail1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvDetail1.PageIndex = e.NewPageIndex;
        DS = obj_Student.DisplayStudent();
        gvDetail1.DataSource = DS;
        gvDetail1.DataBind();
    }


    #region"Class dropdown Slect index changed "
    protected void ddlClass_SelectedIndexChanged(object sender, EventArgs e)
    {
       // FillClassCourses();
       // Search();
    }
    #endregion


    //#region"Fill Subject by Class"
    //private void FillClassCourses()
    //{
    //    try
    //    {
    //        obj_Master.ClassId = Convert.ToInt32(ddlClass.SelectedValue.ToString());
    //        DS = obj_Master.FillClassCoursesDdl();
    //        ddlCourselist.DataSource = DS;

    //        DS.Tables[0].Merge(DS.Tables[1]);

    //        ddlCourselist.DataTextField = DS.Tables[0].Columns[1].ToString();
    //        ddlCourselist.DataValueField = DS.Tables[0].Columns[0].ToString();
    //        ddlCourselist.DataBind();
    //        ddlCourselist.Dispose();
        
    //    }
    //    catch (Exception ex)
    //    {
    //        lblmsg.Text = ex.ToString();
    //    }
    //}
    //#endregion
    protected void ddlCourseList_SelectedIndexChanged(object sender, EventArgs e)
    {
       // FillSubjectFrist();
      //  Search();
    }

    private void Search()
    {
      
        try
        {

            if (txtName.Text == "")
            {
                txtName.Text = null;
            }
            else
            {
                obj_Student.StudentName = txtName.Text.Trim();
            }
            if (txtMobile.Text == "")
            {
                txtMobile.Text = null;
            }
            else
            {
                obj_Student.Mobile = txtMobile.Text.Trim();
            }
            if (txtRegistration.Text == "")
            {
                txtRegistration.Text = null;
            }
            else
            {
                obj_Student.RegistrationNo = txtRegistration.Text.Trim();
            }
               
            if (Convert.ToInt32(ddlClass.SelectedValue) == -1)
            {
                obj_Student.ClassId = 0;
            }
            else
            {
                obj_Student.ClassId = Convert.ToInt32(ddlClass.SelectedValue);
            }

            //if (Convert.ToInt32(ddlCourselist.SelectedValue) == -1)
            //{
            //    obj_Student.ClassId = 0;
            //}
            //else
            //{
            //    obj_Student.CourseOne = ddlCourselist.SelectedItem.ToString();
            //}

            //if (Convert.ToInt32(ddlSubject.SelectedValue) == -1)
            //{
            //    obj_Student.ClassId = 0;
            //}
            //else
            //{
            //    obj_Student.CourseOneSubjectOne = ddlSubject.SelectedItem.ToString();
            //}
            DS = obj_Student.SearchStudentMultiple();
            if (DS != null)
            {
              
                gvDetail1.DataSource = DS;
                gvDetail1.DataBind();
                gvDetail1.Dispose();

                if (gvDetail1.Rows.Count == 0)
                {
                    lblmsg.Visible = true;
                    lblmsg.Text = "Record not Found pleases try again";

                }


            }
            else
            {
      
            }
        }
        catch (Exception ex)
        {
           lblmsg.Text = ex.ToString();
           lblmsg.Visible = true;

        }
 
    }

    //#region"Fill Subject by Class"
    //private void FillSubjectFrist()
    //{
    //    try
    //    {
    //        obj_Master.ClassId = Convert.ToInt32(ddlClass.SelectedValue.ToString());
    //        obj_Master.ClassCoursesId = Convert.ToInt32(ddlCourselist.SelectedValue.ToString());
    //        DS = obj_Master.FillSubjectCourses();
    //        ddlSubject.DataSource = DS;

    //        DS.Tables[0].Merge(DS.Tables[1]);
    //        ddlSubject.DataTextField = DS.Tables[0].Columns[1].ToString();
    //        ddlSubject.DataValueField = DS.Tables[0].Columns[0].ToString();
    //        ddlSubject.DataBind();
    //        ddlSubject.Dispose();
         
    //    }
    //    catch (Exception ex)
    //    {
    //        lblmsg.Text = ex.ToString();
    //    }
    //}
    
    //#endregion



     #region "button Search"
     protected void btnSearch_Click(object sender, EventArgs e)
      {
        try
         {
            obj_Student.StudentName = txtName.Text.Trim();
            obj_Student.Mobile = txtMobile.Text.Trim();
            obj_Student.RegistrationNo = txtRegistration.Text.Trim();
            if (Convert.ToInt32(ddlClass.SelectedValue) == -1)
            {
                obj_Student.ClassId = 0;
            }
            else
            {
                obj_Student.ClassId = Convert.ToInt32(ddlClass.SelectedValue);
            }

            //if (Convert.ToInt32(ddlCourselist.SelectedValue) == -1)
            //{
            //    obj_Student.ClassId = 0;
            //}
            //else
            //{
            //    obj_Student.CourseOne = ddlCourselist.SelectedItem.ToString();
            //}

            //if (Convert.ToInt32(ddlSubject.SelectedValue) == -1)
            //{
            //    obj_Student.ClassId = 0;
            //}
            //else
            //{
            //    obj_Student.CourseOneSubjectOne = ddlSubject.SelectedItem.ToString();
            //}

            DS = obj_Student.SearchStudentMultiple();
            if (DS != null)
            {
                gvDetail1.DataSource = DS;
                gvDetail1.DataBind();
                gvDetail1.Dispose();
                lblmsg.Visible = false;
                if (gvDetail1.Rows.Count == 0)
                {
                    lblmsg.Visible = true;
                    lblmsg.Text = "Record not Found pleases try again";
                }
            }
            else
            {
      
            }
        }
        catch (Exception ex)
        {
           lblmsg.Text = ex.ToString();
           lblmsg.Visible = true;
        }
    }
    #endregion

}