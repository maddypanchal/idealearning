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

public partial class Employee_Heading : System.Web.UI.Page
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
            FillHeading();
        }
    }
    #region Clear Form
    protected void clrForm()
    {
        txtHeading.Text = "";
    }
    #endregion

    protected void btnSave_Click(object sender, EventArgs e)
    {
        obj_News.name = txtHeading.Text.Trim();
        checkRecordStatus = obj_News.AddHeading();
        if (checkRecordStatus > 0)
        {
            lblMsg.ForeColor = Color.Green;
            lblMsg.Text = "Record Saved!";
            lblMsg.Visible = true;
            clrForm();
            FillHeading();
        }
    }

    #region " Fill User Grid View"
    public void FillHeading()
    {
        DS = obj_News.DisplayHeading();
        gvDetail1.DataSource = DS;
        gvDetail1.DataBind();
    }
    #endregion "End Fill User GridView"
    protected void gvDetail1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        obj_News.HeadingId = Convert.ToInt32(gvDetail1.DataKeys[e.RowIndex].Value.ToString());
        TextBox txtUpdateClass = (TextBox)gvDetail1.Rows[e.RowIndex].FindControl("txtUpdateHeading");
        obj_News.name = txtUpdateClass.Text.ToString();
        DS = obj_News.UpdateHeading();
        gvDetail1.EditIndex = -1;
        FillHeading();
    }
    protected void gvDetail1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        gvDetail1.EditIndex = e.NewEditIndex;
        FillHeading();
    }
    protected void gvDetail1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        obj_News.HeadingId = Convert.ToInt32(gvDetail1.DataKeys[e.RowIndex].Values["HeadingId"].ToString());
        RecordStatus = obj_News.DeleteHeading();
        FillHeading();
    }
    protected void gvDetail1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        gvDetail1.EditIndex = -1;
        FillHeading();
    }

    protected void gvDetail1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvDetail1.PageIndex = e.NewPageIndex;
        DS = obj_News.DisplayHeading();
        gvDetail1.DataSource = DS;
        gvDetail1.DataBind();
    }


   
}