using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SMS : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SendSmsIderLearning("7206858925");
    }


    public string SendSmsIderLearning(string number)
    {
        string fullResponse = "";
        string SmsText = "Dear parents , exam information is recently updated. New exam date is 10/7/2018 8:07:35 PM , Please check exam info section on web portal for syllabus and other details.Do check your web portal regularly for latest updates and Live student performance. Thanks & Regards : Team IDEA learning";  //txtMessage.Text;
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

    protected void send_Click(object sender, EventArgs e)
    {
        //SendSMS("9634646284");
        SendSMS("9896545257");
    }


    public string SendSMS(string number)
    {
        string fullResponse = "";
        string SmsText = "this is demo work";  //txtContent.Text.Trim();
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


    //public string SendSMS(string number)
    //{
    //    if (number == null || number == "")
    //    {
    //        string fullResponse = "";
    //        return fullResponse;
    //    }
    //    else
    //    {
    //        string fullResponse = "";
    //        string SmsText = txtmsg.Text;
    //        string uid = "ideaedukkr";
    //        string pwd = "ideakkr@123";
    //        string sid = "IDEAed";
    //        try
    //        {
    //            string URLAuth = "http://www.smsjust.com/sms/user/XMLAPI/send.php";
    //            string postString = string.Format("data={0}", "<message-submit-request><username>" +
    //                uid + "</username><password>" + pwd + "</password><sender-id>" + sid + "</sender-id><MType>TXT</MType>" + "<message-text>" + "<text>" + SmsText + "</text>"
    //               + "<to>" + number + "</to>" + "</message-text>" + "</message-submit-request>");
    //            //+ SmsText + "<to>" + number + "</to>" + "</message-submit-request>");
    //            const string contentType = "application/x-www-form-urlencoded";
    //            System.Net.ServicePointManager.Expect100Continue = false;
    //            CookieContainer cookies = new CookieContainer();
    //            HttpWebRequest webRequest = WebRequest.Create(URLAuth) as HttpWebRequest;
    //            webRequest.Method = "POST";
    //            webRequest.ContentType = contentType;
    //            webRequest.CookieContainer = cookies;
    //            webRequest.ContentLength = postString.Length;
    //            //  webRequest.ReadWriteTimeout = Timeout.Infinite;
    //            //  webRequest.Timeout = Timeout.Infinite;
    //            webRequest.UserAgent = "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.9.0.1) Gecko/2008070208 Firefox/3.0.1";
    //            webRequest.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
    //            webRequest.Referer = "http://www.smsjust.com/sms/user/XMLAPI/send.php";
    //            StreamWriter requestWriter = new StreamWriter(webRequest.GetRequestStream());
    //            requestWriter.Write(postString);
    //            requestWriter.Close();
    //            StreamReader responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
    //            fullResponse = responseReader.ReadToEnd();
    //            responseReader.Close();
    //            webRequest.GetResponse().Close();

    //        }
    //        catch (Exception ex)
    //        {
    //            //Blogger.Error(ex.Message.ToString());
    //            fullResponse = "";
    //        }
    //        return fullResponse;
    //    }



    //}
}