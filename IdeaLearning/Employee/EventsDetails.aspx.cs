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

public partial class Employee_EventsDetails : System.Web.UI.Page
{
    #region "Variable Decleration"
    private clsEvents obj_Events = new clsEvents();
    private DataSet DS;
    private int RecordStatus;
    private static int AdminRegistrationId;
    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            FillEvents();
        }
    }

    #region " Fill User Grid View"
    public void FillEvents()
    {
        DS = obj_Events.DisplayEvent();
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
        obj_Events.EventsId = Convert.ToInt32(gvDetail1.DataKeys[e.RowIndex].Values["EventsId"].ToString());
        RecordStatus = obj_Events.DeleteEvents();
        FillEvents();
    }
    protected void gvDetail1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {

    }
}