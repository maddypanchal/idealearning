using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Data;
using System.IO;
using BusinessLogic.Admin;
using System.Globalization;

public partial class Employee_FillTaskByEmployee : System.Web.UI.Page
{

    #region "VARIABLE DECLARATION"
    private int checkRecordStatus;
    private int EmployeeWorkId;
    private clsMaster obj_Master = new clsMaster();
    private clsEmployee obj_Employee = new clsEmployee();
    private DataSet DS;
    #endregion


    protected void Page_Load(object sender, EventArgs e)
    {
        EmployeeWorkId = int.Parse(Request.QueryString["Sid"]);
        if (!IsPostBack)
        {
            FillUpdateTask();
        }
    }

    #region " Fill User Grid View"
    public void FillUpdateTask()
    {


        obj_Master.CurrentEmployee = Session["USER_NAME"].ToString();
        obj_Master.EmployeeId = Convert.ToInt32(Session["EMPLOYEE_ID"]);
        obj_Master.EmployeeWorkId = EmployeeWorkId;
        DS = obj_Master.DisplayUpateTask();
        gvDetail1.DataSource = DS;
        gvDetail1.DataBind();
        if (gvDetail1.Rows.Count == 0)
        {
            lblMsg.Visible = true;
            lblMsg.Text = "Rocord is Empty";
        }
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
        obj_Master.EmployeeWorkDetailsId = Convert.ToInt32(gvDetail1.DataKeys[e.RowIndex].Values["EmployeeWorkDetailsId"].ToString());
        checkRecordStatus = obj_Master.DeleteDailyReport();
        FillUpdateTask();
    }
    protected void gvDetail1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {

    }
}