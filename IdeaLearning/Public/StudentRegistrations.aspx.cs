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
using System.Configuration;
using System.Globalization;

public partial class Public_StudentRegistrations : System.Web.UI.Page
{

    #region"Variable Declaration"
   
    private clsStudent obj_Student = new clsStudent();
    private clsMaster obj_Master = new clsMaster();
    private DataSet DS;
    private DataTable DT;
    private int checkRecordStatus;
    #endregion
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            FillCountryStateDropDown();
            FillCourses();
           
        }


    }

    private void FillCourses()
    {
        try
        {

            DS = obj_Master.DisplayCoursesForStudent();
            ddlCourse.DataSource = DS;
            DS.Tables[0].Merge(DS.Tables[1]);
            ddlCourse.DataTextField = DS.Tables[0].Columns[1].ToString();
            ddlCourse.DataValueField = DS.Tables[0].Columns[0].ToString();
            ddlCourse.DataBind();
            ddlCourse.Dispose();
        }
        catch (Exception ex)
        {
            // lblMsg.Visible = true;
            // lblMsg.Text = ex.ToString();
        }
    }



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
            lblMsg.Text = ex.Message;
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
            lblMsg.Text = ex.ToString();
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
            lblMsg.Text = ex.ToString();
        }
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
            lblMsg.Text = ex.Message;
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



    private void clearform()
    {
        txtaddress.Text = "";
        //txtCity.Text = "";
        txtConfirmPasword.Text = "";
        txtDateOfBirth.Text = "";
        txtEmail.Text = "";
        txtStudentName.Text = "";
        txtFatherName.Text = "";
        txtMotherName.Text = "";
        txtMobile.Text = "";
        txtPassword.Text = "";
      //  txtState.Text = "";
        txtUserName.Text = "";
        //lblmsg.Text = "Record Saved";
    }
    protected void btnNext_Click(object sender, EventArgs e)
    {
        obj_Student.MobileNumber = txtMobile.Text.Trim();
        obj_Student.Address = txtaddress.Text.Trim();
        DateTime date = DateTime.ParseExact(txtDateOfBirth.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture);
        obj_Student.DateOfBirth = date.ToString("yyyy-MM-dd");
        //obj_Student.DateOfBirth = txtDateOfBirth.Text.Trim();
        obj_Student.DateofRegistration = System.DateTime.Now.ToString();
        obj_Student.EmailID = txtEmail.Text.Trim();
        obj_Student.StudentName = txtStudentName.Text.Trim();
        obj_Student.FatherName = txtFatherName.Text.Trim();
        obj_Student.MotherName = txtMotherName.Text.Trim();
        obj_Student.Gender = ddlGender.SelectedValue.ToString();
        obj_Student.Status = 1;
        obj_Student.Password = txtPassword.Text.Trim();
        obj_Student.ConfirmPassword = txtConfirmPasword.Text.Trim();
        obj_Student.UserName = txtUserName.Text.Trim();
        string ReciptNoGen = ConfigurationManager.AppSettings["OnlineNoGen"].ToString();
        obj_Student.RegistrationNo = ReciptNoGen.ToString();
        obj_Student.CateGory = ddlCategory.SelectedValue.ToString();
        obj_Student.Country = ddlCountryRegion.SelectedValue.ToString();
        obj_Student.State = ddlStateRegion.SelectedValue.ToString();
        obj_Student.City = ddlCity.SelectedValue.ToString();
        obj_Student.DateofRegistration = System.DateTime.Today.Date.ToString();
    
        checkRecordStatus = obj_Student.AddOnlineStudent();
        if (checkRecordStatus > 0)
        {
            Response.Redirect("PhotoSignature.aspx?sid=" + checkRecordStatus , false);
        }
        clearform();
    }
}