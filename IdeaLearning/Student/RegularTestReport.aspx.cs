using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Design;
using System.Drawing.Design;
using System.Drawing.Text;
using DataAccess;
using BusinessLogic.Admin;
using DataAccess;
using System.Data;
using System.Globalization;


public partial class Student_RegularTestReport : System.Web.UI.Page
{

    #region "Variable Decleration"
    private clsAdmin obj_Student = new clsAdmin();
    private clsStudent obj_Studenta = new clsStudent();
    
    private DataSet DS;
    private DataSet DS1;
    private int RecordStatus;
    private static int StudentId;
    private Results Result = new Results();
    private string SubjectName;
    private static int RegularTestId;
    private string StudentRegistration;

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
                // lblFatherName.Text = "FATHER Number : ".ToUpper() + row["FatherNumber"].ToString();
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

    protected void btnObjective_Click(object sender, EventArgs e)
    {

        DataSetisBlanck();
       
        Session["DPP"]  = "Objective DPP";
        btnObjective.BackColor = System.Drawing.Color.Orange;
        BtnSubjective.BackColor = System.Drawing.Color.Gray;
        BtnSubjective.ForeColor = System.Drawing.Color.White;
        btnObjective.ForeColor = System.Drawing.Color.White;
        lblError.Visible = false;
    }

    private void DataSetisBlanck()
    {
        DS = null;
        DS1 = null;
        GvReguler.DataSource = DS;
        GvReguler.DataBind();
    }

    protected void BtnSubjective_Click(object sender, EventArgs e)
    {
        DataSetisBlanck();
        Session["DPP"] = "Subjective DPP/Test";
        btnObjective.BackColor = System.Drawing.Color.Gray;
        BtnSubjective.BackColor = System.Drawing.Color.Orange;
        BtnSubjective.ForeColor = System.Drawing.Color.White;
        btnObjective.ForeColor = System.Drawing.Color.White;

        lblError.Visible = false;


    }

