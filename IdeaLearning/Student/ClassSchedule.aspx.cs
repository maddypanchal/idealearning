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

public partial class Student_ClassSchedule : System.Web.UI.Page
{
    #region "Variable Decleration"
    private clsStudent obj_Student = new clsStudent();
    private clsMaster obj_Master = new clsMaster();
    private DataSet DS;
    private int RecordStatus;
    private static int StudentId;

    #endregion
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["USER_NAME"]!=null)
        //if (!string.IsNullOrEmpty(Session["USER_NAME"].ToString()))
        {
            StudentId = Convert.ToInt32(Session["StudentId"].ToString());
            ClassSchedule();
        }
        else
        {
            Response.Redirect("~/Login.aspx");
        }
    }

    private void ClassSchedule()
    {
        obj_Master.ClassId = Convert.ToInt32(Session["ClassId"]);
        DS = obj_Master.RepeterCs();
        repCs.DataSource = DS;
        repCs.DataBind();

    }
}