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
using System.Drawing;
using System.Data;
using System.IO;

public partial class Employee_EditHomeCourses : System.Web.UI.Page
{

    #region "Variable Decleration"
    private clsMaster obj_News = new clsMaster();
    private DataSet DS;
    private int RecordStatus;
    private static int CourseDetailsId;
    private string myFileExtension;
    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {
        CourseDetailsId = int.Parse(Request.QueryString["Sid"]);
        if (!IsPostBack)
        {
            FillHomeCourses();
        }
    }

    #region " Fill contorole on Form"
    private void FillHomeCourses()
    {
        obj_News.CourseDetailsId = CourseDetailsId;
        DS = obj_News.FillHomeCourses();
        if (DS.Tables[0].Rows.Count > 0)
        {
            foreach (DataRow row in DS.Tables[0].Rows)
            {
      //          [CourseName]
      //,[ImagesName]
      //,[Description]
      //,[CoursesDetails]
      //,[CourseDuration]
      //,[IsActive]

              txtCourse.Text = row["CourseName"].ToString();
           txtDescriptions.Text = row["Description"].ToString();
         txtCourseDuration.Text = row["CourseDuration"].ToString();
                CKEditor1.Text = row["CoursesDetails"].ToString();
                    //CKEditor1.Text = row["ImagesName"].ToString();

                if (row["ImagesName"].ToString() == "")
                {
                    imgUser.ImageUrl = "../UploadedFile/Defultuser.png";
                }
                else
                {
                    //imgUser.ImageUrl = "../UploadedFile/Defultuser.png";
                    imgUser.ImageUrl = "../Employee/Toppers/" + row["ImagesName"].ToString();
                }
                
            }
        }
    }
    #endregion "End Fill contorole on Form"

    #region"Update Student "
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        obj_News.CourseDetailsId = CourseDetailsId;
        obj_News.CourseName = txtCourse.Text.Trim();
        obj_News.CourseDuration = txtCourseDuration.Text.Trim();
        obj_News.Description = txtDescriptions.Text.Trim();
        String ckContentValue = CKEditor1.Text.Trim();
        obj_News.CoursesDetails = ckContentValue;
        DS = obj_News.FillHomeCourses();
       
        //if (DS.Tables[0].Rows.Count > 0)
        //{
        //    foreach (DataRow row in DS.Tables[0].Rows)
        //    {
        //        obj_News.ImagesName = row["ImagesName"].ToString();
        //    }
        //}




        myFileExtension = Path.GetExtension(FileUploadOnLocalComputer.PostedFile.FileName);
        if (FileUploadOnLocalComputer.HasFile)
        {
            if (myFileExtension == ".jpg" || myFileExtension == ".bmp" || myFileExtension == ".png" || myFileExtension == ".jpeg" || myFileExtension == ".JPG" || myFileExtension == ".gif")
            {
                if (FileUploadOnLocalComputer.PostedFile.ContentLength < 3000000)
                {
                    string FileNamekey = DateTime.Now.Ticks.ToString().Substring(12) + ".jpg";
                    FileUploadOnLocalComputer.SaveAs(MapPath("~/Employee/Toppers/" + "CO-" + FileNamekey));
                    System.Drawing.Image ImgOriginal = System.Drawing.Image.FromFile(MapPath("~/Employee/Toppers/") + "CO-" + FileNamekey);
                    System.Drawing.Image imgMain = ImgOriginal.GetThumbnailImage(570, 396, null, IntPtr.Zero);
                    imgMain.Save(MapPath("~/Employee/Toppers/ImgMain/") + "CO-" + FileNamekey);
                    //Thumb Nail Genrator Coded By Rakesh Panchal
                    obj_News.ImagesName = Path.GetFileName("CO-" + FileNamekey);
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
        else
        {

            DS = obj_News.FillHomeCourses();
            if (DS.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in DS.Tables[0].Rows)
                {
                    obj_News.ImagesName = row["ImagesName"].ToString();
                }
            }
        }


        DS = obj_News.UpdateHomeCourses();
        if (RecordStatus == 0)
        {
        //    lblmsg.Text = "Record Saved!";
        }
        //clearform();
        Response.Redirect("HomeCoursesDetails.aspx");
    }
    #endregion
  
}