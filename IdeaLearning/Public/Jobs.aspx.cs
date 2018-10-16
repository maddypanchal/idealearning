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

public partial class Public_Jobs : System.Web.UI.Page
{
    #region"Variable Declaration"
    private clsMaster objMaster = new clsMaster();
    private SendSMS objSendSms = new SendSMS();
    private DataSet DS;
    private int checkRecordStatus;
    private string myFileExtension;
    public int StudentId;
    #endregion
    public string alertmsg = "Your Application is successfully uploaded. We will contact you later for further Interview/ Written Test...";
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    private void clearform()
    {
      
        txtEmail.Text = "";
        txtName.Text = "";
        txtFatherName.Text = "";
        txtMobile.Text = "";
        txtcurrentctc.Text = "";
        txtDegree.Text = "";
        txtCurrentEmployee.Text = "";
        txtexpected.Text = "";
        txtExperience.Text = "";
        txtQual2.Text = "";
        txtPosition.Text = "";
        txtAddress.Text = "";
     
        ddlJobTitle.SelectedIndex = -1;
        ddlGender.SelectedIndex = -1;

   
    
    }
    protected void btnNext_Click(object sender, EventArgs e)
    {
       try
        {
            myFileExtension = Path.GetExtension(FileUploadPhoto.PostedFile.FileName);
            if (FileUploadPhoto.HasFile)
            {
                if (myFileExtension == ".jpg" || myFileExtension == ".bmp" || myFileExtension == ".png" || myFileExtension == ".PNG" || myFileExtension == ".jpeg" || myFileExtension == ".JPG" || myFileExtension == ".gif")
                {
                    if (FileUploadPhoto.PostedFile.ContentLength < 8000000)
                    {
                        string FileNamekey = DateTime.Now.Ticks.ToString().Substring(12) + ".jpg";
                        FileUploadPhoto.SaveAs(MapPath("~/UploadedFile/" + "CP-" + FileNamekey));
                        System.Drawing.Image ImgOriginal = System.Drawing.Image.FromFile(MapPath("~/UploadedFile/") + "CP-" + FileNamekey);
                        System.Drawing.Image imgMain = ImgOriginal.GetThumbnailImage(200, 200, null, IntPtr.Zero);
                        imgMain.Save(MapPath("~/UploadedFile/ImgMain/") + "CP-" + FileNamekey);
                        //Thumb Nail Genrator Coded By Rakesh Panchal
                        objMaster.UploadImages = Path.GetFileName("CP-" + FileNamekey);
                
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this.Page, typeof(string), "Alert", "alert('Image file size is more then 8 MB. Your image is not uploaded Successfully but other records are saved !');", true);
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
           myFileExtension = Path.GetExtension(FileUploadResume.PostedFile.FileName);
           if (FileUploadResume.HasFile)
           {
               if (myFileExtension == ".doc" || myFileExtension == ".docx" || myFileExtension == ".pdf" )
               {
                   if (FileUploadPhoto.PostedFile.ContentLength < 8000000)
                   {
                      
                      
                    


                       string FileNamekey = DateTime.Now.Ticks.ToString().Substring(12) + ".docx";
                       FileUploadResume.SaveAs(MapPath("~/UploadedFile/" + "CV-" + FileNamekey));
                 
                       //Thumb Nail Genrator Coded By Rakesh Panchal
                       objMaster.Resume = Path.GetFileName("CV-" + FileNamekey);
                   
                   }
                   else
                   {
                       ScriptManager.RegisterStartupScript(this.Page, typeof(string), "Alert", "alert('CV file size is more then 8 MB. Your CV is not uploaded Successfully but other records are saved !!');", true);
                   }
               }
               else
               {
                   ScriptManager.RegisterStartupScript(this.Page, typeof(string), "Alert", "alert('Only pdf, doc , docx files are allowed');", true);
               }
           }
       }
       catch (Exception ex)
       {
           lblMsg.Text = ex.ToString();
       }
       objMaster.Name = txtName.Text.Trim();
       objMaster.FatherName = txtFatherName.Text.Trim();
       objMaster.CurrentEmployee = txtCurrentEmployee.Text.Trim();
       objMaster.Mobile = txtMobile.Text.Trim();
       objMaster.Email = txtEmail.Text.Trim();
       objMaster.Address = txtAddress.Text.Trim();

       objMaster.PositionAppliying = txtPosition.Text.Trim();
       objMaster.Degree = txtDegree.Text.Trim();
       objMaster.Degree2 = txtQual2.Text.Trim();
       objMaster.Experience = txtexpected.Text.Trim();
       objMaster.CurrentCTC = txtcurrentctc.Text.Trim();
       objMaster.ExpectedCTC = txtexpected.Text.Trim();
       objMaster.Gender = ddlGender.SelectedItem.ToString();
       objMaster.JobTitle = ddlJobTitle.SelectedItem.ToString();
       objMaster.CurrentDeisgnation = txtCurrentDeisgnation.Text.Trim();

       checkRecordStatus = objMaster.AddCarrer();
       if (checkRecordStatus > 0)
       {
           lblMsg.ForeColor = Color.Green;
           lblMsg.Text = "Your Application Successfully registered";
           lblMsg.Visible = true;
         
           //objSendSms.SendSMS_Career(txtName.Text, txtPosition.Text, txtMobile.Text);
           //objSendSms.SendSMS_Career(txtName.Text, txtPosition.Text, txtMobile.Text,alertmsg);
           ScriptManager.RegisterStartupScript(this.Page, typeof(string), "Alert", "alert('" + alertmsg + "');", true);
           // clrForm();
       }
       else
       {
           lblMsg.ForeColor = Color.Red;
           lblMsg.Text = "Record Already Exist ";
           lblMsg.Visible = true;
       }
           // Response.Redirect("PhotoSignature.aspx?sid=" + checkRecordStatus, false);
           clearform();
    }
}