using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using DataAccess;
using BusinessLogic.Admin;

public partial class Employee_ClassCourses : System.Web.UI.Page
{
    #region "VARIABLE DECLARATION"
    private clsMaster obj_Master = new clsMaster();
    // private  cla = new clsExam();
    private DataSet DS;
    private int checkRecordStatus;
    // private int LoginType;
    public int RecordStatus;
    private string myFileExtension;
    #endregion

    #region"Page Load"
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            FillClass();

        }
    }
    #endregion

    #region "Fill Toppers Year List Method"
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
            //ddlClass.DataTextField = DS.Tables[0].Columns[1].ToString();
            //ddlClass.DataValueField = DS.Tables[0].Columns[0].ToString();
            //ddlClass.DataBind();
            //ddlClass.Items.Add(new System.Web.UI.WebControls.ListItem("---Select Class---", "0"));
            //ddlClass.SelectedValue = "0";
            //DS.Dispose();
            //ddlClass.Dispose();
        }
        catch (Exception ex)
        {
            lblMsg.Text = ex.ToString();
        }
    }
    #endregion "End Main Category List Method"

    protected void btnSave_Click(object sender, EventArgs e)
    {
        obj_Master.ClassId = Convert.ToInt32(ddlClass.SelectedValue.ToString());
        obj_Master.CoursesName = txtSubjectName.Text.Trim();
        checkRecordStatus = obj_Master.AddClassCousese();
        if (checkRecordStatus >= 0)
        {
            lblMsg.Text = "Record Saved!";
            txtSubjectName.Text = "";
            ddlClass.SelectedIndex = -1;
        }
    }

    #region " Fill User Grid View"
    public void FillClassCourses()
    {
        obj_Master.ClassId = Convert.ToInt32(ddlClass.SelectedValue.ToString());
        DS = obj_Master.FillClassCoursesGrid();
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
        obj_Master.ClassCoursesId = Convert.ToInt32(gvDetail1.DataKeys[e.RowIndex].Values["ClassCoursesId"].ToString());
        RecordStatus = obj_Master.DeleteClassCourses();
        FillClassCourses();
    }
    protected void gvDetail1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {

    }
    protected void ddlClass_SelectedIndexChanged(object sender, EventArgs e)
    {
        FillClassCourses();
    }
}