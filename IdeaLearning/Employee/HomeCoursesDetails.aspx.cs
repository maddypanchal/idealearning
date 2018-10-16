using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Data;
using System.IO;
using BusinessLogic.Admin;

public partial class Employee_HomeCoursesDetails : System.Web.UI.Page
{
    #region "VARIABLE DECLARATION"
    //  private clsToppers obj_Toppers = new clsToppers();
    private clsMaster obj_News = new clsMaster();
    private DataSet DS;
    private int RecordStatus;
    private int checkRecordStatus;
    // private int LoginType;
    private string myFileExtension;
    #endregion
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            FillCourses();
        }
    }

    #region " Fill User Grid View"
    public void FillCourses()
    {
        DS = obj_News.FillCoursesDetails();
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
        obj_News.CourseDetailsId = Convert.ToInt32(gvDetail1.DataKeys[e.RowIndex].Values["CourseDetailsId"].ToString());
        RecordStatus = obj_News.DeleteCoursesDetails();
        FillCourses();
    }
    protected void gvDetail1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {

    }
}