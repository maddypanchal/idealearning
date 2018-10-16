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

public partial class Student_HomeWorkDetails : System.Web.UI.Page
{

    #region "Variable Decleration"
    private clsStudent obj_Student = new clsStudent();
    private clsMaster obj_Master = new clsMaster();
    private DataSet DS;
    private static int StudentId;
    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            FillClass();
        }
    }
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
    private void HomeWorkShow()
    {
        obj_Master.ClassId =Convert.ToInt32(ddlClass.SelectedValue);
        obj_Master.ClassCoursesId = Convert.ToInt32(ddlCourselist.SelectedValue);
        obj_Master.SubjectId = Convert.ToInt32(ddlSubject.SelectedValue);
        DS = obj_Master.RepeterHw();
        gvDetail1.DataSource = DS;
        gvDetail1.DataBind();
    }

    protected void ddlClass_SelectedIndexChanged(object sender, EventArgs e)
    {
       
        FillClassCourses();
    }

    protected void ddlCourseList_SelectedIndexChanged(object sender, EventArgs e)
    {
        FillSubject(); 
    }


    protected void ddlSubject_SelectedIndexChanged(object sender, EventArgs e)
    {
        HomeWorkShow();
    }
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

    protected void gvDetail1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        obj_Master.HomeWorkId = Convert.ToInt32(gvDetail1.DataKeys[e.RowIndex].Values["HomeWorkId"].ToString());
        obj_Master.DeleteHomeWorkById();
        HomeWorkShow();
    }
}