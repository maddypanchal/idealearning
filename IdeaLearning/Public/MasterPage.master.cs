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

public partial class MasterPage : System.Web.UI.MasterPage
{

    #region "VARIABLE DECLARATION"
    private clsNews obj_News = new clsNews();
    private clsEvents obj_Events = new clsEvents();
    private clsSlider obj_Slider = new clsSlider();
    private clsHeader obj_Footer = new clsHeader();
    private clsMaster obj_Gallery = new clsMaster();
    private DataSet DS;
    private int RecordStatus;
    private SqlDataReader DR;
    private int checkRecordStatus;
    public string alertmsg = "Thank you for your interest! Enquiry Mail Successfully send. We will contact you soon...";
    public string alertfail = "Error:// Opps! Sorry Enquiry Mail Sending Fail";
    #endregion
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
          
            Gallery();
         
        }
    }



    #region "Showcase Gallery"
    protected void Gallery()
    {
        try
        {
            DS = obj_Gallery.DisplayHomeGallery();
            // gvDetail1.DataSource = DS;
            //gvDetail1.DataSource = DS;
            //gvDetail1.DataBind();

            DataListGalery.DataSource = DS;
            DataListGalery.DataSource = DS;
            DataListGalery.DataBind();

        }
        catch (Exception ex)
        {
            // lblMsg.Visible = true;
            // lblMsg.Text = ex.ToString();
        }
    }
    #endregion 

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        sendEmail();
        Clear();
    }
    private void Clear()
    {

        txtMail.Text = "";
        txtMessage.Text = "";
        txtName.Text = "";
       


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
            s += "<b>Person : </b>" + txtName.Text + "<br/>";

            s += "<b>E-mail : </b>" + txtMail.Text + "<br/>";
            s += "<br/>";
            s += "<b>Message : </b>" + txtMessage.Text + "<br/>";
            s += "<br/>";
            s += "Thanking you for your consideration and forthcoming response.<br/>";
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
    protected void btnReset_Click(object sender, EventArgs e)
    {
        Clear();
    }
}
