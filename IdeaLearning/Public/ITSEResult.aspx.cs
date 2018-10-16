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

public partial class Public_ITSEResult : System.Web.UI.Page
{
   
    #region "Variable Decleration"
    private Results obj_Results = new Results();
    private DataSet DS;
    private int RecordStatus;
    private static int StudentId;

    #endregion
    protected void Page_Load(object sender, EventArgs e)
    {
       // StudentId = int.Parse(Request.QueryString["sid"]);
        FillEmployeeInformation();
    }
    #region " Fill contorole on Form"
    private void FillEmployeeInformation()
    { 
            
        obj_Results.RollNumber =  Session["RollNo"].ToString();
        obj_Results.Year = Session["Year"].ToString();
        DS = obj_Results.SearchItseResult();
        if (DS.Tables[0].Rows.Count > 0)
        {
            foreach (DataRow row in DS.Tables[0].Rows)
            {

                lblName.Text = row["Name"].ToString();
                lblRank.Text = row["Rank"].ToString();
                lblRollNo.Text = row["RollNumber"].ToString();

                LblYear.Text = row["Year"].ToString();
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

    }
    #endregion "End Fill contorole on Form"
}