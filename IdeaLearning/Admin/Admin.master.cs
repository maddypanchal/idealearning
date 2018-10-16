using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Web.Security;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using System.Collections;

public partial class Admin_Admin : System.Web.UI.MasterPage
{
    private string applicationURL;
    protected void Page_Load(object sender, EventArgs e)
    {
        #region "page postback"
        if (!IsPostBack)
        {
            PageURL();
        }
        #endregion

        try
        {
            //if (!string.IsNullOrEmpty(Session["USER_NAME"].ToString()))
            if (Session["USER_NAME"] != null)
            {
                lblUserName.Text = "Welcome " + Session["USER_NAME"].ToString();
            }
            else
            {
                Response.Redirect("/Login.aspx");
            }
        }
        catch
        {
            Response.Redirect(applicationURL + "/Login.aspx");
        }
    }
    #region""

    protected void PageURL()
    {
        applicationURL = ConfigurationManager.AppSettings["ApplicationPath"].ToString();
        //Admin.HRef = applicationURL + "/Admin/DashBord.aspx";
        Emp.HRef = applicationURL + "/Admin/EmployeeDetails.aspx";
    }
    #endregion
}
