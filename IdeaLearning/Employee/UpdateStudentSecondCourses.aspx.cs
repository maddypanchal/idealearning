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

public partial class Employee_UpdateStudentSecondCourses : System.Web.UI.Page
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
            ddlCourselistSecond.DataSource = DS;
            DS.Tables[0].Merge(DS.Tables[1]);
            ddlCourselistSecond.DataTextField = DS.Tables[0].Columns[1].ToString();
            ddlCourselistSecond.DataValueField = DS.Tables[0].Columns[0].ToString();
            ddlCourselistSecond.DataBind();
            ddlCourselistSecond.Dispose();

        }
        catch (Exception ex)
        {
            lblMsg.Text = ex.ToString();
        }
    }
    #endregion

    protected void ddlCourselistSecond_SelectedIndexChanged(object sender, EventArgs e)
    {

        FillSubjectSecond();
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


    #region " Fill contorole on Form"
    private void FillStudentInformation()
    {
        obj_Student.StudentId = StudentId;
        DS = obj_Student.DisplayStudentForUpdate();
        if (DS.Tables[0].Rows.Count > 0)
        {
            foreach (DataRow row in DS.Tables[0].Rows)
            {


            //    ddlClass.SelectedValue = row["ClassId"].ToString();

              //  fillCoursesByClass(row["ClassId"].ToString());

             //   ddlCourselistSecond.SelectedValue = row["CourseTwo"].ToString();



          //      Session["CourseOne"] = row["CourseTwo"].ToString();


               // fillSubjectByCourseOne(row["ClassId"].ToString(), row["CourseTwo"].ToString());


                //Session["CourseTwoSubjectOne"] = row["CourseTwoSubjectOne"].ToString();
                //Session["CourseTwoSubjectTwo"] = row["CourseTwoSubjectTwo"].ToString();
                //Session["CourseTwoSubjectThree"] = row["CourseTwoSubjectThree"].ToString();
                //Session["CourseTwoSubjectFour"] = row["CourseTwoSubjectFour"].ToString();

                //ddlCourse_Second_Subject_Frist.SelectedValue = row["CourseTwoSubjectOne"].ToString();
                //ddlCourse_Second_Subject_Second.SelectedValue = row["CourseTwoSubjectTwo"].ToString();
                //ddlCourse_Second_Subject_third.SelectedValue = row["CourseTwoSubjectThree"].ToString();
                //ddlCourse_Second_Subject_Forth.SelectedValue = row["CourseTwoSubjectFour"].ToString();

                


            }
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
                ddlCourse_Second_Subject_Frist.DataSource = DS;

                DS.Tables[0].Merge(DS.Tables[1]);
                ddlCourse_Second_Subject_Frist.DataTextField = DS.Tables[0].Columns[1].ToString();
                ddlCourse_Second_Subject_Frist.DataValueField = DS.Tables[0].Columns[0].ToString();
                ddlCourse_Second_Subject_Frist.DataBind();
                ddlCourse_Second_Subject_Frist.Dispose();

                ddlCourse_Second_Subject_Second.DataSource = DS;

                ddlCourse_Second_Subject_Second.DataTextField = DS.Tables[0].Columns[1].ToString();
                ddlCourse_Second_Subject_Second.DataValueField = DS.Tables[0].Columns[0].ToString();
                ddlCourse_Second_Subject_Second.DataBind();
                ddlCourse_Second_Subject_Second.Dispose();

                ddlCourse_Second_Subject_third.DataSource = DS;

                ddlCourse_Second_Subject_third.DataTextField = DS.Tables[0].Columns[1].ToString();
                ddlCourse_Second_Subject_third.DataValueField = DS.Tables[0].Columns[0].ToString();
                ddlCourse_Second_Subject_third.DataBind();
                ddlCourse_Second_Subject_third.Dispose();

                ddlCourse_Second_Subject_Forth.DataSource = DS;

                ddlCourse_Second_Subject_Forth.DataTextField = DS.Tables[0].Columns[1].ToString();
                ddlCourse_Second_Subject_Forth.DataValueField = DS.Tables[0].Columns[0].ToString();
                ddlCourse_Second_Subject_Forth.DataBind();
                ddlCourse_Second_Subject_Forth.Dispose();
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
                ddlCourselistSecond.DataSource = DS;

                DS.Tables[0].Merge(DS.Tables[1]);

                ddlCourselistSecond.DataTextField = DS.Tables[0].Columns[1].ToString();
                ddlCourselistSecond.DataValueField = DS.Tables[0].Columns[0].ToString();
                ddlCourselistSecond.DataBind();
                ddlCourselistSecond.Dispose();




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
            obj_Student.ClassId = Convert.ToInt32(ddlClass.SelectedValue.ToString());
            obj_Student.CourseTwo = ddlCourselistSecond.SelectedValue.ToString();
            obj_Student.CourseTwoText = ddlCourselistSecond.SelectedItem.ToString();

            obj_Student.CourseTwoSubjectOne = ddlCourse_Second_Subject_Frist.SelectedValue.ToString();
            obj_Student.CourseTwoSubjectTwo = ddlCourse_Second_Subject_Second.SelectedValue.ToString();
            obj_Student.CourseTwoSubjectThree = ddlCourse_Second_Subject_third.SelectedValue.ToString();
            obj_Student.CourseTwoSubjectFour = ddlCourse_Second_Subject_Forth.SelectedValue.ToString();

            obj_Student.CourseTwoSubjectOneText = ddlCourse_Second_Subject_Frist.SelectedItem.ToString();
            obj_Student.CourseTwoSubjectTwoText = ddlCourse_Second_Subject_Second.SelectedItem.ToString();
            obj_Student.CourseTwoSubjectThreeText = ddlCourse_Second_Subject_third.SelectedItem.ToString();
            obj_Student.CourseTwoSubjectFourText = ddlCourse_Second_Subject_Forth.SelectedItem.ToString();

            DS = obj_Student.UpdateStudentSecondCourse();

            lblMsg.Text = " Your Record is Saved. To return to the back page Cancel the popup Window form top right corner.";
        }
        catch (Exception)
        {

            lblMsg.Text = "some thinks is wrong";
        }

    }
    #endregion

}