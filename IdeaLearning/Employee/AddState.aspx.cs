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
using System.Collections;

public partial class Employee_AddState : System.Web.UI.Page
{
    #region "VARIABLE DECLARATION"
    private clsMaster obj_state = new clsMaster();
    private DataSet DS;
    private int RecordStatus;
    private string UniqueId;
    private SqlDataReader DR;
    #endregion
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            FillCountryDropDown();
                
        }
    }
    #region "FILL State DETAIL"
    protected void FillCountryDropDown()
    {
        try
        {
            
            DS = obj_state.CountryListDropdown();
            ddlCountryState.DataSource = DS;
            DS.Tables[0].Merge(DS.Tables[1]);
            ddlCountryState.DataTextField = DS.Tables[0].Columns[1].ToString();
            ddlCountryState.DataValueField = DS.Tables[0].Columns[0].ToString();
            ddlCountryState.DataBind();
            ddlCountryState.Dispose();
      
        }
        catch (Exception ex)
        {
            //llbSubject.Text = ex.ToString();
        }
    }
    #endregion
    #region "Insert State data"
    protected void Button1_Click(object sender, EventArgs e)
    {
        obj_state.CountryId = Convert.ToInt32(ddlCountryState.SelectedValue.ToString());
        obj_state.StateName = txtState.Text.Trim();
        RecordStatus = obj_state.AddState();
        if (RecordStatus == 0)
        {
            lblState.Text = "Record Saved!";
        }
        else
        {
            lblState.Text = "State Name Already Exists!";
        }
        Clear();
        FillState();
    }
    #endregion
    private void Clear()
    {
        txtState.Text = "";
    }


    #region " Fill Country Grid View"
    public void FillState()
    {
        obj_state.CountryId = Convert.ToInt32(ddlCountryState.SelectedValue.ToString());
        DS = obj_state.StateList();
        gvDetail1.DataSource = DS;
        gvDetail1.DataBind();
    }
    #endregion 

    protected void gvDetail1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        obj_state.CountryId = Convert.ToInt32(ddlCountryState.SelectedValue.ToString());
        obj_state.StateId = Convert.ToInt32(gvDetail1.DataKeys[e.RowIndex].Values["StateId"].ToString());
        RecordStatus = obj_state.DeleteState();
        FillState();
    }
    protected void gvDetail1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        gvDetail1.EditIndex = -1;
        FillState();
    }
    protected void gvDetail1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        obj_state.StateId = Convert.ToInt32(gvDetail1.DataKeys[e.RowIndex].Value.ToString());
        TextBox txtUpdateState = (TextBox)gvDetail1.Rows[e.RowIndex].FindControl("txtUpdateState");
        obj_state.StateName = txtUpdateState.Text.ToString();
        DS = obj_state.UpdateState();
        gvDetail1.EditIndex = -1;
        FillState();
    }
    protected void gvDetail1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        obj_state.CountryId = Convert.ToInt32(ddlCountryState.SelectedValue.ToString());
        gvDetail1.PageIndex = e.NewPageIndex;
        DS = obj_state.StateList();
        gvDetail1.DataSource = DS;
        gvDetail1.DataBind();
    }
    protected void gvDetail1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        gvDetail1.EditIndex = e.NewEditIndex;
        FillState();
    }
    protected void ddlCountryState_SelectedIndexChanged(object sender, EventArgs e)
    {
        FillState();
    }
}
