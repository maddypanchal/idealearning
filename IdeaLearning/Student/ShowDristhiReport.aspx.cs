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
using System.IO;

public partial class Student_ShowDristhiReport : System.Web.UI.Page
{
    #region "Variable Decleration"
    private static int DristhiResultId;
    private string StudentRegistration;
    private string SubjectName;
    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {
        StudentRegistration = Session["StudentRegistration"].ToString();
        DristhiResultId = int.Parse(Request.QueryString["Sid"]);

        Session["DristhiResultId"] = DristhiResultId;
        SubjectName = Session["DristhiTestData"].ToString();

        if (SubjectName == "OTHER")
        {
            Response.Redirect("OTHER.aspx", false);
        }
        else if (SubjectName == "IIT-JEE-ADVANCE")
        {
            Response.Redirect("IIT_JEE_ADVANCE.aspx", false);
        }
        else if (SubjectName == "JEE-MAINS")
        {
            Response.Redirect("JEE_MAINS.aspx", false);
        }
        else if (SubjectName == "AIPMT")
        {
            Response.Redirect("AIPMT.aspx", false);
        }
        else if (SubjectName == "AIIMS")
        {
            Response.Redirect("AIIMS.aspx", false);
        }
        else if (SubjectName == "BITS")
        {
            Response.Redirect("BITS.aspx", false);
        }
        else if (SubjectName == "KVPY")
        {
            Response.Redirect("KVPY.aspx", false);
        }
        else if (SubjectName == "NTSE")
        {
            Response.Redirect("NTSE.aspx", false);
        }
        else if (SubjectName == "OLYMPIAD")
        {
            Response.Redirect("OLYMPIAD.aspx", false);
        }
   
    }

}