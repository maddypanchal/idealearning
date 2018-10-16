using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccess;
using BusinessLogic.Admin;
using System.Data;
using System.Data.SqlClient;
using System.IO;


public partial class Employee_DashBord : System.Web.UI.Page
{
    #region "Variable Decleration"
    private clsEmployee obj_Employee = new clsEmployee();
    private DataSet DS;
    private int RecordStatus;
    private static int EmployeeId;
    public int gender;

    #endregion
 
    protected void Page_Load(object sender, EventArgs e)
    {

             EmployeeId = Convert.ToInt32(Request.QueryString["EMPLOYEE_ID"].ToString());
            if (!IsPostBack)
            {
                FillEmployeeInformation();
            }
     
    }
    
    #region " Fill contorole on Form"
    private void FillEmployeeInformation()
    {
        obj_Employee.EmployeeId = EmployeeId;
        DS = obj_Employee.DisplayPEmployee();
        if (DS.Tables[0].Rows.Count > 0)
        {
            foreach (DataRow row in DS.Tables[0].Rows)
            {

                txtDiscriptions.Text = "Descriptions : ".ToUpper() + row["Descriptions"].ToString();

             
                txtDiscriptions1.Text   = "Designation : ".ToUpper() + row["Designation"].ToString();
             
             
                lblMentorsOne.Text = "Mentor One : " + row["MentorsOne"].ToString();
                //lblMentorsTwo.Text = "Mentor Two : " + row["MentorsTwo"].ToString();
                //lblMentorsThree.Text = "Mentor Three : " + row["MentorsThree"].ToString();
                //lblMentorsFour.Text = "Mentor Four : " + row["MentorsFour"].ToString();


                txtuserName.Text = "User Name : ".ToUpper() + row["UserName"].ToString();
                txtWorkLocation.Text = "Work Location : " + row["WorkLocation"].ToString();

                txtEmployeeCode.Text = "Employee Code :   ".ToUpper() + row["EmployeeCode"].ToString();
                lblDisgnation.Text = "Designation : ".ToUpper() + row["Designation"].ToString();
                txtExperience.Text = "Experience :  ".ToUpper() + row["Experience"].ToString();
                txtOtherDuties.Text = "Other Duties :  ".ToUpper() + row["OtherDuties"].ToString();
                txtInterest.Text = "Interest :  ".ToUpper() + row["Interest"].ToString();
                txtname.Text = "Name :  ".ToUpper() + row["Name"].ToString();


              //  txtAddress.Text = "Address : ".ToUpper() + row["Address"].ToString() + "  " + row["RegionName"].ToString() + "  " + row["StateName"].ToString() + "  " + row["CountryName"].ToString();
                txtQualification.Text = "Qualification : ".ToUpper() + row["Qualification"].ToString();
                txtmobile.Text = "Mobile No : ".ToUpper() + row["Mobile"].ToString();
                txtemail.Text = "Email : ".ToUpper() + row["Email"].ToString();
                txtDateOfBirth.Text = "Date Of Birth : ".ToUpper() + row["DateOfBirth"].ToString();
                txtFatherName.Text = "Father Name : ".ToUpper() + row["FatherName"].ToString();
                txtDateOfRegistration.Text = "Date of Join : ".ToUpper() + row["DateOfJoin"].ToString();
                  gender =Convert.ToInt32(row["Gender"].ToString());
                  if (gender == 1)
                  {
                      txtGender.Text = "Gender : ".ToUpper() + "Male";
                  }
                  else if (gender == 2)
                  {
                      txtGender.Text = "Gender : ".ToUpper() + "Female";
                  }

                  txtuserName.Text = "User Name : ".ToUpper() + row["UserName"].ToString();
              
                if (row["UploadImages"].ToString() == "")
                {
                    imgUser.ImageUrl = "../UploadedFile/Defultuser.png";
                }
                else
                {
                    imgUser.ImageUrl = "../CroppedImages/" + row["UploadImages"].ToString();
                }

                //if (row["IsActive"].ToString() == "True")
                // {
                //     txtStatus.Text = "Status : ".ToUpper() + "Active";
                // }
                //else
                //{
                //    txtStatus.Text = "Status : ".ToUpper() + "InActive";
                //}



            }
        }

    }
    #endregion "End Fill contorole on Form"
}