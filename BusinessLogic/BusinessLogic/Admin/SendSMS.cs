using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Configuration;
using System.Collections;

namespace BusinessLogic.Admin
{
    public class SendSMS
    {
        private void SendSmsIderLearning(string mobile)
        {
            string UserName = "IITILA";
            string Password = "fea00c9e4bXX";
            string mobileNumber = mobile;
            string Message = "Message";

            string strUrl = "http://bulksms.sainfotechnologies.com/sendsms.jsp?user=" + UserName + "&password=" + Password + "&mobiles=" + mobileNumber + "&sms=" + Message + "&senderid= IITILA ";
            WebRequest request = HttpWebRequest.Create(strUrl);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream s = (Stream)response.GetResponseStream();
            StreamReader readStream = new StreamReader(s);
            string dataString = readStream.ReadToEnd();
            string data = dataString.Substring(25, 7);
            response.Close();
            s.Close();
            readStream.Close();
        }
        private void SendSMS1(string mobile , string SMStext)
        {
            string UserName = "IITILA";
            string Password = "fea00c9e4bXX";
            string mobileNumber = mobile;
            string Message = SMStext;

            string strUrl = "http://bulksms.sainfotechnologies.com/sendsms.jsp?user=" + UserName + "&password=" + Password + "&mobiles=" + mobileNumber + "&sms=" + Message + "&senderid= IITILA ";
            WebRequest request = HttpWebRequest.Create(strUrl);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream s = (Stream)response.GetResponseStream();
            StreamReader readStream = new StreamReader(s);
            string dataString = readStream.ReadToEnd();
            string data = dataString.Substring(25, 7);
            response.Close();
            s.Close();
            readStream.Close();
        }
        private void SendSMS_Career(string Name, string mobile, string applyfor, string alertmsg)
        {
            string UserName = "IITILA";
            string Password = "fea00c9e4bXX";
            string mobileNumber = mobile;
            string Message = alertmsg;

            string strUrl = "http://bulksms.sainfotechnologies.com/sendsms.jsp?user=" + UserName + "&password=" + Password + "&mobiles=" + mobileNumber + "&sms=" + Message + "&senderid= IITILA ";
            WebRequest request = HttpWebRequest.Create(strUrl);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream s = (Stream)response.GetResponseStream();
            StreamReader readStream = new StreamReader(s);
            string dataString = readStream.ReadToEnd();
            string data = dataString.Substring(25, 7);
            response.Close();
            s.Close();
            readStream.Close();
        }
        private void SendSMS_Career(string Name, string mobile, string applyfor)
        {
            string UserName = "IITILA";
            string Password = "fea00c9e4bXX";
            string mobileNumber = mobile;
            string Message = "Name : " + Name + " <br/>Mobile : " + mobile + "<br/> Apply for post" + applyfor;

            // string strUrl = "http://bulksms.sainfotechnologies.com/sendsms.jsp?user=" + UserName + "&password=" + Password + "&mobiles=" + mobileNumber + "&sms=" + Message + "&senderid= IITILA ";
            string strUrl = "http://smspanel.sainfotechnologies.in/rest/services/sendSMS/sendGroupSms?AUTH_KEY=57f3f2baae63fa7f7c30a64d97adbaa9&message=" + Message + "&senderId=" + UserName + "&routeId=" + 1 + "&mobileNos=" + mobileNumber + "&smsContentType=english";
            WebRequest request = HttpWebRequest.Create(strUrl);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream s = (Stream)response.GetResponseStream();
            StreamReader readStream = new StreamReader(s);
            string dataString = readStream.ReadToEnd();
            string data = dataString.Substring(25, 7);
            response.Close();
            s.Close();
            readStream.Close();
        }

        //public string SendSMS1(string number , string SMStext )
        //{
        //    string fullResponse = "";
        //    string SmsText = SMStext;
        //    string uid = "ideaedukkr";
        //    string pwd = "ideakkr@123";
        //    string sid = "IDEAed";
        //    try
        //    {
        //        string URLAuth = "http://www.smsjust.com/sms/user/XMLAPI/send.php";
        //        string postString = string.Format("data={0}", "<message-submit-request><username>" +
        //           uid + "</username><password>" + pwd + "</password><sender-id>" + sid + "</sender-id><MType>TXT</MType>" + "<message-text>" + "<text>" + SmsText + "</text>"
        //           + "<to>" + number + "</to>" + "</message-text>" + "</message-submit-request>");
        //        //+ SmsText + "<to>" + number + "</to>" + "</message-submit-request>");
        //        const string contentType = "application/x-www-form-urlencoded";
        //        System.Net.ServicePointManager.Expect100Continue = false;
        //        CookieContainer cookies = new CookieContainer();
        //        HttpWebRequest webRequest = WebRequest.Create(URLAuth) as HttpWebRequest;
        //        webRequest.Method = "POST";
        //        webRequest.ContentType = contentType;
        //        webRequest.CookieContainer = cookies;
        //        webRequest.ContentLength = postString.Length;
        //        //  webRequest.ReadWriteTimeout = Timeout.Infinite;
        //        //  webRequest.Timeout = Timeout.Infinite;
        //        webRequest.UserAgent = "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.9.0.1) Gecko/2008070208 Firefox/3.0.1";
        //        webRequest.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
        //        webRequest.Referer = "http://www.smsjust.com/sms/user/XMLAPI/send.php";
        //        StreamWriter requestWriter = new StreamWriter(webRequest.GetRequestStream());
        //        requestWriter.Write(postString);
        //        requestWriter.Close();
        //        StreamReader responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
        //        fullResponse = responseReader.ReadToEnd();
        //        responseReader.Close();
        //        webRequest.GetResponse().Close();

