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

public partial class Employee_ShowStudentDetails : System.Web.UI.Page
{
    #region "Variable Decleration"
    private clsStudent obj_Student = new clsStudent();
    private clsMaster obj_Master = new clsMaster();
    private DataSet DS;
    private DataSet DS_Two;
    private DataSet DS_Three;
    private DataSet DS_Four;
    private static int CoursesOne;
    private static int CoursesTwo;
    private static int CoursesThree;
    private static int CoursesFour;
    private static int StateId;
    private static int StudentId;
    private static string ClassId;
    private string myFileExtension;

    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {
        StudentId = int.Parse(Request.QueryString["Sid"]);
        Session["StudentId"] = StudentId;

        if (!IsPostBack)
        {
            FillClass();
            FillCountryStateDropDown();
            FillStudentInformation();
        }
    }

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
            CoursesOne = Convert.ToInt32(Session["CourseOne"]);
            CoursesTwo = Convert.ToInt32(Session["CourseTwo"]);
            CoursesThree = Convert.ToInt32(Session["CourseThree"]);
            CoursesFour = Convert.ToInt32(Session["CourseFour"]);

            obj_Master.ClassId = Convert.ToInt32(ddlClass.SelectedValue.ToString());
            DS = obj_Master.FillClassCoursesDdl();
            ClassId = obj_Master.ClassId.ToString();

            if (CoursesOne == -1)
            {
                ddlCourselist.DataSource = DS;
                DS.Tables[0].Merge(DS.Tables[1]);
                ddlCourselist.DataTextField = DS.Tables[0].Columns[1].ToString();
                ddlCourselist.DataValueField = DS.Tables[0].Columns[0].ToString();
                ddlCourselist.DataBind();
                ddlCourselist.Dispose();
            }
            else
            {
                obj_Master.ClassId = obj_Master.ClassId;
                obj_Master.ClassCoursesId = CoursesOne;
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

                ddlSubject.SelectedValue = Session["CourseOneSubjectOne"].ToString();
                ddlSubjectTwo.SelectedValue = Session["CourseOneSubjectTwo"].ToString();
                ddlSubjetThree.SelectedValue = Session["CourseOneSubjectThree"].ToString();
                ddlSubjectFour.SelectedValue = Session["CourseOneSubjectFour"].ToString();


                ddlCourselist.SelectedValue = CoursesOne.ToString();

            }
            //Courses Two 

            if (CoursesTwo == -1)
            {
                ddlCourselistSecond.DataSource = DS;
                ddlCourselistSecond.DataTextField = DS.Tables[0].Columns[1].ToString();
                ddlCourselistSecond.DataValueField = DS.Tables[0].Columns[0].ToString();
                ddlCourselistSecond.DataBind();
                ddlCourselistSecond.Dispose();
            }
            else
            {
                obj_Master.ClassId = Convert.ToInt32(ClassId);
                obj_Master.ClassCoursesId = Convert.ToInt32(CoursesTwo);
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

                ddlCourse_Second_Subject_Frist.SelectedValue = Session["CourseTwoSubjectOne"].ToString();
                ddlCourse_Second_Subject_Second.SelectedValue = Session["CourseTwoSubjectTwo"].ToString();
                ddlCourse_Second_Subject_third.SelectedValue = Session["CourseTwoSubjectThree"].ToString();
                ddlCourse_Second_Subject_Forth.SelectedValue = Session["CourseTwoSubjectFour"].ToString();

                ddlCourselistSecond.SelectedValue = CoursesTwo.ToString();

            }

            //Courses Three

            if (CoursesThree == -1)
            {
                ddlCourse_Third.DataSource = DS;
                ddlCourse_Third.DataTextField = DS.Tables[0].Columns[1].ToString();
                ddlCourse_Third.DataValueField = DS.Tables[0].Columns[0].ToString();
                ddlCourse_Third.DataBind();
                ddlCourse_Third.Dispose();
            }
            else
            {
                obj_Master.ClassId = Convert.ToInt32(ClassId);
                obj_Master.ClassCoursesId = Convert.ToInt32(CoursesThree);
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

                ddlCourse_Third_Subject_Frist.SelectedValue = Session["CourseThreeSubjectOne"].ToString();
                ddlCourse_Third_Subject_Second.SelectedValue = Session["CourseThreeSubjectTwo"].ToString();
                ddlCourse_Third_Subject_Third.SelectedValue = Session["CourseThreeSubjectThree"].ToString();
                ddlCourse_Third_Subject_fourth.SelectedValue = Session["CourseThreeSubjectFour"].ToString();

                ddlCourse_Third.SelectedValue = CoursesThree.ToString();
            }

