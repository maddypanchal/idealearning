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

public partial class Employee_UpdateStudentThreeCourses : System.Web.UI.Page
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
            ddlCourse_Third.DataSource = DS;
            DS.Tables[0].Merge(DS.Tables[1]);
            ddlCourse_Third.DataTextField = DS.Tables[0].Columns[1].ToString();
            ddlCourse_Third.DataValueField = DS.Tables[0].Columns[0].ToString();
            ddlCourse_Third.DataBind();
            ddlCourse_Third.Dispose();

        }
        catch (Exception ex)
        {
            lblMsg.Text = ex.ToString();
        }
    }
    #endregion


    protected void ddlCourse_Third_SelectedIndexChanged(object sender, EventArgs e)
    {

        FillSubjectThird();
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

    #region " Fill contorole on Form"
    //private void FillStudentInformation()
    //{
    //    obj_Student.StudentId = StudentId;
    //    DS = obj_Student.DisplayStudentForUpdate();
    //    if (DS.Tables[0].Rows.Count > 0)
    //    {
    //        foreach (DataRow row in DS.Tables[0].Rows)
    //        {


    //            ddlClass.SelectedValue = row["ClassId"].ToString();

    //            fillCoursesByClass(row["ClassId"].ToString());

    //            ddlCourselist.SelectedValue = row["CourseOne"].ToString();



    //            Session["CourseOne"] = row["CourseOne"].ToString();


    //            fillSubjectByCourseOne(row["ClassId"].ToString(), row["CourseOne"].ToString());


    //            Session["CourseOneSubjectOne"] = row["CourseOneSubjectOne"].ToString();
    //            Session["CourseOneSubjectTwo"] = row["CourseOneSubjectTwo"].ToString();
    //            Session["CourseOneSubjectThree"] = row["CourseOneSubjectThree"].ToString();
    //            Session["CourseOneSubjectFour"] = row["CourseOneSubjectFour"].ToString();

    //            ddlSubject.SelectedValue = row["CourseOneSubjectOne"].ToString();
    //            ddlSubjectTwo.SelectedValue = row["CourseOneSubjectTwo"].ToString();
    //            ddlSubjetThree.SelectedValue = row["CourseOneSubjectThree"].ToString();
    //            ddlSubjectFour.SelectedValue = row["CourseOneSubjectFour"].ToString();




    //        }
    //    }
    //}



    //private void fillSubjectByCourseOne(string ClassId, string CoursesOne)
    //{
    //    try
    //    {
    //        if (ClassId != "" && CoursesOne != "")
    //        {
    //            obj_Master.ClassId = Convert.ToInt32(ClassId);
    //            obj_Master.ClassCoursesId = Convert.ToInt32(CoursesOne);
    //            DS = obj_Master.FillSubjectCourses();
    //            ddlSubject.DataSource = DS;

    //            DS.Tables[0].Merge(DS.Tables[1]);
    //            ddlSubject.DataTextField = DS.Tables[0].Columns[1].ToString();
    //            ddlSubject.DataValueField = DS.Tables[0].Columns[0].ToString();
    //            ddlSubject.DataBind();
    //            ddlSubject.Dispose();

    //            ddlSubjectTwo.DataSource = DS;

    //            ddlSubjectTwo.DataTextField = DS.Tables[0].Columns[1].ToString();
    //            ddlSubjectTwo.DataValueField = DS.Tables[0].Columns[0].ToString();
    //            ddlSubjectTwo.DataBind();
    //            ddlSubjectTwo.Dispose();

    //            ddlSubjetThree.DataSource = DS;

    //            ddlSubjetThree.DataTextField = DS.Tables[0].Columns[1].ToString();
    //            ddlSubjetThree.DataValueField = DS.Tables[0].Columns[0].ToString();
    //            ddlSubjetThree.DataBind();
    //            ddlSubjetThree.Dispose();

    //            ddlSubjectFour.DataSource = DS;

    //            ddlSubjectFour.DataTextField = DS.Tables[0].Columns[1].ToString();
    //            ddlSubjectFour.DataValueField = DS.Tables[0].Columns[0].ToString();
    //            ddlSubjectFour.DataBind();
    //            ddlSubjectFour.Dispose();
    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //        lblMsg.Text = ex.ToString();
    //    }
    //}



    private void fillCoursesByClass(string ClassId)
    {
        try
        {
            if (ClassId != "")
            {
                obj_Master.ClassId = Convert.ToInt32(ClassId);
                DS = obj_Master.FillClassCoursesDdl();
                ddlCourse_Third.DataSource = DS;

                DS.Tables[0].Merge(DS.Tables[1]);

                ddlCourse_Third.DataTextField = DS.Tables[0].Columns[1].ToString();
                ddlCourse_Third.DataValueField = DS.Tables[0].Columns[0].ToString();
                ddlCourse_Third.DataBind();
                ddlCourse_Third.Dispose();


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
            obj_Student.CourseThree = ddlCourse_Third.SelectedValue.ToString();
            obj_Student.CourseThreeText = ddlCourse_Third.SelectedItem.ToString();

            obj_Student.CourseThreeSubjectOne = ddlCourse_Third_Subject_Frist.SelectedValue.ToString();
            obj_Student.CourseThreeSubjectTwo = ddlCourse_Third_Subject_Second.SelectedValue.ToString();
            obj_Student.CourseThreeSubjectThree = ddlCourse_Third_Subject_Third.SelectedValue.ToString();
            obj_Student.CourseThreeSubjectFour = ddlCourse_Third_Subject_fourth.SelectedValue.ToString();

            obj_Student.CourseThreeSubjectOneText = ddlCourse_Third_Subject_Frist.SelectedItem.ToString();
            obj_Student.CourseThreeSubjectTwoText = ddlCourse_Third_Subject_Second.SelectedItem.ToString();
            obj_Student.CourseThreeSubjectThreeText = ddlCourse_Third_Subject_Third.SelectedItem.ToString();
            obj_Student.CourseThreeSubjectFourText = ddlCourse_Third_Subject_fourth.SelectedItem.ToString();

            DS = obj_Student.UpdateStudentThreeCourse();

            lblMsg.Text = " Your Record is Saved. To return to the back page Cancel the popup Window form top right corner.";
        }
        catch (Exception)
        {

            lblMsg.Text = "some thinks is wrong";
        }

    }
    #endregion


}