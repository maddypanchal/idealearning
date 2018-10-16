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

public partial class Employee_YoutubeDetails : System.Web.UI.Page
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
            FillYoutube();
        }
    }
    #region Clear Form
    protected void clrForm()
    {
        txtLink.Text = "";
    }
    #endregion

    protected void btnSave_Click(object sender, EventArgs e)
    {
        obj_Master.Link = txtLink.Text.Trim();
        checkRecordStatus = obj_Master.AddYoutube();
        if (checkRecordStatus > 0)
        {
            lblMsg.ForeColor = Color.Green;
            lblMsg.Text = "Product Record Saved";
            lblMsg.Visible = true;
            clrForm();
            FillYoutube();
        }
    }

    #region " Fill User Grid View"
    public void FillYoutube()
    {
        DS = obj_Master.DisplayYoutube();
        gvDetail1.DataSource = DS;
        gvDetail1.DataBind();
    }
    #endregion "End Fill User GridView"

    protected void gvDetail1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        obj_Master.YoutubeId = Convert.ToInt32(gvDetail1.DataKeys[e.RowIndex].Values["YoutubeId"].ToString());
        RecordStatus = obj_Master.DeleteYoutube();
        FillYoutube();
    }
    protected void gvDetail1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        gvDetail1.EditIndex = -1;
        FillYoutube();
    }
    protected void gvDetail1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        obj_Master.YoutubeId = Convert.ToInt32(gvDetail1.DataKeys[e.RowIndex].Value.ToString());
        TextBox txtUpdateLink = (TextBox)gvDetail1.Rows[e.RowIndex].FindControl("txtUpdateLink");
        obj_Master.Link = txtUpdateLink.Text.ToString();
        DS = obj_Master.UpdateYoutube();
        gvDetail1.EditIndex = -1;
        FillYoutube();
    }
    protected void gvDetail1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvDetail1.PageIndex = e.NewPageIndex;
        DS = obj_Master.DisplayYoutube();
        gvDetail1.DataSource = DS;
        gvDetail1.DataBind();
    }

    protected void gvDetail1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        gvDetail1.EditIndex = e.NewEditIndex;
        FillYoutube();
    }
}