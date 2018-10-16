using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using BusinessLogic.Admin;
using System.IO;
using CKEditor.NET;


public partial class Employee_AddNews : System.Web.UI.Page
{
    #region"Variable Declaration"
    private clsNews obj_News = new clsNews();
    private DataSet DS;
    private int checkRecordStatus;
    #endregion
   
    protected void Page_Load(object sender, EventArgs e)
    {
        txtTitleDate.Text = DateTime.Today.ToString("dd/MM/yyyy"); 
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
       obj_News.TitleName = txtTitle.Text.Trim();
       obj_News.TitleDate = txtTitleDate.Text.Trim();
       String ckContentValue = CKEditor1.Text.Trim();
       obj_News.Description = ckContentValue;
       checkRecordStatus = obj_News.InsertHomeNews();
        if (checkRecordStatus == 0)
        {
            lblmsg.Text = "Record Saved!";
        }
        clearform();
        txtTitleDate.Text = DateTime.Today.ToString("dd/MM/yyyy");
        Response.Redirect("NewsDetails.aspx");


    }

    private void clearform()
    {
        txtTitle.Text = "";
        txtTitleDate.Text = "";
        lblmsg.Text = "Record Saved!";
    }
}