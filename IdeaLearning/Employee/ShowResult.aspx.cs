using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;
using System.Data.SqlClient;
using System.Data.OleDb;

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

public partial class Employee_ShowResult : System.Web.UI.Page
{
    #region "VARIABLE DECLARATION"
    private Results Result = new Results();
    private clsMaster obj_Master = new clsMaster();
    private DataSet DS;
    private int CheckRecordStatus;

    #endregion
    
    #region"Page load "
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            FillClassDristhi();
            FillClassRegular();
        }
    }
    #endregion


    #region "Fill Class Dristhi"
    protected void FillClassDristhi()
    {
        try
        {
            DS = obj_Master.FillClassDdl();
            ddlClassDristhi.DataSource = DS;
            DS.Tables[0].Merge(DS.Tables[1]);
            ddlClassDristhi.DataTextField = DS.Tables[0].Columns[1].ToString();
            ddlClassDristhi.DataValueField = DS.Tables[0].Columns[0].ToString();
            ddlClassDristhi.DataBind();
            ddlClassDristhi.Dispose();
        }
        catch (Exception ex)
        {
            //lblMsg.Text = ex.ToString();
        }
    }
    #endregion

    #region "Fill Class Regular"
    protected void FillClassRegular()
    {
        try
        {
            DS = obj_Master.FillClassDdl();
            ddlClassRegular.DataSource = DS;
            DS.Tables[0].Merge(DS.Tables[1]);
            ddlClassRegular.DataTextField = DS.Tables[0].Columns[1].ToString();
            ddlClassRegular.DataValueField = DS.Tables[0].Columns[0].ToString();
            ddlClassRegular.DataBind();
            ddlClassRegular.Dispose();
        }
        catch (Exception ex)
        {
            // lblMsg.Text = ex.ToString();
        }
    }
    #endregion

    protected void gvDristhi_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        Result.DristhiTestResultId = Convert.ToInt32(gvDristhi.DataKeys[e.RowIndex].Values["DristhiTestResultId"].ToString());
        CheckRecordStatus = Result.DeleteDristhiReuslt();
        FillDataDristhi();
    }
    
    #region"For Result Select Index Change"
    protected void ddlResult_SelectedIndexChanged(object sender, EventArgs e)
    {      // ScholarShip Test
        if (ddlResult.SelectedValue == "1")
        {
            lblResults.Text = "SHOW SCHOLAR SHIP TEST RESULT";
            
            UpScholarShipTest.Visible = true;
            UpItseTest.Visible = false;
            UpRegularTest.Visible = false;
            UpDristhiTest.Visible = false;
            FillDataScholerShip();
        }
        // For ITSE TEST
        else if (ddlResult.SelectedValue == "2")
        {
            lblResults.Text = "SHOW ITSE TEST RESULT";
            UpScholarShipTest.Visible = false;
            UpItseTest.Visible = true;
            UpRegularTest.Visible = false;
            UpDristhiTest.Visible = false;
            FillItseYear();
          
        }
        // For DRISHTI TEST
        else if (ddlResult.SelectedValue == "3")
        {
            lblResults.Text = "SHOW DRISTHI TEST RESULT";
         
            UpDristhiTest.Visible = true;
            UpScholarShipTest.Visible = false;
            UpItseTest.Visible = false;
            UpRegularTest.Visible = false;
        }
        // For REGULAR TEST
        else if (ddlResult.SelectedValue == "4")
        {
            lblResults.Text = "SHOW REGULAR TEST RESULT";
            UpScholarShipTest.Visible = false;
            UpItseTest.Visible = false;
            UpRegularTest.Visible = true;
            UpDristhiTest.Visible = false;
        }
        // For KBPY/NTSE/Loympiad/other Test
        else if (ddlResult.SelectedValue == "5")
        {
            lblResults.Text = "SHOW KVPY/NTSE/Olympiad/Other TEST RESULT";
            UpScholarShipTest.Visible = true;
            UpItseTest.Visible = false;
            UpRegularTest.Visible = false;
            UpDristhiTest.Visible = false;
        }
    }

    private void FillDataScholerShip()
    {
        DS = Result.DisplayScholerShipResult();
        GvScholerShip.DataSource = DS;
        GvScholerShip.DataBind();
    }

    private void FillItseYear()
    {

        DS = Result.DisplayItseResultYear();
        ddlselectYear.DataSource = DS;

        DS.Tables[0].Merge(DS.Tables[1]);
        ddlselectYear.DataTextField = DS.Tables[0].Columns[1].ToString();
        ddlselectYear.DataValueField = DS.Tables[0].Columns[0].ToString();
        ddlselectYear.DataBind();
        ddlselectYear.Dispose();
        DS.Dispose();
    }

    private void FillDataItse()
    {
        DS = Result.DisplayItseResult();
        gvItse.DataSource = DS;
        gvItse.DataBind();
    }

    #endregion
        
    protected void ddlselectYear_SelectedIndexChanged(object sender, EventArgs e)
    {
       Result.Year =  ddlselectYear.SelectedItem.ToString();
       DS = Result.DisplayItseResult();
       gvItse.DataSource = DS;
       gvItse.DataBind();
    }

    protected void ddlDrishti_SelectedIndexChanged(object sender, EventArgs e)
    {
       FillDataDristhi();
    }

    private void FillDataDristhi()
    {
        Result.ClassDristhi = ddlClassDristhi.SelectedValue.ToString();
        Result.DristhiTestCode = ddlDrishti.SelectedItem.ToString();
        DS = Result.DisplayDristhiTest();
        gvDristhi.DataSource = DS;
        gvDristhi.DataBind();
    }

    protected void ddlRegularTestType_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlDpp.SelectedValue != "0")
        {
            Result.ClassRegular = ddlClassRegular.SelectedValue.ToString();
            Result.DPP = ddlDpp.SelectedItem.ToString();
            Result.TestType = ddlRegularTestType.SelectedItem.ToString();
            DS = Result.DisplayRegularTest();
            GvReguler.DataSource = DS;
            GvReguler.DataBind();
        }
        
    }

    protected void btnAllDelete_Click(object sender, EventArgs e)
    {
        Result.Year = ddlselectYear.SelectedItem.ToString();
        CheckRecordStatus = Result.DeleteITSEYearData();
        if (CheckRecordStatus == 1)
        {
            lblError.Text = "Delete Successfully By Year";
        }
    }


    protected void GvReguler_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        Result.RegularTestId = Convert.ToInt32(GvReguler.DataKeys[e.RowIndex].Values["RegularTestId"].ToString());
        CheckRecordStatus = Result.DeleteRegularReuslt();
        FillClassRegular();
    }

 
}