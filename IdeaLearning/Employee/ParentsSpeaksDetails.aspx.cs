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

public partial class Employee_ParentsSpeaksDetails : System.Web.UI.Page
{
    #region "Variable Decleration"
    private clsMaster obj_Gallery = new clsMaster();
    private DataSet DS;
    private int RecordStatus;
    private static int AdminRegistrationId;
    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            FillParentsSpeaks();
        }
    }

    #region " Fill User Grid View"
    public void FillParentsSpeaks()
    {
        DS = obj_Gallery.DisplayParentsSpeaks();
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
        obj_Gallery.ParentsSpeaksId = Convert.ToInt32(gvDetail1.DataKeys[e.RowIndex].Values["ParentsSpeaksId"].ToString());
        RecordStatus = obj_Gallery.DeleteParentsSpeaks();
        FillParentsSpeaks();
    }
    protected void gvDetail1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {

    }

    protected void gvDetail1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvDetail1.PageIndex = e.NewPageIndex;
        // DS = obj_News.DisplayHeading();
        gvDetail1.DataSource = DS;
        gvDetail1.DataBind();
    }
}