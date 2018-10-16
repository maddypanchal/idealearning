using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Drawing;

public partial class Admin_Cropimages : System.Web.UI.Page
{
    #region"Variable Declaration"
    private string myFileExtension;
    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        { 
        FileUpload1.Attributes["onchange"] = "UploadFile(this)";
        }
    }

    protected void Upload(object sender, EventArgs e)
    {
        try
        {
            ImFullImage.Visible = true;
            myFileExtension = Path.GetExtension(FileUpload1.PostedFile.FileName);
            if (FileUpload1.HasFile)
            {
                if (myFileExtension == ".jpg" || myFileExtension == ".bmp" || myFileExtension == ".png" || myFileExtension == ".jpeg" || myFileExtension == ".JPG" || myFileExtension == ".gif")
                {
                    if (FileUpload1.PostedFile.ContentLength < 8000000)
                    {
                        string FileNamekey = DateTime.Now.Ticks.ToString().Substring(12) + ".jpg";
                        FileUpload1.SaveAs(MapPath("~/UploadedFile/" + "EMP-" + FileNamekey));
                        System.Drawing.Image ImgOriginal = System.Drawing.Image.FromFile(MapPath("~/UploadedFile/") + "EMP-" + FileNamekey);
                        ImFullImage.ImageUrl = "~/UploadedFile/" + Path.GetFileName("EMP-" + FileNamekey);
                        Session["ImagesName"] = Path.GetFileName("EMP-" + FileNamekey);
                        lblMessage.Visible = true;
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this.Page, typeof(string), "Alert", "alert('The file has to be less than 6MB only!');", true);
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
            lblMessage.Text = ex.ToString();
        }
    }

    public void CropImage(string path, int X, int Y, int Width, int Height)
    {

        if (Width != 0 && Height != 0)
        {
            using (System.Drawing.Image img = System.Drawing.Image.FromFile(path))
            {
                lblmsg.Text = " Your Cropped Image is Saved. To return to the back page Cancel the popup Window form top right corner.";
                string ImgName = System.IO.Path.GetFileName(path);
                if (Width != 0 && Height !=0 )
                {
                    using (Bitmap bmpCropped = new Bitmap(Width, Height))
                    {
                        using (Graphics g = Graphics.FromImage(bmpCropped))
                        {
                            string FileNamekey = DateTime.Now.Ticks.ToString().Substring(12) + ".jpg";
                            Rectangle rectDestination = new Rectangle(0, 0, bmpCropped.Width, bmpCropped.Height);
                            Rectangle rectCropArea = new Rectangle(X, Y, Width, Height);
                            g.DrawImage(img, rectDestination, rectCropArea, GraphicsUnit.Pixel);
                            string SaveTo = Server.MapPath("~/CroppedImages/") + ImgName;
                            bmpCropped.Save(SaveTo);
                            string CroppedImg = Request.ApplicationPath + @"CroppedImages/" + ImgName;
                            imCropped.Visible = true;
                            imCropped.ImageUrl = CroppedImg;
                        }
                    }
                 }
                else
                {
                    lblmsg.Text = "Select Crop on Image !";
                }
            }
         }
        else
        {
            lblmsg.Text="Frist you have upload Image and Select Crop Image !";
        }
    }

    protected void btnCrop_Click(object sender, EventArgs e)
    {
        int x, y, w, h;
        if (!int.TryParse(hfX.Value, out x))
        {
            //Set default x value
            x = 0;
        }
        if (!int.TryParse(hfY.Value, out y))
        {
            //Set default y value
            y = 0;
        }
        if (!int.TryParse(hfHeight.Value, out h))
        {
            //Set default height value
            h = 0;
        }
        if (!int.TryParse(hfWidth.Value, out w))
        {
            //Set default width value
            w = 0;
        }

        //  CropImage(Server.MapPath(".") + "~/images/arc1.jpg", x, y, w, h);
        //  CropImage(Server.MapPath("~/images/") + "arc1.jpg", x, y, w, h);
        CropImage(Server.MapPath("~/UploadedFile/") + Session["ImagesName"], x, y, w, h);

    }


}