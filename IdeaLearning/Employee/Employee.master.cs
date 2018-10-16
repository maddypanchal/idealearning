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
using System.Web.UI.WebControls.WebParts;


public partial class Employee_Employee : System.Web.UI.MasterPage
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
            if (!string.IsNullOrEmpty(Session["USER_NAME"].ToString()))
            {
                lblUserName.Text = "Welcome " + Session["USER_NAME"].ToString();
                string employeetype = Session["EmployeeType"].ToString();
                if (employeetype == "2")
                {
                    menuEmp1.Visible = false;
                    MenuSimleEmp1.Visible = true;
                  
                }
                if (employeetype == "1")
                {
                    menuEmp1.Visible = true;
                    MenuSimleEmp1.Visible = false;

                }

               
            }
            else
            {
                Response.Redirect("~/Login.aspx");
            }
        }
        catch
        {
            Response.Redirect(applicationURL + "~/Login.aspx");
        }   
    }
    #region"Page"
    protected void PageURL()
    {


        if (Session["EMPLOYEE_ID"] != null)
        {
           //if (!string.IsNullOrEmpty(Session["EMPLOYEE_ID"].ToString()))
            //{
             string employeeid  = Session["EMPLOYEE_ID"].ToString();
             applicationURL = ConfigurationManager.AppSettings["ApplicationPath"].ToString();
             Admin.HRef = applicationURL + "/Employee/DashBord.aspx?EMPLOYEE_ID=" + employeeid;
            }
            else
            {
                Response.Redirect("~/Login.aspx");
            }
    }
    #endregion
}
