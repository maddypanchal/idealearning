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

public partial class Student_KVPY : System.Web.UI.Page
{
    #region "Variable Decleration"
    private Results obj_Results = new Results();
    private DataSet DS;
    private int RecordStatus;
    private static int DristhiResultId;
    private string StudentRegistration;
    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {
        StudentRegistration = Session["StudentRegistration"].ToString();
        DristhiResultId = Convert.ToInt32(Session["DristhiResultId"]);
        FillDristhi();
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
}