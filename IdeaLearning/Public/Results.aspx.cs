using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using BusinessLogic.Admin;
using DataAccess;

public partial class Public_Results : System.Web.UI.Page
{

    #region "Begin Variables Declaration"
    private clsAdmin objMemberLogin = new clsAdmin();
    private Results  ObjResult = new Results();
    private DataSet DS;
      private string RollNo;
  
    #endregion "End Variables Declaration"
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    private void FillItseYear()
    {
        DS = ObjResult.DisplayItseResultYear();
        ddlselectYear.DataSource = DS;
        DS.Tables[0].Merge(DS.Tables[1]);
        ddlselectYear.DataTextField = DS.Tables[0].Columns[1].ToString();
        ddlselectYear.DataValueField = DS.Tables[0].Columns[0].ToString();
        ddlselectYear.DataBind();
        ddlselectYear.Dispose();
        DS.Dispose();
    }


    protected void btnSearch_Click(object sender, EventArgs e)
    {
        objMemberLogin.Year = ddlselectYear.SelectedItem.ToString();
        objMemberLogin.RollNo =txtRollNo.Text.Trim();
        DS = objMemberLogin.SearchResult();
        if (DS.Tables[0].Rows.Count > 0)
        {
            foreach (DataRow row in DS.Tables[0].Rows)
            {
                objMemberLogin.RollNo = row["RollNumber"].ToString();
                objMemberLogin.Year = row["Year"].ToString();
            }
            Session["RollNo"] = DS.Tables[0].Rows[0]["RollNumber"].ToString();
            Session["Year"] = DS.Tables[0].Rows[0]["Year"].ToString();
            Response.Redirect("~/Public/ITSEResult.aspx");
        }
        else
        {
            // lblMsg.Visible = true;
            // lblMsg.ForeColor = Color.Red;
            //  lblMsg.Text = "Invalid Admin ID or Password";
        }
     }

    #region"For Result Select Index Change"
    protected void ddlResult_SelectedIndexChanged(object sender, EventArgs e)
    {      // ScholarShip Test
        if (ddlResult.SelectedValue == "1")
        {
            UpScholarShipTest.Visible = true;
            UpItseTest.Visible = false;
            FillDataScholerShip();
        }
        // For ITSE TEST
        else if (ddlResult.SelectedValue == "2")
        {
            UpScholarShipTest.Visible = false;
            UpItseTest.Visible = true;
            FillItseYear();
            FillDataScholerShip();
        }
    }
    #endregion

    private void FillDataScholerShip()
    {
        DS = ObjResult.DisplayScholerShipResult();
        GvScholerShip.DataSource = DS;
        GvScholerShip.DataBind();
    }
}