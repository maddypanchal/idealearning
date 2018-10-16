using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using BusinessLogic.Admin;
using System.IO;
using CKEditor.NET;

public partial class Employee_AddEvents : System.Web.UI.Page
{

    #region"Variable Declaration"
    private clsEvents obj_Events = new clsEvents();
    private DataSet DS;
    private int checkRecordStatus;
    private string myFileExtension;
    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {
        txtTitleDate.Text = DateTime.Today.ToString("dd/MM/yyyy"); 
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
       try
        {
             myFileExtension = Path.GetExtension(FileUploadResume.PostedFile.FileName);
             if (FileUploadResume.HasFile)
             {
                 if (myFileExtension == ".doc" || myFileExtension == ".docx" || myFileExtension == ".pdf" || myFileExtension == ".jpg" || myFileExtension == ".JPG" || myFileExtension == ".JPEG" || myFileExtension == ".PDF")
                  {
                    if (FileUploadResume.PostedFile.ContentLength < 40000000)
                    {
                        if (myFileExtension == ".doc" || myFileExtension == ".docx")
                        {
                            string FileNamekey = DateTime.Now.Ticks.ToString().Substring(12) + ".docx";
                            FileUploadResume.SaveAs(MapPath("~/UploadedFile/" + "IMP-" + FileNamekey));
                            obj_Events.Description = Path.GetFileName("IMP-" + FileNamekey);
                        }
                        if (myFileExtension == ".jpg" || myFileExtension == ".JPG")
                        {
                            string FileNamekey = DateTime.Now.Ticks.ToString().Substring(12) + ".jpg";
                            FileUploadResume.SaveAs(MapPath("~/UploadedFile/" + "IMP-" + FileNamekey));
                            obj_Events.Description = Path.GetFileName("IMP-" + FileNamekey);
                        }
                        if (myFileExtension == ".pdf" || myFileExtension == ".PDF")
                        {
                            string FileNamekey = DateTime.Now.Ticks.ToString().Substring(12) + ".pdf";
                            FileUploadResume.SaveAs(MapPath("~/UploadedFile/" + "IMP-" + FileNamekey));
                            obj_Events.Description = Path.GetFileName("IMP-" + FileNamekey);
                        }
                        
                     

                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this.Page, typeof(string), "Alert", "alert('The file has to be less than 4mb only!');", true);
                    }
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this.Page, typeof(string), "Alert", "alert('Only pdf, doc , docx, JPG files are allowed');", true);
                }
            }
        }
        catch (Exception ex)
        {
            lblmsg.Text = ex.ToString();
        }

        obj_Events.EventName = txtTitle.Text.Trim();
        obj_Events.EventDate = txtTitleDate.Text.Trim();
     
        checkRecordStatus = obj_Events.InsertEvents();
        if (checkRecordStatus == 0)
        {
            lblmsg.Text = "Record Saved!";
        }
        clearform();
        txtTitleDate.Text = DateTime.Today.ToString("dd/MM/yyyy");

        Response.Redirect("../Employee/EventsDetails.aspx");

    }

    private void clearform()
    {
        txtTitle.Text = "";
        txtTitleDate.Text = "";
        //CKEditor1.Text = "";
        lblmsg.Text = "Record Saved!";
    }
}