using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.IO;
using System.Data.SqlClient;
using System.Data;
using DataAccess;
using BusinessLogic.Admin;


using System.Net;
using System.Text;
using System.Configuration;
using System.Web.Security;
using System.Web.UI.HtmlControls;
using System.Collections;


public partial class Employee_AddAttendance : System.Web.UI.Page
{
    #region "VARIABLE DECLARATION"
    private clsMaster obj_Master = new clsMaster();
    private clsStudent obj_Student = new clsStudent();
    private DataSet DS;
    private int checkRecordStatus;
    private string myFileExtension;
    public int RecordStatus;
    #endregion

    #region"Page Load"
    protected void Page_Load(object sender, EventArgs e)
    {
        txtDate.Text = System.DateTime.Now.ToString();
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

    #region"Class dropdown Slect index changed "
    protected void ddlCourseList_SelectedIndexChanged(object sender, EventArgs e)
    {
      
        FillSubject();
    }
    #endregion

    #region"Fill Subject by Class"
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

    #region "Fill Class for Select index Changed"
    protected void ddlClass_SelectedIndexChanged(object sender, EventArgs e)
    {
        FillClassCourses();
    }
#endregion


    #region"Fill Subject by Class"
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
     
    #region " Fill User Grid View"
    public void FillStudent()
    {
        obj_Student.ClassId = Convert.ToInt32(ddlClass.SelectedValue.ToString());
        obj_Student.ClassCoursesId = Convert.ToInt32(ddlCourselist.SelectedValue.ToString());
      //  obj_Student.CourseOne = ddlCourselist.SelectedItem.ToString();
        obj_Student.SubjectId = Convert.ToInt32(ddlSubject.SelectedValue.ToString());
       // obj_Student.SubjectName = ddlSubject.SelectedItem.ToString();
        //DS = obj_Student.DisplayStudentByClassId();
        DS = obj_Student.StudentByClassAttendence();

        gvDetail1.DataSource = DS;
        gvDetail1.DataBind();
    }
    #endregion "End Fill User GridView"

    protected void gvDetail1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {

    }
    protected void gvDetail1_RowEditing(object sender, GridViewEditEventArgs e)
    {

    }

    protected void gvDetail1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        obj_Student.StudentId = Convert.ToInt32(gvDetail1.DataKeys[e.RowIndex].Values["StudentId"].ToString());
        RecordStatus = obj_Student.DeleteStudent();
        FillStudent();
    }

    protected void gvDetail1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {

    }

    protected void btnSaveButton_Click(object sender, EventArgs e)
    {
        
        if (gvDetail1.PageCount.Equals(0))
        {
            lblMsg.Visible = true;
            lblMsg.Text = "PLEASE SELECT CLASS,COURSES AND SUBJECT";
        }
        else
        {
            foreach (GridViewRow row in gvDetail1.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox chkAttendance = row.FindControl("chkAttendence") as CheckBox;
                    obj_Student.Absent = chkAttendance.Checked ? "Absent" : "Present";
                    obj_Student.RollNo = ((row.FindControl("lblRollNumber") as Label).Text.Trim());
                    obj_Student.StudentName = ((row.FindControl("lblStudentName") as Label).Text.Trim());
                    obj_Student.StudentId = Convert.ToInt32(((row.FindControl("lblStudentId") as Label).Text.Trim()));
                    obj_Student.Date = (this.txtDate.Text.Trim());
                    obj_Student.ClassId = Convert.ToInt32(ddlClass.SelectedValue.ToString());
                    obj_Student.ClassCoursesId = Convert.ToInt32(ddlCourselist.SelectedValue.ToString());
                    obj_Student.SubjectId = Convert.ToInt32(ddlSubject.SelectedValue.ToString());

                    checkRecordStatus = obj_Student.AddAttendanceGridview();
                    if (obj_Student.Absent == "Absent")
                    {
                        string mobile = ((row.FindControl("lblMobile") as Label).Text.Trim());
                       // SendSMS(mobile);
                        SendSmsIderLearning(mobile);
                    }
                }
                lblMsg.Visible = true;
                lblMsg.Text = "ATTENDANCE SUBMITTED SUCCESSFULLY";
             }
         }
     }


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
    //        string SmsText = "Dear parents Your son/daughter is absent in today's class/test At Idea Learning Academy. For details please call us";
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

    protected void ddlSubject_SelectedIndexChanged(object sender, EventArgs e)
    {
        FillStudent();
        btnSaveButton.Visible = true;
    }
}