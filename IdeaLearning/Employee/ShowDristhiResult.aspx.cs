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
public partial class Employee_ShowDristhiResult : System.Web.UI.Page
{
    #region "Variable Decleration"
    private Results obj_Results = new Results();
    private DataSet DS;
    private int RecordStatus;
    private static int DristhiResultId;
    private string myFileExtension;
    #endregion
    protected void Page_Load(object sender, EventArgs e)
    {
        DristhiResultId = int.Parse(Request.QueryString["Sid"]);
        FillDristhi();

    }

    private void FillDristhi()
    {
        obj_Results.DristhiTestResultId = DristhiResultId;
        DS = obj_Results.DisplayDristhiSheet();
        gvDristhiSheet.DataSource = DS;
        gvDristhiSheet.DataBind();
    }



}