        //    }
        //    catch (Exception ex)
        //    {
        //        //Blogger.Error(ex.Message.ToString());
        //        fullResponse = "";
        //    }
        //    return fullResponse;
        //}
        //public string SendSMS_Career(string Name, string mobile, string applyfor, string alertmsg)
        //{
        //   string fullResponse = "";
        //   string SmsText = alertmsg;
        //   string number = mobile;
        //   string uid = "ideaedukkr";
        //   string pwd = "ideakkr@123";
        //   string sid = "IDEAed";
        //    try
        //    {
        //        string URLAuth = "http://www.smsjust.com/sms/user/XMLAPI/send.php";
        //        string postString = string.Format("data={0}", "<message-submit-request><username>" +
        //           uid + "</username><password>" + pwd + "</password><sender-id>" + sid + "</sender-id><MType>TXT</MType>" + "<message-text>" + "<text>" + SmsText + "</text>"
        //           + "<to>" + number + "</to>" + "</message-text>" + "</message-submit-request>");
        //        //+ SmsText + "<to>" + number + "</to>" + "</message-submit-request>");
        //        const string contentType = "application/x-www-form-urlencoded";
        //        System.Net.ServicePointManager.Expect100Continue = false;
        //        CookieContainer cookies = new CookieContainer();
        //        HttpWebRequest webRequest = WebRequest.Create(URLAuth) as HttpWebRequest;
        //        webRequest.Method = "POST";
        //        webRequest.ContentType = contentType;
        //        webRequest.CookieContainer = cookies;
        //        webRequest.ContentLength = postString.Length;
        //        // webRequest.ReadWriteTimeout = Timeout.Infinite;
        //        // webRequest.Timeout = Timeout.Infinite;
        //        webRequest.UserAgent = "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.9.0.1) Gecko/2008070208 Firefox/3.0.1";
        //        webRequest.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
        //        webRequest.Referer = "http://www.smsjust.com/sms/user/XMLAPI/send.php";
        //        StreamWriter requestWriter = new StreamWriter(webRequest.GetRequestStream());
        //        requestWriter.Write(postString);
        //        requestWriter.Close();
        //        StreamReader responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
        //        fullResponse = responseReader.ReadToEnd();
        //        responseReader.Close();
        //        webRequest.GetResponse().Close();

        //    }
        //    catch (Exception ex)
        //    {
        //      //Blogger.Error(ex.Message.ToString());
        //        fullResponse = "";
        //    }
        //    return fullResponse;
        //}

        //public string SendSMS_Career(string Name, string mobile , string applyfor  )
        // {
        //    string fullResponse = "";
        //    string SmsText = "Name : " + Name + " <br/>Mobile : " + mobile + "<br/> Apply for post" + applyfor;
        //    string number = "9416141315";
        //    string uid = "ideaedukkr";
        //    string pwd = "ideakkr@123";
        //    string sid = "IDEAed";
        //     try
        //     {
        //         string URLAuth = "http://www.smsjust.com/sms/user/XMLAPI/send.php";
        //         string postString = string.Format("data={0}", "<message-submit-request><username>" +
        //            uid + "</username><password>" + pwd + "</password><sender-id>" + sid + "</sender-id><MType>TXT</MType>" + "<message-text>" + "<text>" + SmsText + "</text>"
        //            + "<to>" + number + "</to>" + "</message-text>" + "</message-submit-request>");
        //         //+ SmsText + "<to>" + number + "</to>" + "</message-submit-request>");
        //         const string contentType = "application/x-www-form-urlencoded";
        //         System.Net.ServicePointManager.Expect100Continue = false;
        //         CookieContainer cookies = new CookieContainer();
        //         HttpWebRequest webRequest = WebRequest.Create(URLAuth) as HttpWebRequest;
        //         webRequest.Method = "POST";
        //         webRequest.ContentType = contentType;
        //         webRequest.CookieContainer = cookies;
        //         webRequest.ContentLength = postString.Length;
        //         //  webRequest.ReadWriteTimeout = Timeout.Infinite;
        //         //  webRequest.Timeout = Timeout.Infinite;
        //         webRequest.UserAgent = "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.9.0.1) Gecko/2008070208 Firefox/3.0.1";
        //         webRequest.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
        //         webRequest.Referer = "http://www.smsjust.com/sms/user/XMLAPI/send.php";
        //         StreamWriter requestWriter = new StreamWriter(webRequest.GetRequestStream());
        //         requestWriter.Write(postString);
        //         requestWriter.Close();
        //         StreamReader responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
        //         fullResponse = responseReader.ReadToEnd();
        //         responseReader.Close();
        //         webRequest.GetResponse().Close();

        //     }
        //     catch (Exception ex)
        //     {
        //         //Blogger.Error(ex.Message.ToString());
        //         fullResponse = "";
        //     }
        //     return fullResponse;
        // }

    }
}
