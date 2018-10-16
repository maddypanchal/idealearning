using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using DataAccess;
using BusinessLogic.Admin;


public partial class Employee_SyllabusDetails : System.Web.UI.Page
{
    #region "Variable Decleration"
    private clsMaster obj_Master = new clsMaster();
    private clsEmployee obj_Employee = new clsEmployee();
    private DataSet DS;
    private int RecordStatus;
    private static int AdminRegistrationId;
    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            FillSyllabus();
            FillClass();
            Employee();
        }
    }

    #region "Fill Employee"
    protected void Employee()
    {
        try
        {
            DS = obj_Employee.DisplayEmployeeSyllbus();
           // ddlEmployee.DataSource = DS;
           // DS.Tables[0].Merge(DS.Tables[1]);
          //  ddlEmployee.DataTextField = DS.Tables[0].Columns[1].ToString();
          //  ddlEmployee.DataValueField = DS.Tables[0].Columns[0].ToString();
          //  ddlEmployee.DataBind();
           // ddlEmployee.Dispose();
        }
        catch (Exception ex)
        {
            lblMsg.Text = ex.ToString();
        }
    }
    #endregion

    #region "Fill Class"
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
            lblMsg.Text = ex.ToString();
        }
    }
    #endregion 

    #region"Fill Subject by Class"
    private void FillClassCourses()
    {
        try
        {
            obj_Master.ClassId = Convert.ToInt32(ddlClass.SelectedValue.ToString());
            DS = obj_Master.FillClassCoursesDdl();
            ddlCourselist.DataSource = DS;

            DS.Tables[0].Merge(DS.Tables[1]);
            ddlCourselist.DataTextField = DS.Tables[0].Columns[1].ToString();
            ddlCourselist.DataValueField = DS.Tables[0].Columns[0].ToString();
            ddlCourselist.DataBind();
            ddlCourselist.Dispose();


        }
        catch (Exception ex)
        {
            lblMsg.Text = ex.ToString();
        }
    }
    #endregion

    #region"Select Index Change Courses list"
    protected void ddlCourseList_SelectedIndexChanged(object sender, EventArgs e)
    {

        FillSubject();
    }
    #endregion

    #region"Class Select Index Changed"
    protected void ddlClass_SelectedIndexChanged(object sender, EventArgs e)
    {
        FillClassCourses();

    }
    #endregion

    #region" Fill Subject by Class Id"
    private void FillSubject()
    {
        try
        {



            obj_Master.ClassId = Convert.ToInt32(ddlClass.SelectedValue.ToString());
            obj_Master.ClassCoursesId = Convert.ToInt32(ddlCourselist.SelectedValue.ToString());
            DS = obj_Master.FillSubjectCourses();
            ddlSubject.DataSource = DS;
            DS.Tables[0].Merge(DS.Tables[1]);
            ddlSubject.DataTextField = DS.Tables[0].Columns[1].ToString();
            ddlSubject.DataValueField = DS.Tables[0].Columns[0].ToString();
            ddlSubject.DataBind();
            ddlSubject.Dispose();

        }
        catch (Exception ex)
        {
            lblMsg.Text = ex.ToString();
        }
    }
    #endregion
    
    #region " Fill User Grid View"
    public void FillSyllabus()
    {
        DS = obj_Master.DisplaySyllabus();
        gvDetail1.DataSource = DS;
        gvDetail1.DataBind();
    }
    #endregion "End Fill User GridView"

    protected void gvDetail1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {

    }
    protected void gvDetail1_RowEditing(object sender, GridViewEditEventArgs e)
    {

    }
    protected void gvDetail1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        obj_Master.SyllabusId = Convert.ToInt32(gvDetail1.DataKeys[e.RowIndex].Values["SyllabusId"].ToString());
        RecordStatus = obj_Master.DeleteSylabus();
        FillSyllabus();
    }
    protected void gvDetail1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {

    }

    protected void gvDetail1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {

        //if(Convert.ToInt32(ddlClass.SelectedValue)!= -1 && Convert.ToInt32(ddlCourselist.SelectedValue) != -1 && Convert.ToInt32(ddlSubject.SelectedValue) != -1)
        //{
        //    gvDetail1.PageIndex = e.NewPageIndex;
        //    DS = obj_Master.SearchSyllabusMultiple();
        //    if (DS != null)
        //    {

        //        gvDetail1.DataSource = DS;
        //        gvDetail1.DataBind();
        //        gvDetail1.Dispose();
        //        if (gvDetail1.Rows.Count == 0)
        //        {

        //            lblMsg.Text = "No Record Found";
        //        }

        //    }
        //    else
        //    {
        //        lblMsg.Text = "No Record Found";

        //    }

        //}
        //else
        //{
        //}


        gvDetail1.PageIndex = e.NewPageIndex;
        DS = obj_Master.DisplaySyllabus();
        gvDetail1.DataSource = DS;
        gvDetail1.DataBind();

    }

    #region "button Search"
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        try
        {
            if (Convert.ToInt32(ddlClass.SelectedValue) == -1 || ddlClass.SelectedItem.ToString() == "{--Select--}")
            {
                obj_Master.ClassId = 0;
            }
            else
            {
                obj_Master.ClassId = Convert.ToInt32(ddlClass.SelectedValue);
            }

            if (Convert.ToInt32(ddlCourselist.SelectedValue)== -1)
            {
                obj_Master.CoursesId = 0;
            }
            else
            {
                obj_Master.CoursesId = Convert.ToInt32(ddlCourselist.SelectedValue);
            }

            if (Convert.ToInt32(ddlSubject.SelectedValue) == -1 )
            {
                obj_Master.SubjectId = 0;
            }
            else
            {
                obj_Master.SubjectId = Convert.ToInt32(ddlSubject.SelectedValue);
            }

        
            DS = obj_Master.SearchSyllabusMultiple();
            if (DS != null)
            {

                gvDetail1.DataSource = DS;
                gvDetail1.DataBind();
                gvDetail1.Dispose();
                if (gvDetail1.Rows.Count == 0)
                {

                    lblMsg.Text = "No Record Found";
                }
            
            }
            else
            {
                 lblMsg.Text = "No Record Found";
              
            }
        }
        catch (Exception ex)
        {
               lblMsg.Text = ex.ToString();
               lblMsg.Visible = true;

        }
    }
    #endregion
}