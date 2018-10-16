using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.IO;
using System.Net;

public partial class Public_EmailContact : System.Web.UI.Page
{
    public string alertmsg = "Thank you for your interest! Enquiry Mail Successfully send. We will contact you soon...";
    public string alertfail = "Error:// Opps! Sorry Enquiry Mail Sending Fail";
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSend_Click(object sender, EventArgs e)
    {
        sendEmail();
    }

    protected void sendEmail()
    {
        try
        {

            MailMessage msg = new MailMessage();
            msg.From = new MailAddress("no-reply@secureserver.net", "Idea Learning Enquiry");
            msg.To.Add("idea.education@gmail.com");

            // msg.Body = "Hello Sir..!!";
            string s = "<b>Hi Admin...</b><br/>";
            s += "<b>Greetings!!</b><br/>";
            s += "<br/>";
            s += "<br/>";
            s += "<b>Person : </b>" + txtName.Text + "<br/>";

            s += "<b>E-mail : </b>" + txtEmail.Text + "<br/>";
            s += "<br/>";
            s += "<b>Message : </b>" + txtMobile.Text + "<br/>";
            s += "<br/>";
            s += "<b>Message : </b>" + txtPurpose.Text + "<br/>";
            s += "<br/>";
            s += "Thanking you for your consideration and forth coming response.<br/>";
            s += "<br/>";
            s += "Warm Regards<br/>";
            s += "<b>By </b>" + txtName.Text + "<br/>";
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