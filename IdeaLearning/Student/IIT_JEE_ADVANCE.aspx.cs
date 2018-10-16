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
using System.Drawing;
using System.Data;
using System.IO;
using System.Web.UI.DataVisualization.Charting;


public partial class Student_IIT_JEE_ADVANCE : System.Web.UI.Page
{
    #region "Variable Decleration"
    private Results obj_Results = new Results();
    private DataSet DS;
    private DataSet DSMAX;
    private int RecordStatus;
    private static int DristhiResultId;
    private string StudentRegistration;
    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {
        StudentRegistration = Session["StudentRegistration"].ToString();
        DristhiResultId = Convert.ToInt32(Session["DristhiResultId"]);
        FillDristhi();
        if (!IsPostBack)
        {
            // Chart1.Series["Series1"].ChartType = (SeriesChartType)Enum.Parse(typeof(SeriesChartType), "4");
            //   Chart2.Series["Series2"].ChartType = (SeriesChartType)Enum.Parse(typeof(SeriesChartType), "4");
            //   GetChartTypes();
        }

//GetChartTypes();
        
       // FillDristhiMax();
    }


    //private void GetChartTypes()
    //{
    //    foreach (int chartType in Enum.GetValues(typeof(SeriesChartType)))
    //    {
    //        ListItem li = new ListItem(Enum.GetName(typeof(SeriesChartType), chartType), chartType.ToString());
    //        DropDownList1.Items.Add(li);
    //        DropDownList2.Items.Add(li);
    //    }
    //}
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
       // Chart1.Series["Series1"].ChartType = (SeriesChartType)Enum.Parse(typeof(SeriesChartType), DropDownList1.SelectedValue);
       // Chart1.Series["Series1"].ChartType = (SeriesChartType)Enum.Parse(typeof(SeriesChartType), "4");
    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        //Chart2.Series["Series2"].ChartType = (SeriesChartType)Enum.Parse(typeof(SeriesChartType), DropDownList2.SelectedValue);

       // Chart1.Series["Series1"].ChartType = (SeriesChartType)Enum.Parse(typeof(SeriesChartType), "4");
    }
    private void FillDristhi()
    {
        obj_Results.RegistrationNo = StudentRegistration;
        obj_Results.DristhiTestResultId = DristhiResultId;
        DS = obj_Results.DisplayDristhiReport();

        if (DS.Tables[0].Rows.Count > 0)
        {
            gvDristhiSheet.DataSource = DS;
            gvDristhiSheet.DataBind();
        }
        else
        {
            lblMsg.Text = "Either You were Absent in this test or you were not eligable for this test !";
        }
      

      


    }


    private void FillDristhiMax()
    {
        obj_Results.RegistrationNo = StudentRegistration;
        obj_Results.DristhiTestResultId = DristhiResultId;
        DSMAX = obj_Results.DisplayDristhiReportMax();
//GridViewMax.DataSource = DSMAX;
//GridViewMax.DataBind();
    }
}