using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using BusinessLogic.Admin;
using DataAccess;
using System.Net.Mail;
using System.IO;
using System.Net;

public partial class Public_ContactUs : System.Web.UI.Page
{
    #region "VARIABLE DECLARATION"

    private clsHeader obj_Footer = new clsHeader();
    private DataSet DS;
    private int RecordStatus;
    private SqlDataReader DR;
    private int checkRecordStatus;

    public string alertmsg = "Thank you for your interest! Enquiry Mail Successfully send. We will contact you soon...";
    public string alertfail = "Error:// Opps! Sorry Enquiry Mail Sending Fail";
    #endregion
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnContactSubmit_Click(object sender, EventArgs e)
    {
        //obj_Footer.Name = txtCName.Text.Trim();
        //obj_Footer.Email = txtCMail.Text.Trim();
        //obj_Footer.Message = txtCMessage.Text.Trim();
        //checkRecordStatus = obj_Footer.InsertFooterContact();
        //if (checkRecordStatus == 0)
        //{
        //    //lblmessage.text="Record Save"
        //}

        sendEmail();
        Clear();
    }
    protected void btnContactReset_Click(object sender, EventArgs e)
    {
        Clear();
    }
    private void Clear()
    {
        txtCName.Text = "";
        txtCMail.Text = "";
        txtCMessage.Text = "";
    }
    protected void sendEmail()
    {
        try
        {
           
            MailMessage msg = new MailMessage();
            msg.From = new MailAddress("no-reply@secureserver.net", "Idea Learning Enquiry");
            msg.To.Add("idea.learning.academy@gmail.com");

            // msg.Body = "Hello Sir..!!";
            string s = "<b>Hi Admin...</b><br/>";
            s += "<b>Greetings!!</b><br/>";
            s += "<br/>";
            s += "<br/>";
            s += "<b>Person : </b>" + txtCName.Text + "<br/>";
            s += "<b>E-mail : </b>" + txtCMail.Text + "<br/>";
            s += "<br/>";
            s += "<b>Message : </b>" + txtCMessage.Text + "<br/>";
            s += "<br/>";
            //  s += "Thanking you for your consideration and forthcoming response.<br/>";
            // s += "<br/>";
            s += "Warm Regards<br/>";
            s += "<b>By </b>" + txtCName.Text + "<br/>";
            msg.Body = s;
            msg.IsBodyHtml = true;
            // MailMessage instance to a specified SMTP server
            SmtpClient smtp = new SmtpClient("relay-hosting.secureserver.net", 25);
            // Sending the email
            smtp.Send(msg);
            // destroy the message after sent
            msg.Dispose();
            ScriptManager.RegisterStartupScript(this.Page, typeof(string), "Alert", "alert('" + alertmsg + "');", true);
        }
        catch
        {
            ScriptManager.RegisterStartupScript(this.Page, typeof(string), "Alert", "alert('" + alertfail + "');", true);
        }
    }

 
}