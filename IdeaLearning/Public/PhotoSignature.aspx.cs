using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccess;
using System.Data.SqlClient;
using System.Data;
using BusinessLogic.Admin;
using System.Drawing;
using System.IO;

public partial class Public_PhotoSignature : System.Web.UI.Page
{
    #region"Variable Declaration"
    // private clsEmployee  = new clsEmployee();
    private clsStudent obj_Student = new clsStudent();
    private DataSet DS;
    private string myFileExtension;
    private int checkRecordStatus;
    public int StudentId;
  
    #endregion
    protected void Page_Load(object sender, EventArgs e)
    {
        StudentId = Convert.ToInt32(Request.QueryString["sid"]);
    }
    protected void btnConfirm_Click(object sender, EventArgs e)
    {
        try
        {
            myFileExtension = Path.GetExtension(FileUploadPhoto.PostedFile.FileName);
            if (FileUploadPhoto.HasFile)
            {
                if (myFileExtension == ".jpg" || myFileExtension == ".bmp" || myFileExtension == ".png" || myFileExtension == ".PNG" || myFileExtension == ".jpeg" || myFileExtension == ".JPG" || myFileExtension == ".gif")
                {
                    if (FileUploadPhoto.PostedFile.ContentLength < 51200)
                    {
                        obj_Student.StudentId = StudentId;
                        string FileNamekey = DateTime.Now.Ticks.ToString().Substring(12) + ".jpg";
                        FileUploadPhoto.SaveAs(MapPath("~/UploadedFile/" + "PH-" + FileNamekey));
                        System.Drawing.Image ImgOriginal = System.Drawing.Image.FromFile(MapPath("~/UploadedFile/") + "PH-" + FileNamekey);
                        System.Drawing.Image imgMain = ImgOriginal.GetThumbnailImage(200,200, null, IntPtr.Zero);
                        imgMain.Save(MapPath("~/UploadedFile/ImgMain/") + "PH-" + FileNamekey);
                        //Thumb Nail Genrator Coded By Rakesh Panchal
                        obj_Student.UploadImages = Path.GetFileName("PH-" + FileNamekey);
                        checkRecordStatus = obj_Student.AddStudentPhoto();
                        if (checkRecordStatus > 0)
                        {
                            lblMsg.ForeColor = Color.Green;
                            lblMsg.Text = "Photo Upload Successfully";
                            lblMsg.Visible = true;
                            // clrForm();
                        }
                        else
                        {
                            lblMsg.ForeColor = Color.Red;
                            lblMsg.Text = "Photo Already Exist ";
                            lblMsg.Visible = true;
                        }
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this.Page, typeof(string), "Alert", "alert('Maximum file size error');", true);
                    }
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this.Page, typeof(string), "Alert", "alert('Only jpeg, jpg, png, jpe, gif files are allowed');", true);
                }
            }
        }
        catch (Exception ex)
        {
            lblMsg.Text = ex.ToString();
        }
        try
        {
            myFileExtension = Path.GetExtension(FileUploadSignature.PostedFile.FileName);
            if (FileUploadSignature.HasFile)
            {
                if (myFileExtension == ".jpg" || myFileExtension == ".bmp" || myFileExtension == ".png" || myFileExtension == ".PNG" || myFileExtension == ".jpeg" || myFileExtension == ".JPG" || myFileExtension == ".gif")
                {
                    if (FileUploadSignature.PostedFile.ContentLength < 20400)
                    {
                        obj_Student.StudentId = StudentId;
                        string FileNamekey = DateTime.Now.Ticks.ToString().Substring(12) + ".jpg";
                        FileUploadSignature.SaveAs(MapPath("~/UploadedFile/" + "SIG-" + FileNamekey));
                        System.Drawing.Image ImgOriginal = System.Drawing.Image.FromFile(MapPath("~/UploadedFile/") + "SIG-" + FileNamekey);
                        System.Drawing.Image imgMain = ImgOriginal.GetThumbnailImage(200, 50, null, IntPtr.Zero);
                        imgMain.Save(MapPath("~/UploadedFile/ImgMain/") + "SIG -" + FileNamekey);
                        //Thumb Nail Genrator Coded By Rakesh Panchal
                        obj_Student.Signature = Path.GetFileName("SIG-" + FileNamekey);
                        checkRecordStatus = obj_Student.AddStudentSignature();
                        if (checkRecordStatus > 0)
                        {
                            lblMsg.ForeColor = Color.Green;
                            lblMsg.Text = "Registration is Successfull. Check your Email Id...";
                            lblMsg.Visible = true;
                            // clrForm();
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
                        ScriptManager.RegisterStartupScript(this.Page, typeof(string), "Alert", "alert('The file has to be less than 200kb only!');", true);
                    }
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this.Page, typeof(string), "Alert", "alert('Only jpeg, jpg, png, jpe, gif files are allowed');", true);
                }
            }
        }
        catch (Exception ex)
        {
            lblMsg.Text = ex.ToString();
        }


        if (StudentId > 0)
        {
            Response.Redirect("PaymentBy.aspx?sid=" + StudentId, false);
        }
    }
}