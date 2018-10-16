using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using BusinessLogic.Admin;
using DataAccess;


public partial class Employee_TopperDetails : System.Web.UI.Page
{
    #region "Variable Decleration"
    private clsToppers obj_topper = new clsToppers();
    private DataSet DS;
    private int RecordStatus;
    private static int AdminRegistrationId;
    #endregion
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            FillTopper();
        }
    }
    #region " Fill User Grid View"
    public void FillTopper()
    {
        DS = obj_topper.FeatchToppers();
        gvDetail1.DataSource = DS;
        gvDetail1.DataBind();
    }
    #endregion "End Fill User GridView"

    protected void gvDetail1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        obj_topper.ToppersId = Convert.ToInt32(gvDetail1.DataKeys[e.RowIndex].Values["ToppersId"].ToString());
        RecordStatus = obj_topper.DeleteTopperImage();
        FillTopper();
    }
    protected void gvDetail1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {

    }
    protected void gvDetail1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {

    }
    protected void gvDetail1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvDetail1.PageIndex = e.NewPageIndex;
        DS = obj_topper.FeatchToppers();
        gvDetail1.DataSource = DS;
        gvDetail1.DataBind();
    }
}