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


public partial class Student_SyllabusDetails : System.Web.UI.Page
{
    #region "Variable Decleration"
   

    private clsNews obj_News = new clsNews();
    private clsMaster Obj_Master = new clsMaster();
    private clsStudent obj_Student = new clsStudent();
    private DataSet DS;
    private int RecordStatus;
    private static int AdminRegistrationId;
    private static int StudentId;
    #endregion
    protected void Page_Load(object sender, EventArgs e)
    {
        

        if (Session["USER_NAME"] != null)
        //if (!string.IsNullOrEmpty(Session["USER_NAME"].ToString()))
        {
            StudentId = Convert.ToInt32(Session["StudentId"].ToString());
            if (!IsPostBack)
            {
                FillStudentInformation();
              //  FillSyllabus();

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
                    Session["CourseOne"] = row["CourseOne"].ToString();
                    lblCoursesOneText.Visible = true;
                    lblCoursesOneText.Text = "you are registrated in Course " + row["CourseOneText"].ToString();
                }

                if (row["CourseTwoText"].ToString() == "" || row["CourseTwoText"].ToString() == "--Select--")
                {
                    lblCoursesTwoText.Visible = false;
                }
                else
                {
                    Session["CourseTwo"] = row["CourseTwo"].ToString();
                    lblCoursesTwoText.Visible = true;
                    lblCoursesTwoText.Text = "you are registrated in Course " + row["CourseTwoText"].ToString();
                }

                if (row["CourseThreeText"].ToString() == "" || row["CourseThreeText"].ToString() == "--Select--")
                {
                    lblCoursesThreeText.Visible = false;
                }
                else
                {
                    Session["CourseThree"] = row["CourseThree"].ToString();
                    lblCoursesThreeText.Visible = true;
                    lblCoursesThreeText.Text = "you are registrated in Course " + row["CourseThreeText"].ToString();
                }


                if (row["CourseFourText"].ToString() == "" || row["CourseFourText"].ToString() == "--Select--")
                {
                    lblCoursesFourText.Visible = false;
                }
                else
                {
                    Session["CourseFour"] = row["CourseFour"].ToString();
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
                    Session["CourseOneSubjectOne"] = row["CourseOneSubjectOne"].ToString();
                    btnCoOneTextSubjectOneText.Visible = true;
                    lblSubjectOneText.Text = "Subject:";
                    btnCoOneTextSubjectOneText.Text = row["CourseOneSubjectOneText"].ToString();
                }

                if (row["CourseOneSubjectTwoText"].ToString() == "" || row["CourseOneSubjectTwoText"].ToString() == "--Select--")
                {
                    btnCoOneTextSubjectTwoText.Visible = false;
                }
                else
                {
                    Session["CourseOneSubjectTwo"] = row["CourseOneSubjectTwo"].ToString();
                    btnCoOneTextSubjectTwoText.Visible = true;
                    btnCoOneTextSubjectTwoText.Text = row["CourseOneSubjectTwoText"].ToString();
                }
                if (row["CourseOneSubjectThreeText"].ToString() == "" || row["CourseOneSubjectThreeText"].ToString() == "--Select--")
                {
                    btnCoOneTextSubjectThreeText.Visible = false;
                }
                else
                {
                    Session["CourseOneSubjectThree"] = row["CourseOneSubjectThree"].ToString();
                    btnCoOneTextSubjectThreeText.Visible = true;
                    btnCoOneTextSubjectThreeText.Text = row["CourseOneSubjectThreeText"].ToString();
                }

                if (row["CourseOneSubjectFourText"].ToString() == "" || row["CourseOneSubjectFourText"].ToString() == "--Select--")
                {
                    btnCoOneTextSubjectFourText.Visible = false;
                }
                else
                {
                    Session["CourseOneSubjectFour"] = row["CourseOneSubjectFour"].ToString();
                    btnCoOneTextSubjectFourText.Visible = true;
                    btnCoOneTextSubjectFourText.Text = row["CourseOneSubjectFourText"].ToString();
                }


                if (row["CourseTwoSubjectOneText"].ToString() == "" || row["CourseTwoSubjectOneText"].ToString() == "--Select--")
                {
                    btnCoTwoTextSubjectOneText.Visible = false;
                }
                else
                {
                    Session["CourseTwoSubjectOne"] = row["CourseTwoSubjectOne"].ToString();
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
                    Session["CourseTwoSubjectTwo"] = row["CourseTwoSubjectTwo"].ToString();
                    btnCoTwoTextSubjectTwoText.Visible = true;
                    btnCoTwoTextSubjectTwoText.Text = row["CourseTwoSubjectTwoText"].ToString();
                }

                if (row["CourseTwoSubjectThreeText"].ToString() == "" || row["CourseTwoSubjectThreeText"].ToString() == "--Select--")
                {
                    btnCoTwoTextSubjectThreeText.Visible = false;
                }
                else
                {
                    Session["CourseTwoSubjectThree"] = row["CourseTwoSubjectThree"].ToString();
                    btnCoTwoTextSubjectThreeText.Visible = true;
                    btnCoTwoTextSubjectThreeText.Text = row["CourseTwoSubjectThreeText"].ToString();
                }
                if (row["CourseTwoSubjectFourText"].ToString() == "" || row["CourseTwoSubjectFourText"].ToString() == "--Select--")
                {
                    btnCoTwoTextSubjectFourText.Visible = false;
                }
                else
                {
                    Session["CourseTwoSubjectFour"] = row["CourseTwoSubjectFour"].ToString();
                    btnCoTwoTextSubjectFourText.Visible = true;
                    btnCoTwoTextSubjectFourText.Text = row["CourseTwoSubjectFourText"].ToString();
                }

                if (row["CourseThreeSubjectOneText"].ToString() == "" || row["CourseThreeSubjectOneText"].ToString() == "--Select--")
                {
                    btnCoThreeTextSubjectOneText.Visible = false;
                }
                else
                {
                    Session["CourseThreeSubjectOne"] = row["CourseThreeSubjectOne"].ToString();
                    btnCoThreeTextSubjectOneText.Visible = true;
                    lblSubjectThreeText.Text = "Subject:";
                    btnCoThreeTextSubjectOneText.Text = row["CourseThreeSubjectOneText"].ToString();
                }
                if (row["CourseThreeSubjectTwoText"].ToString() == "" || row["CourseThreeSubjectTwoText"].ToString() == "--Select--")
                {
                    btnCoThreeTextSubjectTwoText.Visible = false;
                }
                else
                {
                    Session["CourseThreeSubjectTwo"] = row["CourseThreeSubjectTwo"].ToString();
                    btnCoThreeTextSubjectTwoText.Visible = true;
                    btnCoThreeTextSubjectTwoText.Text = row["CourseThreeSubjectTwoText"].ToString();
                }
                if (row["CourseThreeSubjectThreeText"].ToString() == "" || row["CourseThreeSubjectThreeText"].ToString() == "--Select--")
                {
                    btnCoThreeTextSubjectThreeText.Visible = false;
                }
                else
                {
                    Session["CourseThreeSubjectThree"] = row["CourseThreeSubjectThree"].ToString();
                    btnCoThreeTextSubjectThreeText.Visible = true;
                    btnCoThreeTextSubjectThreeText.Text = row["CourseThreeSubjectThreeText"].ToString();
                }
                if (row["CourseThreeSubjectFourText"].ToString() == "" || row["CourseThreeSubjectFourText"].ToString() == "--Select--")
                {
                    btnCoThreeTextSubjectFourText.Visible = false;
                }
                else
                {
                    Session["CourseThreeSubjectFour"] = row["CourseThreeSubjectFour"].ToString();
                    btnCoThreeTextSubjectFourText.Visible = true;
                    btnCoThreeTextSubjectFourText.Text = row["CourseThreeSubjectFourText"].ToString();
                }
                if (row["CourseFourSubjectOneText"].ToString() == "" || row["CourseFourSubjectOneText"].ToString() == "--Select--")
                {
                    btnCoFourTextSubjectOneText.Visible = false;
                }
                else
                {
                    Session["CourseFourSubjectOne"] = row["CourseFourSubjectOne"].ToString();
                    btnCoFourTextSubjectOneText.Visible = true;
                    lblSubjectFourText.Text = "Subject:";
                    btnCoFourTextSubjectOneText.Text = row["CourseFourSubjectOneText"].ToString();
                }
                if (row["CourseFourSubjectTwoText"].ToString() == "" || row["CourseFourSubjectTwoText"].ToString() == "--Select--")
                {
                    btnCoFourTextSubjectTwoText.Visible = false;
                }
                else
                {
                    Session["CourseFourSubjectTwo"] = row["CourseFourSubjectTwo"].ToString();
                    btnCoFourTextSubjectTwoText.Visible = true;
                    btnCoFourTextSubjectTwoText.Text = row["CourseFourSubjectTwoText"].ToString();
                }
                if (row["CourseFourSubjectThreeText"].ToString() == "" || row["CourseFourSubjectThreeText"].ToString() == "--Select--")
                {
                    btnCoFourTextSubjectThreeText.Visible = false;
                }
                else
                {
                    Session["CourseFourSubjectThree"] = row["CourseFourSubjectThree"].ToString();
                    btnCoFourTextSubjectThreeText.Visible = true;
                    btnCoFourTextSubjectThreeText.Text = row["CourseFourSubjectThreeText"].ToString();
                }
                if (row["CourseFourSubjectFourText"].ToString() == "" || row["CourseFourSubjectFourText"].ToString() == "--Select--")
                {
                    btnCoFourTextSubjectFourText.Visible = false;
                }
                else
                {
                    Session["CourseFourSubjectFour"] = row["CourseFourSubjectFour"].ToString();
                    btnCoFourTextSubjectFourText.Visible = true;
                    btnCoFourTextSubjectFourText.Text = row["CourseFourSubjectFourText"].ToString();
                }
            }
        }

    }
    #endregion "End Fill contorole on Form"


    private void BlankLbl()
    {
        //lblPercent.Text = "";
        //lblTotalPresent.Text = "";
        //lblTotalAbsent.Text = "";
        //lblTotalClass.Text = "";

    }
 

    protected void btnCoOneTextSubjectOneText_Click(object sender, EventArgs e)
    {

        BlankLbl();
        obj_Student.StudentId = StudentId;
        obj_Student.CourseOneText = lblCoursesOneText.Text.Replace("you are registrated in Course ", "");

        obj_Student.CourseOneSubjectOneText = btnCoOneTextSubjectOneText.Text;
        Obj_Master.ClassId = Convert.ToInt32(Session["ClassId"]);
        Obj_Master.CourseOne = Session["CourseOne"].ToString();
        Obj_Master.CourseOneSubjectOne = Session["CourseOneSubjectOne"].ToString();

        DS = Obj_Master.DisplaySyllabusCourseOneSubjectOne();
        gvDetail1.DataSource = DS;
        gvDetail1.DataBind();
        ButtonColor("CoOneTextSubOneText");

    }


    protected void btnCoOneTextSubjectTwoText_Click(object sender, EventArgs e)
    {
        BlankLbl();
        obj_Student.StudentId = StudentId;
       
        obj_Student.CourseOneText = lblCoursesOneText.Text.Replace("you are registrated in Course ", "");
        obj_Student.CourseOneSubjectTwoText = btnCoOneTextSubjectTwoText.Text;
        Obj_Master.ClassId = Convert.ToInt32(Session["ClassId"]);
        Obj_Master.CourseOne = Session["CourseOne"].ToString();
        Obj_Master.CourseOneSubjectTwo = Session["CourseOneSubjectTwo"].ToString();

        DS = Obj_Master.DisplaySyllabusCourseOneSubjectTwo();


        gvDetail1.DataSource = DS;
        gvDetail1.DataBind();
        ButtonColor("CoOneTextSubTwoText");

       



    }
    protected void btnCoOneTextSubjectThreeText_Click(object sender, EventArgs e)
    {
        BlankLbl();
        obj_Student.StudentId = StudentId;
        Obj_Master.ClassId = Convert.ToInt32(Session["ClassId"]);
        obj_Student.CourseOneText = lblCoursesOneText.Text.Replace("you are registrated in Course ", "");
        obj_Student.CourseOneSubjectThreeText = btnCoOneTextSubjectThreeText.Text;
        Obj_Master.CourseOne = Session["CourseOne"].ToString();
        Obj_Master.CourseOneSubjectThree = Session["CourseOneSubjectThree"].ToString();

        DS = Obj_Master.DisplaySyllabusCourseOneSubjectThree();

      

        gvDetail1.DataSource = DS;
        gvDetail1.DataBind();
        ButtonColor("CoOneTextSubThreeText");

     


    }
    protected void btnCoOneTextSubjectFourText_Click(object sender, EventArgs e)
    {
        BlankLbl();
        obj_Student.StudentId = StudentId;
      
        obj_Student.CourseOneText = lblCoursesOneText.Text.Replace("you are registrated in Course ", "");
        obj_Student.CourseOneSubjectFourText = btnCoOneTextSubjectFourText.Text;
        

      
        Obj_Master.ClassId = Convert.ToInt32(Session["ClassId"]);
        Obj_Master.CourseOne = Session["CourseOne"].ToString();
        Obj_Master.CourseOneSubjectFour = Session["CourseOneSubjectFour"].ToString();

        DS = Obj_Master.DisplaySyllabusCourseOneSubjectFour();
        gvDetail1.DataSource = DS;
        gvDetail1.DataBind();
        ButtonColor("CoOneTextSubFourText");



    }

    // courses TwoText 

    protected void btnCoTwoTextSubjectOneText_Click(object sender, EventArgs e)
    {
        BlankLbl();
        obj_Student.StudentId = StudentId;
        Obj_Master.ClassId = Convert.ToInt32(Session["ClassId"]);
        obj_Student.CourseTwoText = lblCoursesTwoText.Text.Replace("you are registrated in Course ", "");
        obj_Student.CourseTwoSubjectOneText = btnCoTwoTextSubjectOneText.Text;
        Obj_Master.CourseTwo = Session["CourseTwo"].ToString();
        Obj_Master.CourseTwoSubjectOne = Session["CourseTwoSubjectOne"].ToString();

        DS = Obj_Master.DisplaySyllabusCourseTwoSubjectOne();

        gvDetail1.DataSource = DS;
        gvDetail1.DataBind();
        ButtonColor("CoTwoTextSubOneText");

 


    }
    protected void btnCoTwoTextSubjectTwoText_Click(object sender, EventArgs e)
    {
        BlankLbl();
        obj_Student.StudentId = StudentId;
        Obj_Master.ClassId = Convert.ToInt32(Session["ClassId"]);
        obj_Student.CourseTwoText = lblCoursesTwoText.Text.Replace("you are registrated in Course ", "");
        obj_Student.CourseTwoSubjectTwoText = btnCoOneTextSubjectTwoText.Text;
        Obj_Master.CourseTwo = Session["CourseTwo"].ToString();
        Obj_Master.CourseTwoSubjectTwo = Session["CourseTwoSubjectTwo"].ToString();

        DS = Obj_Master.DisplaySyllabusCourseTwoSubjectTwo();

        gvDetail1.DataSource = DS;
        gvDetail1.DataBind();
        ButtonColor("CoTwoTextSubTwoText");

 


    }
    protected void btnCoTwoTextSubjectThreeText_Click(object sender, EventArgs e)
    {
        BlankLbl();
        obj_Student.StudentId = StudentId;
        Obj_Master.ClassId = Convert.ToInt32(Session["ClassId"]);
        obj_Student.CourseTwoText = lblCoursesTwoText.Text.Replace("you are registrated in Course ", "");
        obj_Student.CourseTwoSubjectThreeText = btnCoTwoTextSubjectThreeText.Text;
        Obj_Master.CourseTwo = Session["CourseTwo"].ToString();
        Obj_Master.CourseTwoSubjectThree = Session["CourseTwoSubjectThree"].ToString();

        DS = Obj_Master.DisplaySyllabusCourseTwoSubjectThree();

    
        gvDetail1.DataSource = DS;
        gvDetail1.DataBind();
        ButtonColor("CoTwoTextSubThreeText");

    

    }
    protected void btnCoTwoTextSubjectFourText_Click(object sender, EventArgs e)
    {
        BlankLbl();
        obj_Student.StudentId = StudentId;
        Obj_Master.ClassId = Convert.ToInt32(Session["ClassId"]);
        obj_Student.CourseTwoText = lblCoursesTwoText.Text.Replace("you are registrated in Course ", "");
        obj_Student.CourseTwoSubjectFourText = btnCoTwoTextSubjectFourText.Text;
        Obj_Master.CourseTwo = Session["CourseTwo"].ToString();
        Obj_Master.CourseTwoSubjectFour = Session["CourseTwoSubjectFour"].ToString();

        DS = Obj_Master.DisplaySyllabusCourseTwoSubjectFour();

     
        gvDetail1.DataSource = DS;
        gvDetail1.DataBind();
        ButtonColor("CoTwoTextSubFourText");

    

    }

    // courses ThreeText

    protected void btnCoThreeTextSubjectOneText_Click(object sender, EventArgs e)
    {
        BlankLbl();
        obj_Student.StudentId = StudentId;
        Obj_Master.ClassId = Convert.ToInt32(Session["ClassId"]);
        obj_Student.CourseThreeText = lblCoursesThreeText.Text.Replace("you are registrated in Course ", "");
        obj_Student.CourseThreeSubjectOneText = btnCoThreeTextSubjectOneText.Text;
        Obj_Master.CourseThree = Session["CourseThree"].ToString();
        Obj_Master.CourseThreeSubjectOne = Session["CourseThreeSubjectOne"].ToString();

        DS = Obj_Master.DisplaySyllabusCourseThreeSubjectOne();

      
        gvDetail1.DataSource = DS;
        gvDetail1.DataBind();
        ButtonColor("CoThreeTextSubOneText");

     

    }
    protected void btnCoThreeTextSubjectTwoText_Click(object sender, EventArgs e)
    {
        BlankLbl();
        obj_Student.StudentId = StudentId;
        Obj_Master.ClassId = Convert.ToInt32(Session["ClassId"]);
        obj_Student.CourseThreeText = lblCoursesThreeText.Text.Replace("you are registrated in Course ", "");
        obj_Student.CourseThreeSubjectTwoText = btnCoThreeTextSubjectTwoText.Text;
        Obj_Master.CourseThree = Session["CourseThree"].ToString();
        Obj_Master.CourseThreeSubjectTwo = Session["CourseThreeSubjectTwo"].ToString();

        DS = Obj_Master.DisplaySyllabusCourseThreeSubjectTwo();

    
        gvDetail1.DataSource = DS;
        gvDetail1.DataBind();
        ButtonColor("CoThreeTextSubTwoText");

      
    }
    protected void btnCoThreeTextSubjectThreeText_Click(object sender, EventArgs e)
    {
        BlankLbl();
        obj_Student.StudentId = StudentId;
        Obj_Master.ClassId = Convert.ToInt32(Session["ClassId"]);
        obj_Student.CourseThreeText = lblCoursesThreeText.Text.Replace("you are registrated in Course ", "");
        obj_Student.CourseThreeSubjectThreeText = btnCoThreeTextSubjectThreeText.Text;
        Obj_Master.CourseThree = Session["CourseThree"].ToString();
        Obj_Master.CourseThreeSubjectThree = Session["CourseThreeSubjectThree"].ToString();

        DS = Obj_Master.DisplaySyllabusCourseThreeSubjectThree();

    
        gvDetail1.DataSource = DS;
        gvDetail1.DataBind();
        ButtonColor("CoThreeTextSubThreeText");
      

    }
    protected void btnCoThreeTextSubjectFourText_Click(object sender, EventArgs e)
    {
        BlankLbl();
        obj_Student.StudentId = StudentId;
        Obj_Master.ClassId = Convert.ToInt32(Session["ClassId"]);
        obj_Student.CourseThreeText = lblCoursesThreeText.Text.Replace("you are registrated in Course ", "");
        obj_Student.CourseThreeSubjectFourText = btnCoThreeTextSubjectFourText.Text;
        Obj_Master.CourseThree = Session["CourseThree"].ToString();
        Obj_Master.CourseThreeSubjectFour = Session["CourseOneSubjectOne"].ToString();

        DS = Obj_Master.DisplaySyllabusCourseOneSubjectOne();

     
        gvDetail1.DataSource = DS;
        gvDetail1.DataBind();
        ButtonColor("CoThreeTextSubFourText");

       


    }

    // courses FourText

    protected void btnCoFourTextSubjectOneText_Click(object sender, EventArgs e)
    {
        BlankLbl();
        obj_Student.StudentId = StudentId;
        Obj_Master.ClassId = Convert.ToInt32(Session["ClassId"]);
        obj_Student.CourseFourText = lblCoursesFourText.Text.Replace("you are registrated in Course ", "");
        obj_Student.CourseFourSubjectOneText = btnCoFourTextSubjectOneText.Text;
        Obj_Master.CourseFour = Session["CourseFour"].ToString();
        Obj_Master.CourseFourSubjectOne = Session["CourseFourSubjectOne"].ToString();

        DS = Obj_Master.DisplaySyllabusCourseFourSubjectOne();

       
        gvDetail1.DataSource = DS;
        gvDetail1.DataBind();
        ButtonColor("CoFourTextSubOneText");
      


    }
    protected void btnCoFourTextSubjectTwoText_Click(object sender, EventArgs e)
    {
        BlankLbl();
        obj_Student.StudentId = StudentId;
        Obj_Master.ClassId = Convert.ToInt32(Session["ClassId"]);
        obj_Student.CourseFourText = lblCoursesFourText.Text.Replace("you are registrated in Course ", "");
        obj_Student.CourseFourSubjectTwoText = btnCoFourTextSubjectTwoText.Text;
        Obj_Master.CourseFour = Session["CourseFour"].ToString();
        Obj_Master.CourseFourSubjectTwo = Session["CourseFourSubjectTwo"].ToString();

        DS = Obj_Master.DisplaySyllabusCourseFourSubjectTwo();

      
        gvDetail1.DataSource = DS;
        gvDetail1.DataBind();
        ButtonColor("CoFourTextSubTwoText");

    


    }
    protected void btnCoFourTextSubjectThreeText_Click(object sender, EventArgs e)
    {
        BlankLbl();
        obj_Student.StudentId = StudentId;
        Obj_Master.ClassId = Convert.ToInt32(Session["ClassId"]);
        obj_Student.CourseFourText = lblCoursesFourText.Text.Replace("you are registrated in Course ", "");
        obj_Student.CourseFourSubjectThreeText = btnCoFourTextSubjectThreeText.Text;
        Obj_Master.CourseFour = Session["CourseFour"].ToString();
        Obj_Master.CourseFourSubjectThree = Session["CourseFourSubjectThree"].ToString();

        DS = Obj_Master.DisplaySyllabusCourseFourSubjectThree();

        
        gvDetail1.DataSource = DS;
        gvDetail1.DataBind();
        ButtonColor("CoFourTextSubThreeText");

    


    }
    protected void btnCoFourTextSubjectFourText_Click(object sender, EventArgs e)
    {
        BlankLbl();
        obj_Student.StudentId = StudentId;
        Obj_Master.ClassId = Convert.ToInt32(Session["ClassId"]);
        obj_Student.CourseFourText = lblCoursesFourText.Text.Replace("you are registrated in Course ", "");
        obj_Student.CourseFourSubjectOneText = btnCoFourTextSubjectOneText.Text;
        Obj_Master.CourseFour = Session["CourseFour"].ToString();
        Obj_Master.CourseFourSubjectFour = Session["CourseFourSubjectFour"].ToString();

        DS = Obj_Master.DisplaySyllabusCourseFourSubjectFour();

     
        gvDetail1.DataSource = DS;
        gvDetail1.DataBind();
        ButtonColor("CoFourTextSubFourText");

      


    }





    protected void ButtonColor(string Color)
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




    #region " Fill User Grid View"
    public void FillSyllabus()
    {
        DS = Obj_Master.DisplaySyllabus();
        gvDetail1.DataSource = DS;
        gvDetail1.DataBind();
    }
    #endregion "End Fill User GridView"

    protected void gvDetail1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {

    }
    protected void gvDetail1_RowEditing(object sender, GridViewEditEventArgs e)
    {

    }
    protected void gvDetail1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        Obj_Master.SyllabusId = Convert.ToInt32(gvDetail1.DataKeys[e.RowIndex].Values["SyllabusId"].ToString());
        RecordStatus = Obj_Master.DeleteNews();
        FillSyllabus();
    }
    protected void gvDetail1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {

    }

    protected void gvDetail1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvDetail1.PageIndex = e.NewPageIndex;
        DS = Obj_Master.DisplaySyllabus();
        gvDetail1.DataSource = DS;
        gvDetail1.DataBind();
    }
}