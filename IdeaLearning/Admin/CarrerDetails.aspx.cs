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

public partial class Admin_CarrerDetails : System.Web.UI.Page
{
    #region "VARIABLE DECLARATION"
    private clsMaster objMaster = new clsMaster();
    private DataSet DS;
    private int RecordStatus;
    private int checkRecordStatus;
    // private int LoginType;
    private string myFileExtension;
    #endregion
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["AdminId"] == null)
        {
            Response.Redirect("~/Login.aspx", false);
        }
        if (!IsPostBack)
        {
            FillCareerDetails();
        }
    }

    #region " Fill User Grid View"
    public void FillCareerDetails()
    {
        DS = objMaster.DisplayCarrer();
        if (DS != null)
        {
            gvDetail1.DataSource = DS;
            gvDetail1.DataBind();

            if (gvDetail1.Rows.Count == 0)
            {
                lblmsg.Visible = true;
                lblmsg.Text = "Record not Found pleases try again";

            }

        }
        else
        {
            lblmsg.Visible = true;
            lblmsg.Text = "Record not Found pleases try again";
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
        objMaster.CarrerId = Convert.ToInt32(gvDetail1.DataKeys[e.RowIndex].Values["CarrerId"].ToString());
        RecordStatus = objMaster.DeleteCarrer();
        FillCareerDetails();
    }
    protected void gvDetail1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {

    }
    protected void btnDeleteAll_Click(object sender, EventArgs e)
    {
        DS = objMaster.DeleteAllCarrer();
        FillCareerDetails();
    }

    #region "button Search"
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        try
        {
            objMaster.PositionAppliying = txtPostApplied.Text.Trim();
            objMaster.Name = txtName.Text.Trim();
            objMaster.Mobile = txtMobile.Text.Trim();
            objMaster.Degree = txtQualification.Text.Trim();
            DS = objMaster.SearchCareerMultiple();
            if (DS != null)
            {
                gvDetail1.DataSource = DS;
                gvDetail1.DataBind();
                gvDetail1.Dispose();

                if (gvDetail1.Rows.Count == 0)
                {
                    lblmsg.Visible = true;
                    lblmsg.Text = "Record not Found pleases try again";

                }

            }
            else
            {
                lblmsg.Visible = true;
                lblmsg.Text = "Record not Found pleases try again";
            }
        }
        catch (Exception ex)
        {
            lblmsg.Text = ex.ToString();
            lblmsg.Visible = true;
        }
    }
    #endregion
}