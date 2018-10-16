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

public partial class Student_HomeWork : System.Web.UI.Page
{
    #region "Variable Decleration"
    private clsStudent obj_Student = new clsStudent();
    private clsMaster obj_Master = new clsMaster();
    private DataSet DS;
   
    private static int StudentId;

    #endregion
    protected void Page_Load(object sender, EventArgs e)
    {
        // if (!string.IsNullOrEmpty(Session["USER_NAME"].ToString()))
             if (Session["USER_NAME"] != null)
         {
            StudentId = Convert.ToInt32(Session["StudentId"].ToString());
            HomeWorkShow();
        }
         else
         {
             Response.Redirect("~/Login.aspx");
         }
    }

    private void HomeWorkShow()
    {
        obj_Master.ClassId = Convert.ToInt32(Session["ClassId"]);
        DS = obj_Master.RepeterHw();
        rephw.DataSource = DS;
        rephw.DataBind();
       
    }
}