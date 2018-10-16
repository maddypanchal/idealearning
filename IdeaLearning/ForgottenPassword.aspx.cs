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

using System.Net;
using System.Text;
using System.Configuration;
using System.Web.Security;
using System.Web.UI.HtmlControls;
using System.Collections;
using System.IO;


public partial class ForgottenPassword : System.Web.UI.Page
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
        lblLoginMsg.Text = "";
        try
        {
            obj_Login.MOBILE_NUMBER = txtSMobileNo.Text.Trim();
            DS = obj_Login.VarifyForgetPass();
            if (DS.Tables[0].Rows.Count > 0)
            {
                string UserName = DS.Tables[0].Rows[0]["UserName"].ToString();
                string password = DS.Tables[0].Rows[0]["Password"].ToString();
                string mobile = DS.Tables[0].Rows[0]["Mobile"].ToString();

                Session["UserName"] = UserName;
                Session["password"] = password;
                Session["mobile"] = mobile;
                SendSMS(mobile, UserName, password);
                panel_SMobile.Visible = false;
                Panel_SOTP.Visible = true; 
                panel_Slogin.Visible =false;
            }
            else
            {
                lblLoginMsg.Text = "This Mobile Number is not Registered";
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
            lblLoginMsg.Text = "";
            obj_Login.MOBILE_NUMBER = txtEMobile.Text.Trim();
            DS = obj_Login.VarifyLoginEmpPass();
            if (DS.Tables[0].Rows.Count > 0)
            {
                string UserName = DS.Tables[0].Rows[0]["UserName"].ToString();
                // Session["USERTYPE"] = DS.Tables[0].Rows[0]["USER_TYPE"].ToString();
                string Passoword   = DS.Tables[0].Rows[0]["Password"].ToString();
                string mobile = DS.Tables[0].Rows[0]["Mobile"].ToString();
                Session["UserName"] = UserName;
                Session["password"] = Passoword;
                Session["mobile"] = mobile;
                SendSMS(mobile, UserName, Passoword);
                Panel_Employee.Visible=false;
                panel_Elogin.Visible = false;
                Panel_EOTP.Visible=true;
             
            }
            else
            {
                lblLoginMsg.Text = "This Mobile Number is not Registered";
            }
        }
        catch (Exception ex)
        {
            lblLoginMsg.Text = ex.ToString();
        }
    }
    #endregion


    public string SendSmsIderLearning(string number)
    {
        string fullResponse = "";
        string SmsText ="Dear parents Your son / daughter is absent in today's class/test At Idea Learning Academy. For details please call us";
        string uid = "ilaiit";
        string pwd = "learning@2015";
        string sid = "ILAIIT";
        try
        {
            string URLAuth = "http://www.smsjust.com/sms/user/XMLAPI/send.php";
            string postString = string.Format("data={0}", "<message-submit-request><username>" +
                uid + "</username><password>" + pwd + "</password><sender-id>" + sid + "</sender-id><MType>TXT</MType>" + "<message-text>" + "<text>" + SmsText + "</text>"
               + "<to>" + number + "</to>" + "</message-text>" + "</message-submit-request>");
            //+ SmsText + "<to>" + number + "</to>" + "</message-submit-request>");
            const string contentType = "application/x-www-form-urlencoded";
            System.Net.ServicePointManager.Expect100Continue = false;
            CookieContainer cookies = new CookieContainer();
            HttpWebRequest webRequest = WebRequest.Create(URLAuth) as HttpWebRequest;
            webRequest.Method = "POST";
            webRequest.ContentType = contentType;
            webRequest.CookieContainer = cookies;
            webRequest.ContentLength = postString.Length;
            //  webRequest.ReadWriteTimeout = Timeout.Infinite;
            //  webRequest.Timeout = Timeout.Infinite;
            webRequest.UserAgent = "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.9.0.1) Gecko/2008070208 Firefox/3.0.1";
            webRequest.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
            webRequest.Referer = "http://www.smsjust.com/sms/user/XMLAPI/send.php";
            StreamWriter requestWriter = new StreamWriter(webRequest.GetRequestStream());
            requestWriter.Write(postString);
            requestWriter.Close();
            StreamReader responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
            fullResponse = responseReader.ReadToEnd();
            responseReader.Close();
            webRequest.GetResponse().Close();

        }
        catch (Exception ex)
        {
            //Blogger.Error(ex.Message.ToString());
            fullResponse = "";
        }
        return fullResponse;
    }


    //private void SendSmsIderLearning(string mobile)
    //{

    //    string UserName = "IITILA";
    //    string Password = "fea00c9e4bXX";
    //    string mobileNumber = mobile;
    //    string Message = "Dear parents Your son/daughter is absent in today's class/test At Idea Learning Academy. For details please call us";
                   

    //    //string strUrl = "http://bulksms.sainfotechnologies.com/sendsms.jsp?user=" + UserName + "&password=" + Password + "&mobiles=" + mobileNumber + "&sms=" + Message + "&senderid= IITILA ";
    //    string strUrl = "http://smspanel.sainfotechnologies.in/rest/services/sendSMS/sendGroupSms?AUTH_KEY=57f3f2baae63fa7f7c30a64d97adbaa9&message=" + Message + "&senderId=" + UserName + "&routeId=" + 1 + "&mobileNos=" + mobileNumber + "&smsContentType=english";
    //    WebRequest request = HttpWebRequest.Create(strUrl);
    //    HttpWebResponse response = (HttpWebResponse)request.GetResponse();
    //    Stream s = (Stream)response.GetResponseStream();
    //    StreamReader readStream = new StreamReader(s);
    //    string dataString = readStream.ReadToEnd();
    //    string data = dataString.Substring(25, 7);
    //    response.Close();
    //    s.Close();
    //    readStream.Close();
    //}



    public string SendSMS(string number , string UserName, string Password)
    {

        var r = new Random();
          string OTP   = (r.Next(100000, 999999)).ToString();
          string SmsText = "welcome To Idea Learning , Your login OTP is  " + OTP + "  This OTP is valid for 15 min. only !";
          Session["OTP"] = OTP;
           string fullResponse = "";
        // string SmsText = "welcome To IdeaEdu </br>" +"User Name : " + UserName + " Password : " + Password;
        string uid = "ilaiit";
        string pwd = "learning@2015";
        string sid = "ILAIIT";
        try
        {
            string URLAuth = "http://www.smsjust.com/sms/user/XMLAPI/send.php";
            string postString = string.Format("data={0}", "<message-submit-request><username>" +
                uid + "</username><password>" + pwd + "</password><sender-id>" + sid + "</sender-id><MType>TXT</MType>" + "<message-text>" + "<text>" + SmsText + "</text>"
               + "<to>" + number + "</to>" + "</message-text>" + "</message-submit-request>");
            //+ SmsText + "<to>" + number + "</to>" + "</message-submit-request>");
            const string contentType = "application/x-www-form-urlencoded";
            System.Net.ServicePointManager.Expect100Continue = false;
            CookieContainer cookies = new CookieContainer();
            HttpWebRequest webRequest = WebRequest.Create(URLAuth) as HttpWebRequest;
            webRequest.Method = "POST";
            webRequest.ContentType = contentType;
            webRequest.CookieContainer = cookies;
            webRequest.ContentLength = postString.Length;
            //  webRequest.ReadWriteTimeout = Timeout.Infinite;
            //  webRequest.Timeout = Timeout.Infinite;
            webRequest.UserAgent = "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.9.0.1) Gecko/2008070208 Firefox/3.0.1";
            webRequest.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
            webRequest.Referer = "http://www.smsjust.com/sms/user/XMLAPI/send.php";
            StreamWriter requestWriter = new StreamWriter(webRequest.GetRequestStream());
            requestWriter.Write(postString);
            requestWriter.Close();
            StreamReader responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
            fullResponse = responseReader.ReadToEnd();
            responseReader.Close();
            webRequest.GetResponse().Close();

        }
        catch (Exception ex)
        {
            //Blogger.Error(ex.Message.ToString());
            fullResponse = "";
        }
        return fullResponse;
    }

    protected void BtnSOPT_Click(object sender, EventArgs e)
    {
        string OTP = Session["OTP"].ToString();
      
        if (OTP == txtOTP.Text)
        {
            Session["UserName"].ToString(); 
            Session["password"].ToString();
            Session["mobile"].ToString();
            lblLoginMsg.Text = "Welcome To IEDA Learning "  + "Your Password :   " + Session["password"];
        }

        Session["UserName"]="";
        Session["password"]="";
        Session["mobile"]="";
        Panel_SOTP.Visible = false;
        panel_Slogin.Visible = true;
    }
    protected void BtnEOtp_Click(object sender, EventArgs e)
    {
            string OTP = Session["OTP"].ToString();
      
        if (OTP == txtEOTP.Text)
        {
            Session["UserName"].ToString(); 
            Session["password"].ToString();
            Session["mobile"].ToString();
            lblLoginMsg.Text = "Welcome To IDEA Learning  " + "Your Password :   " + Session["password"] + " ";
        }

        Session["UserName"]="";
        Session["password"]="";
        Session["mobile"]="";

        Panel_EOTP.Visible = false;
        panel_Elogin.Visible = true;
    }
    
}