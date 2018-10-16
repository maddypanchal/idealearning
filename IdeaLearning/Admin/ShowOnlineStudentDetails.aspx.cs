using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Data;
using System.IO;
using System.Data.SqlClient;
using DataAccess;
using BusinessLogic.Admin;
using System;


public partial class Admin_ShowOnlineStudentDetails : System.Web.UI.Page
{

    #region "Variable Decleration"
    private clsStudent obj_Employee = new clsStudent();
    private clsMaster obj_Master = new clsMaster();
    private DataSet DS;
    private static int OnlineStudentId;
    private static int StateId;
    #endregion


    protected void Page_Load(object sender, EventArgs e)
    {
        OnlineStudentId = int.Parse(Request.QueryString["Sid"]);
        Session["OnlineStudentId"] = OnlineStudentId;
        if (Session["OnlineStudentId"] == null)
        {
            Response.Redirect("~/login.aspx", false);
        }
        else
        {
            if (!IsPostBack)
            {
                FillCountryStateDropDown();

                FillCourses();
                FillStudentInformation();
            }
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

            StateId = Convert.ToInt32(Session["StateId"]);

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
    private void FillStudentInformation()
    {
        obj_Employee.OnlineStudentRegistrationId = Convert.ToInt32(Session["OnlineStudentId"]);
        DS = obj_Employee.DisplayOnlineStudent();
        if (DS.Tables[0].Rows.Count > 0)
        {
            foreach (DataRow row in DS.Tables[0].Rows)
            {
                txtMotherName.Text = row["MotherName"].ToString();
                txtaddress.Text = row["Address"].ToString();
                txtDateOfBirth.Text = row["DateOfBirth"].ToString();
                txtStudentName.Text = row["StudentName"].ToString();
                txtMobile.Text = row["MobileNumber"].ToString();
                txtFatherName.Text = row["FatherName"].ToString();
                txtPassword.Text = row["Password"].ToString();
                ddlCountryRegion.SelectedValue = row["Country"].ToString();
                ddlCourse.SelectedValue = row["CoursesName"].ToString();
                ddlCategory.SelectedValue=row["CateGory"].ToString();
                fillState(row["Country"].ToString());
                Session["StateId"] = row["State"].ToString();
                ddlStateRegion.SelectedValue = row["State"].ToString();
                fillCity(row["State"].ToString(), row["Country"].ToString());
                Session["CityId"] = row["City"].ToString();
                ddlCity.SelectedValue = row["City"].ToString();
                txtUserName.Text = row["UserName"].ToString();
                ddlGender.SelectedValue = row["Gender"].ToString();
                      
                txtEmail.Text = row["EmailID"].ToString();
                if (row["Photo"].ToString() == "")
                {
                     imgPhoto.ImageUrl = "../UploadedFile/Defultuser.png";
                }
                else
                {
                    // imgUser.ImageUrl = "../UploadedFile/Defultuser.png";
                    imgPhoto.ImageUrl = "../UploadedFile/" + row["Photo"].ToString();
                }

                if (row["Sign"].ToString() == "")
                {
                    ImgSign.ImageUrl = "../UploadedFile/Defultuser.png";
                }
                else
                {
                    // imgUser.ImageUrl = "../UploadedFile/Defultuser.png";
                    ImgSign.ImageUrl = "../UploadedFile/" + row["Sign"].ToString();
                }
            }
        }
    }
    #endregion

   
}