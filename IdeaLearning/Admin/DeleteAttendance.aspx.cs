using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogic.Admin;
using DataAccess;

public partial class Admin_DeleteAttendance : System.Web.UI.Page
{
    #region "Variable Decleration"
    private clsNews obj_News = new clsNews();
    private clsMaster Obj_Master = new clsMaster();
    private clsStudent obj_Student = new clsStudent();
    private DataSet DS;
    private int TotalAbsent;
    private int TotalPresent;
    private int TotalClass;
    private static int StudentId;
    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            FillAttendance();
        }
     }
    public void FillAttendance()
    {
   
        DS = Obj_Master.FillAttendenceStudent();
        gvDetail1.DataSource = DS;
        gvDetail1.DataBind();
    }



    protected void btnDeleted_Click(object sender, EventArgs e)
    {
        DS = obj_Student.DeleteAttendenceStudent();
        //gvDetail1.DataSource = DS;
       // gvDetail1.DataBind();
    }
}