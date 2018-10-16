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

public partial class Employee_AddSlider : System.Web.UI.Page
{
    #region "VARIABLE DECLARATION"
    private clsSlider obj_Images = new clsSlider();
    private DataSet DS;
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
        txtProductTitle.Text = null;
       // txtProductDescription.Text = null;
    }
    #endregion

    protected void btnSave_Click(object sender, EventArgs e)
    {
        {
            try
            {
                myFileExtension = Path.GetExtension(FileUploadOnLocalComputer.PostedFile.FileName);
                if (FileUploadOnLocalComputer.HasFile)
                {
                    if (myFileExtension == ".jpg" || myFileExtension == ".bmp" || myFileExtension == ".png" || myFileExtension == ".jpeg" || myFileExtension == ".JPG" || myFileExtension == ".gif")
                    {
                        if (FileUploadOnLocalComputer.PostedFile.ContentLength < 2000000)
                        {
                            string FileNamekey = DateTime.Now.Ticks.ToString().Substring(12) + ".jpg";
                            FileUploadOnLocalComputer.SaveAs(MapPath("~/UploadedFile/" + "CM-" + FileNamekey));
                            System.Drawing.Image ImgOriginal = System.Drawing.Image.FromFile(MapPath("~/UploadedFile/") + "CM-" + FileNamekey);
                            System.Drawing.Image imgMain = ImgOriginal.GetThumbnailImage(700, 400, null, IntPtr.Zero);
                            imgMain.Save(MapPath("~/UploadedFile/ImgMain/") + "CM-" + FileNamekey);
                     
                            //Thumb Nail Genrator Coded By Rakesh Panchal
                            obj_Images.ImagesName = Path.GetFileName("CM-" + FileNamekey);
                            obj_Images.ImagesTitle = txtProductTitle.Text.Trim();
                           // obj_Images.ImagesDescription = txtProductDescription.Text.Trim();
                            checkRecordStatus = obj_Images.AddProduct();
                            if (checkRecordStatus > 0)
                            {
                                lblMsg.ForeColor = Color.Green;
                                lblMsg.Text = "Product Record Saved!";
                                lblMsg.Visible = true;
                                clrForm();
                                Response.Redirect("SliderDetails.aspx");
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
            }
            catch (Exception ex)
            {
                lblMsg.Text = ex.ToString();
            }
        }
    }
}