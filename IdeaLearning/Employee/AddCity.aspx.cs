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
using System.IO;

public partial class Employee_AddCity : System.Web.UI.Page
{
    #region "VARIABLE DECLARATION"
    private clsMaster obj_region = new clsMaster();
    ArrayList arraylist1 = new ArrayList();
    ArrayList arraylist2 = new ArrayList();
    private DataSet DS;
    //private static decimal TotalAmountR = 0;
    private int RecordStatus;
    private string UniqueId;
    //private static int a, b, c, d, f;
    private SqlDataReader DR;
    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            FillCountryStateDropDown();

        }

    }

    #region "FILL country ddl in region"
    protected void FillCountryStateDropDown()
    {
        try
        {
            //obj.UniqueIdentification = UniqueId;
            DS = obj_region.CountryListDropdown();
            ddlCountryRegion.DataSource = DS;
            DS.Tables[0].Merge(DS.Tables[1]);
            ddlCountryRegion.DataTextField = DS.Tables[0].Columns[1].ToString();
            ddlCountryRegion.DataValueField = DS.Tables[0].Columns[0].ToString();
            ddlCountryRegion.DataBind();
            ddlCountryRegion.Dispose();
        }
        catch (Exception ex)
        {
            //llbSubject.Text = ex.ToString();
        }

    }

    #endregion
    private void Clear()
    {

        txtRegion.Text = "";

    }
    #region "FILL state ddl in region"
    protected void FillCountryStateDropDown1()
    {
        try
        {

            obj_region.CountryId = Convert.ToInt32(ddlCountryRegion.SelectedValue);
            //obj_region.UniqueIdentification = UniqueId;
            DS = obj_region.StateListDropdown1();
            ddlStateRegion.DataSource = DS;
            DS.Tables[0].Merge(DS.Tables[1]);
            ddlStateRegion.DataTextField = DS.Tables[0].Columns[1].ToString();
            ddlStateRegion.DataValueField = DS.Tables[0].Columns[0].ToString();
            ddlStateRegion.DataBind();
            ddlStateRegion.Dispose();


        }
        catch (Exception ex)
        {
            //lblBatch.Text = ex.ToString();
        }

    }

    #endregion
    #region "Country select index changed"
    protected void ddlCountryRegion_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {

            obj_region.CountryId = Convert.ToInt32(ddlCountryRegion.SelectedValue);

            FillCountryStateDropDown1();
            ddlStateRegion.Visible = true;
            ddlStateRegion.DataBind();

        }
        catch (Exception ex)
        {
            lblregion.Text = ex.Message;
        }
    }

    #endregion
    #region "Insert State data"
    protected void Button1_Click1(object sender, EventArgs e)
    {
        obj_region.CountryId = Convert.ToInt32(ddlCountryRegion.SelectedValue.ToString());
        obj_region.StateId = Convert.ToInt32(ddlStateRegion.SelectedValue.ToString());
        obj_region.RegionName = txtRegion.Text.Trim();
        RecordStatus = obj_region.AddRegion();
        if (RecordStatus == 0)
        {
            lblregion.Text = "Record Saved!";
        }
        else
        {
            lblregion.Text = "City Name Already Exists!";
        }
        Clear();
        FillCity();
    }

    #endregion
    protected void ddlStateRegion_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    #region " Fill Country Grid View"
    public void FillCity()
    {
        obj_region.CountryId = Convert.ToInt32(ddlCountryRegion.SelectedValue.ToString());
        obj_region.StateId = Convert.ToInt32(ddlStateRegion.SelectedValue.ToString());
        DS = obj_region.CityLists();
        gvDetail1.DataSource = DS;
        gvDetail1.DataBind();
    }
    #endregion

    protected void gvDetail1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        obj_region.CountryId = Convert.ToInt32(ddlCountryRegion.SelectedValue.ToString());
        obj_region.StateId = Convert.ToInt32(ddlStateRegion.SelectedValue.ToString());
        obj_region.RegionId = Convert.ToInt32(gvDetail1.DataKeys[e.RowIndex].Values["RegionId"].ToString());
        RecordStatus = obj_region.DeleteCity();
        FillCity();
    }
    protected void gvDetail1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        gvDetail1.EditIndex = -1;
        FillCity();
    }
    protected void gvDetail1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        obj_region.RegionId = Convert.ToInt32(gvDetail1.DataKeys[e.RowIndex].Value.ToString());
        TextBox txtUpdateCity = (TextBox)gvDetail1.Rows[e.RowIndex].FindControl("txtUpdateCity");
        obj_region.RegionName = txtUpdateCity.Text.ToString();
        DS = obj_region.UpdateCity();
        gvDetail1.EditIndex = -1;
        FillCity();
    }
    protected void gvDetail1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        obj_region.CountryId = Convert.ToInt32(ddlCountryRegion.SelectedValue.ToString());
        obj_region.StateId = Convert.ToInt32(ddlStateRegion.SelectedValue.ToString());
        gvDetail1.PageIndex = e.NewPageIndex;
        DS = obj_region.CityLists();
        gvDetail1.DataSource = DS;
        gvDetail1.DataBind();
    }
    protected void gvDetail1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        gvDetail1.EditIndex = e.NewEditIndex;
        FillCity();
    }

    //protected void ddlCountryState_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //    FillState();
    //}

    protected void ddlStateRegion_SelectedIndexChanged1(object sender, EventArgs e)
    {
        FillCity();
    }
}