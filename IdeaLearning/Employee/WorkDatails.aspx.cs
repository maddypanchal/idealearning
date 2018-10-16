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
using System.Globalization;

public partial class Employee_WorkDatails : System.Web.UI.Page
{
    #region"Variable Declaration"
    private clsMaster obj_Master = new clsMaster();
    private clsEmployee obj_Employee = new clsEmployee();
    private DataSet DS;
    private int checkRecordStatus;
    #endregion
    protected void Page_Load(object sender, EventArgs e)
    {
        
        txtTitleDate.Text = DateTime.Today.ToString("dd/MM/yyyy");
        //txtTitleDate.Text = DateTime.Today.ToString();
        if (!IsPostBack)
        {
            Employee();
        }
    }


    #region "Fill Employee"
    protected void Employee()
    {
        try
        {
            DS = obj_Employee.DisplayEmployeeWork();
            ddlEmployee.DataSource = DS;
          //  DS.Tables[0].Merge(DS.Tables[1]);
            ddlEmployee.DataTextField = DS.Tables[0].Columns[1].ToString();
            ddlEmployee.DataValueField = DS.Tables[0].Columns[0].ToString();
            ddlEmployee.DataBind();
            ddlEmployee.Dispose();


            //ddlEmployeeWork.DataSource = DS;
            //ddlEmployeeWork.DataTextField = DS.Tables[0].Columns[1].ToString();
            //ddlEmployeeWork.DataValueField = DS.Tables[0].Columns[0].ToString();
            //ddlEmployeeWork.DataBind();
            //ddlEmployeeWork.Dispose();
            
        }
        catch (Exception ex)
        {
            lblMsg.Text = ex.ToString();
        }
    }
    #endregion

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Session["USER_NAME"].ToString()))
        {
            //lblUserName.Text  = "Welcome " + Session["USER_NAME"].ToString();
      
            obj_Master.CurrentEmployee = Session["USER_NAME"].ToString();
            obj_Master.EmployeeId =Convert.ToInt32(Session["EMPLOYEE_ID"]);

            obj_Master.WorkFor = Convert.ToInt32(ddlEmployee.SelectedValue.ToString());
           // obj_Master.workby = Convert.ToInt32(ddlEmployee.SelectedValue.ToString());
            obj_Master.Topic = txtTopic.Text.Trim();
            obj_Master.Date = txtTitleDate.Text.Trim();
            obj_Master.LastDateOfComplate =  DateTime.ParseExact(txtLastDateOfComplate.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture);  // Convert.ToDateTime(txtLastDateOfComplate.Text, CultureInfo.CurrentCulture).ToString("MM/dd/yyyy hh:MM:ss");
            obj_Master.Instruction = txtInstruction.Text.Trim();
            String ckContentValue = CKEditor1.Text.Trim();
            obj_Master.Description = ckContentValue;
            checkRecordStatus = obj_Master.AddEmployeeDailyWork();
            if (checkRecordStatus == 0)
            {
                lblMsg.Text = "Record Saved";
            }
 
        }
        else
        {
            Response.Redirect("/Login.aspx");
        }

               clearform();
        txtTitleDate.Text = DateTime.Today.ToString("dd/MM/yyyy");
    }

    private void clearform()
    {
        txtTopic.Text = "";
        txtTitleDate.Text = "";
        CKEditor1.Text = "";
        lblMsg.Text = "Record Saved";
    }
}