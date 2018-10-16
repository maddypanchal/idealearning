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

public partial class Public_ScholerShipResult : System.Web.UI.Page
{
    #region "Variable Decleration"
    private Results obj_Results = new Results();
    private DataSet DS;
    private int RecordStatus;
    private static int StudentId;

    #endregion
    protected void Page_Load(object sender, EventArgs e)
    {
        StudentId = int.Parse(Request.QueryString["sid"]);

    }

    protected void btnScholerSeach_Click(object sender, EventArgs e)
    {
        if (txtRollNo.Text != "")
        {
            lblMsg.Text = "";
            UpScholerShip.Visible = true;
            obj_Results.RollNumber = txtRollNo.Text.Trim();
            obj_Results.ScholerTestResultId = StudentId;
            DS = obj_Results.SearchScholerResult();
            if (DS.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in DS.Tables[0].Rows)
                {
                    lblName.Text = row["Name"].ToString();
                    lblRank.Text = row["Rank"].ToString();
                    lblRollNo.Text = row["RollNumber"].ToString();
                 
                    lblPrice.Text = row["ScholoarShip"].ToString();
                    //School
                    //    FatherName
                    //    MobileNo
                    //        MaxMark
                    //        ObtainMark
                    //            PercentageMark
                   //                ScholoarShip
                     //                Year

                }
            }

            //FillEmployeeInformation();
        }
        else
        {
            UpScholerShip.Visible = false;
            lblMsg.Text = "Pleases Fill Roll Number !";
        }
    }
}