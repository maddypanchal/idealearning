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

public partial class Employee_AddHeros : System.Web.UI.Page
{
    #region "VARIABLE DECLARATION"
    private clsToppers obj_Toppers = new clsToppers();
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
        txtName.Text = null;
        txtRanks.Text = null;
        txtRollNumber.Text = null;
        ddlCourses.SelectedValue = "-1";
        ddlTopers.SelectedValue = "-1";
    }
    #endregion
    #region"Add Heros Images"
    protected void btnSave_Click1(object sender, EventArgs e)
    {
        myFileExtension = Path.GetExtension(FileUploadOnLocalComputer.PostedFile.FileName);
        if (FileUploadOnLocalComputer.HasFile)
        {
            if (myFileExtension == ".jpg" || myFileExtension == ".bmp" || myFileExtension == ".png" || myFileExtension == ".jpeg" || myFileExtension == ".JPG" || myFileExtension == ".gif")
            {
                if (FileUploadOnLocalComputer.PostedFile.ContentLength < 2000000)
                {
                    string FileNamekey = DateTime.Now.Ticks.ToString().Substring(12) + ".jpg";
                    FileUploadOnLocalComputer.SaveAs(MapPath("~/Employee/Toppers/" + "HO-" + FileNamekey));
                    System.Drawing.Image ImgOriginal = System.Drawing.Image.FromFile(MapPath("~/Employee/Toppers/") + "HO-" + FileNamekey);
                    System.Drawing.Image imgMain = ImgOriginal.GetThumbnailImage(250, 250, null, IntPtr.Zero);
                    imgMain.Save(MapPath("~/Employee/Toppers/ImgMain/") + "HO-" + FileNamekey);
                    //Thumb Nail Genrator Coded By Rakesh Panchal
                    obj_Toppers.ImagesName = Path.GetFileName("HO-" + FileNamekey);
                    obj_Toppers.Name = txtName.Text.Trim();
                    obj_Toppers.RollNumber = txtRollNumber.Text.Trim();
                    obj_Toppers.Courses = ddlCourses.SelectedItem.ToString();
                    obj_Toppers.Toppers = ddlTopers.SelectedItem.ToString();
                    obj_Toppers.Rank = txtRanks.Text.Trim();
                    checkRecordStatus = obj_Toppers.AddHeros();
                    if (checkRecordStatus > 0)
                    {
                        lblMsg.ForeColor = Color.Green;
                        lblMsg.Text = "Record Saved!";
                        lblMsg.Visible = true;
                        clrForm();
                    }
                    else
                    {
                        lblMsg.ForeColor = Color.Red;
                        lblMsg.Text = "Already Exist ";
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
    #endregion
}