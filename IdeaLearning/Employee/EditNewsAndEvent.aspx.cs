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

public partial class Employee_EditNewsAndEvent : System.Web.UI.Page
{
    #region "Variable Decleration"
    private clsNews obj_News = new clsNews();
    private DataSet DS;
    private int RecordStatus;
    private static int NewsTitleId;

    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {
        NewsTitleId = int.Parse(Request.QueryString["Sid"]);
        if (!IsPostBack)
        {
            FillNews();
        }
    }

    #region " Fill contorole on Form"
    private void FillNews()
    {
        obj_News.NewsTitleId = NewsTitleId;
        DS = obj_News.FillNews();
        if (DS.Tables[0].Rows.Count > 0)
        {
            foreach (DataRow row in DS.Tables[0].Rows)
            {
                txtTitle.Text = row["TitleName"].ToString();
                txtTitleDate.Text = row["TitleDate"].ToString();
                CKEditor1.Text = row["Description"].ToString();


            }
        }
    }
    #endregion "End Fill contorole on Form"

    #region"Update Student "
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        obj_News.NewsTitleId = NewsTitleId;
        obj_News.TitleName = txtTitle.Text.Trim();
        obj_News.TitleDate = txtTitleDate.Text.Trim();
        String ckContentValue = CKEditor1.Text.Trim();
        obj_News.Description = ckContentValue;
        DS = obj_News.UpdateHomeNews();
        if (RecordStatus == 0)
        {
            lblmsg.Text = "Record Saved!";
        }
        //clearform();
        txtTitleDate.Text = DateTime.Today.ToString("dd/MM/yyyy");
        Response.Redirect("NewsDetails.aspx");
    }
    #endregion

}