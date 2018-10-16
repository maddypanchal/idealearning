using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using DataAccess;
using BusinessLogic.Admin;


public partial class Employee_UpdateStudentAddress : System.Web.UI.Page
{
    #region "Variable Decleration"
    private clsStudent obj_Student = new clsStudent();
    private clsMaster obj_Master = new clsMaster();
    private DataSet DS;
    private DataSet DS_Two;
    private DataSet DS_Three;
    private DataSet DS_Four;
   
    private static int StateId;
    private static int StudentId;
    private static string ClassId;

    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {
        StudentId = Convert.ToInt32(Session["StudentId"]);

        if (!IsPostBack)
        {
            FillCountryStateDropDown();
            FillStudentInformation();
        }
    }

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


    #region " Fill contorole on Form "
    private void FillStudentInformation()
    {
        obj_Student.StudentId = StudentId;
        DS = obj_Student.DisplayStudentForUpdate();
        if (DS.Tables[0].Rows.Count > 0)
        {
            foreach (DataRow row in DS.Tables[0].Rows)
            {
               
                ddlCountryRegion.SelectedValue = row["Country"].ToString();
                fillState(row["Country"].ToString());
                Session["Country"] = row["Country"].ToString();
                Session["StateId"] = row["State"].ToString();
                ddlStateRegion.SelectedValue = row["State"].ToString();
                fillCity(row["State"].ToString(), row["Country"].ToString());
                ddlCity.SelectedValue = row["City"].ToString();
                Session["City"] = row["City"].ToString();
           
            }
        }
    }

    private void fillCity(string state, string country)
    {
        try
        {
            if (state != "" || country != "")
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
            if (Country != "")
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
        }
        catch (Exception ex)
        {
            //   lblBatch.Text = ex.ToString();
        }
    }
    #endregion "End Fill contorole on Form"

    #region "Country select index changed"
    protected void ddlCountryRegion_SelectedIndexChanged(object sender, EventArgs e)
    {

        try
        {

            //StateId = Convert.ToInt32(Session["CourseOne"]);

            //if (StateId == -1)
            //{
            //    obj_Master.CountryId = Convert.ToInt32(ddlCountryRegion.SelectedValue);
            //    FillCountryStateDropDown1();
            //    ddlStateRegion.Visible = true;
            //    ddlStateRegion.DataBind();
            //}
            //else
            //{



                obj_Master.CountryId = Convert.ToInt32(ddlCountryRegion.SelectedValue);

                DS = obj_Master.StateListDropdown1();
                ddlStateRegion.DataSource = DS;
                DS.Tables[0].Merge(DS.Tables[1]);
                ddlStateRegion.DataTextField = DS.Tables[0].Columns[1].ToString();
                ddlStateRegion.DataValueField = DS.Tables[0].Columns[0].ToString();
                ddlStateRegion.DataBind();
                ddlStateRegion.Dispose();
                ddlStateRegion.SelectedValue = StateId.ToString();
            //}

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

    #region"Update Student "
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
             obj_Student.StudentId = StudentId;
             obj_Student.Country = ddlCountryRegion.SelectedValue.ToString();
             obj_Student.City = ddlCity.SelectedValue.ToString();
             obj_Student.State = ddlStateRegion.SelectedValue.ToString();

             obj_Student.CountryText = ddlCountryRegion.SelectedItem.ToString();
             obj_Student.CityText = ddlCity.SelectedItem.ToString();
             obj_Student.StateText = ddlStateRegion.SelectedItem.ToString();

             DS = obj_Student.UpdateStudentAddress();
             lblMsg.Text = " Your Record is Saved. To return to the back page Cancel the popup Window form top right corner.";
        }
        catch (Exception)
        {
            lblMsg.Text = "some thinks is wrong";
        }




    }
    #endregion
}