            if (CoursesFour == -1)
            {
                ddlCourse_fourth.DataSource = DS;
                ddlCourse_fourth.DataTextField = DS.Tables[0].Columns[1].ToString();
                ddlCourse_fourth.DataValueField = DS.Tables[0].Columns[0].ToString();
                ddlCourse_fourth.DataBind();
                ddlCourse_fourth.Dispose();
            }
            else
            {
                obj_Master.ClassId = Convert.ToInt32(ClassId);
                obj_Master.ClassCoursesId = Convert.ToInt32(CoursesFour);
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

                ddlCourse_fourth_Subject_frist.SelectedValue = Session["CourseFourSubjectOne"].ToString();
                ddlCourse_fourth_Subject_Second.SelectedValue = Session["CourseFourSubjectTwo"].ToString();
                ddlCourse_fourth_Subject_Third.SelectedValue = Session["CourseFourSubjectThree"].ToString();
                ddlCourse_fourth_Subject_Fourth.SelectedValue = Session["CourseFourSubjectFour"].ToString();
                ddlCourse_fourth.SelectedValue = CoursesFour.ToString();
            }
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

            StateId = Convert.ToInt32(Session["CourseOne"]);

            if (StateId == -1)
            {
                obj_Master.CountryId = Convert.ToInt32(ddlCountryRegion.SelectedValue);
                FillCountryStateDropDown1();
                ddlStateRegion.Visible = true;
                ddlStateRegion.DataBind();
            }
            else
            {



                obj_Master.CountryId = Convert.ToInt32(ddlCountryRegion.SelectedValue);

                DS = obj_Master.StateListDropdown1();
                ddlStateRegion.DataSource = DS;
                DS.Tables[0].Merge(DS.Tables[1]);
                ddlStateRegion.DataTextField = DS.Tables[0].Columns[1].ToString();
                ddlStateRegion.DataValueField = DS.Tables[0].Columns[0].ToString();
                ddlStateRegion.DataBind();
                ddlStateRegion.Dispose();
               // ddlStateRegion.SelectedValue = StateId.ToString();
            }

        }
        catch (Exception ex)
        {
            lblMsg.Text = ex.Message;
        }
    }

    #endregion

    private void fillCity(string state, string country)
    {
        try
        {
            if (state != "" || country != "")
            {
                obj_Master.CountryId = Convert.ToInt32(country);
                obj_Master.StateId = Convert.ToInt32(state);
                DS = obj_Master.CityList();
                ddlCity.DataSource = DS;
                DS.Tables[0].Merge(DS.Tables[1]);
                ddlCity.DataTextField = DS.Tables[0].Columns[1].ToString();
                ddlCity.DataValueField = DS.Tables[0].Columns[0].ToString();
                ddlCity.DataBind();
                ddlCity.Dispose();
            }
        }
        catch (Exception ex)
        {
            //lblBatch.Text = ex.ToString();
        }
    }
    protected void fillState(string Country)
    {
        try
        {
            if (Country != "")
            {
                obj_Master.CountryId = Convert.ToInt32(Country);
                DS = obj_Master.StateListDropdown1();
                ddlStateRegion.DataSource = DS;
                DS.Tables[0].Merge(DS.Tables[1]);
                ddlStateRegion.DataTextField = DS.Tables[0].Columns[1].ToString();
                ddlStateRegion.DataValueField = DS.Tables[0].Columns[0].ToString();
                ddlStateRegion.DataBind();
                ddlStateRegion.Dispose();
            }
        }
        catch (Exception ex)
        {
            //   lblBatch.Text = ex.ToString();
        }
    }


    #region " Fill contorole on Form"
    private void FillStudentInformation()
    {
        obj_Student.StudentId = StudentId;
        DS = obj_Student.DisplayStudentForUpdate();
        if (DS.Tables[0].Rows.Count > 0)
        {
            foreach (DataRow row in DS.Tables[0].Rows)
            {
                txtStudentName.Text = row["StudentName"].ToString();
                txtFatherName.Text = row["FatherName"].ToString();
                txtFatherNumber.Text = row["FatherNumber"].ToString();
            
                txtDateOfBirth.Text = row["DateOfBirth"].ToString();
                ddlGender.SelectedValue = row["Gender"].ToString();

                ddlCategory.SelectedValue = row["CateGory"].ToString();
                txtCourseDuration.Text = row["CourseDuration"].ToString();
                txtRollNo.Text = row["RollNo"].ToString();
                txtaddress.Text = row["Address"].ToString();
                txtPinCode.Text = row["PinCode"].ToString();
                ddlCountryRegion.SelectedValue = row["Country"].ToString();
                fillState(row["Country"].ToString());
                Session["Country"] = row["Country"].ToString();
                Session["StateId"] = row["State"].ToString();
                ddlStateRegion.SelectedValue = row["State"].ToString();
                fillCity(row["State"].ToString(), row["Country"].ToString());
                ddlCity.SelectedValue = row["City"].ToString();
                Session["City"] = row["City"].ToString();
                txtEmail.Text = row["Email"].ToString();
                txtMobile.Text = row["Mobile"].ToString();
                txtUserName.Text = row["UserName"].ToString();
                txtPassword.Text = row["Password"].ToString();
                txtDateOfReg.Text = row["DateofRegistration"].ToString();
                txtDuepayment.Text = row["DuePayment"].ToString();
                txtDueDate.Text = row["DueDate"].ToString();
                txtAlert.Text = row["Alert"].ToString();

                ddlClass.SelectedValue = row["ClassId"].ToString();

                fillCoursesByClass(row["ClassId"].ToString());

                ddlCourselist.SelectedValue = row["CourseOne"].ToString();
                ddlCourselistSecond.SelectedValue = row["CourseTwo"].ToString();
                ddlCourse_Third.SelectedValue = row["CourseThree"].ToString();
                ddlCourse_fourth.SelectedValue = row["CourseFour"].ToString();


                Session["CourseOne"] = row["CourseOne"].ToString();
                Session["CourseTwo"] = row["CourseTwo"].ToString();
                Session["CourseThree"] = row["CourseThree"].ToString();
                Session["CourseFour"] = row["CourseFour"].ToString();

                fillSubjectByCourseOne(row["ClassId"].ToString(), row["CourseOne"].ToString());


                Session["CourseOneSubjectOne"] = row["CourseOneSubjectOne"].ToString();
                Session["CourseOneSubjectTwo"] = row["CourseOneSubjectTwo"].ToString();
                Session["CourseOneSubjectThree"] = row["CourseOneSubjectThree"].ToString();
                Session["CourseOneSubjectFour"] = row["CourseOneSubjectFour"].ToString();

                ddlSubject.SelectedValue = row["CourseOneSubjectOne"].ToString();
                ddlSubjectTwo.SelectedValue = row["CourseOneSubjectTwo"].ToString();
                ddlSubjetThree.SelectedValue = row["CourseOneSubjectThree"].ToString();
                ddlSubjectFour.SelectedValue = row["CourseOneSubjectFour"].ToString();
              
                fillSubjectByCourseTwo(row["ClassId"].ToString(), row["CourseTwo"].ToString());

                Session["CourseTwoSubjectOne"] = row["CourseTwoSubjectOne"].ToString();
                Session["CourseTwoSubjectTwo"] = row["CourseTwoSubjectTwo"].ToString();
                Session["CourseTwoSubjectThree"] = row["CourseTwoSubjectThree"].ToString();
                Session["CourseTwoSubjectFour"] = row["CourseTwoSubjectFour"].ToString();

                ddlCourse_Second_Subject_Frist.SelectedValue = row["CourseTwoSubjectOne"].ToString();
                ddlCourse_Second_Subject_Second.SelectedValue = row["CourseTwoSubjectTwo"].ToString();
                ddlCourse_Second_Subject_third.SelectedValue = row["CourseTwoSubjectThree"].ToString();
                ddlCourse_Second_Subject_Forth.SelectedValue = row["CourseTwoSubjectFour"].ToString();

                fillSubjectByCourseThree(row["ClassId"].ToString(), row["CourseThree"].ToString());

                Session["CourseThreeSubjectOne"] = row["CourseThreeSubjectOne"].ToString();
                Session["CourseThreeSubjectTwo"] = row["CourseThreeSubjectTwo"].ToString();
                Session["CourseThreeSubjectThree"] = row["CourseThreeSubjectThree"].ToString();
                Session["CourseThreeSubjectFour"] = row["CourseThreeSubjectFour"].ToString();

                ddlCourse_Third_Subject_Frist.SelectedValue = row["CourseThreeSubjectOne"].ToString();
                ddlCourse_Third_Subject_Second.SelectedValue = row["CourseThreeSubjectTwo"].ToString();
                ddlCourse_Third_Subject_Third.SelectedValue = row["CourseThreeSubjectThree"].ToString();
                ddlCourse_Third_Subject_fourth.SelectedValue = row["CourseThreeSubjectFour"].ToString();

                fillSubjectByCourseFour(row["ClassId"].ToString(), row["CourseFour"].ToString());

                Session["CourseFourSubjectOne"] = row["CourseFourSubjectOne"].ToString();
                Session["CourseFourSubjectTwo"] = row["CourseFourSubjectTwo"].ToString();
                Session["CourseFourSubjectThree"] = row["CourseFourSubjectThree"].ToString();
                Session["CourseFourSubjectFour"] = row["CourseFourSubjectFour"].ToString();

                ddlCourse_fourth_Subject_frist.SelectedValue = row["CourseFourSubjectOne"].ToString();
                ddlCourse_fourth_Subject_Second.SelectedValue = row["CourseFourSubjectTwo"].ToString();
                ddlCourse_fourth_Subject_Third.SelectedValue = row["CourseFourSubjectThree"].ToString();
                ddlCourse_fourth_Subject_Fourth.SelectedValue = row["CourseFourSubjectFour"].ToString();

                lblRegistratoinNo.Text = row["RegistrationNo"].ToString();
                //EMPLOYEE_ID = Convert.ToInt32(row["EMPLOYEE_ID"]);
                txtEmail.Text = row["Email"].ToString();
                //lblname.Text = row["FirstName"].ToString() + " " + row["LastName"].ToString();
                if (row["UploadImages"].ToString() == "")
                {
                    imgUser.ImageUrl = "../UploadedFile/Defultuser.png";
                }
                else
                {
                    imgUser.ImageUrl = "../CroppedImages/" + row["UploadImages"].ToString();
                }
            }
        }
    }

    private void fillSubjectByCourseFour(string ClassId, string CoursesFour)
    {
        try
        {
            if (ClassId != "" && CoursesFour != "")
            {
                obj_Master.ClassId = Convert.ToInt32(ClassId);
                obj_Master.ClassCoursesId = Convert.ToInt32(CoursesFour);
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
        }
        catch (Exception ex)
        {
            lblMsg.Text = ex.ToString();
        }
    }

    private void fillSubjectByCourseThree(string ClassId, string CoursesThree)
    {
        try
        {
            if (ClassId != "" && CoursesThree != "")
            {

                obj_Master.ClassId = Convert.ToInt32(ClassId);
                obj_Master.ClassCoursesId = Convert.ToInt32(CoursesThree);
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
        }
        catch (Exception ex)
        {
            lblMsg.Text = ex.ToString();
        }
    }

    private void fillSubjectByCourseTwo(string ClassId, string CoursesTwo)
    {
        try
        {
            if (ClassId != "" && CoursesTwo != "")
            {
                obj_Master.ClassId = Convert.ToInt32(ClassId);
                obj_Master.ClassCoursesId = Convert.ToInt32(CoursesTwo);
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
        }
        catch (Exception ex)
        {
            lblMsg.Text = ex.ToString();
        }
    }

    private void fillSubjectByCourseOne(string ClassId, string CoursesOne)
    {
        try
        {
            if (ClassId != "" && CoursesOne != "")
            {
                obj_Master.ClassId = Convert.ToInt32(ClassId);
                obj_Master.ClassCoursesId = Convert.ToInt32(CoursesOne);
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
        }
        catch (Exception ex)
        {
            lblMsg.Text = ex.ToString();
        }
    }



    private void fillCoursesByClass(string ClassId)
    {
        try
        {
            if (ClassId != "")
            {
                obj_Master.ClassId = Convert.ToInt32(ClassId);
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
        }
        catch (Exception ex)
        {
            lblMsg.Text = ex.ToString();
        }
    }
    #endregion "End Fill contorole on Form"

    #region"Update Student "
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            obj_Student.StudentId = StudentId;
            //obj_Student.UploadImages = Session["ImagesName"].ToString();
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
            // obj_Student.RegistrationNo = ConfigurationManager.AppSettings["RegNoGen"];
            obj_Student.RegistrationNo = lblRegistratoinNo.Text.Trim();
            obj_Student.DateofRegistration = txtDateOfReg.Text.Trim();
            obj_Student.RollNo = txtRollNo.Text.Trim();

            //obj_Student.Country = ddlCountryRegion.SelectedValue.ToString();
            obj_Student.Gender = ddlGender.SelectedValue.ToString();
            obj_Student.CateGory = ddlCategory.SelectedValue.ToString();

            // obj_Student.ClassId = Convert.ToInt32(ddlClass.SelectedValue.ToString());
            //  obj_Student.City = ddlCity.SelectedValue.ToString();
            //   obj_Student.State = ddlStateRegion.SelectedValue.ToString();
            //obj_Student.CourseOne = ddlCourselist.SelectedValue.ToString();
            //obj_Student.CourseTwo = ddlCourselistSecond.SelectedValue.ToString();
            //obj_Student.CourseThree = ddlCourse_Third.SelectedValue.ToString();
            //obj_Student.CourseFour = ddlCourse_fourth.SelectedValue.ToString();

            //obj_Student.CourseOneSubjectOne = ddlSubject.SelectedValue.ToString();
            //obj_Student.CourseOneSubjectTwo = ddlSubjectTwo.SelectedValue.ToString();
            //obj_Student.CourseOneSubjectThree = ddlSubjetThree.SelectedValue.ToString();
            //obj_Student.CourseOneSubjectFour = ddlSubjectFour.SelectedValue.ToString();

            //obj_Student.CourseTwoSubjectOne = ddlCourse_Second_Subject_Frist.SelectedValue.ToString();
            //obj_Student.CourseTwoSubjectTwo = ddlCourse_Second_Subject_Second.SelectedValue.ToString();
            //obj_Student.CourseTwoSubjectThree = ddlCourse_Second_Subject_third.SelectedValue.ToString();
            //obj_Student.CourseTwoSubjectFour = ddlCourse_Second_Subject_Forth.SelectedValue.ToString();

            //obj_Student.CourseThreeSubjectOne = ddlCourse_Third_Subject_Frist.SelectedValue.ToString();
            //obj_Student.CourseThreeSubjectTwo = ddlCourse_Third_Subject_Second.SelectedValue.ToString();
            //obj_Student.CourseThreeSubjectThree = ddlCourse_Third_Subject_Third.SelectedValue.ToString();
            //obj_Student.CourseThreeSubjectFour = ddlCourse_Third_Subject_fourth.SelectedValue.ToString();


            //obj_Student.CourseFourSubjectOne = ddlCourse_fourth_Subject_frist.SelectedValue.ToString();
            //obj_Student.CourseFourSubjectTwo = ddlCourse_fourth_Subject_Second.SelectedValue.ToString();
            //obj_Student.CourseFourSubjectThree = ddlCourse_fourth_Subject_Third.SelectedValue.ToString();
            //obj_Student.CourseFourSubjectFour = ddlCourse_fourth_Subject_Fourth.SelectedValue.ToString();

            obj_Student.CourseDuration = txtCourseDuration.Text.Trim();
            obj_Student.Alert = txtAlert.Text;
            obj_Student.DueDate = txtDueDate.Text;
            obj_Student.DuePayment = txtDuepayment.Text;
            obj_Student.PinCode = txtPinCode.Text.Trim();

            //if (Session["ImagesName"] == null)
            //{
            //    obj_Student.UploadImages = imgUser.ImageUrl.Replace("../CroppedImages/", String.Empty);

            //}
            //else
            //{
            //    obj_Student.UploadImages = Session["ImagesName"].ToString();
            //    Session["ImagesName"] = null;
            //}

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
            else
            {
                obj_Student.UploadImages = imgUser.ImageUrl.Replace("../CroppedImages/", String.Empty);
            }


            Session["ImagesName"] = null;

            DS = obj_Student.UpdateStudent();

        }
        catch (Exception ex )
        {
            lblMsg.Text = ex.Message;
        }

        
        

    }
    #endregion
}