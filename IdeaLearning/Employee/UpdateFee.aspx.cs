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

public partial class Employee_UpdateFee : System.Web.UI.Page
{
    #region "Variable Decleration"
    private clsStudent obj_Student = new clsStudent();
    private DataSet DS;
    private int RecordStatus;
    private static int StudentId;

    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {
        StudentId = int.Parse(Request.QueryString["Sid"]);
        if (!IsPostBack)
        {
            FillEmployeeInformation();
           // txtMessage.Text = "Dear parents please pay  Rs........ /- on .... to avoid late fee or suspension of classes at IDEA Learning Academy. Ignore if already paid.";
        }
    }

    #region " Fill contorole on Form"
    private void FillEmployeeInformation()
    {
        obj_Student.StudentId = StudentId;
        DS = obj_Student.DisplayPStudent();
        if (DS.Tables[0].Rows.Count > 0)
        {
            foreach (DataRow row in DS.Tables[0].Rows)
            {
                txtDuepayment.Text = row["DuePayment"].ToString();
                txtDate.Text = row["DueDate"].ToString();
                txtFatherNumber.Text = row["FatherNumber"].ToString();
                txtMessage.Text = "Dear parents Your fee payment of " + txtDuepayment.Text + "/- for IDEA Learning Academy is due on " + txtDate.Text + ". Please Pay installments on time to avoid late fee or suspension of study material/classes. Kindly ignore if already paid.";

            }
        }
    }
    #endregion

    protected void btnSend_Click(object sender, EventArgs e)
    {
        string mobile = txtFatherNumber.Text.Trim();
         //mobile = "7206858925";
        SendSmsIderLearning(mobile);

        lblMsg.Text = "SMS Sent!";
    }
    #region"Update Student "

    public string SendSmsIderLearning(string number)
    {
        string fullResponse = "";
        string SmsText = txtMessage.Text;
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
    //    string Password = "@IITILA@123";
    //    string mobileNumber = mobile;
    //    string Message = txtMessage.Text;

    //    //"Dear parents please pay Fee Of " +txtDuepayment.Text+"/- on "+ txtDate.Text+ " to avoid late fee or suspension of Study Material/Classes at IDEA Learning Academy. Ignore if already paid.";
    //    //string Message = "Dear parents Your fee payment of "+txtDuepayment.Text+"/- for IDEA Learning Academy is due on "+txtDate.Text+". Please Pay installments on time to avoid late fee or suspension of study material/classes. Kindly ignore if already paid.";
    //    //string strUrl = "http://bulksms.sainfotechnologies.com/sendsms.jsp?user="+ UserName + "&password=" + Password + "&mobiles=" + mobileNumber + "&sms=" + Message + "&senderid= IITILA ";
    //    string strUrl ="http://smspanel.sainfotechnologies.in/rest/services/sendSMS/sendGroupSms?AUTH_KEY=57f3f2baae63fa7f7c30a64d97adbaa9&message=" + Message + "&senderId="+ UserName + "&routeId="+1+"&mobileNos="+ mobileNumber + "&smsContentType=english";
    //    //string strUrl = "http://www.technicalsms.com/vendorsms/pushsms.aspx?user=charli&password=TAI9DR7L&msisdn="+mobileNumber+"&sid=SHOREX&msg="+Message+"&fl=0&gwid=2";
    //    //string strUrl = "http://www.technicalsms.com/vendorsms/pushsms.aspx?user=charli&password=TAI9DR7L&msisdn=" + mobileNumber + "&sid=SHOREX&msg=" + Message + "&fl=0&gwid=2";

    //    WebRequest request = HttpWebRequest.Create(strUrl);
    //    HttpWebResponse response = (HttpWebResponse)request.GetResponse();
    //    Stream s = (Stream)response.GetResponseStream();
    //    StreamReader readStream = new StreamReader(s);
    //    string dataString = readStream.ReadToEnd();
    //    //string data = dataString.Substring(25, 7);
    //    response.Close();
    //    s.Close();
    //    readStream.Close();
    //}
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        obj_Student.DuePayment = txtDuepayment.Text.Trim();
        obj_Student.DueDate = txtDate.Text.Trim();
        obj_Student.StudentId = StudentId;
        DS = obj_Student.StudentFeeUpdate();
        lblMsg.Text = "Update Fee!";
    }
    #endregion

    protected void txtBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("StudentDetails.aspx", false);
    }
}