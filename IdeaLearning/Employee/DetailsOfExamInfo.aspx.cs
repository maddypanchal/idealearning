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

public partial class Employee_DetailsOfExamInfo : System.Web.UI.Page
{

    #region "Variable Decleration"
    private clsNews obj_News = new clsNews();
    private clsMaster obj_Master = new clsMaster();
    private DataSet DS;
    private int RecordStatus;
    private static int StudentId;
    #endregion
    protected void Page_Load(object sender, EventArgs e)
    {
       // if (Session["USER_NAME"] != null)
       // {
           if (!IsPostBack)
            {
             FillClass();
            }
       // }
      //  else
      //  {
         //   Response.Redirect("/Login.aspx");
       // }
    }
    #region "Fill Toppers Year List Method"
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
            //lblMsg.Text = ex.ToString();
        }
    }
    #endregion "End Main Category List Method"

    protected void ddlClass_SelectedIndexChanged(object sender, EventArgs e)
    {
        FillClassCourses();
    }

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
    #region " Fill User Grid View"

    #region"Course List Selected Index Changed"
    protected void ddlCourseList_SelectedIndexChanged(object sender, EventArgs e)
    {
        FillSubject();
        
    }
    #endregion
    protected void ddlSubject_SelectedIndexChanged(object sender, EventArgs e)
    {
        FillExamInfo();
    }
     
    #region"Fill Subject by Courses"
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

public void FillExamInfo()
    {
        obj_Master.ClassId = Convert.ToInt32(ddlClass.SelectedValue.ToString());
        obj_Master.ClassCoursesId = Convert.ToInt32(ddlCourselist.SelectedValue.ToString());
        obj_Master.SubjectId = Convert.ToInt32(ddlSubject.SelectedValue.ToString());
        DS = obj_Master.DisplayExamInfo();
        gvDetail1.DataSource = DS;
        gvDetail1.DataBind();
    }
    #endregion "End Fill User GridView"

    protected void gvDetail1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        obj_Master.ExamInfoId = Convert.ToInt32(gvDetail1.DataKeys[e.RowIndex].Values["ExamInfoId"].ToString());
        RecordStatus = obj_Master.DeleteExamINFO();
        FillExamInfo();
    }
}