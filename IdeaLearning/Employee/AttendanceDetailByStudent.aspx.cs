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

public partial class Employee_AttendanceDetailByStudent : System.Web.UI.Page
{
    #region "Variable Decleration"
    private clsStudent obj_Student = new clsStudent();
    private DataSet DS;
    private int RecordStatus;
    public int StudentId;
    private static int AdminRegistrationId;
    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {
        StudentId = int.Parse(Request.QueryString["Sid"]);
        if (!IsPostBack)
        {
            FillStudent();
        }
    }


    #region " Fill User Grid View"
    public void FillStudent()
    {
        obj_Student.StudentId = StudentId;
        DS = obj_Student.DisplaySingalStudentByAttendance();
        gvDetail1.DataSource = DS;
        gvDetail1.DataBind();
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
    //    obj_Student.StudentId = Convert.ToInt32(gvDetail1.DataKeys[e.RowIndex].Values["StudentId"].ToString());
    //    RecordStatus = obj_Student.DeleteStudent();
    //    FillStudent();
    }
    protected void gvDetail1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {

    }
}