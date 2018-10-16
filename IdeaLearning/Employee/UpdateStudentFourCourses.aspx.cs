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

public partial class Employee_UpdateStudentFourCourses : System.Web.UI.Page
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

    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {
        StudentId = Convert.ToInt32(Session["StudentId"]);
        if (!IsPostBack)
        {
            FillClass();

            //FillStudentInformation();
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
            ClassId = obj_Master.ClassId.ToString();
            ddlCourse_fourth.DataSource = DS;
            DS.Tables[0].Merge(DS.Tables[1]);
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

    protected void ddlCourse_fourth_SelectedIndexChanged(object sender, EventArgs e)
    {
        FillSubjectFourth();
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

    #region"Update Student "
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            obj_Student.StudentId = StudentId;
            obj_Student.ClassId = Convert.ToInt32(ddlClass.SelectedValue.ToString());
            obj_Student.CourseFour = ddlCourse_fourth.SelectedValue.ToString();
            obj_Student.CourseFourText = ddlCourse_fourth.SelectedItem.ToString();

            obj_Student.CourseFourSubjectOne = ddlCourse_fourth_Subject_frist.SelectedValue.ToString();
            obj_Student.CourseFourSubjectTwo = ddlCourse_fourth_Subject_Second.SelectedValue.ToString();
            obj_Student.CourseFourSubjectThree = ddlCourse_fourth_Subject_Third.SelectedValue.ToString();
            obj_Student.CourseFourSubjectFour = ddlCourse_fourth_Subject_Fourth.SelectedValue.ToString();

            obj_Student.CourseFourSubjectOneText = ddlCourse_fourth_Subject_frist.SelectedItem.ToString();
            obj_Student.CourseFourSubjectTwoText = ddlCourse_fourth_Subject_Second.SelectedItem.ToString();
            obj_Student.CourseFourSubjectThreeText = ddlCourse_fourth_Subject_Third.SelectedItem.ToString();
            obj_Student.CourseFourSubjectFourText = ddlCourse_fourth_Subject_Fourth.SelectedItem.ToString();

            DS = obj_Student.UpdateStudentFourCourse();

            lblMsg.Text = " Your Record is Saved. To return to the back page Cancel the popup Window form top right corner.";
        }
        catch (Exception)
        {

            lblMsg.Text = "some thinks is wrong";
        }

    }
    #endregion

}