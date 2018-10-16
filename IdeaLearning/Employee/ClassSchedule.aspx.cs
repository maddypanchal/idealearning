using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.IO;
using System.Data.SqlClient;
using System.Data;
using DataAccess;
using BusinessLogic.Admin;

public partial class Employee_ClassSchedule : System.Web.UI.Page
{

    #region "VARIABLE DECLARATION"
    private clsMaster obj_Master = new clsMaster();
    private DataSet DS;
    private int checkRecordStatus;
    private string myFileExtension;
    private DateTime firstDate;
    private DateTime secondDate;
    #endregion

    #region"Page Load"
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            FillClass();
        }
    }
    #endregion

    #region "Fill Class List Method"
    protected void FillClass()
    {
        try
        {


            DS = obj_Master.FillClassDdl();
            ddlClass.DataSource = DS;
            DS.Tables[0].Merge(DS.Tables[1]);
            ddlClass.DataTextField = DS.Tables[0].Columns[1].ToString();
            ddlClass.DataValueField = DS.Tables[0].Columns[0].ToString();
            ddlClass.DataBind();
            ddlClass.Dispose();


      
        }
        catch (Exception ex)
        {
            lblMsg.Text = ex.ToString();
        }
    }
    #endregion "End Main Category List Method"

    #region"Save Event of Class Schedule"
    protected void btnSave_Click(object sender, EventArgs e)
    {


        myFileExtension = Path.GetExtension(FileUploadPDF.PostedFile.FileName);
        if (FileUploadPDF.HasFile)
        {
            if (myFileExtension == ".pdf" || myFileExtension == ".PDF" || myFileExtension == ".docx" || myFileExtension == ".doc")
            {
                if (FileUploadPDF.PostedFile.ContentLength < 4000000)
                {
                    string FileNamekey = DateTime.Now.Ticks.ToString().Substring(12) + ".pdf";
                    FileUploadPDF.SaveAs(MapPath("~/Employee/PdfFile/" + "CS-" + FileNamekey));
                    //Thumb Nail Genrator Coded By Rakesh Panchal
                    obj_Master.pdffile = Path.GetFileName("CS-" + FileNamekey);
                    obj_Master.ClassId = Convert.ToInt32(ddlClass.SelectedValue.ToString());
                    obj_Master.FormDate =txtDateFrom.Text.Trim();
                    obj_Master.TillDate =txtTillDate.Text.Trim();
                    checkRecordStatus = obj_Master.AddClassSchedule();
                    if (checkRecordStatus >= 0)
                    {
                        lblMsg.Text = "Record Saved !";
                        ddlClass.SelectedIndex = -1;
                        txtDateFrom.Text = "";
                        txtTillDate.Text = "";
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
                    ScriptManager.RegisterStartupScript(this.Page, typeof(string), "Alert", "alert('The file has to be less than 4MB only!');", true);
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