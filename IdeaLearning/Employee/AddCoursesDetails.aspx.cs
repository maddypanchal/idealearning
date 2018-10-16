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

public partial class Employee_AddCoursesDetails : System.Web.UI.Page
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
                    obj_News.ImagesName = Path.GetFileName("CO-" + FileNamekey);
                    obj_News.CourseName = txtCourse.Text.Trim();
                    String ckContentValue = CKEditor1.Text.Trim();
                    obj_News.CoursesDetails = ckContentValue;
                    obj_News.CourseDuration = txtCourseDuration.Text.Trim();
                    obj_News.Description = txtDescriptions.Text.Trim();

                    checkRecordStatus = obj_News.AddCourses();
                    if (checkRecordStatus > 0)
                    {
                        lblMsg.ForeColor = Color.Green;
                        lblMsg.Text = "Product Record Saved!";
                        lblMsg.Visible = true;
                        clrForm();
                       
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
  
}