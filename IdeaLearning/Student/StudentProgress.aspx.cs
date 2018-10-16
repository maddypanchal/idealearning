using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Design;
using System.Drawing.Design;
using System.Drawing.Text;

using System.Data;
using System.Data.SqlClient;
using DataAccess;
using BusinessLogic.Admin;

using System.Web.UI.DataVisualization.Charting;

public partial class Student_StudentProgress : System.Web.UI.Page
{
    #region "Variable Decleration"
    private clsAdmin obj_Student = new clsAdmin();
    private clsStudent obj_Studenta = new clsStudent();
    private Results obj_Results = new Results();
    private DataSet DS;
    private DataSet DS1;
    private string DristhiTestData;
    private static int StudentId;
    private static int DristhiResultId;
    private string StudentRegistration;
    public  DataTable DT;
    private Results Result = new Results();
    private int CheckRecordStatus;
    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {
      
        if (Session["USER_NAME"] != null)
        {
            StudentId = Convert.ToInt32(Session["StudentId"].ToString());
            if (!IsPostBack)
            {
                FillStudentInformation();
            }
        }
        else
        {
            Response.Redirect("~/Login.aspx");
        }
    }

     
    #region " Fill contorole on Form"
    private void FillStudentInformation()
    {
        obj_Studenta.StudentId = StudentId;
        DS = obj_Studenta.DisplayPStudent();
        if (DS.Tables[0].Rows.Count > 0)
        {
            foreach (DataRow row in DS.Tables[0].Rows)
            {
                //txtAddress.Text = "Address : ".ToUpper() + row["Address"].ToString() + "  " + row["CityText"].ToString() + "  " + row["StateText"].ToString() + "  " + row["CountryText"].ToString();
                //txtemail.Text = "EMAIL : ".ToUpper() + row["Email"].ToString();
                //lblSname.Text = "STUDENT NAME : ".ToUpper() + row["StudentName"].ToString();
                lblClass.Text = "Class Name : ".ToUpper() + row["ClassText"].ToString();
                //txtCourseDuration.Text = "Course Duration : ".ToUpper() + row["CourseDuration"].ToString();
                //txtDateofBifth.Text = "DATE OF BIRTH : ".ToUpper() + row["DateOfBirth"].ToString();
                //txtDuePayment.Text = "Due Payment : ".ToUpper() + row["DuePayment"].ToString();
                //txtRegistrationNo.Text = "Registration No : ".ToUpper() + row["RegistrationNo"].ToString();
                //txtmobile.Text = "Mobile Number : ".ToUpper() + row["Mobile"].ToString();
                lblFatherName.Text = "FATHER NAME : ".ToUpper() + row["FatherName"].ToString();
                //lblFatherName.Text = "FATHER Number : ".ToUpper() + row["FatherNumber"].ToString();
                //lblAlters.Text = "ALERT : ".ToUpper() + row["Alert"].ToString();
                Session["ClassId"] = row["ClassId"].ToString();
                //txtCorusesOne.Text = "CoursesOne : " + row["CourseOneText"].ToString();
                lblRegistrationNo.Text = "Registration No : ".ToUpper() + row["RegistrationNo"].ToString();

                Session["StudentRegistration"] = row["RegistrationNo"].ToString();
                lblStudentName.Text = "STUDENT NAME : ".ToUpper() + row["StudentName"].ToString();
                if (row["UploadImages"].ToString() == "")
                {
                    ImgPhoto.ImageUrl = "../UploadedFile/Defultuser.png";
                }
                else
                {
                    ImgPhoto.ImageUrl = "../CroppedImages/" + row["UploadImages"].ToString();
                }

               
            }
        }

    }
    #endregion "End Fill contorole on Form"

 
    protected void ButtonColor(string  Color)
    {
        if (Color == "IIT_JEE_ADVANCE")
        {
            btnAIPMT.BackColor = System.Drawing.Color.Gray;
            btnAIPMT.ForeColor = System.Drawing.Color.White;

            btnAIIMS.BackColor = System.Drawing.Color.Gray;
            btnAIIMS.ForeColor = System.Drawing.Color.White;

            btnBITS.BackColor = System.Drawing.Color.Gray;
            btnBITS.ForeColor = System.Drawing.Color.White;
            
            btnIIT_JEE_ADVANCE.BackColor = System.Drawing.Color.Orange;
            btnIIT_JEE_ADVANCE.ForeColor = System.Drawing.Color.White;
            
            btnJEE_MAINS.BackColor = System.Drawing.Color.Gray;
            btnJEE_MAINS.ForeColor = System.Drawing.Color.White;
            btnKVPY.BackColor = System.Drawing.Color.Gray;
            btnKVPY.ForeColor = System.Drawing.Color.White;
            btnNTSE.BackColor = System.Drawing.Color.Gray;
            btnNTSE.ForeColor = System.Drawing.Color.White;
            btnOLYMPIAD.BackColor = System.Drawing.Color.Gray;
            btnOLYMPIAD.ForeColor = System.Drawing.Color.White;
            btnOTHER.BackColor = System.Drawing.Color.Gray;
            btnOTHER.ForeColor = System.Drawing.Color.White;
    
        }
        else if (Color == "JEE_MAINS")
        {
            btnAIPMT.BackColor = System.Drawing.Color.Gray;
            btnAIPMT.ForeColor = System.Drawing.Color.White;

            btnAIIMS.BackColor = System.Drawing.Color.Gray;
            btnAIIMS.ForeColor = System.Drawing.Color.White;

            btnBITS.BackColor = System.Drawing.Color.Gray;
            btnBITS.ForeColor = System.Drawing.Color.White;

            btnIIT_JEE_ADVANCE.BackColor = System.Drawing.Color.Gray;
            btnIIT_JEE_ADVANCE.ForeColor = System.Drawing.Color.White;

            btnJEE_MAINS.BackColor = System.Drawing.Color.Orange;
            btnJEE_MAINS.ForeColor = System.Drawing.Color.White;
            btnKVPY.BackColor = System.Drawing.Color.Gray;
            btnKVPY.ForeColor = System.Drawing.Color.White;
            btnNTSE.BackColor = System.Drawing.Color.Gray;
            btnNTSE.ForeColor = System.Drawing.Color.White;
            btnOLYMPIAD.BackColor = System.Drawing.Color.Gray;
            btnOLYMPIAD.ForeColor = System.Drawing.Color.White;
            btnOTHER.BackColor = System.Drawing.Color.Gray;
            btnOTHER.ForeColor = System.Drawing.Color.White;
        }
        else if (Color == "AIPMT")
        {
            btnAIPMT.BackColor = System.Drawing.Color.Orange;
            btnAIPMT.ForeColor = System.Drawing.Color.White;

            btnAIIMS.BackColor = System.Drawing.Color.Gray;
            btnAIIMS.ForeColor = System.Drawing.Color.White;

            btnBITS.BackColor = System.Drawing.Color.Gray;
            btnBITS.ForeColor = System.Drawing.Color.White;

            btnIIT_JEE_ADVANCE.BackColor = System.Drawing.Color.Gray;
            btnIIT_JEE_ADVANCE.ForeColor = System.Drawing.Color.White;

            btnJEE_MAINS.BackColor = System.Drawing.Color.Gray;
            btnJEE_MAINS.ForeColor = System.Drawing.Color.White;
            btnKVPY.BackColor = System.Drawing.Color.Gray;
            btnKVPY.ForeColor = System.Drawing.Color.White;
            btnNTSE.BackColor = System.Drawing.Color.Gray;
            btnNTSE.ForeColor = System.Drawing.Color.White;
            btnOLYMPIAD.BackColor = System.Drawing.Color.Gray;
            btnOLYMPIAD.ForeColor = System.Drawing.Color.White;
            btnOTHER.BackColor = System.Drawing.Color.Gray;
            btnOTHER.ForeColor = System.Drawing.Color.White;
        }
        else if (Color == "BITS")
        {
            btnAIPMT.BackColor = System.Drawing.Color.Gray;
            btnAIPMT.ForeColor = System.Drawing.Color.White;

            btnAIIMS.BackColor = System.Drawing.Color.Gray;
            btnAIIMS.ForeColor = System.Drawing.Color.White;

            btnBITS.BackColor = System.Drawing.Color.Orange;
            btnBITS.ForeColor = System.Drawing.Color.White;

            btnIIT_JEE_ADVANCE.BackColor = System.Drawing.Color.Gray;
            btnIIT_JEE_ADVANCE.ForeColor = System.Drawing.Color.White;

            btnJEE_MAINS.BackColor = System.Drawing.Color.Gray;
            btnJEE_MAINS.ForeColor = System.Drawing.Color.White;
            btnKVPY.BackColor = System.Drawing.Color.Gray;
            btnKVPY.ForeColor = System.Drawing.Color.White;
            btnNTSE.BackColor = System.Drawing.Color.Gray;
            btnNTSE.ForeColor = System.Drawing.Color.White;
            btnOLYMPIAD.BackColor = System.Drawing.Color.Gray;
            btnOLYMPIAD.ForeColor = System.Drawing.Color.White;
            btnOTHER.BackColor = System.Drawing.Color.Gray;
            btnOTHER.ForeColor = System.Drawing.Color.White;
        }
        else if (Color == "KVPY")
        {
            btnAIPMT.BackColor = System.Drawing.Color.Gray;
            btnAIPMT.ForeColor = System.Drawing.Color.White;

            btnAIIMS.BackColor = System.Drawing.Color.Gray;
            btnAIIMS.ForeColor = System.Drawing.Color.White;

            btnBITS.BackColor = System.Drawing.Color.Gray;
            btnBITS.ForeColor = System.Drawing.Color.White;

            btnIIT_JEE_ADVANCE.BackColor = System.Drawing.Color.Gray;
            btnIIT_JEE_ADVANCE.ForeColor = System.Drawing.Color.White;

            btnJEE_MAINS.BackColor = System.Drawing.Color.Gray;
            btnJEE_MAINS.ForeColor = System.Drawing.Color.White;
            btnKVPY.BackColor = System.Drawing.Color.Orange;
            btnKVPY.ForeColor = System.Drawing.Color.White;
            btnNTSE.BackColor = System.Drawing.Color.Gray;
            btnNTSE.ForeColor = System.Drawing.Color.White;
            btnOLYMPIAD.BackColor = System.Drawing.Color.Gray;
            btnOLYMPIAD.ForeColor = System.Drawing.Color.White;
            btnOTHER.BackColor = System.Drawing.Color.Gray;
            btnOTHER.ForeColor = System.Drawing.Color.White;
        }
        else if (Color == "NTSE")
        {
            btnAIPMT.BackColor = System.Drawing.Color.Gray;
            btnAIPMT.ForeColor = System.Drawing.Color.White;

            btnAIIMS.BackColor = System.Drawing.Color.Gray;
            btnAIIMS.ForeColor = System.Drawing.Color.White;

            btnBITS.BackColor = System.Drawing.Color.Gray;
            btnBITS.ForeColor = System.Drawing.Color.White;

            btnIIT_JEE_ADVANCE.BackColor = System.Drawing.Color.Gray;
            btnIIT_JEE_ADVANCE.ForeColor = System.Drawing.Color.White;

            btnJEE_MAINS.BackColor = System.Drawing.Color.Gray;
            btnJEE_MAINS.ForeColor = System.Drawing.Color.White;
            btnKVPY.BackColor = System.Drawing.Color.Gray;
            btnKVPY.ForeColor = System.Drawing.Color.White;
            btnNTSE.BackColor = System.Drawing.Color.Orange;
            btnNTSE.ForeColor = System.Drawing.Color.White;
            btnOLYMPIAD.BackColor = System.Drawing.Color.Gray;
            btnOLYMPIAD.ForeColor = System.Drawing.Color.White;
            btnOTHER.BackColor = System.Drawing.Color.Gray;
            btnOTHER.ForeColor = System.Drawing.Color.White;
        }
        else if (Color == "OLYMPIAD")
        {
            btnAIPMT.BackColor = System.Drawing.Color.Gray;
            btnAIPMT.ForeColor = System.Drawing.Color.White;

            btnAIIMS.BackColor = System.Drawing.Color.Gray;
            btnAIIMS.ForeColor = System.Drawing.Color.White;

            btnBITS.BackColor = System.Drawing.Color.Gray;
            btnBITS.ForeColor = System.Drawing.Color.White;

            btnIIT_JEE_ADVANCE.BackColor = System.Drawing.Color.Gray;
            btnIIT_JEE_ADVANCE.ForeColor = System.Drawing.Color.White;

            btnJEE_MAINS.BackColor = System.Drawing.Color.Gray;
            btnJEE_MAINS.ForeColor = System.Drawing.Color.White;
            btnKVPY.BackColor = System.Drawing.Color.Gray;
            btnKVPY.ForeColor = System.Drawing.Color.White;
            btnNTSE.BackColor = System.Drawing.Color.Gray;
            btnNTSE.ForeColor = System.Drawing.Color.White;
            btnOLYMPIAD.BackColor = System.Drawing.Color.Orange;
            btnOLYMPIAD.ForeColor = System.Drawing.Color.White;
            btnOTHER.BackColor = System.Drawing.Color.Gray;
            btnOTHER.ForeColor = System.Drawing.Color.White;
        }
        else if (Color == "OTHER")
        {
            btnAIPMT.BackColor = System.Drawing.Color.Gray;
            btnAIPMT.ForeColor = System.Drawing.Color.White;

            btnAIIMS.BackColor = System.Drawing.Color.Gray;
            btnAIIMS.ForeColor = System.Drawing.Color.White;

            btnBITS.BackColor = System.Drawing.Color.Gray;
            btnBITS.ForeColor = System.Drawing.Color.White;

            btnIIT_JEE_ADVANCE.BackColor = System.Drawing.Color.Gray;
            btnIIT_JEE_ADVANCE.ForeColor = System.Drawing.Color.White;

            btnJEE_MAINS.BackColor = System.Drawing.Color.Gray;
            btnJEE_MAINS.ForeColor = System.Drawing.Color.White;
            btnKVPY.BackColor = System.Drawing.Color.Gray;
            btnKVPY.ForeColor = System.Drawing.Color.White;
            btnNTSE.BackColor = System.Drawing.Color.Gray;
            btnNTSE.ForeColor = System.Drawing.Color.White;
            btnOLYMPIAD.BackColor = System.Drawing.Color.Gray;
            btnOLYMPIAD.ForeColor = System.Drawing.Color.White;
            btnOTHER.BackColor = System.Drawing.Color.Orange;
            btnOTHER.ForeColor = System.Drawing.Color.White;
        }
        else if (Color == "AIIMS")
         {
            btnAIPMT.BackColor = System.Drawing.Color.Gray;
            btnAIPMT.ForeColor = System.Drawing.Color.White;

            btnAIIMS.BackColor = System.Drawing.Color.Orange;
            btnAIIMS.ForeColor = System.Drawing.Color.White;

            btnBITS.BackColor = System.Drawing.Color.Gray;
            btnBITS.ForeColor = System.Drawing.Color.White;

            btnIIT_JEE_ADVANCE.BackColor = System.Drawing.Color.Gray;
            btnIIT_JEE_ADVANCE.ForeColor = System.Drawing.Color.White;

            btnJEE_MAINS.BackColor = System.Drawing.Color.Gray;
            btnJEE_MAINS.ForeColor = System.Drawing.Color.White;
            btnKVPY.BackColor = System.Drawing.Color.Gray;
            btnKVPY.ForeColor = System.Drawing.Color.White;
            btnNTSE.BackColor = System.Drawing.Color.Gray;
            btnNTSE.ForeColor = System.Drawing.Color.White;
            btnOLYMPIAD.BackColor = System.Drawing.Color.Gray;
            btnOLYMPIAD.ForeColor = System.Drawing.Color.White;
            btnOTHER.BackColor = System.Drawing.Color.Gray;
            btnOTHER.ForeColor = System.Drawing.Color.White;
        }
    }