    private void BindGridView(string SujbectName)
    {
        var dt = new System.Data.DataTable();
        Result.DPP = Session["DPP"].ToString();
        Result.TestType = SujbectName;
        Result.ClassRegular = Session["ClassId"].ToString();
        DS = Result.DisplayRegularTest();
        GvReguler.DataSource = DS;
        GvReguler.DataBind();
        dt.Columns.Add("Name", typeof(string));
        dt.Columns.Add("BugCount", typeof(int));
        dt.Columns.Add("TestName", typeof(string));

        if (DS.Tables[0].Rows.Count > 0)
        {
            foreach (DataRow row in DS.Tables[0].Rows)
            {
                string TestName = row["RegularTestDate"].ToString();
                StudentRegistration = Session["StudentRegistration"].ToString();
                RegularTestId = Convert.ToInt32(row["RegularTestId"].ToString());
                Result.RegistrationNo = Session["StudentRegistration"].ToString();
                Result.RegularTestId = RegularTestId;
                DS1 = Result.DisplayRegularDataSingalStudent();
                if (DS1.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow row1 in DS1.Tables[0].Rows)
                    {
                        float TotalMarks = float.Parse(row1["ObtainMark"].ToString(), CultureInfo.InvariantCulture.NumberFormat);
                        //int TotalMarks = Convert.ToInt32(row1["ObtainMark"].ToString());
                        int TotalMarksOfToper = Convert.ToInt32(row1["MaxMark"].ToString());
                        dt.Rows.Add("Lowest Marks", TotalMarks, TestName);
                        dt.Rows.Add("Highest Marks", TotalMarksOfToper, TestName);
                     }
                }
                lblError1.Visible = false;
                lblError.Visible = false;
            }
        }
        else
        {
            lblError1.Visible = true;
            lblError1.Text = "Record Not Found";
        }
        Chart1.DataBindCrossTable(dt.Rows, "Name", "TestName", "BugCount", "");
        Chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
        Chart1.ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = false;   
    }


    protected void ButtonColor(string Color)
    {
        if (Color == "Mathsx11")
        {

            btnBiological.BackColor = System.Drawing.Color.Gray;
            btnBiological.ForeColor = System.Drawing.Color.White;

           btnChemistry.BackColor = System.Drawing.Color.Gray;
           btnChemistry.ForeColor = System.Drawing.Color.White;

            btnEnglishv.BackColor = System.Drawing.Color.Gray;
            btnEnglishv.ForeColor = System.Drawing.Color.White;

          btnMathsv11.BackColor = System.Drawing.Color.Gray;
          btnMathsv11.ForeColor = System.Drawing.Color.White;

          btnMathsx11.BackColor = System.Drawing.Color.Orange;
          btnMathsx11.ForeColor = System.Drawing.Color.White;
      
          btnPhysics.BackColor = System.Drawing.Color.Gray;
          btnPhysics.ForeColor = System.Drawing.Color.White;

          btnSciencex.BackColor = System.Drawing.Color.Gray;
          btnSciencex.ForeColor = System.Drawing.Color.White;
       
        }
        else if (Color == "Mathsv11")
        {
            btnBiological.BackColor = System.Drawing.Color.Gray;
            btnBiological.ForeColor = System.Drawing.Color.White;

            btnChemistry.BackColor = System.Drawing.Color.Gray;
            btnChemistry.ForeColor = System.Drawing.Color.White;

            btnEnglishv.BackColor = System.Drawing.Color.Gray;
            btnEnglishv.ForeColor = System.Drawing.Color.White;

            btnMathsv11.BackColor = System.Drawing.Color.Orange;
            btnMathsv11.ForeColor = System.Drawing.Color.White;

            btnMathsx11.BackColor = System.Drawing.Color.Gray;
            btnMathsx11.ForeColor = System.Drawing.Color.White;

            btnPhysics.BackColor = System.Drawing.Color.Gray;
            btnPhysics.ForeColor = System.Drawing.Color.White;

            btnSciencex.BackColor = System.Drawing.Color.Gray;
            btnSciencex.ForeColor = System.Drawing.Color.White;
        }
        else if (Color == "Sciencex")
        {
            btnBiological.BackColor = System.Drawing.Color.Gray;
            btnBiological.ForeColor = System.Drawing.Color.White;

            btnChemistry.BackColor = System.Drawing.Color.Gray;
            btnChemistry.ForeColor = System.Drawing.Color.White;

            btnEnglishv.BackColor = System.Drawing.Color.Gray;
            btnEnglishv.ForeColor = System.Drawing.Color.White;

            btnMathsv11.BackColor = System.Drawing.Color.Gray;
            btnMathsv11.ForeColor = System.Drawing.Color.White;

            btnMathsx11.BackColor = System.Drawing.Color.Gray;
            btnMathsx11.ForeColor = System.Drawing.Color.White;

            btnPhysics.BackColor = System.Drawing.Color.Gray;
            btnPhysics.ForeColor = System.Drawing.Color.White;

            btnSciencex.BackColor = System.Drawing.Color.Orange;
            btnSciencex.ForeColor = System.Drawing.Color.White;
        }
        else if (Color == "Englishv")
        {
            btnBiological.BackColor = System.Drawing.Color.Gray;
            btnBiological.ForeColor = System.Drawing.Color.White;

            btnChemistry.BackColor = System.Drawing.Color.Gray;
            btnChemistry.ForeColor = System.Drawing.Color.White;

            btnEnglishv.BackColor = System.Drawing.Color.Orange;
            btnEnglishv.ForeColor = System.Drawing.Color.White;

            btnMathsv11.BackColor = System.Drawing.Color.Gray;
            btnMathsv11.ForeColor = System.Drawing.Color.White;

            btnMathsx11.BackColor = System.Drawing.Color.Gray;
            btnMathsx11.ForeColor = System.Drawing.Color.White;

            btnPhysics.BackColor = System.Drawing.Color.Gray;
            btnPhysics.ForeColor = System.Drawing.Color.White;

            btnSciencex.BackColor = System.Drawing.Color.Gray;
            btnSciencex.ForeColor = System.Drawing.Color.White;
        }
        else if (Color == "Biological")
        {
            btnBiological.BackColor = System.Drawing.Color.Orange;
            btnBiological.ForeColor = System.Drawing.Color.White;

            btnChemistry.BackColor = System.Drawing.Color.Gray;
            btnChemistry.ForeColor = System.Drawing.Color.White;

            btnEnglishv.BackColor = System.Drawing.Color.Gray;
            btnEnglishv.ForeColor = System.Drawing.Color.White;

            btnMathsv11.BackColor = System.Drawing.Color.Gray;
            btnMathsv11.ForeColor = System.Drawing.Color.White;

            btnMathsx11.BackColor = System.Drawing.Color.Gray;
            btnMathsx11.ForeColor = System.Drawing.Color.White;

            btnPhysics.BackColor = System.Drawing.Color.Gray;
            btnPhysics.ForeColor = System.Drawing.Color.White;

            btnSciencex.BackColor = System.Drawing.Color.Gray;
            btnSciencex.ForeColor = System.Drawing.Color.White;
        }
        else if (Color == "Physics")
        {
            btnBiological.BackColor = System.Drawing.Color.Gray;
            btnBiological.ForeColor = System.Drawing.Color.White;

            btnChemistry.BackColor = System.Drawing.Color.Gray;
            btnChemistry.ForeColor = System.Drawing.Color.White;

            btnEnglishv.BackColor = System.Drawing.Color.Gray;
            btnEnglishv.ForeColor = System.Drawing.Color.White;

            btnMathsv11.BackColor = System.Drawing.Color.Gray;
            btnMathsv11.ForeColor = System.Drawing.Color.White;

            btnMathsx11.BackColor = System.Drawing.Color.Gray;
            btnMathsx11.ForeColor = System.Drawing.Color.White;

            btnPhysics.BackColor = System.Drawing.Color.Orange;
            btnPhysics.ForeColor = System.Drawing.Color.White;

            btnSciencex.BackColor = System.Drawing.Color.Gray;
            btnSciencex.ForeColor = System.Drawing.Color.White;
        }
        else if (Color == "Mathsx11")
        {
            btnBiological.BackColor = System.Drawing.Color.Gray;
            btnBiological.ForeColor = System.Drawing.Color.White;

            btnChemistry.BackColor = System.Drawing.Color.Gray;
            btnChemistry.ForeColor = System.Drawing.Color.White;

            btnEnglishv.BackColor = System.Drawing.Color.Gray;
            btnEnglishv.ForeColor = System.Drawing.Color.White;

            btnMathsv11.BackColor = System.Drawing.Color.Gray;
            btnMathsv11.ForeColor = System.Drawing.Color.White;

            btnMathsx11.BackColor = System.Drawing.Color.Orange;
            btnMathsx11.ForeColor = System.Drawing.Color.White;

            btnPhysics.BackColor = System.Drawing.Color.Gray;
            btnPhysics.ForeColor = System.Drawing.Color.White;

            btnSciencex.BackColor = System.Drawing.Color.Gray;
            btnSciencex.ForeColor = System.Drawing.Color.White;
        }
        else if (Color == "Chemistry")
        {
            btnBiological.BackColor = System.Drawing.Color.Gray;
            btnBiological.ForeColor = System.Drawing.Color.White;

            btnChemistry.BackColor = System.Drawing.Color.Orange;
            btnChemistry.ForeColor = System.Drawing.Color.White;

            btnEnglishv.BackColor = System.Drawing.Color.Gray;
            btnEnglishv.ForeColor = System.Drawing.Color.White;

            btnMathsv11.BackColor = System.Drawing.Color.Gray;
            btnMathsv11.ForeColor = System.Drawing.Color.White;

            btnMathsx11.BackColor = System.Drawing.Color.Gray;
            btnMathsx11.ForeColor = System.Drawing.Color.White;

            btnPhysics.BackColor = System.Drawing.Color.Gray;
            btnPhysics.ForeColor = System.Drawing.Color.White;

            btnSciencex.BackColor = System.Drawing.Color.Gray;
            btnSciencex.ForeColor = System.Drawing.Color.White;
        }
    }

    protected void btnChemistry_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Session["DPP"] as string))
        {
            ButtonColor("Chemistry");
            SubjectName = btnChemistry.Text;
            BindGridView(SubjectName);
            lblError.Visible = false;
            Chart1.Titles.Add("Chemistry");
            Chart1.Visible = true;

        }
        else
        {
            lblError.Visible = true;
            lblError.Text = "please Select DPP";
        }

    }
    protected void btnMathsx11_Click(object sender, EventArgs e)
    {

        // !string.IsNullOrEmpty(Session["emp_num"] as string
       //  if (Session["DPP"].ToString() != null)
            if (!string.IsNullOrEmpty(Session["DPP"] as string))
            {
            ButtonColor("Mathsx11");
            SubjectName = btnMathsx11.Text;
            BindGridView(SubjectName);
            lblError.Visible = false;
            Chart1.Titles.Add("Mathsx11");
            Chart1.Visible = true;
        }
        else
        {
            lblError.Visible = true;
            lblError.Text = "please Select DPP";
        }
    }
    protected void btnMathsv11_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Session["DPP"] as string))
        {
            ButtonColor("Mathsv11");
            SubjectName = btnMathsv11.Text;
            BindGridView(SubjectName);
            lblError.Visible = false;
            Chart1.Titles.Add("Mathsv11");
            Chart1.Visible = true;
        }
        else
        {
            lblError.Visible = true;
            lblError.Text = "please Select DPP";
        }
    }
    protected void btnSciencex_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Session["DPP"] as string))
        {
            ButtonColor("Sciencex");
            SubjectName = btnSciencex.Text;
            BindGridView(SubjectName);
            lblError.Visible = false;
            Chart1.Titles.Add("Sciencex");
            Chart1.Visible = true;
        }
        else
        {
            lblError.Visible = true;
            lblError.Text = "please Select DPP";
        }
    }
    protected void btnEnglishv_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Session["DPP"] as string))
        {
            ButtonColor("Englishv");
            SubjectName = btnEnglishv.Text;
            BindGridView(SubjectName);
            lblError.Visible = false;
            Chart1.Titles.Add("Englishv");
           Chart1.Visible = true;
        }
        else
        {
            lblError.Visible = true;
            lblError.Text = "please Select DPP";
        }
    }
    protected void btnBiological_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Session["DPP"] as string))
        {
            ButtonColor("Biological");
            SubjectName = btnBiological.Text;
            BindGridView(SubjectName);
            lblError.Visible = false;
            Chart1.Titles.Add("Biological");
            Chart1.Visible = true;
        }
        else
        {
            lblError.Visible = true;
            lblError.Text = "please Select DPP";
        }
    }
    protected void btnPhysics_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Session["DPP"] as string))
        {
            ButtonColor("Physics");
            SubjectName = btnPhysics.Text;
            BindGridView(SubjectName);
            lblError.Visible = false;
            Chart1.Titles.Add("Physics");
           Chart1.Visible = true;
        }
        else
        {
            lblError.Visible = true;
            lblError.Text = "please Select DPP";
        }
    }
}