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
using System.IO;


public partial class Employee_SendSmsExam : System.Web.UI.Page
{
    #region "Variable Decleration"
    private clsMaster obj_Master = new clsMaster();
    private DataSet DS;
    private int RecordStatus;
    private static int ExamInfoId;
    public static int ClassId;
    public static int ClassCourseId;
    public static int SubjectId;
    
    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {

       // SendSmsIderLearning("7206858925");
        ExamInfoId = int.Parse(Request.QueryString["Sid"]);
        if (!IsPostBack)
        {
            txtDate.Text = DateTime.Now.ToString();
            FillClass();

        }
    }

    private void FillClass()
    {
        obj_Master.ExamInfoId = ExamInfoId; 
    
        DS = obj_Master.FillExamId();
        if (DS.Tables[0].Rows.Count > 0)
        {
            foreach (DataRow row in DS.Tables[0].Rows)
            {

                ClassId =Convert.ToInt32(row["ClassId"]);
                ClassCourseId = Convert.ToInt32(row["ClassCoursesId"]);
                SubjectId = Convert.ToInt32(row["SubjectId"]);

                string ClassText = row["ClassName"].ToString();
                string CourseName = row["CoursesName"].ToString();
                string SubjectName= row["SubjectName"].ToString();


                txtMessage.Text = "Dear parents , exam information is recently updated. New exam date is "+ txtDate.Text + " ,Please check exam info section on web portal for syllabus and other details. Do check your web portal regularly for latest updates and Live student performance.Thanks $ Regards : Team IDEA learning";
            }
        }
    }

    protected void btnSend_Click(object sender, EventArgs e)
    {
       SendSMSHomepage();
        lblMsg.Text = "SMS Sent!";
    }

private void SendSMSHomepage()
    {
        obj_Master.ClassId = ClassId;
        obj_Master.ClassCoursesId = ClassCourseId;
        obj_Master.SubjectId = SubjectId;
        DS = obj_Master.Fill_Student_for_HomeWork();
        if (DS.Tables[0].Rows.Count > 0)
        {
            foreach (DataRow row in DS.Tables[0].Rows)
            {
                //ClassText = row["ClassText"].ToString();

                object val = row["Mobile"];

                String values = Convert.ToString(val);
                if (values != null && values != "")
                {
                    string mobile = row["Mobile"].ToString();
                    SendSmsIderLearning(mobile);
                    //SendSmsIderLearning("7206858925");
                }
                else
                {
                    lblMsg.Text = "Mobile number is not Found";
                }

                object val1 = row["FatherNumber"];

                String values1 = Convert.ToString(val1);
                if (values1 != null && values1 != "")
                {
                    string mobile = row["FatherNumber"].ToString();
                    SendSmsIderLearning(mobile);
                }
                else
                {
                    lblMsg.Text = "Mobile number is not Found";
                }

            }
        }
    }
    public string SendSmsIderLearning(string number)
    {
        string fullResponse = "";
        string SmsText = txtMessage.Text; // "SUNIL PANCHAL";
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

    //public string SendSmsIderLearning(string number)
    //{
    //    string fullResponse = "";
    //    string SmsText = txtMessage.Text; 
    //    string uid = "ilaiit";
    //    string pwd = "learning@2015";
    //    string sid = "ILAIIT";
    //    try
    //    {
    //        string URLAuth = "http://www.smsjust.com/sms/user/XMLAPI/send.php";
    //        string postString = string.Format("data={0}", "<message-submit-request><username>" +
    //            uid + "</username><password>" + pwd + "</password><sender-id>" + sid + "</sender-id><MType>TXT</MType>" + "<message-text>" + "<text>" + SmsText + "</text>"
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


    //private void SendSmsIderLearning(string mobile)
    //{
    //    //string ClassName = ClassText;
    //   // string SubjectName = ClassCourseId.ToString();
    //    string UserName = "IITILA";
    //    string Password = "fea00c9e4bXX";
    //    string mobileNumber =mobile; //"7206858925";//
    //    string Message = txtMessage.Text;// "Dear student, We have uploaded the Assignment/Homework for the class " + ClassName + "and its due date for submission is "+ txtDate.Text +" Do submit your home work on time to get  best results. Do not forget to get signature of your mentor on submitted copy/sheet/Register, Its mandatory .Thanks $ Regards: Team IDEA Learning";
    //    //string Message = "Dear student, We have uploaded the Assignment/Homework for the class " + ClassName + " , Subject " + SubjectName + "and its due date for submission is ...... Do submit your home work on time to get  best results. Do not forget to get signature of your mentor on submitted copy/sheet/Register, Its mandatory .Thanks $ Regards: Team IDEA Learning";
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

    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("DetailsOfExamInfo.aspx", false);
    }
}