    private void FillDataDristhi(String Dristhi)
    {

        var dt = new System.Data.DataTable();
        Result.ClassDristhi = Session["ClassId"].ToString();
        Result.DristhiTestCode = Dristhi; // ddlDrishti.SelectedItem.ToString();
        DS = Result.DisplayDristhiTest();
        gvDristhi.DataSource = DS;
        gvDristhi.DataBind();
        dt.Columns.Add("Name", typeof(string));
        dt.Columns.Add("BugCount", typeof(int));
        dt.Columns.Add("TestName", typeof(string));

        if (DS.Tables[0].Rows.Count > 0)
        {
            foreach (DataRow row in DS.Tables[0].Rows)
            {
                string dristhiTestName = row["DristhiTestName"].ToString();
                StudentRegistration = Session["StudentRegistration"].ToString();
                DristhiResultId = Convert.ToInt32(row["DristhiTestResultId"].ToString());
                obj_Results.RegistrationNo = StudentRegistration;
                obj_Results.DristhiTestResultId = DristhiResultId;
                DS1 = obj_Results.DisplayDristhiReport();
                if (DS1.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow row1 in DS1.Tables[0].Rows)
                    {
                        int TotalMarks = Convert.ToInt32(row1["TotalMarks"].ToString());
                        int TotalMarksOfToper = Convert.ToInt32(row1["TotalMaxMarks"].ToString());
                        dt.Rows.Add("Lowest Marks", TotalMarks, dristhiTestName);
                        dt.Rows.Add("Highest Marks", TotalMarksOfToper, dristhiTestName);
                       // ChartId++;
                    }
                    lblError.Visible = false;
                }
                else
                {
                    lblError.Visible = true;
                    lblError.Text = "Record Not Found";
                }
            }
        }
        else
        {
            lblError.Visible = true;
            lblError.Text = "Record Not Found";
        }
              Chart1.DataBindCrossTable(dt.Rows, "Name", "TestName", "BugCount", "");
              Chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
              Chart1.ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = false;   
    }

    protected void gvDristhi_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
         Result.DristhiTestResultId = Convert.ToInt32(gvDristhi.DataKeys[e.RowIndex].Values["DristhiTestResultId"].ToString());
         CheckRecordStatus = Result.DeleteDristhiReuslt();
         // FillDataDristhi();
    }

    protected void btnIIT_JEE_ADVANCE_Click(object sender, EventArgs e)
    {
       ButtonColor("IIT_JEE_ADVANCE");
       DristhiTestData  = btnIIT_JEE_ADVANCE.Text;
       Session["DristhiTestData"] = DristhiTestData;
       FillDataDristhi(DristhiTestData);
       Chart1.Titles.Add("IIT_JEE_ADVANCE");
       Chart1.Visible = true;
     

    }
    protected void btnJEE_MAINS_Click(object sender, EventArgs e)
    {
        ButtonColor("JEE_MAINS");
        DristhiTestData = btnJEE_MAINS.Text;
        Session["DristhiTestData"] = DristhiTestData;
        FillDataDristhi(DristhiTestData);
        Chart1.Titles.Add("JEE_MAINS");
        Chart1.Visible = true;
    }
    protected void btnAIPMT_Click(object sender, EventArgs e)
    {
        ButtonColor("AIPMT");
        DristhiTestData = btnAIPMT.Text;
        Session["DristhiTestData"] = DristhiTestData;
        FillDataDristhi(DristhiTestData);
        Chart1.Titles.Add("AIPMT");
        Chart1.Visible = true;
    }

    protected void btnAIIMS_Click(object sender, EventArgs e)
    {
        ButtonColor("AIIMS");
        DristhiTestData = btnAIIMS.Text;
     
        Session["DristhiTestData"] = DristhiTestData;
        FillDataDristhi(DristhiTestData);
        Chart1.Titles.Add("AIIMS");
        Chart1.Visible = true;
    }
    
    protected void btnBITS_Click(object sender, EventArgs e)
    {
        ButtonColor("BITS");
        DristhiTestData = btnBITS.Text;

        Session["DristhiTestData"] = DristhiTestData;
        FillDataDristhi(DristhiTestData);
        Chart1.Titles.Add("BITS");
        Chart1.Visible = true;
    }
    protected void btnKVPY_Click(object sender, EventArgs e)
    {
        ButtonColor("KVPY");
        DristhiTestData = btnKVPY.Text;
        Session["DristhiTestData"] = DristhiTestData;
        FillDataDristhi(DristhiTestData);
        Chart1.Titles.Add("KVPY");
        Chart1.Visible = true;
    }
    protected void btnNTSE_Click(object sender, EventArgs e)
    {
        ButtonColor("NTSE");
        DristhiTestData = btnNTSE.Text;
        Session["DristhiTestData"] = DristhiTestData;
        FillDataDristhi(DristhiTestData);
        Chart1.Titles.Add("NTSE");
        Chart1.Visible = true;
    }
    protected void btnOLYMPIAD_Click(object sender, EventArgs e)
    {
        ButtonColor("OLYMPIAD");
        DristhiTestData = btnOLYMPIAD.Text;
        Session["DristhiTestData"] = DristhiTestData;
        FillDataDristhi(DristhiTestData);
        Chart1.Titles.Add("OLYMPIAD");
        Chart1.Visible = true;
    }
    protected void btnOTHER_Click(object sender, EventArgs e)
    {
        ButtonColor("OTHER");
        DristhiTestData = btnOTHER.Text;
        Session["DristhiTestData"] = DristhiTestData;
        FillDataDristhi(DristhiTestData);
        Chart1.Titles.Add("OTHER");
        Chart1.Visible = true;
    }
}