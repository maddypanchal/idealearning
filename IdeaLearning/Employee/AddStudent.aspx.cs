using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccess;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.IO;
using BusinessLogic.Admin;
using System.Configuration;


public partial class Employee_AddStudent : System.Web.UI.Page
{
    #region"Variable Declaration"
    // private clsEmployee  = new clsEmployee();
    private clsMaster obj_Master = new clsMaster();
    private clsStudent obj_Student = new clsStudent();
    private DataSet DS;
    private DataSet DS_Two;
    private DataSet DS_Three;
    private DataSet DS_Four;
    private int checkRecordStatus;
    private string myFileExtension;
    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            FillClass();
            FillCountryStateDropDown();
        }
    }

    #region"Class dropdown Slect index changed "
    protected void ddlClass_SelectedIndexChanged(object sender, EventArgs e)
    {
        FillClassCourses();
    }
    #endregion

    #region"Fill Subject by Class"
    private void FillClassCourses()
    {
        try
        {
            obj_Master.ClassId = Convert.ToInt32(ddlClass.SelectedValue.ToString());
            DS = obj_Master.FillClassCoursesDdl();
            ddlCourselist.DataSource = DS;

            DS.Tables[0].Merge(DS.Tables[1]);

            ddlCourselist.DataTextField = DS.Tables[0].Columns[1].ToString();
            ddlCourselist.DataValueField = DS.Tables[0].Columns[0].ToString();
            ddlCourselist.DataBind();
            ddlCourselist.Dispose();



            ddlCourselistSecond.DataSource = DS;
            ddlCourselistSecond.DataTextField = DS.Tables[0].Columns[1].ToString();
            ddlCourselistSecond.DataValueField = DS.Tables[0].Columns[0].ToString();
            ddlCourselistSecond.DataBind();
            ddlCourselistSecond.Dispose();

            ddlCourse_Third.DataSource = DS;
            ddlCourse_Third.DataTextField = DS.Tables[0].Columns[1].ToString();
            ddlCourse_Third.DataValueField = DS.Tables[0].Columns[0].ToString();
            ddlCourse_Third.DataBind();
            ddlCourse_Third.Dispose();

            ddlCourse_fourth.DataSource = DS;
            ddlCourse_fourth.DataTextField = DS.Tables[0].Columns[1].ToString();
            ddlCourse_fourth.DataValueField = DS.Tables[0].Columns[0].ToString();
            ddlCourse_fourth.DataBind();
            ddlCourse_fourth.Dispose();

        }
        catch (Exception ex)
        {
            lblMsg.Text = ex.ToString();
        }
    }
    #endregion

    #region "FILL country ddl in region"
    protected void FillCountryStateDropDown()
    {
        try
        {

            DS = obj_Master.CountryListDropdown();
            ddlCountryRegion.DataSource = DS;
            DS.Tables[0].Merge(DS.Tables[1]);
            ddlCountryRegion.DataTextField = DS.Tables[0].Columns[1].ToString();
            ddlCountryRegion.DataValueField = DS.Tables[0].Columns[0].ToString();
            ddlCountryRegion.DataBind();
            ddlCountryRegion.Dispose();
        }
        catch (Exception ex)
        {
            lblMsg.Text = ex.ToString();
        }
    }

    #endregion

    #region "FILL state ddl in region"
    protected void FillCountryStateDropDown1()
    {
        try
        {
            obj_Master.CountryId = Convert.ToInt32(ddlCountryRegion.SelectedValue);
            DS = obj_Master.StateListDropdown1();
            ddlStateRegion.DataSource = DS;
            DS.Tables[0].Merge(DS.Tables[1]);
            ddlStateRegion.DataTextField = DS.Tables[0].Columns[1].ToString();
            ddlStateRegion.DataValueField = DS.Tables[0].Columns[0].ToString();
            ddlStateRegion.DataBind();
            ddlStateRegion.Dispose();
        }
        catch (Exception ex)
        {
            lblMsg.Text = ex.ToString();
        }
    }
    #endregion

    #region "Country select index changed"
    protected void ddlCountryRegion_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            obj_Master.CountryId = Convert.ToInt32(ddlCountryRegion.SelectedValue);
            FillCountryStateDropDown1();
            ddlStateRegion.Visible = true;
            ddlStateRegion.DataBind();
        }
        catch (Exception ex)
        {
            lblMsg.Text = ex.Message;
        }
    }

    #endregion

    #region"Btn Event "
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {


            myFileExtension = Path.GetExtension(FileUploadOnLocalComputer.PostedFile.FileName);
            if (FileUploadOnLocalComputer.HasFile)
            {
                if (myFileExtension == ".jpg" || myFileExtension == ".bmp" || myFileExtension == ".png" || myFileExtension == ".jpeg" || myFileExtension == ".JPG" || myFileExtension == ".gif")
                {
                    if (FileUploadOnLocalComputer.PostedFile.ContentLength < 2000000)
                    {
                        string FileNamekey = DateTime.Now.Ticks.ToString().Substring(12) + ".jpg";
                        FileUploadOnLocalComputer.SaveAs(MapPath("~/CroppedImages/" + "Photo-" + FileNamekey));
                        //System.Drawing.Image ImgOriginal = System.Drawing.Image.FromFile(MapPath("~/Employee/Toppers/") + "GA-" + FileNamekey);
                        //System.Drawing.Image imgMain = ImgOriginal.GetThumbnailImage(570, 396, null, IntPtr.Zero);
                        //imgMain.Save(MapPath("~/CroppedImages/") + "GA-" + FileNamekey);
                        //Thumb Nail Genrator Coded By Rakesh Panchal
                        obj_Student.UploadImages = Path.GetFileName("Photo-" + FileNamekey);



                    }
                }
            }


            // obj_Student.UploadImages = Session["ImagesName"].ToString();
            obj_Student.Address = txtaddress.Text.Trim();
            obj_Student.DateOfBirth = txtDateOfBirth.Text.Trim();
            obj_Student.Email = txtEmail.Text.Trim();
            obj_Student.StudentName = txtStudentName.Text.Trim();
            obj_Student.FatherName = txtFatherName.Text.Trim();
            obj_Student.FatherNumber = txtFatherNumber.Text.Trim();
            obj_Student.Mobile = txtMobile.Text.Trim();
            obj_Student.Status = 1;
            obj_Student.Password = txtPassword.Text.Trim();
            obj_Student.UserName = txtUserName.Text.Trim();
            obj_Student.RegistrationNo = ConfigurationManager.AppSettings["RegNoGen"];

            obj_Student.DateofRegistration = txtDateOfReg.Text.Trim();
            obj_Student.RollNo = txtRollNo.Text.Trim();


            obj_Student.Gender = ddlGender.SelectedValue.ToString();
            obj_Student.CateGory = ddlCategory.SelectedValue.ToString();

            obj_Student.Country = ddlCountryRegion.SelectedValue.ToString();
            obj_Student.ClassId = Convert.ToInt32(ddlClass.SelectedValue.ToString());
            obj_Student.City = ddlCity.SelectedValue.ToString();
            obj_Student.State = ddlStateRegion.SelectedValue.ToString();
            obj_Student.CourseOne = ddlCourselist.SelectedValue.ToString();
            obj_Student.CourseTwo = ddlCourselistSecond.SelectedValue.ToString();
            if (obj_Student.CourseTwo == "--Select--")
            {
                obj_Student.CourseTwo = "-1";
            }
            obj_Student.CourseThree = ddlCourse_Third.SelectedValue.ToString();
            if (obj_Student.CourseThree == "--Select--")
            {
                obj_Student.CourseThree = "-1";
            }
            obj_Student.CourseFour = ddlCourse_fourth.SelectedValue.ToString();
            if (obj_Student.CourseFour == "--Select--")
            {
                obj_Student.CourseFour = "-1";
            }

            obj_Student.CourseOneSubjectOne = ddlSubject.SelectedValue.ToString();
            obj_Student.CourseOneSubjectTwo = ddlSubjectTwo.SelectedValue.ToString();
            obj_Student.CourseOneSubjectThree = ddlSubjetThree.SelectedValue.ToString();
            obj_Student.CourseOneSubjectFour = ddlSubjectFour.SelectedValue.ToString();

            obj_Student.CourseTwoSubjectOne = ddlCourse_Second_Subject_Frist.SelectedValue.ToString();
            if (obj_Student.CourseTwoSubjectOne == "--Select--")
            {
                obj_Student.CourseTwoSubjectOne = "-1";
            }
            obj_Student.CourseTwoSubjectTwo = ddlCourse_Second_Subject_Second.SelectedValue.ToString();
            if (obj_Student.CourseTwoSubjectTwo == "--Select--")
            {
                obj_Student.CourseTwoSubjectTwo = "-1";
            }
            obj_Student.CourseTwoSubjectThree = ddlCourse_Second_Subject_third.SelectedValue.ToString();
            if (obj_Student.CourseTwoSubjectThree == "--Select--")
            {
                obj_Student.CourseTwoSubjectThree = "-1";
            }
            obj_Student.CourseTwoSubjectFour = ddlCourse_Second_Subject_Forth.SelectedValue.ToString();
            if (obj_Student.CourseTwoSubjectFour == "--Select--")
            {
                obj_Student.CourseTwoSubjectFour = "-1";
            }
            obj_Student.CourseThreeSubjectOne = ddlCourse_Third_Subject_Frist.SelectedValue.ToString();
            if (obj_Student.CourseThreeSubjectOne == "--Select--")
            {
                obj_Student.CourseThreeSubjectOne = "-1";
            }
            obj_Student.CourseThreeSubjectTwo = ddlCourse_Third_Subject_Second.SelectedValue.ToString();
            if (obj_Student.CourseThreeSubjectTwo == "--Select--")
            {
                obj_Student.CourseThreeSubjectTwo = "-1";
            }
            obj_Student.CourseThreeSubjectThree = ddlCourse_Third_Subject_Third.SelectedValue.ToString();
            if (obj_Student.CourseThreeSubjectThree == "--Select--")
            {
                obj_Student.CourseThreeSubjectThree = "-1";
            }

            obj_Student.CourseThreeSubjectFour = ddlCourse_Third_Subject_fourth.SelectedValue.ToString();
            if (obj_Student.CourseThreeSubjectFour == "--Select--")
            {
                obj_Student.CourseThreeSubjectFour = "-1";
            }
            obj_Student.CourseFourSubjectOne = ddlCourse_fourth_Subject_frist.SelectedValue.ToString();
            if (obj_Student.CourseFourSubjectOne == "--Select--")
            {
                obj_Student.CourseFourSubjectOne = "-1";
            }
            obj_Student.CourseFourSubjectTwo = ddlCourse_fourth_Subject_Second.SelectedValue.ToString();
            if (obj_Student.CourseFourSubjectTwo == "--Select--")
            {
                obj_Student.CourseFourSubjectTwo = "-1";
            }
            obj_Student.CourseFourSubjectThree = ddlCourse_fourth_Subject_Third.SelectedValue.ToString();
            if (obj_Student.CourseFourSubjectThree == "--Select--")
            {
                obj_Student.CourseFourSubjectThree = "-1";
            }
            obj_Student.CourseFourSubjectFour = ddlCourse_fourth_Subject_Fourth.SelectedValue.ToString();
            if (obj_Student.CourseFourSubjectFour == "--Select--")
            {
                obj_Student.CourseFourSubjectFour = "-1";
            }

            obj_Student.CountryText = ddlCountryRegion.SelectedItem.ToString();
            obj_Student.ClassText = ddlClass.SelectedItem.ToString();
            obj_Student.CityText = ddlCity.SelectedItem.ToString();
            obj_Student.StateText = ddlStateRegion.SelectedItem.ToString();
            obj_Student.CourseOneText = ddlCourselist.SelectedItem.ToString();
            obj_Student.CourseTwoText = ddlCourselistSecond.SelectedItem.ToString();
            obj_Student.CourseThreeText = ddlCourse_Third.SelectedItem.ToString();
            obj_Student.CourseFourText = ddlCourse_fourth.SelectedItem.ToString();
            obj_Student.CourseOneSubjectOneText = ddlSubject.SelectedItem.ToString();
            obj_Student.CourseOneSubjectTwoText = ddlSubjectTwo.SelectedItem.ToString();
            obj_Student.CourseOneSubjectThreeText = ddlSubjetThree.SelectedItem.ToString();
            obj_Student.CourseOneSubjectFourText = ddlSubjectFour.SelectedItem.ToString();

            obj_Student.CourseTwoSubjectOneText = ddlCourse_Second_Subject_Frist.SelectedItem.ToString();
            obj_Student.CourseTwoSubjectTwoText = ddlCourse_Second_Subject_Second.SelectedItem.ToString();
            obj_Student.CourseTwoSubjectThreeText = ddlCourse_Second_Subject_third.SelectedItem.ToString();
            obj_Student.CourseTwoSubjectFourText = ddlCourse_Second_Subject_Forth.SelectedItem.ToString();

            obj_Student.CourseThreeSubjectOneText = ddlCourse_Third_Subject_Frist.SelectedItem.ToString();
            obj_Student.CourseThreeSubjectTwoText = ddlCourse_Third_Subject_Second.SelectedItem.ToString();
            obj_Student.CourseThreeSubjectThreeText = ddlCourse_Third_Subject_Third.SelectedItem.ToString();
            obj_Student.CourseThreeSubjectFourText = ddlCourse_Third_Subject_fourth.SelectedItem.ToString();

            obj_Student.CourseFourSubjectOneText = ddlCourse_fourth_Subject_frist.SelectedItem.ToString();
            obj_Student.CourseFourSubjectTwoText = ddlCourse_fourth_Subject_Second.SelectedItem.ToString();
            obj_Student.CourseFourSubjectThreeText = ddlCourse_fourth_Subject_Third.SelectedItem.ToString();
            obj_Student.CourseFourSubjectFourText = ddlCourse_fourth_Subject_Fourth.SelectedItem.ToString();

            obj_Student.CourseDuration = txtCourseDuration.Text.Trim();
            obj_Student.Alert = txtAlert.Text;
            obj_Student.DueDate = txtDueDate.Text;
            obj_Student.DuePayment = txtDuepayment.Text;
            obj_Student.PinCode = txtPinCode.Text.Trim();
            checkRecordStatus = obj_Student.AddStudent();

            if (checkRecordStatus > 0)
            {
                ScriptManager.RegisterStartupScript(this.Page, typeof(string), "Alert", "alert('Record Saved!');", true);
                clearform();
            }
            if (checkRecordStatus == 0)
            {
                ScriptManager.RegisterStartupScript(this.Page, typeof(string), "Alert", "alert('Registrations No is Exists!');", true);
            }

        }
        catch (Exception ex)
        {
            lblMsg.Text = ex.ToString();
        }
        if (checkRecordStatus == 1)
        {
            lblMsg.Text = "Record Saved";
        }
        // clearform();
    }
    private void clearform()
    {
        txtCourseDuration.Text = "";
        txtDateOfReg.Text = "";
        txtPinCode.Text = "";
        txtFatherNumber.Text = "";
        //txtRegistrations.Text = "";
        txtaddress.Text = "";
        txtConfirmPasword.Text = "";
        txtDateOfBirth.Text = "";
        txtEmail.Text = "";
        txtStudentName.Text = "";
        txtFatherName.Text = "";
        txtMobile.Text = "";
        txtPassword.Text = "";
        txtAlert.Text = "";
        txtUserName.Text = "";
        txtDueDate.Text = "";
        txtDuepayment.Text = "";
        txtRollNo.Text = "";
        txtStudentName.Text = "";
        txtUserName.Text = "";
        ddlCategory.SelectedValue = "-1";
        ddlCity.SelectedValue = "-1";
        ddlCountryRegion.SelectedValue = "-1";
        ddlGender.SelectedIndex = -1;
        ddlStateRegion.SelectedIndex = -1;
        ddlSubject.SelectedIndex = -1;
        ddlClass.SelectedValue = "-1";
        ddlCourse_fourth.SelectedValue = "-1";
        ddlCourse_fourth_Subject_Fourth.SelectedValue = "-1";
        ddlCourse_fourth_Subject_frist.SelectedValue = "-1";
        ddlCourse_fourth_Subject_Second.SelectedValue = "-1";
        ddlCourse_fourth_Subject_Third.SelectedValue = "-1";
        ddlCourse_Second_Subject_Forth.SelectedValue = "-1";
        ddlCourse_Second_Subject_Frist.SelectedValue = "-1";
        ddlCourse_Second_Subject_Second.SelectedValue = "-1";
        ddlCourse_Second_Subject_third.SelectedValue = "-1";
        ddlCourse_Third.SelectedValue = "-1";
        ddlCourse_Third_Subject_fourth.SelectedValue = "-1";
        ddlCourse_Third_Subject_Frist.SelectedValue = "-1";
        ddlCourse_Third_Subject_Second.SelectedValue = "-1";
        ddlCourse_Third_Subject_Third.SelectedValue = "-1";
        ddlCourselist.SelectedValue = "-1";
        ddlCourselistSecond.SelectedValue = "-1";
        ddlSubjectFour.SelectedValue = "-1";
        ddlSubjectTwo.SelectedValue = "-1";
        ddlSubjetThree.SelectedValue = "-1";

        //lblmsg.Text = "Record Save";
    }
    #endregion

    #region "Fill FillClass"
    protected void FillClass()
    {
        try
        {
            DS = obj_Master.FillClassDdl();
            ddlClass.DataSource = DS;
            DS.Tables[0].Merge(DS.Tables[1]);
            ddlClass.DataTextField = DS.Tables[0].Columns[1].ToString();
            ddlClass.DataValueField = DS.Tables[0].Columns[0].ToString();
            ddlClass.DataBind();
            ddlClass.Dispose();
        }
        catch (Exception ex)
        {
            lblMsg.Text = ex.ToString();
        }
    }
    #endregion

    #region"Fill City by country and State"
    protected void ddlStateRegion_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            obj_Master.CountryId = Convert.ToInt32(ddlCountryRegion.SelectedValue);
            obj_Master.StateId = Convert.ToInt32(ddlStateRegion.SelectedValue);
            FillCountryCity();
            ddlCity.Visible = true;
            ddlCity.DataBind();
        }
        catch (Exception ex)
        {
            lblMsg.Text = ex.Message;
        }
    }
    #endregion

    #region "FILL state ddl in region"
    protected void FillCountryCity()
    {
        try
        {
            obj_Master.CountryId = Convert.ToInt32(ddlCountryRegion.SelectedValue);
            obj_Master.StateId = Convert.ToInt32(ddlStateRegion.SelectedValue);
            DS = obj_Master.CityList();
            ddlCity.DataSource = DS;
            DS.Tables[0].Merge(DS.Tables[1]);
            ddlCity.DataTextField = DS.Tables[0].Columns[1].ToString();
            ddlCity.DataValueField = DS.Tables[0].Columns[0].ToString();
            ddlCity.DataBind();
            ddlCity.Dispose();
        }
        catch (Exception ex)
        {
            //lblBatch.Text = ex.ToString(); 
        }

    }

    #endregion

    #region"Class dropdown Slect index changed "
    protected void ddlCourseList_SelectedIndexChanged(object sender, EventArgs e)
    {

        FillSubjectFrist();
    }
    protected void ddlCourselistSecond_SelectedIndexChanged(object sender, EventArgs e)
    {

        FillSubjectSecond();
    }
    protected void ddlCourse_Third_SelectedIndexChanged(object sender, EventArgs e)
    {

        FillSubjectThird();
    }

    protected void ddlCourse_fourth_SelectedIndexChanged(object sender, EventArgs e)
    {
        FillSubjectFourth();
    }
    #endregion

    #region"Fill Subject by Class"
    private void FillSubjectFrist()
    {
        try
        {
            obj_Master.ClassId = Convert.ToInt32(ddlClass.SelectedValue.ToString());
            obj_Master.ClassCoursesId = Convert.ToInt32(ddlCourselist.SelectedValue.ToString());
            DS = obj_Master.FillSubjectCourses();
            ddlSubject.DataSource = DS;

            DS.Tables[0].Merge(DS.Tables[1]);
            ddlSubject.DataTextField = DS.Tables[0].Columns[1].ToString();
            ddlSubject.DataValueField = DS.Tables[0].Columns[0].ToString();
            ddlSubject.DataBind();
            ddlSubject.Dispose();

            ddlSubjectTwo.DataSource = DS;

            ddlSubjectTwo.DataTextField = DS.Tables[0].Columns[1].ToString();
            ddlSubjectTwo.DataValueField = DS.Tables[0].Columns[0].ToString();
            ddlSubjectTwo.DataBind();
            ddlSubjectTwo.Dispose();

            ddlSubjetThree.DataSource = DS;

            ddlSubjetThree.DataTextField = DS.Tables[0].Columns[1].ToString();
            ddlSubjetThree.DataValueField = DS.Tables[0].Columns[0].ToString();
            ddlSubjetThree.DataBind();
            ddlSubjetThree.Dispose();

            ddlSubjectFour.DataSource = DS;

            ddlSubjectFour.DataTextField = DS.Tables[0].Columns[1].ToString();
            ddlSubjectFour.DataValueField = DS.Tables[0].Columns[0].ToString();
            ddlSubjectFour.DataBind();
            ddlSubjectFour.Dispose();
        }
        catch (Exception ex)
        {
            lblMsg.Text = ex.ToString();
        }
    }

    private void FillSubjectSecond()
    {
        try
        {
            obj_Master.ClassId = Convert.ToInt32(ddlClass.SelectedValue.ToString());
            obj_Master.ClassCoursesId = Convert.ToInt32(ddlCourselistSecond.SelectedValue.ToString());
            DS_Two = obj_Master.FillSubjectCourses();
            ddlCourse_Second_Subject_Frist.DataSource = DS_Two;

            DS_Two.Tables[0].Merge(DS_Two.Tables[1]);
            ddlCourse_Second_Subject_Frist.DataTextField = DS_Two.Tables[0].Columns[1].ToString();
            ddlCourse_Second_Subject_Frist.DataValueField = DS_Two.Tables[0].Columns[0].ToString();
            ddlCourse_Second_Subject_Frist.DataBind();
            ddlCourse_Second_Subject_Frist.Dispose();

            ddlCourse_Second_Subject_Second.DataSource = DS_Two;
            ddlCourse_Second_Subject_Second.DataTextField = DS_Two.Tables[0].Columns[1].ToString();
            ddlCourse_Second_Subject_Second.DataValueField = DS_Two.Tables[0].Columns[0].ToString();
            ddlCourse_Second_Subject_Second.DataBind();
            ddlCourse_Second_Subject_Second.Dispose();

            ddlCourse_Second_Subject_third.DataSource = DS_Two;

            ddlCourse_Second_Subject_third.DataTextField = DS_Two.Tables[0].Columns[1].ToString();
            ddlCourse_Second_Subject_third.DataValueField = DS_Two.Tables[0].Columns[0].ToString();
            ddlCourse_Second_Subject_third.DataBind();
            ddlCourse_Second_Subject_third.Dispose();

            ddlCourse_Second_Subject_Forth.DataSource = DS_Two;

            ddlCourse_Second_Subject_Forth.DataTextField = DS_Two.Tables[0].Columns[1].ToString();
            ddlCourse_Second_Subject_Forth.DataValueField = DS_Two.Tables[0].Columns[0].ToString();
            ddlCourse_Second_Subject_Forth.DataBind();
            ddlCourse_Second_Subject_Forth.Dispose();
        }
        catch (Exception ex)
        {
            lblMsg.Text = ex.ToString();
        }
    }

    private void FillSubjectThird()
    {
        try
        {
            obj_Master.ClassId = Convert.ToInt32(ddlClass.SelectedValue.ToString());
            obj_Master.ClassCoursesId = Convert.ToInt32(ddlCourse_Third.SelectedValue.ToString());
            DS_Three = obj_Master.FillSubjectCourses();
            ddlCourse_Third_Subject_Frist.DataSource = DS_Three;

            DS_Three.Tables[0].Merge(DS_Three.Tables[1]);
            ddlCourse_Third_Subject_Frist.DataTextField = DS_Three.Tables[0].Columns[1].ToString();
            ddlCourse_Third_Subject_Frist.DataValueField = DS_Three.Tables[0].Columns[0].ToString();
            ddlCourse_Third_Subject_Frist.DataBind();
            ddlCourse_Third_Subject_Frist.Dispose();

            ddlCourse_Third_Subject_Second.DataSource = DS_Three;

            ddlCourse_Third_Subject_Second.DataTextField = DS_Three.Tables[0].Columns[1].ToString();
            ddlCourse_Third_Subject_Second.DataValueField = DS_Three.Tables[0].Columns[0].ToString();
            ddlCourse_Third_Subject_Second.DataBind();
            ddlCourse_Third_Subject_Second.Dispose();

            ddlCourse_Third_Subject_Third.DataSource = DS_Three;

            ddlCourse_Third_Subject_Third.DataTextField = DS_Three.Tables[0].Columns[1].ToString();
            ddlCourse_Third_Subject_Third.DataValueField = DS_Three.Tables[0].Columns[0].ToString();
            ddlCourse_Third_Subject_Third.DataBind();
            ddlCourse_Third_Subject_Third.Dispose();

            ddlCourse_Third_Subject_fourth.DataSource = DS_Three;

            ddlCourse_Third_Subject_fourth.DataTextField = DS_Three.Tables[0].Columns[1].ToString();
            ddlCourse_Third_Subject_fourth.DataValueField = DS_Three.Tables[0].Columns[0].ToString();
            ddlCourse_Third_Subject_fourth.DataBind();
            ddlCourse_Third_Subject_fourth.Dispose();
        }
        catch (Exception ex)
        {
            lblMsg.Text = ex.ToString();
        }
    }

    private void FillSubjectFourth()
    {
        try
        {
            obj_Master.ClassId = Convert.ToInt32(ddlClass.SelectedValue.ToString());
            obj_Master.ClassCoursesId = Convert.ToInt32(ddlCourse_fourth.SelectedValue.ToString());
            DS_Four = obj_Master.FillSubjectCourses();
            ddlCourse_fourth_Subject_frist.DataSource = DS_Four;

            DS_Four.Tables[0].Merge(DS_Four.Tables[1]);
            ddlCourse_fourth_Subject_frist.DataTextField = DS_Four.Tables[0].Columns[1].ToString();
            ddlCourse_fourth_Subject_frist.DataValueField = DS_Four.Tables[0].Columns[0].ToString();
            ddlCourse_fourth_Subject_frist.DataBind();
            ddlCourse_fourth_Subject_frist.Dispose();

            ddlCourse_fourth_Subject_Second.DataSource = DS_Four;

            ddlCourse_fourth_Subject_Second.DataTextField = DS_Four.Tables[0].Columns[1].ToString();
            ddlCourse_fourth_Subject_Second.DataValueField = DS_Four.Tables[0].Columns[0].ToString();
            ddlCourse_fourth_Subject_Second.DataBind();
            ddlCourse_fourth_Subject_Second.Dispose();

            ddlCourse_fourth_Subject_Third.DataSource = DS_Four;

            ddlCourse_fourth_Subject_Third.DataTextField = DS_Four.Tables[0].Columns[1].ToString();
            ddlCourse_fourth_Subject_Third.DataValueField = DS_Four.Tables[0].Columns[0].ToString();
            ddlCourse_fourth_Subject_Third.DataBind();
            ddlCourse_fourth_Subject_Third.Dispose();

            ddlCourse_fourth_Subject_Fourth.DataSource = DS_Four;

            ddlCourse_fourth_Subject_Fourth.DataTextField = DS_Four.Tables[0].Columns[1].ToString();
            ddlCourse_fourth_Subject_Fourth.DataValueField = DS_Four.Tables[0].Columns[0].ToString();
            ddlCourse_fourth_Subject_Fourth.DataBind();
            ddlCourse_fourth_Subject_Fourth.Dispose();
        }
        catch (Exception ex)
        {
            lblMsg.Text = ex.ToString();
        }
    }
    #endregion

}