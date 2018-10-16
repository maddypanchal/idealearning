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

using System.Net;
using System.Text;
using System.Configuration;
using System.Web.Security;
using System.Web.UI.HtmlControls;
using System.Collections;

using System.Design;
using System.Drawing.Design;
using System.Drawing.Text;
using DataAccess;
using BusinessLogic.Admin;

public partial class Student_ViewResult : System.Web.UI.Page
{
    #region "Variable Decleration"
    private clsAdmin obj_Student = new clsAdmin();
    private clsStudent obj_Studenta = new clsStudent();
    private DataSet DS;
    private int RecordStatus;
    private static int StudentId;

    private Results Result = new Results();
    //private DataSet DS;
    private int CheckRecordStatus;
    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void gvDristhi_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        Result.DristhiTestResultId = Convert.ToInt32(gvDristhi.DataKeys[e.RowIndex].Values["DristhiTestResultId"].ToString());
        CheckRecordStatus = Result.DeleteDristhiReuslt();
        FillDataDristhi();
    }

    #region"For Result Select Index Change"
    protected void ddlResult_SelectedIndexChanged(object sender, EventArgs e)
    {      // ScholarShip Test
        // For DRISHTI TEST
        if (ddlResult.SelectedValue == "3")
        {
            lblResults.Text = "SHOW DRISTHI TEST RESULT";

            UpDristhiTest.Visible = true;
            UpRegularTest.Visible = false;
        }
        // For REGULAR TEST
        else if (ddlResult.SelectedValue == "4")
        {
            lblResults.Text = "SHOW REGULAR TEST RESULT";
            UpRegularTest.Visible = true;
            UpDristhiTest.Visible = false;
        }
     }

    
    #endregion



    protected void ddlDrishti_SelectedIndexChanged(object sender, EventArgs e)
    {
        FillDataDristhi();
    }

    private void FillDataDristhi()
    {
        Result.DristhiTestCode = ddlDrishti.SelectedItem.ToString();
        DS = Result.DisplayDristhiTest();
        gvDristhi.DataSource = DS;
        gvDristhi.DataBind();
    }

    protected void ddlRegularTestType_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlDpp.SelectedValue != "0")
        {
            Result.DPP = ddlDpp.SelectedItem.ToString();
            Result.TestType = ddlRegularTestType.SelectedItem.ToString();
            DS = Result.DisplayRegularTest();
            GvReguler.DataSource = DS;
            GvReguler.DataBind();
        }
    }
   
}