using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogic.Admin;
using DataAccess;

public partial class Student_attendence : System.Web.UI.Page
{
    #region "Variable Decleration"
    private clsNews obj_News = new clsNews();
    private clsMaster Obj_Master = new clsMaster();
    private clsStudent obj_Student = new clsStudent();
    private DataSet DS;
    private int TotalAbsent;
    private int TotalPresent;
    private int TotalClass;
    private static int StudentId;
    #endregion
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["USER_NAME"]!=null)
        //if (!string.IsNullOrEmpty(Session["USER_NAME"].ToString()))
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
        obj_Student.StudentId = StudentId;
        DS = obj_Student.AttendenceStudent();
        if (DS.Tables[0].Rows.Count > 0)
        {
            foreach (DataRow row in DS.Tables[0].Rows)
            {
                Session["ClassId"] = row["ClassId"].ToString();
                // Courses
                if (row["CourseOneText"].ToString() == "" || row["CourseOneText"].ToString() == "--Select--")
                {
                    lblCoursesOneText.Visible = false;
                }
                else
                {
                    lblCoursesOneText.Visible = true;
                    lblCoursesOneText.Text = "you are registrated in Course " + row["CourseOneText"].ToString();
                }

                if (row["CourseTwoText"].ToString() == "" || row["CourseTwoText"].ToString() == "--Select--")
                {
                    lblCoursesTwoText.Visible = false;
                }
                else
                {
                    lblCoursesTwoText.Visible = true;
                    lblCoursesTwoText.Text = "you are registrated in Course " + row["CourseTwoText"].ToString();
                }

                if (row["CourseThreeText"].ToString() == "" || row["CourseThreeText"].ToString() == "--Select--")
                {
                    lblCoursesThreeText.Visible = false;
                }
                else
                {
                    lblCoursesThreeText.Visible = true;
                    lblCoursesThreeText.Text = "you are registrated in Course " + row["CourseThreeText"].ToString();
                }


                if (row["CourseFourText"].ToString() == "" || row["CourseFourText"].ToString() == "--Select--")
                {
                    lblCoursesFourText.Visible = false;
                }
                else
                {
                    lblCoursesFourText.Visible = true;
                    lblCoursesFourText.Text = "you are registrated in Course " + row["CourseFourText"].ToString();
                }

                // Subject

                if (row["CourseOneSubjectOneText"].ToString() == "" || row["CourseOneSubjectOneText"].ToString() == "--Select--")
                {
                    btnCoOneTextSubjectOneText.Visible = false;
                }
                else
                {
                    btnCoOneTextSubjectOneText.Visible = true;
                    lblSubjectOneText.Text = "Subject:";
                    btnCoOneTextSubjectOneText.Text =  row["CourseOneSubjectOneText"].ToString();
                }

                if (row["CourseOneSubjectTwoText"].ToString() == "" || row["CourseOneSubjectTwoText"].ToString() == "--Select--")
                {
                    btnCoOneTextSubjectTwoText.Visible = false;
                }
                else
                {
                    btnCoOneTextSubjectTwoText.Visible = true;
                    btnCoOneTextSubjectTwoText.Text =  row["CourseOneSubjectTwoText"].ToString();
                }
                if (row["CourseOneSubjectThreeText"].ToString() == "" || row["CourseOneSubjectThreeText"].ToString() == "--Select--")
                {
                    btnCoOneTextSubjectThreeText.Visible = false;
                }
                else
                {
                    btnCoOneTextSubjectThreeText.Visible = true;
                    btnCoOneTextSubjectThreeText.Text =  row["CourseOneSubjectThreeText"].ToString();
                }

                if (row["CourseOneSubjectFourText"].ToString() == "" || row["CourseOneSubjectFourText"].ToString() == "--Select--")
                {
                    btnCoOneTextSubjectFourText.Visible = false;
                }
                else
                {
                    btnCoOneTextSubjectFourText.Visible = true;
                    btnCoOneTextSubjectFourText.Text =  row["CourseOneSubjectFourText"].ToString();
                }


                if (row["CourseTwoSubjectOneText"].ToString() == "" || row["CourseTwoSubjectOneText"].ToString() == "--Select--")
                {
                    btnCoTwoTextSubjectOneText.Visible = false;
                }
                else
                {
                    btnCoTwoTextSubjectOneText.Visible = true;
                    lblSubjectTwoText.Text = "Subject:";
                    btnCoTwoTextSubjectOneText.Text = row["CourseTwoSubjectOneText"].ToString();
                }

                if (row["CourseTwoSubjectTwoText"].ToString() == "" || row["CourseTwoSubjectTwoText"].ToString() == "--Select--")
                {
                    btnCoTwoTextSubjectTwoText.Visible = false;
                }
                else
                {
                    btnCoTwoTextSubjectTwoText.Visible = true;
                    btnCoTwoTextSubjectTwoText.Text =  row["CourseTwoSubjectTwoText"].ToString();
                }

                if (row["CourseTwoSubjectThreeText"].ToString() == "" || row["CourseTwoSubjectThreeText"].ToString() == "--Select--")
                {
                    btnCoTwoTextSubjectThreeText.Visible = false;
                }
                else
                {
                    btnCoTwoTextSubjectThreeText.Visible = true;
                    btnCoTwoTextSubjectThreeText.Text =  row["CourseTwoSubjectThreeText"].ToString();
                }
                if (row["CourseTwoSubjectFourText"].ToString() == "" || row["CourseTwoSubjectFourText"].ToString() == "--Select--")
                {
                    btnCoTwoTextSubjectFourText.Visible = false;
                }
                else
                {
                    btnCoTwoTextSubjectFourText.Visible = true;
                    btnCoTwoTextSubjectFourText.Text =  row["CourseTwoSubjectFourText"].ToString();
                }

                if (row["CourseThreeSubjectOneText"].ToString() == "" || row["CourseThreeSubjectOneText"].ToString() == "--Select--")
                {
                    btnCoThreeTextSubjectOneText.Visible = false;
                }
                else
                {
                    btnCoThreeTextSubjectOneText.Visible = true;
                    lblSubjectThreeText.Text = "Subject:";
                    btnCoThreeTextSubjectOneText.Text =  row["CourseThreeSubjectOneText"].ToString();
                }
                if (row["CourseThreeSubjectTwoText"].ToString() == "" || row["CourseThreeSubjectTwoText"].ToString() == "--Select--")
                {
                    btnCoThreeTextSubjectTwoText.Visible = false;
                }
                else
                {
                    btnCoThreeTextSubjectTwoText.Visible = true;
                    btnCoThreeTextSubjectTwoText.Text =  row["CourseThreeSubjectTwoText"].ToString();
                }
                if (row["CourseThreeSubjectThreeText"].ToString() == "" || row["CourseThreeSubjectThreeText"].ToString() == "--Select--")
                {
                    btnCoThreeTextSubjectThreeText.Visible = false;
                }
                else
                {
                    btnCoThreeTextSubjectThreeText.Visible = true;
                    btnCoThreeTextSubjectThreeText.Text =  row["CourseThreeSubjectThreeText"].ToString();
                }
                if (row["CourseThreeSubjectFourText"].ToString() == "" || row["CourseThreeSubjectFourText"].ToString() == "--Select--")
                {
                    btnCoThreeTextSubjectFourText.Visible = false;
                }
                else
                {
                    btnCoThreeTextSubjectFourText.Visible = true;
                    btnCoThreeTextSubjectFourText.Text =  row["CourseThreeSubjectFourText"].ToString();
                }
                if (row["CourseFourSubjectOneText"].ToString() == "" || row["CourseFourSubjectOneText"].ToString() == "--Select--")
                {
                    btnCoFourTextSubjectOneText.Visible = false;
                }
                else
                {
                    btnCoFourTextSubjectOneText.Visible = true;
                    lblSubjectFourText.Text = "Subject:";
                    btnCoFourTextSubjectOneText.Text =  row["CourseFourSubjectOneText"].ToString();
                }
                if (row["CourseFourSubjectTwoText"].ToString() == "" || row["CourseFourSubjectTwoText"].ToString() == "--Select--")
                {
                    btnCoFourTextSubjectTwoText.Visible = false;
                }
                else
                {
                    btnCoFourTextSubjectTwoText.Visible = true;
                    btnCoFourTextSubjectTwoText.Text =  row["CourseFourSubjectTwoText"].ToString();
                }
                if (row["CourseFourSubjectThreeText"].ToString() == "" || row["CourseFourSubjectThreeText"].ToString() == "--Select--")
                {
                    btnCoFourTextSubjectThreeText.Visible = false;
                }
                else
                {
                    btnCoFourTextSubjectThreeText.Visible = true;
                    btnCoFourTextSubjectThreeText.Text =  row["CourseFourSubjectThreeText"].ToString();
                }
                if (row["CourseFourSubjectFourText"].ToString() == "" || row["CourseFourSubjectFourText"].ToString() == "--Select--")
                {
                    btnCoFourTextSubjectFourText.Visible = false;
                }
                else
                {
                    btnCoFourTextSubjectFourText.Visible = true;
                    btnCoFourTextSubjectFourText.Text =  row["CourseFourSubjectFourText"].ToString();
                }
           }
        }

    }
    #endregion "End Fill contorole on Form"

    #region " Fill User Grid View"
    public void FillNews()
    {
        Obj_Master.StudentId = StudentId;
        DS = Obj_Master.DisplayStudentAbsent();
        gvDetail1.DataSource = DS;
        gvDetail1.DataBind();
    }
    #endregion "End Fill User GridView"

    // courses OneText

    private void BlankLbl()
    {
        lblPercent.Text="";
        lblTotalPresent.Text = "";
        lblTotalAbsent.Text = "";
        lblTotalClass.Text = "";

    }
 
    protected void btnCoOneTextSubjectOneText_Click(object sender, EventArgs e)
    {

        BlankLbl();
        obj_Student.StudentId = StudentId;
        obj_Student.ClassId = Convert.ToInt32(Session["ClassId"]);
        obj_Student.CourseOneText = lblCoursesOneText.Text.Replace("you are registrated in Course ", "");
       
        obj_Student.CourseOneSubjectOneText = btnCoOneTextSubjectOneText.Text;
        DS = obj_Student.AttendenceCoursesOneSubjectOneText();

        foreach (DataRow row in DS.Tables[0].Rows)
        {
            if (row["Absent"].ToString() == "Present")
            {
            
                TotalPresent = TotalPresent + 1;
            }
            if (row["Absent"].ToString() == "Absent")
            {
                TotalAbsent = TotalAbsent + 1;
            }
        
        }
        gvDetail1.DataSource = DS;
        gvDetail1.DataBind();
        ButtonColor("CoOneTextSubOneText");

        lblTotalAbsent.Text = "Total Absent : " + "<b>" + TotalAbsent.ToString() + "</b>";
        lblTotalPresent.Text = " Total Present : " + "<b>" + TotalPresent.ToString() + "</b>";
        if (TotalAbsent > 0 || TotalPresent > 0)
        {
            lblPercent.Text = "Attendence : " + "<b>" + (((TotalPresent) * 100) / (TotalAbsent + TotalPresent)).ToString() + "% " + "</b>";
        }
        
        lblTotalClass.Text = "Total Class Till Now  : " + "<b>" + gvDetail1.Rows.Count.ToString() +"</b>";

    }

   
    protected void btnCoOneTextSubjectTwoText_Click(object sender, EventArgs e)
    {
        BlankLbl();
        obj_Student.StudentId = StudentId;
        obj_Student.ClassId = Convert.ToInt32(Session["ClassId"]);
        obj_Student.CourseOneText = lblCoursesOneText.Text.Replace("you are registrated in Course ", "");
        obj_Student.CourseOneSubjectTwoText = btnCoOneTextSubjectTwoText.Text;
        DS = obj_Student.AttendenceCoursesOneSubjectTwoText();

        foreach (DataRow row in DS.Tables[0].Rows)
        {
            if (row["Absent"].ToString() == "Present")
            {

                TotalPresent = TotalPresent + 1;
            }
            if (row["Absent"].ToString() == "Absent")
            {
                TotalAbsent = TotalAbsent + 1;
            }

        }
        gvDetail1.DataSource = DS;
        gvDetail1.DataBind();
        ButtonColor("CoOneTextSubTwoText");

        lblTotalAbsent.Text = "Total Absent : " + "<b>" + TotalAbsent.ToString() + "</b>";
        lblTotalPresent.Text = " Total Present : " + "<b>" + TotalPresent.ToString() + "</b>";
        if (TotalAbsent > 0 || TotalPresent > 0)
        {
            lblPercent.Text = "Attendence : " + "<b>" + (((TotalPresent) * 100) / (TotalAbsent + TotalPresent)).ToString() + "% " + "</b>";
        }

        lblTotalClass.Text = "Total Class Till Now  : " + "<b>" + gvDetail1.Rows.Count.ToString() + "</b>";

       
    }
    protected void btnCoOneTextSubjectThreeText_Click(object sender, EventArgs e)
    {
        BlankLbl();
        obj_Student.StudentId = StudentId;
        obj_Student.ClassId = Convert.ToInt32(Session["ClassId"]);
        obj_Student.CourseOneText = lblCoursesOneText.Text.Replace("you are registrated in Course ", "");
        obj_Student.CourseOneSubjectThreeText = btnCoOneTextSubjectThreeText.Text;
        DS = obj_Student.AttendenceCoursesOneSubjectThreeText();

        foreach (DataRow row in DS.Tables[0].Rows)
        {
            if (row["Absent"].ToString() == "Present")
            {

                TotalPresent = TotalPresent + 1;
            }
            if (row["Absent"].ToString() == "Absent")
            {
                TotalAbsent = TotalAbsent + 1;
            }

        }
        gvDetail1.DataSource = DS;
        gvDetail1.DataBind();
        ButtonColor("CoOneTextSubThreeText");

        lblTotalAbsent.Text = "Total Absent : " + "<b>" + TotalAbsent.ToString() + "</b>";
        lblTotalPresent.Text = " Total Present : " + "<b>" + TotalPresent.ToString() + "</b>";
        if (TotalAbsent > 0 || TotalPresent > 0)
        {
            lblPercent.Text = "Attendence : " + "<b>" + (((TotalPresent) * 100) / (TotalAbsent + TotalPresent)).ToString() + "% " + "</b>";
        }

        lblTotalClass.Text = "Total Class Till Now  : " + "<b>" + gvDetail1.Rows.Count.ToString() + "</b>";

        
    }
    protected void btnCoOneTextSubjectFourText_Click(object sender, EventArgs e)
    {
        BlankLbl();
        obj_Student.StudentId = StudentId;
        obj_Student.ClassId = Convert.ToInt32(Session["ClassId"]);
        obj_Student.CourseOneText = lblCoursesOneText.Text.Replace("you are registrated in Course ", "");
        obj_Student.CourseOneSubjectFourText = btnCoOneTextSubjectFourText.Text;
        DS = obj_Student.AttendenceCoursesOneSubjectFourText();

        foreach (DataRow row in DS.Tables[0].Rows)
        {
            if (row["Absent"].ToString() == "Present")
            {

                TotalPresent = TotalPresent + 1;
            }
            if (row["Absent"].ToString() == "Absent")
            {
                TotalAbsent = TotalAbsent + 1;
            }

        }
        gvDetail1.DataSource = DS;
        gvDetail1.DataBind();
        ButtonColor("CoOneTextSubFourText");

        lblTotalAbsent.Text = "Total Absent : " + "<b>" + TotalAbsent.ToString() + "</b>";
        lblTotalPresent.Text = " Total Present : " + "<b>" + TotalPresent.ToString() + "</b>";
        if (TotalAbsent > 0 || TotalPresent > 0)
        {
            lblPercent.Text = "Attendence : " + "<b>" + (((TotalPresent) * 100) / (TotalAbsent + TotalPresent)).ToString() + "% " + "</b>";
        }

        lblTotalClass.Text = "Total Class Till Now  : " + "<b>" + gvDetail1.Rows.Count.ToString() + "</b>";

       
    }

    // courses TwoText 

    protected void btnCoTwoTextSubjectOneText_Click(object sender, EventArgs e)
    {
        BlankLbl();
        obj_Student.StudentId = StudentId;
        obj_Student.ClassId = Convert.ToInt32(Session["ClassId"]);
        obj_Student.CourseTwoText = lblCoursesTwoText.Text.Replace("you are registrated in Course ", "");
        obj_Student.CourseTwoSubjectOneText = btnCoTwoTextSubjectOneText.Text;
        DS = obj_Student.AttendenceCoursesTwoSubjectOneText();

        foreach (DataRow row in DS.Tables[0].Rows)
        {
            if (row["Absent"].ToString() == "Present")
            {

                TotalPresent = TotalPresent + 1;
            }
            if (row["Absent"].ToString() == "Absent")
            {
                TotalAbsent = TotalAbsent + 1;
            }

        }
        gvDetail1.DataSource = DS;
        gvDetail1.DataBind();
        ButtonColor("CoTwoTextSubOneText");

        lblTotalAbsent.Text = "Total Absent : " + "<b>" + TotalAbsent.ToString() + "</b>";
        lblTotalPresent.Text = " Total Present : " + "<b>" + TotalPresent.ToString() + "</b>";
        if (TotalAbsent > 0 || TotalPresent > 0)
        {
            lblPercent.Text = "Attendence : " + "<b>" + (((TotalPresent) * 100) / (TotalAbsent + TotalPresent)).ToString() + "% " + "</b>";
        }

        lblTotalClass.Text = "Total Class Till Now  : " + "<b>" + gvDetail1.Rows.Count.ToString() + "</b>";

       
    }
    protected void btnCoTwoTextSubjectTwoText_Click(object sender, EventArgs e)
    {
        BlankLbl();
        obj_Student.StudentId = StudentId;
        obj_Student.ClassId = Convert.ToInt32(Session["ClassId"]);
        obj_Student.CourseTwoText = lblCoursesTwoText.Text.Replace("you are registrated in Course ", "");
        obj_Student.CourseTwoSubjectTwoText = btnCoOneTextSubjectTwoText.Text;
        DS = obj_Student.AttendenceCoursesTwoSubjectOneText();

        foreach (DataRow row in DS.Tables[0].Rows)
        {
            if (row["Absent"].ToString() == "Present")
            {

                TotalPresent = TotalPresent + 1;
            }
            if (row["Absent"].ToString() == "Absent")
            {
                TotalAbsent = TotalAbsent + 1;
            }

        }
        gvDetail1.DataSource = DS;
        gvDetail1.DataBind();
        ButtonColor("CoTwoTextSubTwoText");

        lblTotalAbsent.Text = "Total Absent : " + "<b>" + TotalAbsent.ToString() + "</b>";
        lblTotalPresent.Text = " Total Present : " + "<b>" + TotalPresent.ToString() + "</b>";
        if (TotalAbsent > 0 || TotalPresent > 0)
        {
            lblPercent.Text = "Attendence : " + "<b>" + (((TotalPresent) * 100) / (TotalAbsent + TotalPresent)).ToString() + "% " + "</b>";
        }

        lblTotalClass.Text = "Total Class Till Now  : " + "<b>" + gvDetail1.Rows.Count.ToString() + "</b>";

       
    }
    protected void btnCoTwoTextSubjectThreeText_Click(object sender, EventArgs e)
    {
        BlankLbl();
        obj_Student.StudentId = StudentId;
        obj_Student.ClassId = Convert.ToInt32(Session["ClassId"]);
        obj_Student.CourseTwoText = lblCoursesTwoText.Text.Replace("you are registrated in Course ", "");
        obj_Student.CourseTwoSubjectThreeText = btnCoTwoTextSubjectThreeText.Text;
        DS = obj_Student.AttendenceCoursesTwoSubjectOneText();

        foreach (DataRow row in DS.Tables[0].Rows)
        {
            if (row["Absent"].ToString() == "Present")
            {

                TotalPresent = TotalPresent + 1;
            }
            if (row["Absent"].ToString() == "Absent")
            {
                TotalAbsent = TotalAbsent + 1;
            }

        }
        gvDetail1.DataSource = DS;
        gvDetail1.DataBind();
        ButtonColor("CoTwoTextSubThreeText");

        lblTotalAbsent.Text = "Total Absent : " + "<b>" + TotalAbsent.ToString() + "</b>";
        lblTotalPresent.Text = " Total Present : " + "<b>" + TotalPresent.ToString() + "</b>";
        if (TotalAbsent > 0 || TotalPresent > 0)
        {
            lblPercent.Text = "Attendence : " + "<b>" + (((TotalPresent) * 100) / (TotalAbsent + TotalPresent)).ToString() + "% " + "</b>";
        }

        lblTotalClass.Text = "Total Class Till Now  : " + "<b>" + gvDetail1.Rows.Count.ToString() + "</b>";

       
    }
    protected void btnCoTwoTextSubjectFourText_Click(object sender, EventArgs e)
    {
        BlankLbl();
        obj_Student.StudentId = StudentId;
        obj_Student.ClassId = Convert.ToInt32(Session["ClassId"]);
        obj_Student.CourseTwoText = lblCoursesTwoText.Text.Replace("you are registrated in Course ", "");
        obj_Student.CourseTwoSubjectFourText = btnCoTwoTextSubjectFourText.Text;
        DS = obj_Student.AttendenceCoursesTwoSubjectFourText();

        foreach (DataRow row in DS.Tables[0].Rows)
        {
            if (row["Absent"].ToString() == "Present")
            {

                TotalPresent = TotalPresent + 1;
            }
            if (row["Absent"].ToString() == "Absent")
            {
                TotalAbsent = TotalAbsent + 1;
            }

        }
        gvDetail1.DataSource = DS;
        gvDetail1.DataBind();
        ButtonColor("CoTwoTextSubFourText");

        lblTotalAbsent.Text = "Total Absent : " + "<b>" + TotalAbsent.ToString() + "</b>";
        lblTotalPresent.Text = " Total Present : " + "<b>" + TotalPresent.ToString() + "</b>";
        if (TotalAbsent > 0 || TotalPresent > 0)
        {
            lblPercent.Text = "Attendence : " + "<b>" + (((TotalPresent) * 100) / (TotalAbsent + TotalPresent)).ToString() + "% " + "</b>";
        }

        lblTotalClass.Text = "Total Class Till Now  : " + "<b>" + gvDetail1.Rows.Count.ToString() + "</b>";

       
    }

    // courses ThreeText
   protected void btnCoThreeTextSubjectOneText_Click(object sender, EventArgs e)
    {
        BlankLbl();
        obj_Student.StudentId = StudentId;
        obj_Student.ClassId = Convert.ToInt32(Session["ClassId"]);
        obj_Student.CourseThreeText = lblCoursesThreeText.Text.Replace("you are registrated in Course ", "");
        obj_Student.CourseThreeSubjectOneText = btnCoThreeTextSubjectOneText.Text;
        DS = obj_Student.AttendenceCoursesThreeSubjectOneText();

        foreach (DataRow row in DS.Tables[0].Rows)
        {
            if (row["Absent"].ToString() == "Present")
            {

                TotalPresent = TotalPresent + 1;
            }
            if (row["Absent"].ToString() == "Absent")
            {
                TotalAbsent = TotalAbsent + 1;
            }

        }
        gvDetail1.DataSource = DS;
        gvDetail1.DataBind();
        ButtonColor("CoThreeTextSubOneText");

        lblTotalAbsent.Text = "Total Absent : " + "<b>" + TotalAbsent.ToString() + "</b>";
        lblTotalPresent.Text = " Total Present : " + "<b>" + TotalPresent.ToString() + "</b>";
        if (TotalAbsent > 0 || TotalPresent > 0)
        {
            lblPercent.Text = "Attendence : " + "<b>" + (((TotalPresent) * 100) / (TotalAbsent + TotalPresent)).ToString() + "% " + "</b>";
        }

        lblTotalClass.Text = "Total Class Till Now  : " + "<b>" + gvDetail1.Rows.Count.ToString() + "</b>";

        
    }
    protected void btnCoThreeTextSubjectTwoText_Click(object sender, EventArgs e)
    {
        BlankLbl();
        obj_Student.StudentId = StudentId;
        obj_Student.ClassId = Convert.ToInt32(Session["ClassId"]);
        obj_Student.CourseThreeText = lblCoursesThreeText.Text.Replace("you are registrated in Course ", "");
        obj_Student.CourseThreeSubjectTwoText = btnCoThreeTextSubjectTwoText.Text;
        DS = obj_Student.AttendenceCoursesThreeSubjectTwoText();

        foreach (DataRow row in DS.Tables[0].Rows)
        {
            if (row["Absent"].ToString() == "Present")
            {

                TotalPresent = TotalPresent + 1;
            }
            if (row["Absent"].ToString() == "Absent")
            {
                TotalAbsent = TotalAbsent + 1;
            }

        }
        gvDetail1.DataSource = DS;
        gvDetail1.DataBind();
        ButtonColor("CoThreeTextSubTwoText");

        lblTotalAbsent.Text = "Total Absent : " + "<b>" + TotalAbsent.ToString() + "</b>";
        lblTotalPresent.Text = " Total Present : " + "<b>" + TotalPresent.ToString() + "</b>";
        if (TotalAbsent > 0 || TotalPresent > 0)
        {
            lblPercent.Text = "Attendence : " + "<b>" + (((TotalPresent) * 100) / (TotalAbsent + TotalPresent)).ToString() + "% " + "</b>";
        }

        lblTotalClass.Text = "Total Class Till Now  : " + "<b>" + gvDetail1.Rows.Count.ToString() + "</b>";

        
    }
    protected void btnCoThreeTextSubjectThreeText_Click(object sender, EventArgs e)
    {
        BlankLbl();
        obj_Student.StudentId = StudentId;
        obj_Student.ClassId = Convert.ToInt32(Session["ClassId"]);
        obj_Student.CourseThreeText = lblCoursesThreeText.Text.Replace("you are registrated in Course ", "");
        obj_Student.CourseThreeSubjectThreeText = btnCoThreeTextSubjectThreeText.Text;
        DS = obj_Student.AttendenceCoursesThreeSubjectThreeText();

        foreach (DataRow row in DS.Tables[0].Rows)
        {
            if (row["Absent"].ToString() == "Present")
            {

                TotalPresent = TotalPresent + 1;
            }
            if (row["Absent"].ToString() == "Absent")
            {
                TotalAbsent = TotalAbsent + 1;
            }

        }
        gvDetail1.DataSource = DS;
        gvDetail1.DataBind();
        ButtonColor("CoThreeTextSubThreeText");
        lblTotalAbsent.Text = "Total Absent : " + "<b>" + TotalAbsent.ToString() + "</b>";
        lblTotalPresent.Text = " Total Present : " + "<b>" + TotalPresent.ToString() + "</b>";
        if (TotalAbsent > 0 || TotalPresent > 0)
        {
            lblPercent.Text = "Attendence : " + "<b>" + (((TotalPresent) * 100) / (TotalAbsent + TotalPresent)).ToString() + "% " + "</b>";
        }

        lblTotalClass.Text = "Total Class Till Now  : " + "<b>" + gvDetail1.Rows.Count.ToString() + "</b>";


       

       

    }
    protected void btnCoThreeTextSubjectFourText_Click(object sender, EventArgs e)
    {
        BlankLbl();
        obj_Student.StudentId = StudentId;
        obj_Student.ClassId = Convert.ToInt32(Session["ClassId"]);
        obj_Student.CourseThreeText = lblCoursesThreeText.Text.Replace("you are registrated in Course ", "");
        obj_Student.CourseThreeSubjectFourText = btnCoThreeTextSubjectFourText.Text;
        DS = obj_Student.AttendenceCoursesThreeSubjectFourText();

        foreach (DataRow row in DS.Tables[0].Rows)
        {
            if (row["Absent"].ToString() == "Present")
            {

                TotalPresent = TotalPresent + 1;
            }
            if (row["Absent"].ToString() == "Absent")
            {
                TotalAbsent = TotalAbsent + 1;
            }

        }
        gvDetail1.DataSource = DS;
        gvDetail1.DataBind();
        ButtonColor("CoThreeTextSubFourText");

        lblTotalAbsent.Text = "Total Absent : " + "<b>" + TotalAbsent.ToString() + "</b>";
        lblTotalPresent.Text = " Total Present : " + "<b>" + TotalPresent.ToString() + "</b>";
        if (TotalAbsent > 0 || TotalPresent > 0)
        {
            lblPercent.Text = "Attendence : " + "<b>" + (((TotalPresent) * 100) / (TotalAbsent + TotalPresent)).ToString() + "% " + "</b>";
        }

        lblTotalClass.Text = "Total Class Till Now  : " + "<b>" + gvDetail1.Rows.Count.ToString() + "</b>";

        
    }
    // courses FourText
    protected void btnCoFourTextSubjectOneText_Click(object sender, EventArgs e)
    {
        BlankLbl();
        obj_Student.StudentId = StudentId;
        obj_Student.ClassId = Convert.ToInt32(Session["ClassId"]);
        obj_Student.CourseFourText = lblCoursesFourText.Text.Replace("you are registrated in Course ", "");
        obj_Student.CourseFourSubjectOneText = btnCoFourTextSubjectOneText.Text;
        DS = obj_Student.AttendenceCoursesFourSubjectOneText();

        foreach (DataRow row in DS.Tables[0].Rows)
        {
            if (row["Absent"].ToString() == "Present")
            {

                TotalPresent = TotalPresent + 1;
            }
            if (row["Absent"].ToString() == "Absent")
            {
                TotalAbsent = TotalAbsent + 1;
            }

        }
        gvDetail1.DataSource = DS;
        gvDetail1.DataBind();
        ButtonColor("CoFourTextSubOneText");
        lblTotalAbsent.Text = "Total Absent : " + "<b>" + TotalAbsent.ToString() + "</b>";
        lblTotalPresent.Text = " Total Present : " + "<b>" + TotalPresent.ToString() + "</b>";
        if (TotalAbsent > 0 || TotalPresent > 0)
        {
            lblPercent.Text = "Attendence : " + "<b>" + (((TotalPresent) * 100) / (TotalAbsent + TotalPresent)).ToString() + "% " + "</b>";
        }

        lblTotalClass.Text = "Total Class Till Now  : " + "<b>" + gvDetail1.Rows.Count.ToString() + "</b>";

      
    }
    protected void btnCoFourTextSubjectTwoText_Click(object sender, EventArgs e)
    {
        BlankLbl();
        obj_Student.StudentId = StudentId;
        obj_Student.ClassId = Convert.ToInt32(Session["ClassId"]);
        obj_Student.CourseFourText = lblCoursesFourText.Text.Replace("you are registrated in Course ", "");
        obj_Student.CourseFourSubjectTwoText = btnCoFourTextSubjectTwoText.Text;
        DS = obj_Student.AttendenceCoursesFourSubjectTwoText();

        foreach (DataRow row in DS.Tables[0].Rows)
        {
            if (row["Absent"].ToString() == "Present")
            {

                TotalPresent = TotalPresent + 1;
            }
            if (row["Absent"].ToString() == "Absent")
            {
                TotalAbsent = TotalAbsent + 1;
            }

        }
        gvDetail1.DataSource = DS;
        gvDetail1.DataBind();
        ButtonColor("CoFourTextSubTwoText");

        lblTotalAbsent.Text = "Total Absent : " + "<b>" + TotalAbsent.ToString() + "</b>";
        lblTotalPresent.Text = " Total Present : " + "<b>" + TotalPresent.ToString() + "</b>";
        if (TotalAbsent > 0 || TotalPresent > 0)
        {
            lblPercent.Text = "Attendence : " + "<b>" + (((TotalPresent) * 100) / (TotalAbsent + TotalPresent)).ToString() + "% " + "</b>";
        }

        lblTotalClass.Text = "Total Class Till Now  : " + "<b>" + gvDetail1.Rows.Count.ToString() + "</b>";

       
    }
    protected void btnCoFourTextSubjectThreeText_Click(object sender, EventArgs e)
    {
        BlankLbl();
        obj_Student.StudentId = StudentId;
        obj_Student.ClassId = Convert.ToInt32(Session["ClassId"]);
        obj_Student.CourseFourText = lblCoursesFourText.Text.Replace("you are registrated in Course ", "");
        obj_Student.CourseFourSubjectThreeText = btnCoFourTextSubjectThreeText.Text;
        DS = obj_Student.AttendenceCoursesThreeSubjectThreeText();

        foreach (DataRow row in DS.Tables[0].Rows)
        {
            if (row["Absent"].ToString() == "Present")
            {

                TotalPresent = TotalPresent + 1;
            }
            if (row["Absent"].ToString() == "Absent")
            {
                TotalAbsent = TotalAbsent + 1;
            }

        }
        gvDetail1.DataSource = DS;
        gvDetail1.DataBind();
        ButtonColor("CoFourTextSubThreeText");

        lblTotalAbsent.Text = "Total Absent : " + "<b>" + TotalAbsent.ToString() + "</b>";
        lblTotalPresent.Text = " Total Present : " + "<b>" + TotalPresent.ToString() + "</b>";
        if (TotalAbsent > 0 || TotalPresent > 0)
        {
            lblPercent.Text = "Attendence : " + "<b>" + (((TotalPresent) * 100) / (TotalAbsent + TotalPresent)).ToString() + "% " + "</b>";
        }

        lblTotalClass.Text = "Total Class Till Now  : " + "<b>" + gvDetail1.Rows.Count.ToString() + "</b>";

      
    }
    protected void btnCoFourTextSubjectFourText_Click(object sender, EventArgs e)
    {
        BlankLbl();
        obj_Student.StudentId = StudentId;
        obj_Student.ClassId = Convert.ToInt32(Session["ClassId"]);
        obj_Student.CourseFourText = lblCoursesFourText.Text.Replace("you are registrated in Course ", "");
        obj_Student.CourseFourSubjectOneText = btnCoFourTextSubjectOneText.Text;
        DS = obj_Student.AttendenceCoursesThreeSubjectFourText();

        foreach (DataRow row in DS.Tables[0].Rows)
        {
            if (row["Absent"].ToString() == "Present")
            {

                TotalPresent = TotalPresent + 1;
            }
            if (row["Absent"].ToString() == "Absent")
            {
                TotalAbsent = TotalAbsent + 1;
            }

        }
        gvDetail1.DataSource = DS;
        gvDetail1.DataBind();
        ButtonColor("CoFourTextSubFourText");

        lblTotalAbsent.Text = "Total Absent : " + "<b>" + TotalAbsent.ToString() + "</b>";
        lblTotalPresent.Text = " Total Present : " + "<b>" + TotalPresent.ToString() + "</b>";
        if (TotalAbsent > 0 || TotalPresent > 0)
        {
            lblPercent.Text = "Attendence : " + "<b>" + (((TotalPresent) * 100) / (TotalAbsent + TotalPresent)).ToString() + "% " + "</b>";
        }

        lblTotalClass.Text = "Total Class Till Now  : " + "<b>" + gvDetail1.Rows.Count.ToString() + "</b>";

        
    }
    protected void ButtonColor(string  Color)
    {
        if (Color == "CoOneTextSubOneText")
        {
            btnCoOneTextSubjectOneText.BackColor = System.Drawing.Color.Orange;
            btnCoOneTextSubjectOneText.ForeColor = System.Drawing.Color.White;

            btnCoOneTextSubjectTwoText.BackColor = System.Drawing.Color.Gray;
            btnCoOneTextSubjectTwoText.ForeColor = System.Drawing.Color.White;
            btnCoOneTextSubjectThreeText.BackColor = System.Drawing.Color.Gray;
            btnCoOneTextSubjectThreeText.ForeColor = System.Drawing.Color.White;
            btnCoOneTextSubjectFourText.BackColor = System.Drawing.Color.Gray;
            btnCoOneTextSubjectFourText.ForeColor = System.Drawing.Color.White;



            btnCoTwoTextSubjectOneText.BackColor = System.Drawing.Color.Gray;
            btnCoTwoTextSubjectOneText.ForeColor = System.Drawing.Color.White;
            btnCoTwoTextSubjectTwoText.BackColor = System.Drawing.Color.Gray;
            btnCoTwoTextSubjectTwoText.ForeColor = System.Drawing.Color.White;
            btnCoTwoTextSubjectThreeText.BackColor = System.Drawing.Color.Gray;
            btnCoTwoTextSubjectThreeText.ForeColor = System.Drawing.Color.White;
            btnCoTwoTextSubjectFourText.BackColor = System.Drawing.Color.Gray;
            btnCoTwoTextSubjectFourText.ForeColor = System.Drawing.Color.White;

            btnCoThreeTextSubjectOneText.BackColor = System.Drawing.Color.Gray;
            btnCoThreeTextSubjectOneText.ForeColor = System.Drawing.Color.White;
            btnCoThreeTextSubjectTwoText.BackColor = System.Drawing.Color.Gray;
            btnCoThreeTextSubjectTwoText.ForeColor = System.Drawing.Color.White;
            btnCoThreeTextSubjectThreeText.BackColor = System.Drawing.Color.Gray;
            btnCoThreeTextSubjectThreeText.ForeColor = System.Drawing.Color.White;
            btnCoThreeTextSubjectFourText.BackColor = System.Drawing.Color.Gray;
            btnCoThreeTextSubjectFourText.ForeColor = System.Drawing.Color.White;

            btnCoFourTextSubjectOneText.BackColor = System.Drawing.Color.Gray;
            btnCoFourTextSubjectOneText.ForeColor = System.Drawing.Color.White;
            btnCoFourTextSubjectTwoText.BackColor = System.Drawing.Color.Gray;
            btnCoFourTextSubjectTwoText.ForeColor = System.Drawing.Color.White;
            btnCoFourTextSubjectThreeText.BackColor = System.Drawing.Color.Gray;
            btnCoFourTextSubjectThreeText.ForeColor = System.Drawing.Color.White;
            btnCoFourTextSubjectFourText.BackColor = System.Drawing.Color.Gray;
            btnCoFourTextSubjectFourText.ForeColor = System.Drawing.Color.White;
        }
        else if (Color == "CoOneTextSubTwoText")
        {
            btnCoOneTextSubjectTwoText.BackColor = System.Drawing.Color.Orange;
            btnCoOneTextSubjectTwoText.ForeColor = System.Drawing.Color.White;
            btnCoOneTextSubjectOneText.BackColor = System.Drawing.Color.Gray;
            btnCoOneTextSubjectOneText.ForeColor = System.Drawing.Color.White;
            btnCoOneTextSubjectThreeText.BackColor = System.Drawing.Color.Gray;
            btnCoOneTextSubjectThreeText.ForeColor = System.Drawing.Color.White;
            btnCoOneTextSubjectFourText.BackColor = System.Drawing.Color.Gray;
            btnCoOneTextSubjectFourText.ForeColor = System.Drawing.Color.White;


            btnCoTwoTextSubjectOneText.BackColor = System.Drawing.Color.Gray;
            btnCoTwoTextSubjectOneText.ForeColor = System.Drawing.Color.White;
            btnCoTwoTextSubjectTwoText.BackColor = System.Drawing.Color.Gray;
            btnCoTwoTextSubjectTwoText.ForeColor = System.Drawing.Color.White;
            btnCoTwoTextSubjectThreeText.BackColor = System.Drawing.Color.Gray;
            btnCoTwoTextSubjectThreeText.ForeColor = System.Drawing.Color.White;
            btnCoTwoTextSubjectFourText.BackColor = System.Drawing.Color.Gray;
            btnCoTwoTextSubjectFourText.ForeColor = System.Drawing.Color.White;

            btnCoThreeTextSubjectOneText.BackColor = System.Drawing.Color.Gray;
            btnCoThreeTextSubjectOneText.ForeColor = System.Drawing.Color.White;
            btnCoThreeTextSubjectTwoText.BackColor = System.Drawing.Color.Gray;
            btnCoThreeTextSubjectTwoText.ForeColor = System.Drawing.Color.White;
            btnCoThreeTextSubjectThreeText.BackColor = System.Drawing.Color.Gray;
            btnCoThreeTextSubjectThreeText.ForeColor = System.Drawing.Color.White;
            btnCoThreeTextSubjectFourText.BackColor = System.Drawing.Color.Gray;
            btnCoThreeTextSubjectFourText.ForeColor = System.Drawing.Color.White;

            btnCoFourTextSubjectOneText.BackColor = System.Drawing.Color.Gray;
            btnCoFourTextSubjectOneText.ForeColor = System.Drawing.Color.White;
            btnCoFourTextSubjectTwoText.BackColor = System.Drawing.Color.Gray;
            btnCoFourTextSubjectTwoText.ForeColor = System.Drawing.Color.White;
            btnCoFourTextSubjectThreeText.BackColor = System.Drawing.Color.Gray;
            btnCoFourTextSubjectThreeText.ForeColor = System.Drawing.Color.White;
            btnCoFourTextSubjectFourText.BackColor = System.Drawing.Color.Gray;
            btnCoFourTextSubjectFourText.ForeColor = System.Drawing.Color.White;
        }
        else if (Color == "CoOneTextSubThreeText")
        {
            btnCoOneTextSubjectTwoText.BackColor = System.Drawing.Color.Gray;
            btnCoOneTextSubjectTwoText.ForeColor = System.Drawing.Color.White;
            btnCoOneTextSubjectOneText.BackColor = System.Drawing.Color.Gray;
            btnCoOneTextSubjectOneText.ForeColor = System.Drawing.Color.White;
            btnCoOneTextSubjectThreeText.BackColor = System.Drawing.Color.Orange;
            btnCoOneTextSubjectThreeText.ForeColor = System.Drawing.Color.White;
            btnCoOneTextSubjectFourText.BackColor = System.Drawing.Color.Gray;
            btnCoOneTextSubjectFourText.ForeColor = System.Drawing.Color.White;


            btnCoTwoTextSubjectOneText.BackColor = System.Drawing.Color.Gray;
            btnCoTwoTextSubjectOneText.ForeColor = System.Drawing.Color.White;
            btnCoTwoTextSubjectTwoText.BackColor = System.Drawing.Color.Gray;
            btnCoTwoTextSubjectTwoText.ForeColor = System.Drawing.Color.White;
            btnCoTwoTextSubjectThreeText.BackColor = System.Drawing.Color.Gray;
            btnCoTwoTextSubjectThreeText.ForeColor = System.Drawing.Color.White;
            btnCoTwoTextSubjectFourText.BackColor = System.Drawing.Color.Gray;
            btnCoTwoTextSubjectFourText.ForeColor = System.Drawing.Color.White;

            btnCoThreeTextSubjectOneText.BackColor = System.Drawing.Color.Gray;
            btnCoThreeTextSubjectOneText.ForeColor = System.Drawing.Color.White;
            btnCoThreeTextSubjectTwoText.BackColor = System.Drawing.Color.Gray;
            btnCoThreeTextSubjectTwoText.ForeColor = System.Drawing.Color.White;
            btnCoThreeTextSubjectThreeText.BackColor = System.Drawing.Color.Gray;
            btnCoThreeTextSubjectThreeText.ForeColor = System.Drawing.Color.White;
            btnCoThreeTextSubjectFourText.BackColor = System.Drawing.Color.Gray;
            btnCoThreeTextSubjectFourText.ForeColor = System.Drawing.Color.White;

            btnCoFourTextSubjectOneText.BackColor = System.Drawing.Color.Gray;
            btnCoFourTextSubjectOneText.ForeColor = System.Drawing.Color.White;
            btnCoFourTextSubjectTwoText.BackColor = System.Drawing.Color.Gray;
            btnCoFourTextSubjectTwoText.ForeColor = System.Drawing.Color.White;
            btnCoFourTextSubjectThreeText.BackColor = System.Drawing.Color.Gray;
            btnCoFourTextSubjectThreeText.ForeColor = System.Drawing.Color.White;
            btnCoFourTextSubjectFourText.BackColor = System.Drawing.Color.Gray;
            btnCoFourTextSubjectFourText.ForeColor = System.Drawing.Color.White;
        }
        else if (Color == "CoOneTextSubFourText")
        {
            btnCoOneTextSubjectTwoText.BackColor = System.Drawing.Color.Gray;
            btnCoOneTextSubjectTwoText.ForeColor = System.Drawing.Color.White;
            btnCoOneTextSubjectOneText.BackColor = System.Drawing.Color.Gray;
            btnCoOneTextSubjectOneText.ForeColor = System.Drawing.Color.White;
            btnCoOneTextSubjectThreeText.BackColor = System.Drawing.Color.Gray;
            btnCoOneTextSubjectThreeText.ForeColor = System.Drawing.Color.White;
            btnCoOneTextSubjectFourText.BackColor = System.Drawing.Color.Orange;
            btnCoOneTextSubjectFourText.ForeColor = System.Drawing.Color.White;


            btnCoTwoTextSubjectOneText.BackColor = System.Drawing.Color.Gray;
            btnCoTwoTextSubjectOneText.ForeColor = System.Drawing.Color.White;
            btnCoTwoTextSubjectTwoText.BackColor = System.Drawing.Color.Gray;
            btnCoTwoTextSubjectTwoText.ForeColor = System.Drawing.Color.White;
            btnCoTwoTextSubjectThreeText.BackColor = System.Drawing.Color.Gray;
            btnCoTwoTextSubjectThreeText.ForeColor = System.Drawing.Color.White;
            btnCoTwoTextSubjectFourText.BackColor = System.Drawing.Color.Gray;
            btnCoTwoTextSubjectFourText.ForeColor = System.Drawing.Color.White;

            btnCoThreeTextSubjectOneText.BackColor = System.Drawing.Color.Gray;
            btnCoThreeTextSubjectOneText.ForeColor = System.Drawing.Color.White;
            btnCoThreeTextSubjectTwoText.BackColor = System.Drawing.Color.Gray;
            btnCoThreeTextSubjectTwoText.ForeColor = System.Drawing.Color.White;
            btnCoThreeTextSubjectThreeText.BackColor = System.Drawing.Color.Gray;
            btnCoThreeTextSubjectThreeText.ForeColor = System.Drawing.Color.White;
            btnCoThreeTextSubjectFourText.BackColor = System.Drawing.Color.Gray;
            btnCoThreeTextSubjectFourText.ForeColor = System.Drawing.Color.White;

            btnCoFourTextSubjectOneText.BackColor = System.Drawing.Color.Gray;
            btnCoFourTextSubjectOneText.ForeColor = System.Drawing.Color.White;
            btnCoFourTextSubjectTwoText.BackColor = System.Drawing.Color.Gray;
            btnCoFourTextSubjectTwoText.ForeColor = System.Drawing.Color.White;
            btnCoFourTextSubjectThreeText.BackColor = System.Drawing.Color.Gray;
            btnCoFourTextSubjectThreeText.ForeColor = System.Drawing.Color.White;
            btnCoFourTextSubjectFourText.BackColor = System.Drawing.Color.Gray;
            btnCoFourTextSubjectFourText.ForeColor = System.Drawing.Color.White;
        }
        else if (Color == "CoTwoTextSubOneText")
        {
            btnCoOneTextSubjectTwoText.BackColor = System.Drawing.Color.Gray;
            btnCoOneTextSubjectTwoText.ForeColor = System.Drawing.Color.White;
            btnCoOneTextSubjectOneText.BackColor = System.Drawing.Color.Gray;
            btnCoOneTextSubjectOneText.ForeColor = System.Drawing.Color.White;
            btnCoOneTextSubjectThreeText.BackColor = System.Drawing.Color.Gray;
            btnCoOneTextSubjectThreeText.ForeColor = System.Drawing.Color.White;
            btnCoOneTextSubjectFourText.BackColor = System.Drawing.Color.Gray;
            btnCoOneTextSubjectFourText.ForeColor = System.Drawing.Color.White;


            btnCoTwoTextSubjectOneText.BackColor = System.Drawing.Color.Orange;
            btnCoTwoTextSubjectOneText.ForeColor = System.Drawing.Color.White;
            btnCoTwoTextSubjectTwoText.BackColor = System.Drawing.Color.Gray;
            btnCoTwoTextSubjectTwoText.ForeColor = System.Drawing.Color.White;
            btnCoTwoTextSubjectThreeText.BackColor = System.Drawing.Color.Gray;
            btnCoTwoTextSubjectThreeText.ForeColor = System.Drawing.Color.White;
            btnCoTwoTextSubjectFourText.BackColor = System.Drawing.Color.Gray;
            btnCoTwoTextSubjectFourText.ForeColor = System.Drawing.Color.White;

            btnCoThreeTextSubjectOneText.BackColor = System.Drawing.Color.Gray;
            btnCoThreeTextSubjectOneText.ForeColor = System.Drawing.Color.White;
            btnCoThreeTextSubjectTwoText.BackColor = System.Drawing.Color.Gray;
            btnCoThreeTextSubjectTwoText.ForeColor = System.Drawing.Color.White;
            btnCoThreeTextSubjectThreeText.BackColor = System.Drawing.Color.Gray;
            btnCoThreeTextSubjectThreeText.ForeColor = System.Drawing.Color.White;
            btnCoThreeTextSubjectFourText.BackColor = System.Drawing.Color.Gray;
            btnCoThreeTextSubjectFourText.ForeColor = System.Drawing.Color.White;

            btnCoFourTextSubjectOneText.BackColor = System.Drawing.Color.Gray;
            btnCoFourTextSubjectOneText.ForeColor = System.Drawing.Color.White;
            btnCoFourTextSubjectTwoText.BackColor = System.Drawing.Color.Gray;
            btnCoFourTextSubjectTwoText.ForeColor = System.Drawing.Color.White;
            btnCoFourTextSubjectThreeText.BackColor = System.Drawing.Color.Gray;
            btnCoFourTextSubjectThreeText.ForeColor = System.Drawing.Color.White;
            btnCoFourTextSubjectFourText.BackColor = System.Drawing.Color.Gray;
            btnCoFourTextSubjectFourText.ForeColor = System.Drawing.Color.White;
        }
        else if (Color == "CoTwoTextSubTwoText")
        {
            btnCoOneTextSubjectTwoText.BackColor = System.Drawing.Color.Gray;
            btnCoOneTextSubjectTwoText.ForeColor = System.Drawing.Color.White;
            btnCoOneTextSubjectOneText.BackColor = System.Drawing.Color.Gray;
            btnCoOneTextSubjectOneText.ForeColor = System.Drawing.Color.White;
            btnCoOneTextSubjectThreeText.BackColor = System.Drawing.Color.Gray;
            btnCoOneTextSubjectThreeText.ForeColor = System.Drawing.Color.White;
            btnCoOneTextSubjectFourText.BackColor = System.Drawing.Color.Gray;
            btnCoOneTextSubjectFourText.ForeColor = System.Drawing.Color.White;


            btnCoTwoTextSubjectOneText.BackColor = System.Drawing.Color.Gray;
            btnCoTwoTextSubjectOneText.ForeColor = System.Drawing.Color.White;
            btnCoTwoTextSubjectTwoText.BackColor = System.Drawing.Color.Orange;
            btnCoTwoTextSubjectTwoText.ForeColor = System.Drawing.Color.White;
            btnCoTwoTextSubjectThreeText.BackColor = System.Drawing.Color.Gray;
            btnCoTwoTextSubjectThreeText.ForeColor = System.Drawing.Color.White;
            btnCoTwoTextSubjectFourText.BackColor = System.Drawing.Color.Gray;
            btnCoTwoTextSubjectFourText.ForeColor = System.Drawing.Color.White;

            btnCoThreeTextSubjectOneText.BackColor = System.Drawing.Color.Gray;
            btnCoThreeTextSubjectOneText.ForeColor = System.Drawing.Color.White;
            btnCoThreeTextSubjectTwoText.BackColor = System.Drawing.Color.Gray;
            btnCoThreeTextSubjectTwoText.ForeColor = System.Drawing.Color.White;
            btnCoThreeTextSubjectThreeText.BackColor = System.Drawing.Color.Gray;
            btnCoThreeTextSubjectThreeText.ForeColor = System.Drawing.Color.White;
            btnCoThreeTextSubjectFourText.BackColor = System.Drawing.Color.Gray;
            btnCoThreeTextSubjectFourText.ForeColor = System.Drawing.Color.White;

            btnCoFourTextSubjectOneText.BackColor = System.Drawing.Color.Gray;
            btnCoFourTextSubjectOneText.ForeColor = System.Drawing.Color.White;
            btnCoFourTextSubjectTwoText.BackColor = System.Drawing.Color.Gray;
            btnCoFourTextSubjectTwoText.ForeColor = System.Drawing.Color.White;
            btnCoFourTextSubjectThreeText.BackColor = System.Drawing.Color.Gray;
            btnCoFourTextSubjectThreeText.ForeColor = System.Drawing.Color.White;
            btnCoFourTextSubjectFourText.BackColor = System.Drawing.Color.Gray;
            btnCoFourTextSubjectFourText.ForeColor = System.Drawing.Color.White;
        }
        else if (Color == "CoTwoTextSubThreeText")
        {
            btnCoOneTextSubjectTwoText.BackColor = System.Drawing.Color.Gray;
            btnCoOneTextSubjectTwoText.ForeColor = System.Drawing.Color.White;
            btnCoOneTextSubjectOneText.BackColor = System.Drawing.Color.Gray;
            btnCoOneTextSubjectOneText.ForeColor = System.Drawing.Color.White;
            btnCoOneTextSubjectThreeText.BackColor = System.Drawing.Color.Gray;
            btnCoOneTextSubjectThreeText.ForeColor = System.Drawing.Color.White;
            btnCoOneTextSubjectFourText.BackColor = System.Drawing.Color.Gray;
            btnCoOneTextSubjectFourText.ForeColor = System.Drawing.Color.White;


            btnCoTwoTextSubjectOneText.BackColor = System.Drawing.Color.Gray;
            btnCoTwoTextSubjectOneText.ForeColor = System.Drawing.Color.White;
            btnCoTwoTextSubjectTwoText.BackColor = System.Drawing.Color.Gray;
            btnCoTwoTextSubjectTwoText.ForeColor = System.Drawing.Color.White;
            btnCoTwoTextSubjectThreeText.BackColor = System.Drawing.Color.Orange;
            btnCoTwoTextSubjectThreeText.ForeColor = System.Drawing.Color.White;
            btnCoTwoTextSubjectFourText.BackColor = System.Drawing.Color.Gray;
            btnCoTwoTextSubjectFourText.ForeColor = System.Drawing.Color.White;

            btnCoThreeTextSubjectOneText.BackColor = System.Drawing.Color.Gray;
            btnCoThreeTextSubjectOneText.ForeColor = System.Drawing.Color.White;
            btnCoThreeTextSubjectTwoText.BackColor = System.Drawing.Color.Gray;
            btnCoThreeTextSubjectTwoText.ForeColor = System.Drawing.Color.White;
            btnCoThreeTextSubjectThreeText.BackColor = System.Drawing.Color.Gray;
            btnCoThreeTextSubjectThreeText.ForeColor = System.Drawing.Color.White;
            btnCoThreeTextSubjectFourText.BackColor = System.Drawing.Color.Gray;
            btnCoThreeTextSubjectFourText.ForeColor = System.Drawing.Color.White;

            btnCoFourTextSubjectOneText.BackColor = System.Drawing.Color.Gray;
            btnCoFourTextSubjectOneText.ForeColor = System.Drawing.Color.White;
            btnCoFourTextSubjectTwoText.BackColor = System.Drawing.Color.Gray;
            btnCoFourTextSubjectTwoText.ForeColor = System.Drawing.Color.White;
            btnCoFourTextSubjectThreeText.BackColor = System.Drawing.Color.Gray;
            btnCoFourTextSubjectThreeText.ForeColor = System.Drawing.Color.White;
            btnCoFourTextSubjectFourText.BackColor = System.Drawing.Color.Gray;
            btnCoFourTextSubjectFourText.ForeColor = System.Drawing.Color.White;
        }
        else if (Color == "CoTwoTextSubFourText")
        {
            btnCoOneTextSubjectTwoText.BackColor = System.Drawing.Color.Gray;
            btnCoOneTextSubjectTwoText.ForeColor = System.Drawing.Color.White;
            btnCoOneTextSubjectOneText.BackColor = System.Drawing.Color.Gray;
            btnCoOneTextSubjectOneText.ForeColor = System.Drawing.Color.White;
            btnCoOneTextSubjectThreeText.BackColor = System.Drawing.Color.Gray;
            btnCoOneTextSubjectThreeText.ForeColor = System.Drawing.Color.White;
            btnCoOneTextSubjectFourText.BackColor = System.Drawing.Color.Gray;
            btnCoOneTextSubjectFourText.ForeColor = System.Drawing.Color.White;


            btnCoTwoTextSubjectOneText.BackColor = System.Drawing.Color.Gray;
            btnCoTwoTextSubjectOneText.ForeColor = System.Drawing.Color.White;
            btnCoTwoTextSubjectTwoText.BackColor = System.Drawing.Color.Gray;
            btnCoTwoTextSubjectTwoText.ForeColor = System.Drawing.Color.White;
            btnCoTwoTextSubjectThreeText.BackColor = System.Drawing.Color.Gray;
            btnCoTwoTextSubjectThreeText.ForeColor = System.Drawing.Color.White;
            btnCoTwoTextSubjectFourText.BackColor = System.Drawing.Color.Orange;
            btnCoTwoTextSubjectFourText.ForeColor = System.Drawing.Color.White;

            btnCoThreeTextSubjectOneText.BackColor = System.Drawing.Color.Gray;
            btnCoThreeTextSubjectOneText.ForeColor = System.Drawing.Color.White;
            btnCoThreeTextSubjectTwoText.BackColor = System.Drawing.Color.Gray;
            btnCoThreeTextSubjectTwoText.ForeColor = System.Drawing.Color.White;
            btnCoThreeTextSubjectThreeText.BackColor = System.Drawing.Color.Gray;
            btnCoThreeTextSubjectThreeText.ForeColor = System.Drawing.Color.White;
            btnCoThreeTextSubjectFourText.BackColor = System.Drawing.Color.Gray;
            btnCoThreeTextSubjectFourText.ForeColor = System.Drawing.Color.White;

            btnCoFourTextSubjectOneText.BackColor = System.Drawing.Color.Gray;
            btnCoFourTextSubjectOneText.ForeColor = System.Drawing.Color.White;
            btnCoFourTextSubjectTwoText.BackColor = System.Drawing.Color.Gray;
            btnCoFourTextSubjectTwoText.ForeColor = System.Drawing.Color.White;
            btnCoFourTextSubjectThreeText.BackColor = System.Drawing.Color.Gray;
            btnCoFourTextSubjectThreeText.ForeColor = System.Drawing.Color.White;
            btnCoFourTextSubjectFourText.BackColor = System.Drawing.Color.Gray;
            btnCoFourTextSubjectFourText.ForeColor = System.Drawing.Color.White;
        }
        else if (Color == "CoThreeTextSubOneText")
        {
            btnCoOneTextSubjectTwoText.BackColor = System.Drawing.Color.Gray;
            btnCoOneTextSubjectTwoText.ForeColor = System.Drawing.Color.White;
            btnCoOneTextSubjectOneText.BackColor = System.Drawing.Color.Gray;
            btnCoOneTextSubjectOneText.ForeColor = System.Drawing.Color.White;
            btnCoOneTextSubjectThreeText.BackColor = System.Drawing.Color.Gray;
            btnCoOneTextSubjectThreeText.ForeColor = System.Drawing.Color.White;
            btnCoOneTextSubjectFourText.BackColor = System.Drawing.Color.Gray;
            btnCoOneTextSubjectFourText.ForeColor = System.Drawing.Color.White;


            btnCoTwoTextSubjectOneText.BackColor = System.Drawing.Color.Gray;
            btnCoTwoTextSubjectOneText.ForeColor = System.Drawing.Color.White;
            btnCoTwoTextSubjectTwoText.BackColor = System.Drawing.Color.Gray;
            btnCoTwoTextSubjectTwoText.ForeColor = System.Drawing.Color.White;
            btnCoTwoTextSubjectThreeText.BackColor = System.Drawing.Color.Gray;
            btnCoTwoTextSubjectThreeText.ForeColor = System.Drawing.Color.White;
            btnCoTwoTextSubjectFourText.BackColor = System.Drawing.Color.Gray;
            btnCoTwoTextSubjectFourText.ForeColor = System.Drawing.Color.White;

            btnCoThreeTextSubjectOneText.BackColor = System.Drawing.Color.Orange;
            btnCoThreeTextSubjectOneText.ForeColor = System.Drawing.Color.White;
            btnCoThreeTextSubjectTwoText.BackColor = System.Drawing.Color.Gray;
            btnCoThreeTextSubjectTwoText.ForeColor = System.Drawing.Color.White;
            btnCoThreeTextSubjectThreeText.BackColor = System.Drawing.Color.Gray;
            btnCoThreeTextSubjectThreeText.ForeColor = System.Drawing.Color.White;
            btnCoThreeTextSubjectFourText.BackColor = System.Drawing.Color.Gray;
            btnCoThreeTextSubjectFourText.ForeColor = System.Drawing.Color.White;

            btnCoFourTextSubjectOneText.BackColor = System.Drawing.Color.Gray;
            btnCoFourTextSubjectOneText.ForeColor = System.Drawing.Color.White;
            btnCoFourTextSubjectTwoText.BackColor = System.Drawing.Color.Gray;
            btnCoFourTextSubjectTwoText.ForeColor = System.Drawing.Color.White;
            btnCoFourTextSubjectThreeText.BackColor = System.Drawing.Color.Gray;
            btnCoFourTextSubjectThreeText.ForeColor = System.Drawing.Color.White;
            btnCoFourTextSubjectFourText.BackColor = System.Drawing.Color.Gray;
            btnCoFourTextSubjectFourText.ForeColor = System.Drawing.Color.White;
        }
        else if (Color == "CoThreeTextSubTwoText")
        {
            btnCoOneTextSubjectTwoText.BackColor = System.Drawing.Color.Gray;
            btnCoOneTextSubjectTwoText.ForeColor = System.Drawing.Color.White;
            btnCoOneTextSubjectOneText.BackColor = System.Drawing.Color.Gray;
            btnCoOneTextSubjectOneText.ForeColor = System.Drawing.Color.White;
            btnCoOneTextSubjectThreeText.BackColor = System.Drawing.Color.Gray;
            btnCoOneTextSubjectThreeText.ForeColor = System.Drawing.Color.White;
            btnCoOneTextSubjectFourText.BackColor = System.Drawing.Color.Gray;
            btnCoOneTextSubjectFourText.ForeColor = System.Drawing.Color.White;


            btnCoTwoTextSubjectOneText.BackColor = System.Drawing.Color.Gray;
            btnCoTwoTextSubjectOneText.ForeColor = System.Drawing.Color.White;
            btnCoTwoTextSubjectTwoText.BackColor = System.Drawing.Color.Gray;
            btnCoTwoTextSubjectTwoText.ForeColor = System.Drawing.Color.White;
            btnCoTwoTextSubjectThreeText.BackColor = System.Drawing.Color.Gray;
            btnCoTwoTextSubjectThreeText.ForeColor = System.Drawing.Color.White;
            btnCoTwoTextSubjectFourText.BackColor = System.Drawing.Color.Gray;
            btnCoTwoTextSubjectFourText.ForeColor = System.Drawing.Color.White;

            btnCoThreeTextSubjectOneText.BackColor = System.Drawing.Color.Gray;
            btnCoThreeTextSubjectOneText.ForeColor = System.Drawing.Color.White;
            btnCoThreeTextSubjectTwoText.BackColor = System.Drawing.Color.Orange;
            btnCoThreeTextSubjectTwoText.ForeColor = System.Drawing.Color.White;
            btnCoThreeTextSubjectThreeText.BackColor = System.Drawing.Color.Gray;
            btnCoThreeTextSubjectThreeText.ForeColor = System.Drawing.Color.White;
            btnCoThreeTextSubjectFourText.BackColor = System.Drawing.Color.Gray;
            btnCoThreeTextSubjectFourText.ForeColor = System.Drawing.Color.White;

            btnCoFourTextSubjectOneText.BackColor = System.Drawing.Color.Gray;
            btnCoFourTextSubjectOneText.ForeColor = System.Drawing.Color.White;
            btnCoFourTextSubjectTwoText.BackColor = System.Drawing.Color.Gray;
            btnCoFourTextSubjectTwoText.ForeColor = System.Drawing.Color.White;
            btnCoFourTextSubjectThreeText.BackColor = System.Drawing.Color.Gray;
            btnCoFourTextSubjectThreeText.ForeColor = System.Drawing.Color.White;
            btnCoFourTextSubjectFourText.BackColor = System.Drawing.Color.Gray;
            btnCoFourTextSubjectFourText.ForeColor = System.Drawing.Color.White;
        }
        else if (Color == "CoThreeTextSubThreeText")
        {
            btnCoOneTextSubjectTwoText.BackColor = System.Drawing.Color.Gray;
            btnCoOneTextSubjectTwoText.ForeColor = System.Drawing.Color.White;
            btnCoOneTextSubjectOneText.BackColor = System.Drawing.Color.Gray;
            btnCoOneTextSubjectOneText.ForeColor = System.Drawing.Color.White;
            btnCoOneTextSubjectThreeText.BackColor = System.Drawing.Color.Gray;
            btnCoOneTextSubjectThreeText.ForeColor = System.Drawing.Color.White;
            btnCoOneTextSubjectFourText.BackColor = System.Drawing.Color.Gray;
            btnCoOneTextSubjectFourText.ForeColor = System.Drawing.Color.White;


            btnCoTwoTextSubjectOneText.BackColor = System.Drawing.Color.Gray;
            btnCoTwoTextSubjectOneText.ForeColor = System.Drawing.Color.White;
            btnCoTwoTextSubjectTwoText.BackColor = System.Drawing.Color.Gray;
            btnCoTwoTextSubjectTwoText.ForeColor = System.Drawing.Color.White;
            btnCoTwoTextSubjectThreeText.BackColor = System.Drawing.Color.Gray;
            btnCoTwoTextSubjectThreeText.ForeColor = System.Drawing.Color.White;
            btnCoTwoTextSubjectFourText.BackColor = System.Drawing.Color.Gray;
            btnCoTwoTextSubjectFourText.ForeColor = System.Drawing.Color.White;

            btnCoThreeTextSubjectOneText.BackColor = System.Drawing.Color.Gray;
            btnCoThreeTextSubjectOneText.ForeColor = System.Drawing.Color.White;
            btnCoThreeTextSubjectTwoText.BackColor = System.Drawing.Color.Gray;
            btnCoThreeTextSubjectTwoText.ForeColor = System.Drawing.Color.White;
            btnCoThreeTextSubjectThreeText.BackColor = System.Drawing.Color.Orange;
            btnCoThreeTextSubjectThreeText.ForeColor = System.Drawing.Color.White;
            btnCoThreeTextSubjectFourText.BackColor = System.Drawing.Color.Gray;
            btnCoThreeTextSubjectFourText.ForeColor = System.Drawing.Color.White;

            btnCoFourTextSubjectOneText.BackColor = System.Drawing.Color.Gray;
            btnCoFourTextSubjectOneText.ForeColor = System.Drawing.Color.White;
            btnCoFourTextSubjectTwoText.BackColor = System.Drawing.Color.Gray;
            btnCoFourTextSubjectTwoText.ForeColor = System.Drawing.Color.White;
            btnCoFourTextSubjectThreeText.BackColor = System.Drawing.Color.Gray;
            btnCoFourTextSubjectThreeText.ForeColor = System.Drawing.Color.White;
            btnCoFourTextSubjectFourText.BackColor = System.Drawing.Color.Gray;
            btnCoFourTextSubjectFourText.ForeColor = System.Drawing.Color.White;
        }
        else if (Color == "CoThreeTextSubFourText")
        {
            btnCoOneTextSubjectTwoText.BackColor = System.Drawing.Color.Gray;
            btnCoOneTextSubjectTwoText.ForeColor = System.Drawing.Color.White;
            btnCoOneTextSubjectOneText.BackColor = System.Drawing.Color.Gray;
            btnCoOneTextSubjectOneText.ForeColor = System.Drawing.Color.White;
            btnCoOneTextSubjectThreeText.BackColor = System.Drawing.Color.Gray;
            btnCoOneTextSubjectThreeText.ForeColor = System.Drawing.Color.White;
            btnCoOneTextSubjectFourText.BackColor = System.Drawing.Color.Gray;
            btnCoOneTextSubjectFourText.ForeColor = System.Drawing.Color.White;


            btnCoTwoTextSubjectOneText.BackColor = System.Drawing.Color.Gray;
            btnCoTwoTextSubjectOneText.ForeColor = System.Drawing.Color.White;
            btnCoTwoTextSubjectTwoText.BackColor = System.Drawing.Color.Gray;
            btnCoTwoTextSubjectTwoText.ForeColor = System.Drawing.Color.White;
            btnCoTwoTextSubjectThreeText.BackColor = System.Drawing.Color.Gray;
            btnCoTwoTextSubjectThreeText.ForeColor = System.Drawing.Color.White;
            btnCoTwoTextSubjectFourText.BackColor = System.Drawing.Color.Gray;
            btnCoTwoTextSubjectFourText.ForeColor = System.Drawing.Color.White;

            btnCoThreeTextSubjectOneText.BackColor = System.Drawing.Color.Gray;
            btnCoThreeTextSubjectOneText.ForeColor = System.Drawing.Color.White;
            btnCoThreeTextSubjectTwoText.BackColor = System.Drawing.Color.Gray;
            btnCoThreeTextSubjectTwoText.ForeColor = System.Drawing.Color.White;
            btnCoThreeTextSubjectThreeText.BackColor = System.Drawing.Color.Gray;
            btnCoThreeTextSubjectThreeText.ForeColor = System.Drawing.Color.White;
            btnCoThreeTextSubjectFourText.BackColor = System.Drawing.Color.Orange;
            btnCoThreeTextSubjectFourText.ForeColor = System.Drawing.Color.White;

            btnCoFourTextSubjectOneText.BackColor = System.Drawing.Color.Gray;
            btnCoFourTextSubjectOneText.ForeColor = System.Drawing.Color.White;
            btnCoFourTextSubjectTwoText.BackColor = System.Drawing.Color.Gray;
            btnCoFourTextSubjectTwoText.ForeColor = System.Drawing.Color.White;
            btnCoFourTextSubjectThreeText.BackColor = System.Drawing.Color.Gray;
            btnCoFourTextSubjectThreeText.ForeColor = System.Drawing.Color.White;
            btnCoFourTextSubjectFourText.BackColor = System.Drawing.Color.Gray;
            btnCoFourTextSubjectFourText.ForeColor = System.Drawing.Color.White;
        }

        else if (Color == "CoFourTextSubOneText")
        {
            btnCoOneTextSubjectTwoText.BackColor = System.Drawing.Color.Gray;
            btnCoOneTextSubjectTwoText.ForeColor = System.Drawing.Color.White;
            btnCoOneTextSubjectOneText.BackColor = System.Drawing.Color.Gray;
            btnCoOneTextSubjectOneText.ForeColor = System.Drawing.Color.White;
            btnCoOneTextSubjectThreeText.BackColor = System.Drawing.Color.Gray;
            btnCoOneTextSubjectThreeText.ForeColor = System.Drawing.Color.White;
            btnCoOneTextSubjectFourText.BackColor = System.Drawing.Color.Gray;
            btnCoOneTextSubjectFourText.ForeColor = System.Drawing.Color.White;


            btnCoTwoTextSubjectOneText.BackColor = System.Drawing.Color.Gray;
            btnCoTwoTextSubjectOneText.ForeColor = System.Drawing.Color.White;
            btnCoTwoTextSubjectTwoText.BackColor = System.Drawing.Color.Gray;
            btnCoTwoTextSubjectTwoText.ForeColor = System.Drawing.Color.White;
            btnCoTwoTextSubjectThreeText.BackColor = System.Drawing.Color.Gray;
            btnCoTwoTextSubjectThreeText.ForeColor = System.Drawing.Color.White;
            btnCoTwoTextSubjectFourText.BackColor = System.Drawing.Color.Gray;
            btnCoTwoTextSubjectFourText.ForeColor = System.Drawing.Color.White;

            btnCoThreeTextSubjectOneText.BackColor = System.Drawing.Color.Gray;
            btnCoThreeTextSubjectOneText.ForeColor = System.Drawing.Color.White;
            btnCoThreeTextSubjectTwoText.BackColor = System.Drawing.Color.Gray;
            btnCoThreeTextSubjectTwoText.ForeColor = System.Drawing.Color.White;
            btnCoThreeTextSubjectThreeText.BackColor = System.Drawing.Color.Gray;
            btnCoThreeTextSubjectThreeText.ForeColor = System.Drawing.Color.White;
            btnCoThreeTextSubjectFourText.BackColor = System.Drawing.Color.Gray;
            btnCoThreeTextSubjectFourText.ForeColor = System.Drawing.Color.White;

            btnCoFourTextSubjectOneText.BackColor = System.Drawing.Color.Orange;
            btnCoFourTextSubjectOneText.ForeColor = System.Drawing.Color.White;
            btnCoFourTextSubjectTwoText.BackColor = System.Drawing.Color.Gray;
            btnCoFourTextSubjectTwoText.ForeColor = System.Drawing.Color.White;
            btnCoFourTextSubjectThreeText.BackColor = System.Drawing.Color.Gray;
            btnCoFourTextSubjectThreeText.ForeColor = System.Drawing.Color.White;
            btnCoFourTextSubjectFourText.BackColor = System.Drawing.Color.Gray;
            btnCoFourTextSubjectFourText.ForeColor = System.Drawing.Color.White;
        }
        else if (Color == "CoFourTextSubTwoText")
        {
            btnCoOneTextSubjectTwoText.BackColor = System.Drawing.Color.Gray;
            btnCoOneTextSubjectTwoText.ForeColor = System.Drawing.Color.White;
            btnCoOneTextSubjectOneText.BackColor = System.Drawing.Color.Gray;
            btnCoOneTextSubjectOneText.ForeColor = System.Drawing.Color.White;
            btnCoOneTextSubjectThreeText.BackColor = System.Drawing.Color.Gray;
            btnCoOneTextSubjectThreeText.ForeColor = System.Drawing.Color.White;
            btnCoOneTextSubjectFourText.BackColor = System.Drawing.Color.Gray;
            btnCoOneTextSubjectFourText.ForeColor = System.Drawing.Color.White;


            btnCoTwoTextSubjectOneText.BackColor = System.Drawing.Color.Gray;
            btnCoTwoTextSubjectOneText.ForeColor = System.Drawing.Color.White;
            btnCoTwoTextSubjectTwoText.BackColor = System.Drawing.Color.Gray;
            btnCoTwoTextSubjectTwoText.ForeColor = System.Drawing.Color.White;
            btnCoTwoTextSubjectThreeText.BackColor = System.Drawing.Color.Gray;
            btnCoTwoTextSubjectThreeText.ForeColor = System.Drawing.Color.White;
            btnCoTwoTextSubjectFourText.BackColor = System.Drawing.Color.Gray;
            btnCoTwoTextSubjectFourText.ForeColor = System.Drawing.Color.White;

            btnCoThreeTextSubjectOneText.BackColor = System.Drawing.Color.Gray;
            btnCoThreeTextSubjectOneText.ForeColor = System.Drawing.Color.White;
            btnCoThreeTextSubjectTwoText.BackColor = System.Drawing.Color.Gray;
            btnCoThreeTextSubjectTwoText.ForeColor = System.Drawing.Color.White;
            btnCoThreeTextSubjectThreeText.BackColor = System.Drawing.Color.Gray;
            btnCoThreeTextSubjectThreeText.ForeColor = System.Drawing.Color.White;
            btnCoThreeTextSubjectFourText.BackColor = System.Drawing.Color.Gray;
            btnCoThreeTextSubjectFourText.ForeColor = System.Drawing.Color.White;

            btnCoFourTextSubjectOneText.BackColor = System.Drawing.Color.Gray;
            btnCoFourTextSubjectOneText.ForeColor = System.Drawing.Color.White;
            btnCoFourTextSubjectTwoText.BackColor = System.Drawing.Color.Orange;
            btnCoFourTextSubjectTwoText.ForeColor = System.Drawing.Color.White;
            btnCoFourTextSubjectThreeText.BackColor = System.Drawing.Color.Gray;
            btnCoFourTextSubjectThreeText.ForeColor = System.Drawing.Color.White;
            btnCoFourTextSubjectFourText.BackColor = System.Drawing.Color.Gray;
            btnCoFourTextSubjectFourText.ForeColor = System.Drawing.Color.White;
        }
        else if (Color == "CoFourTextSubThreeText")
        {
            btnCoOneTextSubjectTwoText.BackColor = System.Drawing.Color.Gray;
            btnCoOneTextSubjectTwoText.ForeColor = System.Drawing.Color.White;
            btnCoOneTextSubjectOneText.BackColor = System.Drawing.Color.Gray;
            btnCoOneTextSubjectOneText.ForeColor = System.Drawing.Color.White;
            btnCoOneTextSubjectThreeText.BackColor = System.Drawing.Color.Gray;
            btnCoOneTextSubjectThreeText.ForeColor = System.Drawing.Color.White;
            btnCoOneTextSubjectFourText.BackColor = System.Drawing.Color.Gray;
            btnCoOneTextSubjectFourText.ForeColor = System.Drawing.Color.White;


            btnCoTwoTextSubjectOneText.BackColor = System.Drawing.Color.Gray;
            btnCoTwoTextSubjectOneText.ForeColor = System.Drawing.Color.White;
            btnCoTwoTextSubjectTwoText.BackColor = System.Drawing.Color.Gray;
            btnCoTwoTextSubjectTwoText.ForeColor = System.Drawing.Color.White;
            btnCoTwoTextSubjectThreeText.BackColor = System.Drawing.Color.Gray;
            btnCoTwoTextSubjectThreeText.ForeColor = System.Drawing.Color.White;
            btnCoTwoTextSubjectFourText.BackColor = System.Drawing.Color.Gray;
            btnCoTwoTextSubjectFourText.ForeColor = System.Drawing.Color.White;

            btnCoThreeTextSubjectOneText.BackColor = System.Drawing.Color.Gray;
            btnCoThreeTextSubjectOneText.ForeColor = System.Drawing.Color.White;
            btnCoThreeTextSubjectTwoText.BackColor = System.Drawing.Color.Gray;
            btnCoThreeTextSubjectTwoText.ForeColor = System.Drawing.Color.White;
            btnCoThreeTextSubjectThreeText.BackColor = System.Drawing.Color.Gray;
            btnCoThreeTextSubjectThreeText.ForeColor = System.Drawing.Color.White;
            btnCoThreeTextSubjectFourText.BackColor = System.Drawing.Color.Gray;
            btnCoThreeTextSubjectFourText.ForeColor = System.Drawing.Color.White;

            btnCoFourTextSubjectOneText.BackColor = System.Drawing.Color.Gray;
            btnCoFourTextSubjectOneText.ForeColor = System.Drawing.Color.White;
            btnCoFourTextSubjectTwoText.BackColor = System.Drawing.Color.Gray;
            btnCoFourTextSubjectTwoText.ForeColor = System.Drawing.Color.White;
            btnCoFourTextSubjectThreeText.BackColor = System.Drawing.Color.Orange;
            btnCoFourTextSubjectThreeText.ForeColor = System.Drawing.Color.White;
            btnCoFourTextSubjectFourText.BackColor = System.Drawing.Color.Gray;
            btnCoFourTextSubjectFourText.ForeColor = System.Drawing.Color.White;
        }
        else if (Color == "CoFourTextSubFourText")
        {
            btnCoOneTextSubjectTwoText.BackColor = System.Drawing.Color.Gray;
            btnCoOneTextSubjectTwoText.ForeColor = System.Drawing.Color.White;
            btnCoOneTextSubjectOneText.BackColor = System.Drawing.Color.Gray;
            btnCoOneTextSubjectOneText.ForeColor = System.Drawing.Color.White;
            btnCoOneTextSubjectThreeText.BackColor = System.Drawing.Color.Gray;
            btnCoOneTextSubjectThreeText.ForeColor = System.Drawing.Color.White;
            btnCoOneTextSubjectFourText.BackColor = System.Drawing.Color.Gray;
            btnCoOneTextSubjectFourText.ForeColor = System.Drawing.Color.White;


            btnCoTwoTextSubjectOneText.BackColor = System.Drawing.Color.Gray;
            btnCoTwoTextSubjectOneText.ForeColor = System.Drawing.Color.White;
            btnCoTwoTextSubjectTwoText.BackColor = System.Drawing.Color.Gray;
            btnCoTwoTextSubjectTwoText.ForeColor = System.Drawing.Color.White;
            btnCoTwoTextSubjectThreeText.BackColor = System.Drawing.Color.Gray;
            btnCoTwoTextSubjectThreeText.ForeColor = System.Drawing.Color.White;
            btnCoTwoTextSubjectFourText.BackColor = System.Drawing.Color.Gray;
            btnCoTwoTextSubjectFourText.ForeColor = System.Drawing.Color.White;

            btnCoThreeTextSubjectOneText.BackColor = System.Drawing.Color.Gray;
            btnCoThreeTextSubjectOneText.ForeColor = System.Drawing.Color.White;
            btnCoThreeTextSubjectTwoText.BackColor = System.Drawing.Color.Gray;
            btnCoThreeTextSubjectTwoText.ForeColor = System.Drawing.Color.White;
            btnCoThreeTextSubjectThreeText.BackColor = System.Drawing.Color.Gray;
            btnCoThreeTextSubjectThreeText.ForeColor = System.Drawing.Color.White;
            btnCoThreeTextSubjectFourText.BackColor = System.Drawing.Color.Gray;
            btnCoThreeTextSubjectFourText.ForeColor = System.Drawing.Color.White;

            btnCoFourTextSubjectOneText.BackColor = System.Drawing.Color.Gray;
            btnCoFourTextSubjectOneText.ForeColor = System.Drawing.Color.White;
            btnCoFourTextSubjectTwoText.BackColor = System.Drawing.Color.Gray;
            btnCoFourTextSubjectTwoText.ForeColor = System.Drawing.Color.White;
            btnCoFourTextSubjectThreeText.BackColor = System.Drawing.Color.Gray;
            btnCoFourTextSubjectThreeText.ForeColor = System.Drawing.Color.White;
            btnCoFourTextSubjectFourText.BackColor = System.Drawing.Color.Orange;
            btnCoFourTextSubjectFourText.ForeColor = System.Drawing.Color.White;
        }
        else
        {
            btnCoOneTextSubjectTwoText.BackColor = System.Drawing.Color.Gray;
            btnCoOneTextSubjectTwoText.ForeColor = System.Drawing.Color.White;
            btnCoOneTextSubjectOneText.BackColor = System.Drawing.Color.Gray;
            btnCoOneTextSubjectOneText.ForeColor = System.Drawing.Color.White;
            btnCoOneTextSubjectThreeText.BackColor = System.Drawing.Color.Gray;
            btnCoOneTextSubjectThreeText.ForeColor = System.Drawing.Color.White;
            btnCoOneTextSubjectFourText.BackColor = System.Drawing.Color.Gray;
            btnCoOneTextSubjectFourText.ForeColor = System.Drawing.Color.White;


            btnCoTwoTextSubjectOneText.BackColor = System.Drawing.Color.Gray;
            btnCoTwoTextSubjectOneText.ForeColor = System.Drawing.Color.White;
            btnCoTwoTextSubjectTwoText.BackColor = System.Drawing.Color.Gray;
            btnCoTwoTextSubjectTwoText.ForeColor = System.Drawing.Color.White;
            btnCoTwoTextSubjectThreeText.BackColor = System.Drawing.Color.Gray;
            btnCoTwoTextSubjectThreeText.ForeColor = System.Drawing.Color.White;
            btnCoTwoTextSubjectFourText.BackColor = System.Drawing.Color.Gray;
            btnCoTwoTextSubjectFourText.ForeColor = System.Drawing.Color.White;

            btnCoThreeTextSubjectOneText.BackColor = System.Drawing.Color.Gray;
            btnCoThreeTextSubjectOneText.ForeColor = System.Drawing.Color.White;
            btnCoThreeTextSubjectTwoText.BackColor = System.Drawing.Color.Gray;
            btnCoThreeTextSubjectTwoText.ForeColor = System.Drawing.Color.White;
            btnCoThreeTextSubjectThreeText.BackColor = System.Drawing.Color.Gray;
            btnCoThreeTextSubjectThreeText.ForeColor = System.Drawing.Color.White;
            btnCoThreeTextSubjectFourText.BackColor = System.Drawing.Color.Gray;
            btnCoThreeTextSubjectFourText.ForeColor = System.Drawing.Color.White;

            btnCoFourTextSubjectOneText.BackColor = System.Drawing.Color.Gray;
            btnCoFourTextSubjectOneText.ForeColor = System.Drawing.Color.White;
            btnCoFourTextSubjectTwoText.BackColor = System.Drawing.Color.Gray;
            btnCoFourTextSubjectTwoText.ForeColor = System.Drawing.Color.White;
            btnCoFourTextSubjectThreeText.BackColor = System.Drawing.Color.Gray;
            btnCoFourTextSubjectThreeText.ForeColor = System.Drawing.Color.White;
            btnCoFourTextSubjectFourText.BackColor = System.Drawing.Color.Gray;
            btnCoFourTextSubjectFourText.ForeColor = System.Drawing.Color.White;
        }
    }
}