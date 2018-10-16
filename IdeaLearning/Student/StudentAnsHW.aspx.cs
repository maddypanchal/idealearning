﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.IO;
using System.Data.SqlClient;
using System.Data;
using DataAccess;
using BusinessLogic.Admin;

public partial class Student_StudentAnsHW : System.Web.UI.Page
{
    #region "VARIABLE DECLARATION"
    private clsMaster obj_Master = new clsMaster();
    private DataSet DS;
    private int checkRecordStatus;
    private string myFileExtension;
    #endregion

    #region"Page Load"
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
           FillClass();
           // FillSubject();
        }
   
    }
    #endregion

    #region "Fill Class List Method"
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
    #endregion "End Main Category List Method"

    #region"Student Home Work"
    protected void btnSave_Click(object sender, EventArgs e)
    {
        myFileExtension = Path.GetExtension(FileUploadPDF.PostedFile.FileName);
        if (FileUploadPDF.HasFile)
        {
            if (myFileExtension == ".doc" || myFileExtension == ".docx" || myFileExtension == ".DOC" || myFileExtension == ".DOCX")
            {
                if (FileUploadPDF.PostedFile.ContentLength < 10000000)
                {
                    string FileNamekey = DateTime.Now.Ticks.ToString().Substring(12) + ".docx";
                    FileUploadPDF.SaveAs(MapPath("~/Employee/DocFile/" + "Ans-" + FileNamekey));
                    //Thumb Nail Genrator Coded By Rakesh Panchal
                    obj_Master.DocFile = Path.GetFileName("Ans-" + FileNamekey);
                    obj_Master.ClassId = Convert.ToInt32(ddlClass.SelectedValue.ToString());
                    obj_Master.SubjectId = Convert.ToInt32(ddlSubject.SelectedValue.ToString());
                    obj_Master.ClassCoursesId = Convert.ToInt32(ddlCourselist.SelectedValue.ToString());
                    obj_Master.Date = System.DateTime.Now.ToString();
                    checkRecordStatus = obj_Master.AddHomeWorkAns();
                    if (checkRecordStatus >= 0)
                    {
                        lblMsg.Text = "Record Saved !";
                        ddlClass.SelectedIndex = -1;
                    }

                    else
                    {
                        lblMsg.ForeColor = Color.Red;
                        lblMsg.Text = "Product Already Exist ";
                        lblMsg.Visible = true;
                    }
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this.Page, typeof(string), "Alert", "alert('The file has to be less than 2MB only!');", true);
                }
            }
            else
            {
                ScriptManager.RegisterStartupScript(this.Page, typeof(string), "Alert", "alert('Only doc, docx');", true);
            }
        }


    }
    #endregion

    #region"Class list Selected Index Changed"
    protected void ddlClass_SelectedIndexChanged(object sender, EventArgs e)
    {
        FillClassCourses();
    }
    #endregion

    #region"Fill Class Courses by Class"
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
        }
        catch (Exception ex)
        {
            lblMsg.Text = ex.ToString();
        }
    }
    #endregion

    #region"Course List Selected Index Changed"
    protected void ddlCourseList_SelectedIndexChanged(object sender, EventArgs e)
    {
        FillSubject();
    }
    #endregion

    #region"Fill Subject by Courses"
    private void FillSubject()
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
        }
        catch (Exception ex)
        {
            lblMsg.Text = ex.ToString();
        }
    }
    #endregion
}