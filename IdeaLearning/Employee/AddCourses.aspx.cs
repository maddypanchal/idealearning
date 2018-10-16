﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Data;
using System.IO;
using BusinessLogic.Admin;

public partial class Employee_AddCourses : System.Web.UI.Page
{
    #region "VARIABLE DECLARATION"
    private clsToppers obj_Toppers = new clsToppers();
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
    #region Clear Form
    protected void clrForm()
    {
        txtCourse.Text = "";
    }
    #endregion
    
    protected void btnSave_Click(object sender, EventArgs e)
    {

        myFileExtension = Path.GetExtension(FileUploadOnLocalComputer.PostedFile.FileName);
        if (FileUploadOnLocalComputer.HasFile)
        {
            if (myFileExtension == ".jpg" || myFileExtension == ".bmp" || myFileExtension == ".png" || myFileExtension == ".jpeg" || myFileExtension == ".JPG" || myFileExtension == ".gif")
            {
                if (FileUploadOnLocalComputer.PostedFile.ContentLength < 2000000)
                {
                    string FileNamekey = DateTime.Now.Ticks.ToString().Substring(12) + ".jpg";
                    FileUploadOnLocalComputer.SaveAs(MapPath("~/Employee/Toppers/" + "CO-" + FileNamekey));
                    System.Drawing.Image ImgOriginal = System.Drawing.Image.FromFile(MapPath("~/Employee/Toppers/") + "CO-" + FileNamekey);
                    System.Drawing.Image imgMain = ImgOriginal.GetThumbnailImage(570, 396, null, IntPtr.Zero);
                    imgMain.Save(MapPath("~/Employee/Toppers/ImgMain/") + "CO-" + FileNamekey);
                    //Thumb Nail Genrator Coded By Rakesh Panchal
                    obj_Toppers.ImagesName = Path.GetFileName("CO-" + FileNamekey);
                    obj_Toppers.CourseName = txtCourse.Text.Trim();
                    checkRecordStatus = obj_Toppers.AddCourses();
                    if (checkRecordStatus > 0)
                    {
                        lblMsg.ForeColor = Color.Green;
                        lblMsg.Text = "Product Record Saved!";
                        lblMsg.Visible = true;
                        clrForm();
                        FillCourses();
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
                ScriptManager.RegisterStartupScript(this.Page, typeof(string), "Alert", "alert('Only jpeg, jpg, png, jpe, gif files are allowed');", true);
            }
        }



        //obj_Toppers.CourseName = txtCourse.Text.Trim();
        //checkRecordStatus = obj_Toppers.AddCourses();
        //if (checkRecordStatus > 0)
        //{
        //    lblMsg.ForeColor = Color.Green;
        //    lblMsg.Text = "Product Record Save";
        //    lblMsg.Visible = true;
        //    clrForm();
        //    FillCourses();
        //}
    }

    #region " Fill User Grid View"
    public void FillCourses()
    {
        DS = obj_News.FillCourses();
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
        obj_News.CourseId = Convert.ToInt32(gvDetail1.DataKeys[e.RowIndex].Values["CourseId"].ToString());
        RecordStatus = obj_News.DeleteCourses();
        FillCourses();
    }
    protected void gvDetail1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {

    }
}