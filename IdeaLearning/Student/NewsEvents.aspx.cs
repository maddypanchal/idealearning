using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using BusinessLogic.Admin;
using DataAccess;

public partial class Student_NewsEvents : System.Web.UI.Page
{

    #region "VARIABLE DECLARATION"
    private clsMaster obj_Master = new clsMaster();
   
    private DataSet DS;
    private DataTable DT;
    private int RecordStatus;
    private SqlDataReader DR;
    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {
     
        if (!IsPostBack)
        {
            RepeteEvents();
        }
    }

    private void RepeteEvents()
    {
        obj_Master.ClassId = Convert.ToInt32(Session["ClassId"]);
        DS = obj_Master.RepeterEvents();
        repnews.DataSource = DS;
        repnews.DataBind();
    }
}