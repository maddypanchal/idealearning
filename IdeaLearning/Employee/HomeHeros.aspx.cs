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


public partial class Employee_HomeHeros : System.Web.UI.Page
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
            FillHomeHeros();
        }
    }
    #region Clear Form
    protected void clrForm()
    {
        txtCourse.Text = "";
        txtRank.Text = "";
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
                    FileUploadOnLocalComputer.SaveAs(MapPath("~/Employee/Toppers/" + "HO-" + FileNamekey));
                    System.Drawing.Image ImgOriginal = System.Drawing.Image.FromFile(MapPath("~/Employee/Toppers/") + "HO-" + FileNamekey);
                    System.Drawing.Image imgMain = ImgOriginal.GetThumbnailImage(570, 396, null, IntPtr.Zero);
                    imgMain.Save(MapPath("~/Employee/Toppers/ImgMain/") + "HO-" + FileNamekey);
                    //Thumb Nail Genrator Coded By Rakesh Panchal
                    obj_Toppers.ImagesName = Path.GetFileName("HO-" + FileNamekey);
                    obj_Toppers.Name = txtCourse.Text.Trim();
                    obj_Toppers.Rank = txtRank.Text.Trim();
                    checkRecordStatus = obj_Toppers.AddHomeHeros();
                    if (checkRecordStatus > 0)
                    {
                        lblMsg.ForeColor = Color.Green;
                        lblMsg.Text = "Product Record Saved!";
                        lblMsg.Visible = true;
                        clrForm();
                        FillHomeHeros();
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

    #region " Fill User Grid View"
    public void FillHomeHeros()
    {
        DS = obj_News.FillHomeHeros();
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
        obj_News.HomeHerosId = Convert.ToInt32(gvDetail1.DataKeys[e.RowIndex].Values["HomeHerosId"].ToString());
        RecordStatus = obj_News.DeleteHomeHeros();
        FillHomeHeros();
    }
    protected void gvDetail1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {

    }
}