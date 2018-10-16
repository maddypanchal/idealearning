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
using System.Drawing;
using System.IO;


public partial class Public_PaymentBy : System.Web.UI.Page
{
    #region"Variable Declaration"
    // private clsEmployee  = new clsEmployee();
    private clsStudent obj_Student = new clsStudent();
    private DataSet DS;
    private string myFileExtension;
    private int checkRecordStatus;
    public int StudentId;

    #endregion
    protected void Page_Load(object sender, EventArgs e)
    {
        StudentId = Convert.ToInt32(Request.QueryString["sid"]);
        FillUserInformation();
    }

    #region " Fill contorole on Form"
    private void FillUserInformation()
    {
        obj_Student.StudentId = Convert.ToInt32(StudentId);
        DS = obj_Student.FillStudentPreview();

        foreach (DataRow row in DS.Tables[0].Rows)
        {
            //txtName.Text = row["Name"].ToString();
            //txtFatherName.Text = row["FatherName"].ToString();
            //txtMotherName.Text = row["MatherName"].ToString();
            //txtDateOfBirth.Text = row["DateOfBirth"].ToString();
            //txtNationality.Text = row["Nationality"].ToString();
            //ddlCategory.Text = row["Category"].ToString();
            //rdoGender.Text = row["Gender"].ToString();
            //txtContactNumber.Text = row["ContactNo"].ToString();
            //txtEmailID.Text = row["EmailId"].ToString();
            //txtCorressAddress.Text = row["CorressAddress"].ToString();
            //txtPermanentAddress.Text = row["ParmanentAddress"].ToString();
            //txt10thNameofIns.Text = row["TENTH_NameOfIns"].ToString();
            //txt10thPercentage.Text = row["TENTH_Percentage"].ToString();
            //txt10thState.Text = row["TENTH_State"].ToString();
            //txt10thUniversityOrBorad.Text = row["TENTH_UniversityBoard"].ToString();
            //txt10thYearOfPass.Text = row["TENTH_YearOfPass"].ToString();
            //txt12thNameofIns.Text = row["TWELTH_NameOfIns"].ToString();
            //txt12thPercentage.Text = row["TWELTH_Percentage"].ToString();
            //txt12thState.Text = row["TWELTH_State"].ToString();
            //txt12thUniversityOrBorad.Text = row["TWELTH_UniversityBoard"].ToString();
            //txt12thYearOfPass.Text = row["TWELTH_YearOfPass"].ToString();
            //txtDiplomaNameofIns.Text = row["Diploma_NameOfIns"].ToString();
            //txtDiplomaPercentage.Text = row["Diploma_Percentage"].ToString();
            //txtDiplomaState.Text = row["Diploma_State"].ToString();
            //txtDiplomaUniversityOrBorad.Text = row["Diploma_UniversityBoard"].ToString();
            //txtDiplomaYearOfPass.Text = row["Diploma_YearOfPass"].ToString();
            //if (row["Photo"].ToString() == "")
            //{
            //    imgUser.ImageUrl = "../UserPhoto/Defultuser.png";
            //}
            //else
            //{
            //    imgUser.ImageUrl = "../UserPhoto/" + row["Photo"].ToString();

            //}
        }
    }
    #endregion "End Fill contorole on Form"
    protected void btnChallan_Click(object sender, EventArgs e)
    {
        Response.Redirect("Challan.aspx?sid=" + StudentId, false);
    }
}