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

public partial class Employee_ClassDetails : System.Web.UI.Page
{

    #region "VARIABLE DECLARATION"
    private clsMaster obj_Master = new clsMaster();

    private DataSet DS;
    private int RecordStatus;
    private int checkRecordStatus;
 
    private string myFileExtension;
    #endregion
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            FillClass();
        }
    }
    #region Clear Form
    protected void clrForm()
    {
        txtClass.Text = "";
    }
    #endregion

    protected void btnSave_Click(object sender, EventArgs e)
    {
        obj_Master.ClassName = txtClass.Text.Trim();
        checkRecordStatus = obj_Master.AddClass();
        if (checkRecordStatus > 0)
        {
            lblMsg.ForeColor = Color.Green;
            lblMsg.Text = "Product Record Saved";
            lblMsg.Visible = true;
            clrForm();
            FillClass();
        }
    }

    #region " Fill User Grid View"
    public void FillClass()
    {
        DS = obj_Master.DisplayClass();
        gvDetail1.DataSource = DS;
        gvDetail1.DataBind();
    }
    #endregion "End Fill User GridView"
  
    protected void gvDetail1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        obj_Master.ClassId = Convert.ToInt32(gvDetail1.DataKeys[e.RowIndex].Values["ClassId"].ToString());
        RecordStatus = obj_Master.DeleteClass();
        FillClass();
    }
   protected void gvDetail1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        gvDetail1.EditIndex = -1;
        FillClass();
    }
    protected void gvDetail1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        obj_Master.ClassId = Convert.ToInt32(gvDetail1.DataKeys[e.RowIndex].Value.ToString());
        TextBox txtUpdateClass = (TextBox)gvDetail1.Rows[e.RowIndex].FindControl("txtUpdateClass");
        obj_Master.ClassName = txtUpdateClass.Text.ToString();
        DS = obj_Master.UpdateClass();
        gvDetail1.EditIndex = -1;
        FillClass();
    }
    protected void gvDetail1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvDetail1.PageIndex = e.NewPageIndex;
        DS = obj_Master.DisplayClass();
        gvDetail1.DataSource = DS;
        gvDetail1.DataBind();
    }

    protected void gvDetail1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        gvDetail1.EditIndex = e.NewEditIndex;
        FillClass();
    }
}