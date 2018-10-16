using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.IO;
using DataAccess;
using BusinessLogic.Admin;
using System.Configuration;

public partial class Admin_AddEmployee : System.Web.UI.Page
{   
    #region"Variable Declaration"
    private clsMaster obj_Master = new clsMaster();
    private clsEmployee obj_Employee = new clsEmployee();
    private DataSet DS;
    private int checkRecordStatus;
    private string myFileExtension;
    #endregion

    #region"Page load Eevent"
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["AdminId"] == null)
        {
            Response.Redirect("~/login.aspx", false);
        }
        else
        {

            if (!IsPostBack)
            {
                 FillCountryStateDropDown();
            }
        }
    }
    #endregion

    #region"Record Saved event"
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
           try
               {
            //obj_Employee.UploadImages = Session["ImagesName"].ToString(); 



            myFileExtension = Path.GetExtension(FileUploadOnLocalComputer.PostedFile.FileName);
            if (FileUploadOnLocalComputer.HasFile)
            {
                if (myFileExtension == ".jpg" || myFileExtension == ".bmp" || myFileExtension == ".png" || myFileExtension == ".jpeg" || myFileExtension == ".JPG" || myFileExtension == ".gif")
                {
                    if (FileUploadOnLocalComputer.PostedFile.ContentLength < 2000000)
                    {
                        string FileNamekey = DateTime.Now.Ticks.ToString().Substring(12) + ".jpg";
                        FileUploadOnLocalComputer.SaveAs(MapPath("~/CroppedImages/" + "Photo-" + FileNamekey));
                        //System.Drawing.Image ImgOriginal = System.Drawing.Image.FromFile(MapPath("~/Employee/Toppers/") + "GA-" + FileNamekey);
                        //System.Drawing.Image imgMain = ImgOriginal.GetThumbnailImage(570, 396, null, IntPtr.Zero);
                        //imgMain.Save(MapPath("~/CroppedImages/") + "GA-" + FileNamekey);
                        //Thumb Nail Genrator Coded By Rakesh Panchal
                        obj_Employee.UploadImages = Path.GetFileName("Photo-" + FileNamekey);



                    }
                }
            }

                        obj_Employee.EmployeeType = ddlEmpType.SelectedValue.ToString();
                        obj_Employee.MentorsOne = ddlmentorsOne.SelectedValue.ToString();
                        obj_Employee.MentorsTwo = ddlmentorsTwo.SelectedValue.ToString();
                        obj_Employee.MentorsThree = ddlmentorsThree.SelectedValue.ToString();
                        obj_Employee.MentorsFour = ddlmentorsFour.SelectedValue.ToString();
                        obj_Employee.Address =txtaddress.Text.Trim();
                        obj_Employee.DateOfBirth = txtDateOfBirth.Text.Trim();
                        obj_Employee.SequenceNumber = txtSequenceNumber.Text.Trim();
                        obj_Employee.Email = txtEmail.Text.Trim();
                        obj_Employee.Name = txtEmployeeName.Text.Trim();
                        obj_Employee.FatherName = txtFatherName.Text.Trim();
                        obj_Employee.Gender = Convert.ToInt32(ddlGender.SelectedValue.ToString());
                        obj_Employee.Mobile = txtMobile.Text.Trim();
                        obj_Employee.City = ddlCity.SelectedValue.ToString();
                        obj_Employee.State = ddlStateRegion.SelectedValue.ToString();
                        obj_Employee.Country = ddlCountryRegion.SelectedValue.ToString();
                        obj_Employee.DateOfJoin = txtDateOfjoin.Text.Trim();
                        obj_Employee.EmployeeCode = ConfigurationManager.AppSettings["EmpNoGen"];
                        obj_Employee.Status = 2;
                        obj_Employee.Password = txtPassword.Text.Trim();
                        obj_Employee.UserName = txtuserName.Text.Trim();
                        obj_Employee.Descriptions = txtDiscriptions.Text.Trim();
                        obj_Employee.Designation = txtDisgnation.Text.Trim();
                        obj_Employee.WorkLocation = txtWorkLocation.Text.Trim();
                        obj_Employee.Qualification = txtQualification.Text.Trim();
                        obj_Employee.OtherDuties = txtOtherDuties.Text.Trim();
                        obj_Employee.Interest = txtInterest.Text.Trim();
                        obj_Employee.Experience = txtExperience.Text.Trim();
                        checkRecordStatus = obj_Employee.AddEmployee();
                        if (checkRecordStatus == 1)
                        {
                              //lblMsg.ForeColor = Color.Green;
                              //lblMsg.Text = "Product Record Save";
                              //lblMsg.Visible = true;
                               ScriptManager.RegisterStartupScript(this.Page, typeof(string), "Alert", "alert('Record Saved!');", true);
                        }
                        else
                        {
                               //lblMsg.ForeColor = Color.Red;
                               //lblMsg.Text = "Product Already Exist ";
                               //lblMsg.Visible = true;
                               //ScriptManager.RegisterStartupScript(this.Page, typeof(string), "Alert", "alert('Registration Number Already Exist !');", true);
                        }

              
        }
        catch (Exception ex)
        {
           // lblMsg.Text = ex.ToString();
        }
        clearform();
        Response.Redirect("EmployeeDetails.aspx");
    }
    #endregion
    #region"clear form "
    private void clearform()
    {
        // txtAddress.Text = "";
        //   txtCity.Text = "";
        txtConfirm.Text = "";
        txtDateOfBirth.Text = "";
        txtEmail.Text = "";
        txtEmployeeName.Text = "";
        txtFatherName.Text = "";
        txtMobile.Text = "";
        txtPassword.Text = "";
       // txtState.Text = "";
        txtuserName.Text = "";
        ddlmentorsOne.SelectedIndex = -1;
       
        txtDisgnation.Text = "";
        txtDiscriptions.Text = "";
        //lblmsg.Text = "Record Save";
    }
    #endregion
    #region"Fill City by country and State"
    protected void ddlStateRegion_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            obj_Master.CountryId = Convert.ToInt32(ddlCountryRegion.SelectedValue);
            obj_Master.StateId = Convert.ToInt32(ddlStateRegion.SelectedValue);
            FillCountryCity();
            ddlCity.Visible = true;
            ddlCity.DataBind();
        }
        catch (Exception ex)
        {
            // lblregion.Text = ex.Message;
        }
    }
    #endregion
    #region "FILL state ddl in region"
    protected void FillCountryCity()
    {
        try
        {
            obj_Master.CountryId = Convert.ToInt32(ddlCountryRegion.SelectedValue);
            obj_Master.StateId = Convert.ToInt32(ddlStateRegion.SelectedValue);
            //obj_region.UniqueIdentification = UniqueId;
            DS = obj_Master.CityList();
            ddlCity.DataSource = DS;
            DS.Tables[0].Merge(DS.Tables[1]);
            ddlCity.DataTextField = DS.Tables[0].Columns[1].ToString();
            ddlCity.DataValueField = DS.Tables[0].Columns[0].ToString();
            ddlCity.DataBind();
            ddlCity.Dispose();
        }
        catch (Exception ex)
        {
            //lblBatch.Text = ex.ToString();
        }

    }

    #endregion
    #region "Country select index changed"
    protected void ddlCountryRegion_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            obj_Master.CountryId = Convert.ToInt32(ddlCountryRegion.SelectedValue);
            FillCountryStateDropDown1();
            ddlStateRegion.Visible = true;
            ddlStateRegion.DataBind();
        }
        catch (Exception ex)
        {
            // lblregion.Text = ex.Message;
        }
    }
    #endregion
    #region "FILL country ddl in region"
    protected void FillCountryStateDropDown()
    {
        try
        {
            //obj.UniqueIdentification = UniqueId;
            DS = obj_Master.CountryListDropdown();
            ddlCountryRegion.DataSource = DS;
            DS.Tables[0].Merge(DS.Tables[1]);
            ddlCountryRegion.DataTextField = DS.Tables[0].Columns[1].ToString();
            ddlCountryRegion.DataValueField = DS.Tables[0].Columns[0].ToString();
            ddlCountryRegion.DataBind();
            ddlCountryRegion.Dispose();
        }
        catch (Exception ex)
        {
            //llbSubject.Text = ex.ToString();
        }
    }

    #endregion
    #region "FILL state ddl in region"
    protected void FillCountryStateDropDown1()
    {
        try
        {
            obj_Master.CountryId = Convert.ToInt32(ddlCountryRegion.SelectedValue);
            //obj_region.UniqueIdentification = UniqueId;
            DS = obj_Master.StateListDropdown1();
            ddlStateRegion.DataSource = DS;
            DS.Tables[0].Merge(DS.Tables[1]);
            ddlStateRegion.DataTextField = DS.Tables[0].Columns[1].ToString();
            ddlStateRegion.DataValueField = DS.Tables[0].Columns[0].ToString();
            ddlStateRegion.DataBind();
            ddlStateRegion.Dispose();

        }
        catch (Exception ex)
        {
            //   lblBatch.Text = ex.ToString();
        }

    }

    #endregion

}