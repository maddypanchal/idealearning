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



public partial class Index : System.Web.UI.Page
{
    #region "VARIABLE DECLARATION"
    private clsNews obj_News = new clsNews();
    private clsEvents obj_Events = new clsEvents();
    private clsSlider obj_Slider = new clsSlider();
    private clsHeader obj_Footer = new clsHeader();
    private clsToppers obj_clsImages = new clsToppers();
    private clsCounter obj_Counter = new clsCounter();
    private clsMaster obj_Gallery = new clsMaster();
    private DataSet DS;
    private DataTable DT;
    private int RecordStatus;
    private SqlDataReader DR;
    public string alertmsg = "Thank you for contacting us. We will get back to you within 72 HRS.";
    public string alertfail = "Error:// Opps! Sorry Enquiry Mail Sending Fail";
    private int checkRecordStatus;


    #endregion
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            RepeteDataNews();
            RepeteEvents();
            RepeteSlider();
            RepterHeading();
            ShowcaseHeros();
            latestgalleryTopper();
            DisplayCourses();
            FillVister();
            Gallery();
            Youtube();
        }
    }

    
    #region "Showcase Youtube"
    protected void Youtube()
    {
        try
        {
            DS = obj_Gallery.DisplayHomeYoutube();
            DataListYoutube.DataSource = DS;
            DataListYoutube.DataSource = DS;
            DataListYoutube.DataBind();
            
        }
        catch (Exception ex)
        {
            // lblMsg.Visible = true;
            // lblMsg.Text = ex.ToString();
        }
    }
    #endregion

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

    #region "Vister Counter"
    public void FillVister()
    {
        DS = obj_Counter.DisplayCounter();
        if (DS.Tables[0].Rows.Count > 0)
        {
            foreach (DataRow row in DS.Tables[0].Rows)
            {
                lblVisiter.Text = "Visiter Counter is " + row["VisiterNumber"].ToString();

                int Counter = Convert.ToInt32(row["VisiterNumber"].ToString());
                // int Counter = Convert.ToInt32("lblVisiter.Text");
                Counter++;
                obj_Counter.VisiterNumber = Counter;
                DS = obj_Counter.CounterVisiter();
            }
        }

    }
    #endregion "End Fill User GridView"

    #region "Display Display Courses"
    protected void DisplayCourses()
    {
        try
        {

            DT = obj_clsImages.DisplayCourses();
            CoursesName.DataSource = DT;
            CoursesName.DataBind();
            CoursesName.Dispose();
        }
        catch (Exception ex)
        {
            // lblMsg.Visible = true;
            // lblMsg.Text = ex.ToString();
        }
    }
    #endregion "End Display Products Method"

    #region "Display latest Gallery Topper"
    protected void latestgalleryTopper()
    {
        try
        {
         
            DT = obj_clsImages.DisplayGalleryTopper();
          //  latestGallery.DataSource = DT;
       //     latestGallery.DataBind();
         //   latestGallery.Dispose();
        }
        catch (Exception ex)
        {
            // lblMsg.Visible = true;
            // lblMsg.Text = ex.ToString();
        }
    }
    #endregion "End Display Products Method"


    #region "Showcase Heros"
    protected void ShowcaseHeros()
    {
        try
        {

            DT = obj_clsImages.FillHomeHeros();
            dtListCategoryTopers.DataSource = DT;
            dtListCategoryTopers.DataBind();
            dtListCategoryTopers.Dispose();
        }
        catch (Exception ex)
        {
            // lblMsg.Visible = true;
            // lblMsg.Text = ex.ToString();
        }
    }
    #endregion 


    private void RepeteDataNews()
    {
        DS = obj_News.RepeterNews();
        Repeater.DataSource = DS;
        Repeater.DataBind();
    }
     private void RepeteEvents()
    {
        DS = obj_Events.RepeterEvents();
        Repeater1.DataSource = DS;
       Repeater1.DataBind();
    }

      private void RepterHeading()
    {
        DS = obj_Slider.RepterHeading();

        for (int i = 0; i <= DS.Tables.Count; i++)
        {
            if (i == 0)
            {
                SliderRa.InnerHtml = DS.Tables[0].Rows[i]["name"].ToString() ;
            }
            else
            {
                SliderRa.InnerHtml = SliderRa.InnerHtml + " // "+ DS.Tables[0].Rows[i]["name"].ToString();
            }
        }


        //RptHeading.DataSource = DS;
        //RptHeading.DataBind();
    }
   
       private void RepeteSlider()
    {
        DS = obj_Slider.RepeterSlider();
       SliderImages.DataSource = DS;
       SliderImages.DataBind();
    }

       protected void btnSubmit_Click(object sender, EventArgs e)
       {
           //obj_Footer.Name = txtName.Text.Trim();
           //obj_Footer.Email = txtEmail.Text.Trim();
           //obj_Footer.Message = txtMessage.Text.Trim();
           //checkRecordStatus = obj_Footer.InsertFooterContact();
           //if (checkRecordStatus == 0)
           //{
           //    //lblmessage.text="Record Save"
           //}
           sendEmail();
           Clear();
       }

       private void Clear()
       {
           txtMail.Text = "";
           txtMessage.Text = "";
           txtName.Text = "";
           txtCEmail.Text = "";
           txtCMessage.Text = "";
           txtCName.Text = "";
           txtCPhone.Text = "";
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
              // s += "Thanking you for your consideration and forthcoming response.<br/>";
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
       protected void sendEmailC()
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

               s += "<b>E-mail : </b>" + txtCEmail.Text + "<br/>";
               s += "<br/>";
               s += "<b>Phone : </b>" + txtCPhone.Text + "<br/>";
               s += "<br/>";
               s += "<b>Message : </b>" + txtCMessage.Text + "<br/>";
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

      protected void  btnReset_Click(object sender, EventArgs e)
      {
          Clear();
      }
      protected void btnCsubmit_Click(object sender, EventArgs e)
      {
          sendEmailC();
          Clear();
      }
      protected void btnCReset_Click(object sender, EventArgs e)
      {
        
          Clear();
      }
}
       
