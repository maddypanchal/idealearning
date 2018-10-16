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


public partial class Employee_NewsDetails : System.Web.UI.Page
{
    #region "Variable Decleration"
    private clsNews obj_News = new clsNews();
    private DataSet DS;
    private int RecordStatus;
    private static int AdminRegistrationId;
    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            FillNews();
        }
    }

    #region " Fill User Grid View"
    public void FillNews()
    {
        DS = obj_News.DisplayNews();
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
        obj_News.NewsTitleId = Convert.ToInt32(gvDetail1.DataKeys[e.RowIndex].Values["NewsTitleId"].ToString());
        RecordStatus = obj_News.DeleteNews();
        FillNews();
    }
    protected void gvDetail1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {

    }

    protected void gvDetail1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvDetail1.PageIndex = e.NewPageIndex;
        DS = obj_News.DisplayNews();
        gvDetail1.DataSource = DS;
        gvDetail1.DataBind();
    }
}