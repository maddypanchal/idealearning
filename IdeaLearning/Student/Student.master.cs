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

public partial class Student_Student : System.Web.UI.MasterPage
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
            if (Session["USER_NAME"]!=null)
            //if(!string.IsNullOrEmpty(Session["USER_NAME"].ToString()))
            {
                lblUserName.Text = "Welcome " + Session["USER_NAME"].ToString();
            }
            else
            {
                Response.Redirect("../Login.aspx");
            }
        }
        catch
        {
            Response.Redirect(applicationURL + "../Login.aspx");
        }
     }

    #region"Page bind url"
    protected void PageURL()
    {
        applicationURL = ConfigurationManager.AppSettings["ApplicationPath"].ToString();
        Admin.HRef = applicationURL + "/Student/DashBord.aspx";
    }
    #endregion
}
