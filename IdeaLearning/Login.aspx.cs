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

public partial class Login : System.Web.UI.Page
{
    #region "variable Decleration"
    public clsLogin obj_Login = new clsLogin();
    public DataSet DS;
    private int CheckRecordstatus;
    private int EMPLOYEE_ID;
    private int StudentId;
    private int AdminId;
    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    #region"Login Student"
    protected void btnSSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            obj_Login.UserName = txtSName.Text.Trim();
            obj_Login.Password = txtSPassword.Text.Trim();
            DS = obj_Login.VarifyLoginSAccount();
            if (DS.Tables[0].Rows.Count > 0)
            {
                Session["USER_NAME"] = DS.Tables[0].Rows[0]["StudentName"].ToString();
                // Session["USERTYPE"] = DS.Tables[0].Rows[0]["USER_TYPE"].ToString();
                Session["StudentId"] = DS.Tables[0].Rows[0]["StudentId"].ToString();
                //    CheckRecordstatus = Convert.ToInt32(Session["USERTYPE"]);
                StudentId = Convert.ToInt32(Session["StudentId"]);
                //  CurrentUserID=int.Parse("IS_ACTIVE");

                if (CheckRecordstatus == 0)
                {
                    Response.Redirect("Student/DashBord.aspx?StudentId=" + StudentId, false);
                }
            }
            else
            {
                lblLoginMsg.Text = "Invalid User Name or Password";
            }
        }
        catch (Exception ex)
        {
            lblLoginMsg.Text = ex.ToString();
        }
    }
    #endregion
    
    #region"Login Employee"
    protected void btnESubmit_Click(object sender, EventArgs e)
    {
        try
        {
            obj_Login.UserName = txtEName.Text.Trim();
            obj_Login.Password = txtEPasswrod.Text.Trim();
            DS = obj_Login.VarifyLoginEAccount();
            if (DS.Tables[0].Rows.Count > 0)
            {
                Session["USER_NAME"] = DS.Tables[0].Rows[0]["Name"].ToString();
                 // Session["USERTYPE"] = DS.Tables[0].Rows[0]["USER_TYPE"].ToString();
                Session["EMPLOYEE_ID"] = DS.Tables[0].Rows[0]["EmployeeId"].ToString();
                Session["EmployeeType"] = DS.Tables[0].Rows[0]["EmployeeType"].ToString();
                //    CheckRecordstatus = Convert.ToInt32(Session["USERTYPE"]);
                EMPLOYEE_ID = Convert.ToInt32(Session["EMPLOYEE_ID"]);
                //  CurrentUserID=int.Parse("IS_ACTIVE");
                if (CheckRecordstatus == 0)
                {
                    Response.Redirect("Employee/DashBord.aspx?EMPLOYEE_ID=" + EMPLOYEE_ID, false);
                }
            }
            else
            {
                lblLoginMsg.Text = "Invalid User Name or Password";
            }
        }
        catch (Exception ex)
        {
            lblLoginMsg.Text = ex.ToString();
        }
    }
    #endregion
    
    #region" Login Admin"
    protected void btnASubmit_Click(object sender, EventArgs e)
    {
        try
        {

            obj_Login.UserName = txtAName.Text.Trim();
            obj_Login.Password = txtAPassword.Text.Trim();
            DS = obj_Login.VarifyLoginAAccount();

            if (DS.Tables[0].Rows.Count > 0)
            {
                Session["USER_NAME"] = DS.Tables[0].Rows[0]["Name"].ToString();
                // Session["USERTYPE"] = DS.Tables[0].Rows[0]["USER_TYPE"].ToString();
                Session["AdminId"] = DS.Tables[0].Rows[0]["AdminId"].ToString();
                //    CheckRecordstatus = Convert.ToInt32(Session["USERTYPE"]);
                AdminId = Convert.ToInt32(Session["AdminId"]);
                //  CurrentUserID=int.Parse("IS_ACTIVE");

                if (CheckRecordstatus == 0)
                {
                    Response.Redirect("Admin/EmployeeDetails.aspx", false);
                }
            }
            else
            {
                lblLoginMsg.Text = "Invalid UserName or Password";
            }
        }
        catch (Exception ex)
        {
            lblLoginMsg.Text = ex.ToString();
        }
    }
    #endregion
}