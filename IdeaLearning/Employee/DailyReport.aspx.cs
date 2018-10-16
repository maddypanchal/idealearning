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

public partial class Employee_DailyReport : System.Web.UI.Page
{
    #region "VARIABLE DECLARATION"
    private clsMaster objMaster = new clsMaster();
    private DataSet DS;
    private int RecordStatus;
    private int checkRecordStatus;
    private int EmployeeId;
    // private int LoginType;
    private string myFileExtension;
    #endregion
    protected void Page_Load(object sender, EventArgs e)
    {
        EmployeeId = int.Parse(Request.QueryString["Sid"]); 
        if (!IsPostBack)
        {
            FillDailyReprt();
        }
    }

    #region "Active / Inactive Pack Type Data"
    public void IS_LOCKED_Activate_Deactivate(object sender, CommandEventArgs e) //ACTIVE\DAECTIVE
    {
        try
        {
            objMaster.EmployeeWorkId = Convert.ToInt32(e.CommandArgument.ToString());
            objMaster.TaskStatusActiveInactive();
            FillDailyReprt();
        }
        catch (System.Exception ex)
        {
            //  lblMsg.Text = ex.ToString(); //LABEL ERROR MSG
            // lblMsg.Visible = true;
        }
    }
    #endregion


    #region " Fill User Grid View"
    public void FillDailyReprt()
    {
        objMaster.EmployeeId = EmployeeId;
        DS = objMaster.DisplayDailyReport();
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
        objMaster.EmployeeWorkId = Convert.ToInt32(gvDetail1.DataKeys[e.RowIndex].Values["EmployeeWorkId"].ToString());
        RecordStatus = objMaster.DeleteDailyReport();
        FillDailyReprt();
    }
    protected void gvDetail1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {

    }
}