using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using DataAccess;
using BusinessLogic.Admin;
using System.Net;
using System.IO;

public partial class Employee_ExamInfo : System.Web.UI.Page
{
    #region "VARIABLE DECLARATION"
    private clsMaster obj_Master = new clsMaster();
    private DataSet DS;
    private int checkRecordStatus;
    private string myFileExtension;
    #endregion

    #region"Page Load"
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            FillClass();
        }
    }
    #endregion

    #region "Fill Class List Method"
    protected void FillClass()
    {
        try
        {
            DS = obj_Master.FillClassDdl();
            ddlClass.DataSource = DS;
            DS.Tables[0].Merge(DS.Tables[1]);
            ddlClass.DataTextField = DS.Tables[0].Columns[1].ToString();
            ddlClass.DataValueField = DS.Tables[0].Columns[0].ToString();
            ddlClass.DataBind();
            ddlClass.Dispose();
        }
        catch (Exception ex)
        {
            lblMsg.Text = ex.ToString();
        }
    }
    #endregion "End Main Category List Method"
  
    #region"Save Event Exam Info"
    protected void btnSave_Click(object sender, EventArgs e)
    {
        obj_Master.ClassId = Convert.ToInt32(ddlClass.SelectedValue); //    Convert.ToInt32(ddlClass.SelectedValue.ToString());
        obj_Master.ClassCoursesId = Convert.ToInt32(ddlCourselist.SelectedValue);
        obj_Master.SubjectId = Convert.ToInt32(ddlSubject.SelectedValue);
        obj_Master.SubjectName = txtSubjectName.Text.Trim();
        obj_Master.Syllabus = txtSyllabus.Text.Trim();
        obj_Master.TestDate = txtTestDate.Text.Trim();
        obj_Master.Venue = txtVenue.Text.Trim();
        obj_Master.TypeOfTest = ddlTest.SelectedItem.ToString();
        checkRecordStatus = obj_Master.AddExamInfoByEmployee();
        if (checkRecordStatus >= 0)
        {
            lblMsg.Text = "Record Saved!";

            //SendSMSByExamInfo();

            txtSubjectName.Text = "";
            txtSyllabus.Text = "";
            txtTestDate.Text = "";
            txtVenue.Text = "";
            ddlTest.SelectedIndex = -1;
            ddlClass.SelectedIndex = -1;
        }

     
    }
    #endregion

    #region"Sms Send Event"
    private void SendSMSByExamInfo()
    {
        obj_Master.ClassId = Convert.ToInt32(ddlClass.SelectedValue);
        //  Convert.ToInt32(Session["Classid"].ToString());
        obj_Master.ClassCoursesId = Convert.ToInt32(ddlCourselist.SelectedValue);

        DS = obj_Master.FillStudentByExamInfo();
        if (DS.Tables[0].Rows.Count > 0)
        {
            foreach (DataRow row in DS.Tables[0].Rows)
            {

                object val = row["Mobile"];
                String values = Convert.ToString(val);
                if (values != null && values != "" )
                {
                    string mobile = row["Mobile"].ToString();
                    //SendSmsIderLearning(mobile); // send sms which student send homework
                }
                else
                {
                    lblMsg.Text = "Mobile number is not Found";
                }
            }
        }
    }
    #endregion

    #region"Sms Send"
    private void SendSmsIderLearning(string mobile)
    {

        string UserName = "IITILA";
        string Password = "fea00c9e4bXX";
        string mobileNumber = mobile;
        string Message = "Dear parents , exam information is recently updated. New exam date is .......,Please check exam info section on web portal for syllabus and other details.Do check your web portal regularly for latest updates &Live student performance.Thanks & Regards : Team IDEA learning";

        //string strUrl = "http://bulksms.sainfotechnologies.com/sendsms.jsp?user=" + UserName + "&password=" + Password + "&mobiles=" + mobileNumber + "&sms=" + Message + "&senderid= IITILA ";
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

    //public string SendSMS(string number)
    //{
    //    string fullResponse = "";
    //    string SmsText = txtContent.Text.Trim();
    //    string uid = "ideaedukkr";
    //    string pwd = "idea@2017";
    //    string sid = "IDEAed";
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
    #endregion




    #region"Class list Selected Index Changed"
    protected void ddlClass_SelectedIndexChanged(object sender, EventArgs e)
    {
        FillClassCourses();
    }
    #endregion

    #region"Fill Class Courses by Class"
    private void FillClassCourses()
    {
        try
        {
            obj_Master.ClassId = Convert.ToInt32(ddlClass.SelectedValue.ToString());
            DS = obj_Master.FillClassCoursesDdl();
            ddlCourselist.DataSource = DS;
            DS.Tables[0].Merge(DS.Tables[1]);
            ddlCourselist.DataTextField = DS.Tables[0].Columns[1].ToString();
            ddlCourselist.DataValueField = DS.Tables[0].Columns[0].ToString();
            ddlCourselist.DataBind();
            ddlCourselist.Dispose();
        }
        catch (Exception ex)
        {
            lblMsg.Text = ex.ToString();
        }
    }
    #endregion

    #region"Course List Selected Index Changed"
    protected void ddlCourseList_SelectedIndexChanged(object sender, EventArgs e)
    {
        FillSubject();
    }
    #endregion

    #region"Fill Subject by Courses"
    private void FillSubject()
    {
        try
        {
            obj_Master.ClassId = Convert.ToInt32(ddlClass.SelectedValue.ToString());
            obj_Master.ClassCoursesId = Convert.ToInt32(ddlCourselist.SelectedValue.ToString());
            DS = obj_Master.FillSubjectCourses();
            ddlSubject.DataSource = DS;
            DS.Tables[0].Merge(DS.Tables[1]);
            ddlSubject.DataTextField = DS.Tables[0].Columns[1].ToString();
            ddlSubject.DataValueField = DS.Tables[0].Columns[0].ToString();
            ddlSubject.DataBind();
            ddlSubject.Dispose();
        }
        catch (Exception ex)
        {
            lblMsg.Text = ex.ToString();
        }
    }
    #endregion
}