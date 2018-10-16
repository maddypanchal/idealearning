using System;
using System.Collections.Generic;
//using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccess;
using BusinessLogic.Admin;
using System.Data;
using System.Data.SqlClient;

public partial class Admin_DashBord : System.Web.UI.Page
{
    #region "Variable Decleration"
    private clsEmployee obj_Employee = new clsEmployee();
    private DataSet DS;
    private int RecordStatus;
    private static int AdminId;
    public int gender;

    #endregion
    protected void Page_Load(object sender, EventArgs e)
    {
       
        if (Session["AdminId"] == null)
        {
            Response.Redirect("~/login.aspx", false);
        }
        else
        {
            AdminId = Convert.ToInt32(Session["AdminId"].ToString());

            lblAdmin.Text = Session["USER_NAME"].ToString();
            if (!IsPostBack)
            {

            }
       }
    }
}