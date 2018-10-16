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

public partial class Student_FeeDetails : System.Web.UI.Page
{
    #region "Variable Decleration"
    private clsStudent obj_Student = new clsStudent();
    private DataSet DS;
    private int RecordStatus;
    private static int StudentId;

    #endregion
    protected void Page_Load(object sender, EventArgs e)
    {

        // if (!string.IsNullOrEmpty(Session["USER_NAME"].ToString()))
         if (Session["USER_NAME"]!=null)
            {
            StudentId = Convert.ToInt32(Session["StudentId"].ToString());
            if (!IsPostBack)
            {
                FillEmployeeInformation();
            }
        }
        else
        {
            Response.Redirect("~/Login.aspx");
        }
    }

    #region " Fill contorole on Form"
    private void FillEmployeeInformation()
    {
        obj_Student.StudentId = StudentId;
        DS = obj_Student.DisplayPStudent();
        if (DS.Tables[0].Rows.Count > 0)
        {
            foreach (DataRow row in DS.Tables[0].Rows)
            {
                txtDuepayment.Text = row["DuePayment"].ToString();
                txtDueDate.Text = row["DueDate"].ToString();
           
            }
        }

    }
    #endregion "End Fill contorole on Form"
}