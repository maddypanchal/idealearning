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
public partial class Admin_StudentPrint : System.Web.UI.Page
{
    #region "Variable Decleration"
    private clsStudent obj_Student = new clsStudent();
    private DataSet DS;
    private int RecordStatus;
    private static int AdminRegistrationId;
    #endregion
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            FillStudent();
        }
    }

    #region " Fill User Grid View"
    public void FillStudent()
    {


        obj_Student.StudentName = "";
        obj_Student.Mobile = "";
        obj_Student.RegistrationNo = "";
        obj_Student.ClassId =Convert.ToInt32(Session["ClassId"].ToString());
        // DS = obj_Student.DisplayStudent();
        DS = obj_Student.SearchStudentMultiple();
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
        obj_Student.StudentId = Convert.ToInt32(gvDetail1.DataKeys[e.RowIndex].Values["StudentId"].ToString());
        RecordStatus = obj_Student.DeleteStudent();
        FillStudent();
    }
    protected void gvDetail1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {

    }
}