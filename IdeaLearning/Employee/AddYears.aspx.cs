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

public partial class Employee_AddYears : System.Web.UI.Page
{
   

    #region "VARIABLE DECLARATION"
    private clsToppers obj_Toppers = new clsToppers();
    private clsNews obj_News = new clsNews();
    private DataSet DS;
    private int RecordStatus;
    private int checkRecordStatus;
    // private int LoginType;
    private string myFileExtension;
    #endregion
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            FillYears();
        }
    }
  
    #region Clear Form
    protected void clrForm()
    {
        txtYears.Text = "";
    }
    #endregion
    
    protected void btnSave_Click(object sender, EventArgs e)
    {
        obj_Toppers.YearName = txtYears.Text.Trim();
        checkRecordStatus = obj_Toppers.AddYear();
        if (checkRecordStatus > 0)
        {
            lblMsg.ForeColor = Color.Green;
            lblMsg.Text = "Record Saved!";
            lblMsg.Visible = true;
            clrForm();
        }
    }

    #region " Fill User Grid View"
    public void FillYears()
    {
        DS = obj_Toppers.FillToppersYear();
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
        obj_Toppers.YearId = Convert.ToInt32(gvDetail1.DataKeys[e.RowIndex].Values["YearId"].ToString());
        RecordStatus = obj_Toppers.DeleteYear();
        FillYears();
    }
    protected void gvDetail1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {

    }
}