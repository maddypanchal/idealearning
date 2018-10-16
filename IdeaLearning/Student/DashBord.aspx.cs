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


public partial class Student_DashBord : System.Web.UI.Page
{

    #region "Variable Decleration"
    private clsStudent obj_Student = new clsStudent();
    private DataSet DS;
    private int RecordStatus;
    private static int StudentId;
    public int gender;

    #endregion
   
    protected void Page_Load(object sender, EventArgs e)
    {
        //  if (!string.IsNullOrEmpty(Session["USER_NAME"].ToString()))
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
       // StudentId = Convert.ToInt32(Request.QueryString["StudentId"].ToString());
    }

    #region " Fill contorole on Form"
    private void FillStudentInformation()
    {
        obj_Student.StudentId = StudentId;
        DS = obj_Student.DisplayPStudent();
        if (DS.Tables[0].Rows.Count > 0)
        {
            foreach (DataRow row in DS.Tables[0].Rows)
            {
                 txtAddress.Text = "Address : ".ToUpper() + row["Address"].ToString() + "  " + row["CityText"].ToString() + "  " + row["StateText"].ToString() + "  " + row["CountryText"].ToString();
                 txtemail.Text = "EMAIL : ".ToUpper() + row["Email"].ToString();
                 lblSname.Text = "STUDENT NAME : ".ToUpper() + row["StudentName"].ToString();
                 txtClass.Text = "Class Name : ".ToUpper() + row["ClassText"].ToString();
                 Session["ClassId"] = row["ClassId"].ToString();
                 txtCourseDuration.Text = "Course Duration : ".ToUpper() + row["CourseDuration"].ToString();
                 txtDateofBifth.Text = "DATE OF BIRTH : ".ToUpper() + row["DateOfBirth"].ToString();
                 txtDuePayment.Text = "Due Payment : ".ToUpper() + row["DuePayment"].ToString();
                 txtRegistrationNo.Text = "Registration No : ".ToUpper() + row["RegistrationNo"].ToString();
                 txtmobile.Text = "Mobile Number : ".ToUpper() + row["Mobile"].ToString();
                 txtFatherName.Text = "FATHER NAME : ".ToUpper() + row["FatherName"].ToString();
                 txtFatherName.Text = "FATHER Number : ".ToUpper() + row["FatherNumber"].ToString();
                 //lblAlters.Text = "ALERT : ".ToUpper() + row["Alert"].ToString();

                 txtAlert.Text = "ALERT : ".ToUpper() + row["Alert"].ToString();
                 txtRollNo.Text = "Roll Number : ".ToUpper() + row["RollNo"].ToString();
                 txtUserName.Text = "User Name : ".ToUpper() + row["UserName"].ToString();
                 txtRollNo.Text = "RollNo : ".ToUpper() + row["RollNo"].ToString();
                 txtPinCode.Text = "Pin Code : ".ToUpper() + row["PinCode"].ToString();
                 txtDueDate.Text = "Due Date : ".ToUpper() + row["DueDate"].ToString();

                 //txtCorusesOne.Text = "CoursesOne : " + row["CourseOneText"].ToString();

                 if (row["CourseOneText"].ToString() == "" || row["CourseOneText"].ToString() == "--Select--")
                 {
                   //txtCorusesOne.Visible = false;
                 }
                 else
                 {
                     lblCorusesOne.Visible = true;
                  //   txtCorusesOne.Text = "CoursesOne : " + row["CourseOneText"].ToString();
                     lblCorusesOne.Text = "Courses One : " + row["CourseOneText"].ToString();
                 }

                 if (row["CourseTwoText"].ToString() == "" || row["CourseTwoText"].ToString() == "--Select--")
                 {
                    // txtCorusesTwo.Visible = false;
                 }
                 else
                 {
                     lblCorusesTwo.Visible = true;
                   //  txtCorusesTwo.Text = "CoursesTwo : " + row["CourseTwoText"].ToString();
                     lblCorusesTwo.Text = "Courses Two : " + row["CourseTwoText"].ToString();

                 }

                 if (row["CourseThreeText"].ToString() == "" || row["CourseThreeText"].ToString() == "--Select--")
                 {
                   //  txtCorusesThree.Visible = false;
                 }
                 else
                 {
                     lblCorusesThree.Visible = true;
                    // txtCorusesThree.Text = "CoursesThree : " + row["CourseThreeText"].ToString();
                     lblCorusesThree.Text = "Courses Three : " + row["CourseThreeText"].ToString();
                 }


                 if (row["CourseFourText"].ToString() == "" || row["CourseFourText"].ToString() == "--Select--")
                 {
                     //txtCorusesFour.Visible = false;
                 }
                 else
                 {
                     lblCorusesFour.Visible = true;
                   //  txtCorusesFour.Text = " Course Four : " + row["CourseFourText"].ToString();
                     lblCorusesFour.Text = " Course Four : " + row["CourseFourText"].ToString();
                 }

                 // Subject

                 if (row["CourseOneSubjectOneText"].ToString() == "" || row["CourseOneSubjectOneText"].ToString() == "--Select--")
                 {
                    // txtCoOneTextSubjectOneText.Visible = false;
                     lblCoOneTextSubjectOneText.Visible = false;
                 }
                 else
                 {
                   //  txtCoOneTextSubjectOneText.Visible = true;
                   //  txtCoOneTextSubjectOneText.Text = "Subject :" + row["CourseOneSubjectOneText"].ToString();
                     lblCoOneTextSubjectOneText.Visible = true;
                     lblCoOneTextSubjectOneText.Text = "Subject :" + row["CourseOneSubjectOneText"].ToString();
                 }

                 if (row["CourseOneSubjectTwoText"].ToString() == "" || row["CourseOneSubjectTwoText"].ToString() == "--Select--")
                 {
                   //  txtCoOneTextSubjectTwoText.Visible = false;
                     lblCoOneTextSubjectTwoText.Visible = false;
                 }
                 else
                 {
                   //  txtCoOneTextSubjectTwoText.Visible = true;
                    // txtCoOneTextSubjectTwoText.Text = "Subject :" + row["CourseOneSubjectTwoText"].ToString();

                     lblCoOneTextSubjectTwoText.Visible = true;
                     lblCoOneTextSubjectTwoText.Text = "Subject :" + row["CourseOneSubjectTwoText"].ToString();
                 }
                 if (row["CourseOneSubjectThreeText"].ToString() == "" || row["CourseOneSubjectThreeText"].ToString() == "--Select--")
                 {
                    // txtCoOneTextSubjectThreeText.Visible = false;
                     lblCoOneTextSubjectThreeText.Visible = false;
                 }
                 else
                 {
                    // txtCoOneTextSubjectThreeText.Visible = true;
                  //   txtCoOneTextSubjectThreeText.Text = "Subject :" + row["CourseOneSubjectThreeText"].ToString();

                     lblCoOneTextSubjectThreeText.Visible = true;
                     lblCoOneTextSubjectThreeText.Text = "Subject :" + row["CourseOneSubjectThreeText"].ToString();
                 }

                 if (row["CourseOneSubjectFourText"].ToString() == "" || row["CourseOneSubjectFourText"].ToString() == "--Select--")
                 {
                   //  txtCoOneTextSubjectFourText.Visible = false;
                     lblCoOneTextSubjectFourText.Visible = false;
                 }
                 else
                 {
                   //  txtCoOneTextSubjectFourText.Visible = true;
                   //  txtCoOneTextSubjectFourText.Text = "Subject :" + row["CourseOneSubjectFourText"].ToString();
                     lblCoOneTextSubjectFourText.Visible = true;
                     lblCoOneTextSubjectFourText.Text = "Subject :" + row["CourseOneSubjectFourText"].ToString();
                 }


                 if (row["CourseTwoSubjectOneText"].ToString() == "" || row["CourseTwoSubjectOneText"].ToString() == "--Select--")
                 {
                   //  txtCoTwoTextSubjectOneText.Visible = false;
                     lblCoTwoTextSubjectOneText.Visible = false;
                 }
                 else
                 {
                 //    txtCoTwoTextSubjectOneText.Visible = true;
                   //  txtCoTwoTextSubjectOneText.Text = "Subject :" + row["CourseTwoSubjectOneText"].ToString();

                     lblCoTwoTextSubjectOneText.Visible = true;
                     lblCoTwoTextSubjectOneText.Text = "Subject :" + row["CourseTwoSubjectOneText"].ToString();
                 }

                 if (row["CourseTwoSubjectTwoText"].ToString() == "" || row["CourseTwoSubjectTwoText"].ToString() == "--Select--")
                 {
                   //  txtCoTwoTextSubjectTwoText.Visible = false;
                     lblCoTwoTextSubjectTwoText.Visible = false;
                 }
                 else
                 {
                   //  txtCoTwoTextSubjectTwoText.Visible = true;
                  //   txtCoTwoTextSubjectTwoText.Text = "Subject :" + row["CourseTwoSubjectTwoText"].ToString();
                     lblCoTwoTextSubjectTwoText.Visible = true;
                     lblCoTwoTextSubjectTwoText.Text = "Subject :" + row["CourseTwoSubjectTwoText"].ToString();
                 }

                 if (row["CourseTwoSubjectThreeText"].ToString() == "" || row["CourseTwoSubjectThreeText"].ToString() == "--Select--")
                 {
                   //  txtCoTwoTextSubjectThreeText.Visible = false;
                     lblCoTwoTextSubjectThreeText.Visible = false;
                 }
                 else
                 {
                   //  txtCoTwoTextSubjectThreeText.Visible = true;
                   //  txtCoTwoTextSubjectThreeText.Text = "Subject :" + row["CourseTwoSubjectThreeText"].ToString();
                     lblCoTwoTextSubjectThreeText.Visible = true;
                     lblCoTwoTextSubjectThreeText.Text = "Subject :" + row["CourseTwoSubjectThreeText"].ToString();
                 }
                 if (row["CourseTwoSubjectFourText"].ToString() == "" || row["CourseTwoSubjectFourText"].ToString() == "--Select--")
                 {
                    // txtCoTwoTextSubjectFourText.Visible = false;
                     lblCoTwoTextSubjectFourText.Visible = false;
                 }
                 else
                 {
                   //  txtCoTwoTextSubjectFourText.Visible = true;
                   //  txtCoTwoTextSubjectFourText.Text = "Subject :" + row["CourseTwoSubjectFourText"].ToString();
                     lblCoTwoTextSubjectFourText.Visible = true;
                     lblCoTwoTextSubjectFourText.Text = "Subject :" + row["CourseTwoSubjectFourText"].ToString();
                 }

                 if (row["CourseThreeSubjectOneText"].ToString() == "" || row["CourseThreeSubjectOneText"].ToString() == "--Select--")
                 {
                   //  txtCoThreeTextSubjectOneText.Visible = false;
                     lblCoThreeTextSubjectOneText.Visible = false;
                 }
                 else
                 {
                   //  txtCoThreeTextSubjectOneText.Visible = true;
                   //  txtCoThreeTextSubjectOneText.Text = "Subject :" + row["CourseThreeSubjectOneText"].ToString();
                     lblCoThreeTextSubjectOneText.Visible = true;
                     lblCoThreeTextSubjectOneText.Text = "Subject :" + row["CourseThreeSubjectOneText"].ToString();
                 }
                 if (row["CourseThreeSubjectTwoText"].ToString() == "" || row["CourseThreeSubjectTwoText"].ToString() == "--Select--")
                 {
                   //  txtCoThreeTextSubjectTwoText.Visible = false;
                     lblCoThreeTextSubjectTwoText.Visible = false;
                 }
                 else
                 {
                   //  txtCoThreeTextSubjectTwoText.Visible = true;
                   //  txtCoThreeTextSubjectTwoText.Text = "Subject :" + row["CourseThreeSubjectTwoText"].ToString();
                     lblCoThreeTextSubjectTwoText.Visible = true;
                     lblCoThreeTextSubjectTwoText.Text = "Subject :" + row["CourseThreeSubjectTwoText"].ToString();
                 }
                 if (row["CourseThreeSubjectThreeText"].ToString() == "" || row["CourseThreeSubjectThreeText"].ToString() == "--Select--")
                 {
                  //   txtCoThreeTextSubjectThreeText.Visible = false;
                     lblCoThreeTextSubjectThreeText.Visible = false;
                 }
                 else
                 {
                   //  txtCoThreeTextSubjectThreeText.Visible = true;
                  //   txtCoThreeTextSubjectThreeText.Text = "Subject :" + row["CourseThreeSubjectThreeText"].ToString();
                     lblCoThreeTextSubjectThreeText.Visible = true;
                     lblCoThreeTextSubjectThreeText.Text = "Subject :" + row["CourseThreeSubjectThreeText"].ToString();
                 }
                 if (row["CourseThreeSubjectFourText"].ToString() == "" || row["CourseThreeSubjectFourText"].ToString() == "--Select--")
                 {
                   //  txtCoThreeTextSubjectFourText.Visible = false;
                     lblCoThreeTextSubjectFourText.Visible = false;
                 }
                 else
                 {
                   //  txtCoThreeTextSubjectFourText.Visible = true;
                   //  txtCoThreeTextSubjectFourText.Text = "Subject :" + row["CourseThreeSubjectFourText"].ToString();
                     lblCoThreeTextSubjectFourText.Visible = true;
                     lblCoThreeTextSubjectFourText.Text = "Subject :" + row["CourseThreeSubjectFourText"].ToString();

                 }
                 if (row["CourseFourSubjectOneText"].ToString() == "" || row["CourseFourSubjectOneText"].ToString() == "--Select--")
                 {
                    // txtCoFourTextSubjectOneText.Visible = false;
                     lblCoFourTextSubjectOneText.Visible = false;
                 }
                 else
                 {
                   //  txtCoFourTextSubjectOneText.Visible = true;
                  //   txtCoFourTextSubjectOneText.Text = "Subject :" + row["CourseFourSubjectOneText"].ToString();
                     lblCoFourTextSubjectOneText.Visible = true;
                     lblCoFourTextSubjectOneText.Text = "Subject :" + row["CourseFourSubjectOneText"].ToString();
                 }
                 if (row["CourseFourSubjectTwoText"].ToString() == "" || row["CourseFourSubjectTwoText"].ToString() == "--Select--")
                 {
                    // txtCoFourTextSubjectTwoText.Visible = false;
                     lblCoFourTextSubjectTwoText.Visible = false;
                 }
                 else
                 {
                   //  txtCoFourTextSubjectTwoText.Visible = true;
                   //  txtCoFourTextSubjectTwoText.Text = "Subject :" + row["CourseFourSubjectTwoText"].ToString();
                     lblCoFourTextSubjectTwoText.Visible = true;
                     lblCoFourTextSubjectTwoText.Text = "Subject :" + row["CourseFourSubjectTwoText"].ToString();
                 }
                 if (row["CourseFourSubjectThreeText"].ToString() == "" || row["CourseFourSubjectThreeText"].ToString() == "--Select--")
                 {
                   //  txtCoFourTextSubjectThreeText.Visible = false;
                     lblCoFourTextSubjectThreeText.Visible = false;
                 }
                 else
                 {
                    //  txtCoFourTextSubjectThreeText.Visible = true;
                    //  txtCoFourTextSubjectThreeText.Text = "Subject :" + row["CourseFourSubjectThreeText"].ToString();
                     lblCoFourTextSubjectThreeText.Visible = true;
                     lblCoFourTextSubjectThreeText.Text = "Subject :" + row["CourseFourSubjectThreeText"].ToString();
                 }
                 if (row["CourseFourSubjectFourText"].ToString() == "" || row["CourseFourSubjectFourText"].ToString() == "--Select--")
                 {
                    // txtCoFourTextSubjectFourText.Visible = false;
                     lblCoFourTextSubjectFourText.Visible = false;
                 }
                 else
                 {
                   //  txtCoFourTextSubjectFourText.Visible = true;
                   //  txtCoFourTextSubjectFourText.Text = "Subject :"  +  row["CourseFourSubjectFourText"].ToString();
                     lblCoFourTextSubjectFourText.Visible = true;
                     lblCoFourTextSubjectFourText.Text = "Subject :" + row["CourseFourSubjectFourText"].ToString();

                 }




                               
                txtDateOfRegistration.Text = "Date Of Registration : ".ToUpper() + row["DateOfRegistration"].ToString(); 
                gender = Convert.ToInt32(row["Gender"].ToString());
                if (gender == 1)
                {
                    txtGender.Text = "Gender : ".ToUpper() + "Male";
                }
                else if (gender == 2)
                {
                    txtGender.Text = "Gender : ".ToUpper() + "Female";
                }
                if (row["CateGory"].ToString() == "1")
                {
                    txtCateGory.Text = "CateGory : ".ToUpper() + "Gen";
                }
                else if (row["CateGory"].ToString() == "2")
                {
                    txtCateGory.Text = "CateGory : ".ToUpper() + "OBC";
                }
                else if (row["CateGory"].ToString() == "3")
                {
                    txtCateGory.Text = "CateGory : ".ToUpper() + "SC";
                }
                else if (row["CateGory"].ToString() == "4")
                {
                    txtCateGory.Text = "CateGory : ".ToUpper() + "ST";
                }
                else if (row["CateGory"].ToString() == "5")
                {
                    txtCateGory.Text = "CateGory : ".ToUpper() + "Other";
                }


                txtStudentName.Text = "STUDENT NAME : ".ToUpper() + row["StudentName"].ToString();
           
                if (row["UploadImages"].ToString() == "")
                {
                    imgUser.ImageUrl = "../UploadedFile/Defultuser.png";
                }
                else
                {
                    imgUser.ImageUrl = "../CroppedImages/" + row["UploadImages"].ToString();
                }

                if (row["IsActive"].ToString() == "True")
                {
                    txtStatus.Text = "Status : ".ToUpper() + "Active";
                }
                else
                {
                    txtStatus.Text = "Status : ".ToUpper() + "InActive";
                }
            }
        }

    }
    #endregion "End Fill contorole on Form"
    
}