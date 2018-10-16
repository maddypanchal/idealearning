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

public partial class Admin_DeleteSyllabus : System.Web.UI.Page
{
    #region "Variable Decleration"
    private clsMaster obj_Master = new clsMaster();
    private clsEmployee obj_Employee = new clsEmployee();
    private DataSet DS;
    private int RecordStatus;
    private static int AdminRegistrationId;
    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            FillSyllabus();
 
        }
    }

 
   

 

    #region " Fill User Grid View"
    public void FillSyllabus()
    {
        DS = obj_Master.DisplaySyllabus();
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
        obj_Master.SyllabusId = Convert.ToInt32(gvDetail1.DataKeys[e.RowIndex].Values["SyllabusId"].ToString());
        RecordStatus = obj_Master.DeleteSylabus();
        FillSyllabus();
    }
    protected void gvDetail1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {

    }

    protected void gvDetail1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {

        //if(Convert.ToInt32(ddlClass.SelectedValue)!= -1 && Convert.ToInt32(ddlCourselist.SelectedValue) != -1 && Convert.ToInt32(ddlSubject.SelectedValue) != -1)
        //{
        //    gvDetail1.PageIndex = e.NewPageIndex;
        //    DS = obj_Master.SearchSyllabusMultiple();
        //    if (DS != null)
        //    {

        //        gvDetail1.DataSource = DS;
        //        gvDetail1.DataBind();
        //        gvDetail1.Dispose();
        //        if (gvDetail1.Rows.Count == 0)
        //        {

        //            lblMsg.Text = "No Record Found";
        //        }

        //    }
        //    else
        //    {
        //        lblMsg.Text = "No Record Found";

        //    }

        //}
        //else
        //{
        //}


        gvDetail1.PageIndex = e.NewPageIndex;
        DS = obj_Master.DisplaySyllabus();
        gvDetail1.DataSource = DS;
        gvDetail1.DataBind();

    }

    #region "button Search"
    protected void btnDeleteAdd_Click(object sender, EventArgs e)
    {
        DS = obj_Master.DeleteSyllabus();
        lblMsg.Text = "All Syllabus deleted, refresh to confirm ! ";
    }
    #endregion
}