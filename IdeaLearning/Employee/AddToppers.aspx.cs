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

public partial class Employee_AddToppers : System.Web.UI.Page
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
        if (!IsPostBack)
        {
            FillToppersYear();
          //  FillToppersCourses();
        }
    }

    #region "Fill Toppers Year List Method"
    protected void FillToppersYear()
    {
        try
        {
            DS = obj_Toppers.FillToppersYear();
            ddlTopers.DataSource = DS;
            ddlTopers.DataTextField = DS.Tables[0].Columns[1].ToString();
            ddlTopers.DataValueField = DS.Tables[0].Columns[0].ToString();
            ddlTopers.DataBind();
            ddlTopers.Items.Add(new System.Web.UI.WebControls.ListItem("---Select Years---", "0"));
            ddlTopers.SelectedValue = "0";
            DS.Dispose();
            ddlTopers.Dispose();

        }
        catch (Exception ex)
        {
            lblMsg.Text = ex.ToString();

        }

    }
    #endregion "End Main Category List Method"
    #region "Fill Toppers Courses List Method"
    protected void FillToppersCourses()
    {
        try
        {
            DS = obj_Toppers.FillToppersCourses();
            ddlCourses.DataSource = DS;
            ddlCourses.DataTextField = DS.Tables[0].Columns[1].ToString();
            ddlCourses.DataValueField = DS.Tables[0].Columns[0].ToString();
            ddlCourses.DataBind();
            ddlCourses.Items.Add(new System.Web.UI.WebControls.ListItem("---Select Exam---", "0"));
            ddlCourses.SelectedValue = "0";
            DS.Dispose();
            ddlCourses.Dispose();

        }
        catch (Exception ex)
        {
            lblMsg.Text = ex.ToString();

        }

    }
    #endregion "End Main Category List Method"
    #region Clear Form
    protected void clrForm()
    {
        txtName.Text = null;
        txtRanks.Text = null;
        txtRollNumber.Text = null;
        ddlCourses.SelectedValue = "0";
        ddlTopers.SelectedValue = "0";
    }
    #endregion
    #region"Add Toppers Images"
    protected void btnSave_Click(object sender, EventArgs e)
     {
           myFileExtension = Path.GetExtension(FileUploadOnLocalComputer.PostedFile.FileName);
                 if (FileUploadOnLocalComputer.HasFile)
                 {
                     if (myFileExtension == ".jpg" || myFileExtension == ".bmp" || myFileExtension == ".png" || myFileExtension == ".jpeg" || myFileExtension == ".JPG" || myFileExtension == ".gif")
                     {
                         if (FileUploadOnLocalComputer.PostedFile.ContentLength < 8000000)
                         {
                             string FileNamekey = DateTime.Now.Ticks.ToString().Substring(12) + ".jpg";
                             FileUploadOnLocalComputer.SaveAs(MapPath("~/Employee/Toppers/" + "TP-" + FileNamekey));
                             System.Drawing.Image ImgOriginal = System.Drawing.Image.FromFile(MapPath("~/Employee/Toppers/") + "TP-" + FileNamekey);
                             System.Drawing.Image imgMain = ImgOriginal.GetThumbnailImage(230, 220, null, IntPtr.Zero);
                             imgMain.Save(MapPath("~/Employee/Toppers/ImgMain/") + "TP-" + FileNamekey);
                             System.Drawing.Image ImgThumbnail = ImgOriginal.GetThumbnailImage(160, 170, null, IntPtr.Zero);
                             ImgThumbnail.Save(MapPath("~/Employee/Toppers/ImgThumbnail/") + "TP-" + FileNamekey);
                             System.Drawing.Image MiniThumbnail = ImgOriginal.GetThumbnailImage(55, 55, null, IntPtr.Zero);
                             MiniThumbnail.Save(MapPath("~/Employee/Toppers/ImgMiniThumbnail/") + "TP-" + FileNamekey);
                              //Thumb Nail Genrator Coded By Rakesh Panchal
                             obj_Toppers.ImagesName = Path.GetFileName("TP-" + FileNamekey);
                             obj_Toppers.Name = txtName.Text.Trim();
                             obj_Toppers.RollNumber = txtRollNumber.Text.Trim();
                             obj_Toppers.Courses= ddlCourses.SelectedItem.ToString();
                             obj_Toppers.Toppers=ddlTopers.SelectedItem.ToString();
                             obj_Toppers.Rank = txtRanks.Text.Trim();
                             checkRecordStatus = obj_Toppers.AddToppers();
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