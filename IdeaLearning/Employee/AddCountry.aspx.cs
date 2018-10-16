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

public partial class Employee_AddCountry : System.Web.UI.Page
{
    #region "VARIABLE DECLARATION"
    private clsMaster obj_country = new clsMaster();
    ArrayList arraylist1 = new ArrayList();
    ArrayList arraylist2 = new ArrayList();
    private DataSet DS;
    private int RecordStatus;
    private int checkRecordStatus;
    private string myFileExtension;
    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            FillCountry();
        }
    }

    #region "Add Country"
    protected void Button1_Click(object sender, EventArgs e)
    {
        obj_country.CountryName = txtCountry.Text.Trim();
        RecordStatus = obj_country.AddCountry();
        if (RecordStatus == 1)
        {
            lblCountry.Text = "Record Saved!";
        }
        else
        {
            lblCountry.Text = "Country Name Already Exists!";
        }
        Clear();
        FillCountry();
    }

    #endregion

    private void Clear()
    {
        txtCountry.Text = "";
    }
    
    #region " Fill Country Grid View"
    public void FillCountry()
    {
        DS = obj_country.CountryList();
        gvDetail1.DataSource = DS;
        gvDetail1.DataBind();
    }
    #endregion 

    protected void gvDetail1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        obj_country.CountryId = Convert.ToInt32(gvDetail1.DataKeys[e.RowIndex].Values["CountryId"].ToString());
        RecordStatus = obj_country.DeleteCountry();
        FillCountry();
    }
    protected void gvDetail1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        gvDetail1.EditIndex = -1;
        FillCountry();
    }
    protected void gvDetail1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        obj_country.CountryId = Convert.ToInt32(gvDetail1.DataKeys[e.RowIndex].Value.ToString());
        TextBox txtUpdateCountry = (TextBox)gvDetail1.Rows[e.RowIndex].FindControl("txtUpdateCountry");
        obj_country.CountryName = txtUpdateCountry.Text.ToString();
        DS = obj_country.UpdateCountry();
        gvDetail1.EditIndex = -1;
        FillCountry();
    }
    protected void gvDetail1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvDetail1.PageIndex = e.NewPageIndex;
        DS = obj_country.CountryList();
        gvDetail1.DataSource = DS;
        gvDetail1.DataBind();
    }
    protected void gvDetail1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        gvDetail1.EditIndex = e.NewEditIndex;
        FillCountry();
    }
}