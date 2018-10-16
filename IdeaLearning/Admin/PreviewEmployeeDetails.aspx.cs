using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Data;
using System.IO;
using System.Data.SqlClient;
using DataAccess;
using BusinessLogic.Admin;

public partial class Admin_PreviewEmployeeDetails : System.Web.UI.Page
{
    #region "Variable Decleration"
    private clsEmployee obj_Employee = new clsEmployee();
    private clsMaster obj_Master = new clsMaster();
    private DataSet DS;
    private static int EmployeeId;
    private static int StateId;
    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {

        EmployeeId = int.Parse(Request.QueryString["Eid"]);
        Session["EmployeeId"] = EmployeeId; 
        if (Session["AdminId"] == null)
        {
            Response.Redirect("~/login.aspx", false);
        }
        else
        {
            if (!IsPostBack)
            {
                FillCountryStateDropDown();

                
                FillEmployeeInformation();
           }
       }
    }

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

            StateId =Convert.ToInt32(Session["StateId"]);

            if (StateId == -1)
            {
                obj_Master.CountryId = Convert.ToInt32(ddlCountryRegion.SelectedValue);
                FillCountryStateDropDown1();
                ddlStateRegion.Visible = true;
                ddlStateRegion.DataBind();
            }
            else
            {

             

                obj_Master.CountryId = Convert.ToInt32(ddlCountryRegion.SelectedValue);

                DS = obj_Master.StateListDropdown1();
                ddlStateRegion.DataSource = DS;
                DS.Tables[0].Merge(DS.Tables[1]);
                ddlStateRegion.DataTextField = DS.Tables[0].Columns[1].ToString();
                ddlStateRegion.DataValueField = DS.Tables[0].Columns[0].ToString();
                ddlStateRegion.DataBind();
                ddlStateRegion.Dispose();
                ddlStateRegion.SelectedValue = StateId.ToString();
            }
          
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
    private void fillCity(string state, string country)
    {
        try
        {
            obj_Master.CountryId = Convert.ToInt32(country);
            obj_Master.StateId = Convert.ToInt32(state);

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

    protected void fillState(string Country)
    {
        try
        {
            obj_Master.CountryId = Convert.ToInt32(Country);

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
    
    #region " Fill Employee Informations"
    private void FillEmployeeInformation()
    {
        obj_Employee.EmployeeId = Convert.ToInt32(Session["EmployeeId"]);
        DS = obj_Employee.FillEmployeeBYID();
        if (DS.Tables[0].Rows.Count > 0)
        {
            foreach (DataRow row in DS.Tables[0].Rows)
            {
                lblEmployeeCode.Text = row["EmployeeCode"].ToString();
                ddlmentorsOne.SelectedValue = row["MentorsOne"].ToString();
                ddlmentorsTwo.SelectedValue = row["MentorsTwo"].ToString();
                ddlmentorsThree.SelectedValue = row["MentorsThree"].ToString();
                ddlmentorsFour.SelectedValue = row["MentorsFour"].ToString();
                txtDisgnation.Text=row["Designation"].ToString();
                txtDiscriptions.Text=row["Descriptions"].ToString();
                txtAddress.Text = row["Address"].ToString();
                txtDateOfBirth.Text = row["DateOfBirth"].ToString();
                txtDateOfjoin.Text = row["DateOfJoin"].ToString();
                txtMobile.Text = row["Mobile"].ToString();
                txtFatherName.Text = row["FatherName"].ToString();
                txtPassword.Text = row["Password"].ToString();
                ddlCountryRegion.SelectedValue=row["Country"].ToString();

                fillState(row["Country"].ToString());
                Session["StateId"] = row["State"].ToString();
                ddlStateRegion.SelectedValue=row["State"].ToString();
                fillCity(row["State"].ToString() , row["Country"].ToString());
                Session["CityId"] = row["City"].ToString();
                ddlCity.SelectedValue= row["City"].ToString();
                txtuserName.Text = row["UserName"].ToString();
                ddlGender.SelectedValue = row["Gender"].ToString();
                txtEmployeeName.Text = row["Name"].ToString();
                ddlEmpType.SelectedValue = row["EmployeeType"].ToString(); 
                txtWorkLocation.Text = row["WorkLocation"].ToString();
                txtExperience.Text = row["Experience"].ToString();
                txtOtherDuties.Text = row["OtherDuties"].ToString();
                txtQualification.Text = row["Qualification"].ToString();
                txtInterest.Text = row["Interest"].ToString();
                txtSequenceNumber.Text = row["SequenceNumber"].ToString();
                txtEmail.Text = row["Email"].ToString();
                if (row["UploadImages"].ToString() == "")
                {
                    imgUser.ImageUrl = "../UploadedFile/Defultuser.png";
                }
                else
                {
                   // imgUser.ImageUrl = "../UploadedFile/Defultuser.png";
                    imgUser.ImageUrl = "../CroppedImages/" + row["UploadImages"].ToString();
                }
            }
        }
    }
    #endregion
 
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        obj_Employee.EmployeeId = Convert.ToInt32(Session["EmployeeId"]);
        //obj_Employee.UploadImages = Session["ImagesName"].ToString();
        obj_Employee.EmployeeType = ddlEmpType.SelectedValue.ToString();
        obj_Employee.MentorsOne = ddlmentorsOne.SelectedValue.ToString();
        obj_Employee.MentorsTwo = ddlmentorsTwo.SelectedValue.ToString();
        obj_Employee.MentorsThree = ddlmentorsThree.SelectedValue.ToString();
        obj_Employee.MentorsFour = ddlmentorsFour.SelectedValue.ToString();
        obj_Employee.Address = txtAddress.Text.Trim();
        obj_Employee.DateOfBirth = txtDateOfBirth.Text.Trim();
        obj_Employee.SequenceNumber = txtSequenceNumber.Text.Trim();
        obj_Employee.Email = txtEmail.Text.Trim();
        obj_Employee.Name = txtEmployeeName.Text.Trim();
        obj_Employee.FatherName = txtFatherName.Text.Trim();
        obj_Employee.Gender = Convert.ToInt32(ddlGender.SelectedValue.ToString());
        obj_Employee.Mobile = txtMobile.Text.Trim();

        obj_Employee.DateOfJoin = txtDateOfjoin.Text.Trim();
        obj_Employee.EmployeeCode = lblEmployeeCode.Text.Trim();
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

        obj_Employee.DateOfBirth = txtDateOfBirth.Text.Trim();
        obj_Employee.Email = txtEmail.Text.Trim();
        obj_Employee.Name = txtEmployeeName.Text.Trim();
        obj_Employee.FatherName = txtFatherName.Text.Trim();
        obj_Employee.Gender = Convert.ToInt32(ddlGender.SelectedValue.ToString());
        obj_Employee.Mobile = txtMobile.Text.Trim();
        obj_Employee.Status = 2;
        obj_Employee.Country = ddlCountryRegion.SelectedValue.ToString();
        obj_Employee.City = ddlCity.SelectedValue.ToString();
        obj_Employee.State = ddlStateRegion.SelectedValue.ToString();
        if (Session["ImagesName"] == null)
        {
            obj_Employee.UploadImages = imgUser.ImageUrl.Replace("../CroppedImages/", String.Empty); 
        }
        else
        {
            obj_Employee.UploadImages = Session["ImagesName"].ToString();
        }
         DS = obj_Employee.UpdateEmployee();
        FillCountryStateDropDown();
        FillEmployeeInformation();
        Session["ImagesName"] = null;
    }
}