﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using DataAccess;
using BusinessLogic.Admin;

public partial class Admin_EmployeeDetails : System.Web.UI.Page
{
    #region "Variable Decleration"
    private clsEmployee obj_Employee = new clsEmployee();
    private DataSet DS;
    private int RecordStatus;
    private static int AdminRegistrationId;
    #endregion
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            FillEmployee();
        }
    }

    #region " Fill User Grid View"
    public void FillEmployee()
    {
        DS = obj_Employee.DisplayEmployee();
        gvDetail1.DataSource = DS;
        gvDetail1.DataBind();
    }
    #endregion "End Fill User GridView"

    #region "Active / Inactive Pack Type Data"
    public void IS_LOCKED_Activate_Deactivate(object sender, CommandEventArgs e) //ACTIVE\DAECTIVE
    {
        try
        {
            obj_Employee.EmployeeId = Convert.ToInt32(e.CommandArgument.ToString());
            obj_Employee.AccountActiveInactiveAccount();
            FillEmployee();
        }
        catch (System.Exception ex)
        {
            //  lblMsg.Text = ex.ToString(); //LABEL ERROR MSG
            // lblMsg.Visible = true;
        }
    }
    #endregion

    protected void gvDetail1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {

    }
    protected void gvDetail1_RowEditing(object sender, GridViewEditEventArgs e)
    {

    }
    protected void gvDetail1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        obj_Employee.EmployeeId = Convert.ToInt32(gvDetail1.DataKeys[e.RowIndex].Values["EmployeeId"].ToString());
        RecordStatus = obj_Employee.DeleteEmployee();
        FillEmployee();
    }
    protected void gvDetail1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {

    }
    protected void gvDetail1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvDetail1.PageIndex = e.NewPageIndex;
        DS = obj_Employee.DisplayEmployee();
        gvDetail1.DataSource = DS;
        gvDetail1.DataBind();
    }

    #region "button Search"
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        try
        {
            obj_Employee.Email = txtEmail.Text.Trim();
            obj_Employee.Name = txtName.Text.Trim();
            obj_Employee.Mobile = txtMobile.Text.Trim();
            obj_Employee.EmployeeCode = txtEmployeeCode.Text.Trim();
            DS = obj_Employee.SearchEmployeeMultiple();
            
            if (DS != null)
            {
                gvDetail1.DataSource = DS;
                gvDetail1.DataBind();
                gvDetail1.Dispose();

                if (gvDetail1.Rows.Count == 0)
                {
                    lblMsg.Visible = true;
                    lblMsg.Text = "Record not Found !";

                }
            }
            else
            {
                lblMsg.Text ="Record not found !";
            }
        }
        catch (Exception ex)
        {
            //  lblMsg.Text = ex.ToString();
            //  lblMsg.Visible = true;
        }
    }
    #endregion
}