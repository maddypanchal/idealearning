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

using System.IO;
using System.Net;
using System.Text;
using System.Configuration;
using System.Web.Security;
using System.Web.UI.HtmlControls;
using System.Collections;

public partial class Admin_EditSyllabus : System.Web.UI.Page
{
    
    #region "VARIABLE DECLARATION"
    private clsMaster obj_Master = new clsMaster();
    private clsEmployee obj_Employee = new clsEmployee();
    private DataSet DS;
    private int checkRecordStatus;
    public int SyallbusId;
    #endregion

    #region"Page Load"
    protected void Page_Load(object sender, EventArgs e)
    {
        SyallbusId = int.Parse(Request.QueryString["Sid"]);
       Session["SyallbusId"] = SyallbusId;
        if (!IsPostBack)
        {
           // SyallbusId = int.Parse(Request.QueryString["Sid"]);
            FillClass();
            Employee();
            FillSyllabus();
        }
        txtTitleDate.Text = DateTime.Today.ToString("dd/MM/yyyy"); 
    }
    #endregion

    #region"Fill Syllabus"
    public void FillSyllabus()
    {
        obj_Master.SyllabusId = Convert.ToInt32(Session["SyallbusId"]);
        DS = obj_Master.DisplaySyllabusbyid();

        if (DS.Tables[0].Rows.Count > 0)
        {
            foreach (DataRow row in DS.Tables[0].Rows)
            {
               ddlClass.SelectedValue=  row["ClassId"].ToString();
               ddlCourselist.SelectedValue = row["CoursesId"].ToString();
               ddlSubject.SelectedValue = row["SubjectId"].ToString();


               fillCoursesByClass(row["ClassId"].ToString());

               ddlCourselist.SelectedValue = row["CoursesId"].ToString();



               Session["CoursesId"] = row["CoursesId"].ToString();


               fillSubjectByCourseOne(row["ClassId"].ToString(), row["CoursesId"].ToString());

               Session["CoursesId"] = row["CoursesId"].ToString();
           

               ddlSubject.SelectedValue = row["CoursesId"].ToString();
             

               ddlEmployee.SelectedValue = row["EmployeeId"].ToString();
               txtContent.Text= row["ContentBy"].ToString();
               txtTitleDate.Text= row["Date"].ToString();
               CKEditor1.Text = row["SyllabusDescription"].ToString();
            
                  
            }
        }
     
    }

    private void fillSubjectByCourseOne(string ClassId, string CoursesOne)
    {
        try
        {
            if (ClassId != "" && CoursesOne != "")
            {
                obj_Master.ClassId = Convert.ToInt32(ClassId);
                obj_Master.ClassCoursesId = Convert.ToInt32(CoursesOne);
                DS = obj_Master.FillSubjectCourses();
                ddlSubject.DataSource = DS;

                DS.Tables[0].Merge(DS.Tables[1]);
                ddlSubject.DataTextField = DS.Tables[0].Columns[1].ToString();
                ddlSubject.DataValueField = DS.Tables[0].Columns[0].ToString();
                ddlSubject.DataBind();
                ddlSubject.Dispose();

               
            }
        }
        catch (Exception ex)
        {
            lblMsg.Text = ex.ToString();
        }
    }

    private void fillCoursesByClass(string ClassId)
    {
        try
        {
            if (ClassId != "")
            {
                obj_Master.ClassId = Convert.ToInt32(ClassId);
                DS = obj_Master.FillClassCoursesDdl();
                ddlCourselist.DataSource = DS;

                DS.Tables[0].Merge(DS.Tables[1]);

                ddlCourselist.DataTextField = DS.Tables[0].Columns[1].ToString();
                ddlCourselist.DataValueField = DS.Tables[0].Columns[0].ToString();
                ddlCourselist.DataBind();
                ddlCourselist.Dispose();




            }
        }
        catch (Exception ex)
        {
            lblMsg.Text = ex.ToString();
        }
    }
    #endregion

    #region "Fill Employee"
    protected void Employee()
    {
        try
        {
            DS = obj_Employee.DisplayEmployeeSyllbus();
            ddlEmployee.DataSource = DS;
            DS.Tables[0].Merge(DS.Tables[1]);
            ddlEmployee.DataTextField = DS.Tables[0].Columns[1].ToString();
            ddlEmployee.DataValueField = DS.Tables[0].Columns[0].ToString();
            ddlEmployee.DataBind();
            ddlEmployee.Dispose();
        }
        catch (Exception ex)
        {
            lblMsg.Text = ex.ToString();
        }
    }
    #endregion 

    #region "Fill Class"
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

    #region"Home Work Event"
    protected void btnSave_Click(object sender, EventArgs e)
    {
                    obj_Master.SyllabusId = Convert.ToInt32(Session["SyallbusId"]); 
                    obj_Master.ClassId = Convert.ToInt32(ddlClass.SelectedValue.ToString());

                    obj_Master.CoursesId =Convert.ToInt32(ddlCourselist.SelectedValue.ToString());
                    if (obj_Master.CoursesId == -1)
                    {
                        obj_Master.CoursesId = Convert.ToInt32( Session["CoursesId"]);
                    }
                    obj_Master.SubjectId = Convert.ToInt32(ddlSubject.SelectedValue.ToString());
                    obj_Master.EmployeeId = Convert.ToInt32(ddlEmployee.SelectedValue.ToString());
                    obj_Master.ContentBy = txtContent.Text.Trim();
                    String ckContentValue = CKEditor1.Text.Trim();
                    obj_Master.SyllabusDescription = ckContentValue;
                    obj_Master.Date = txtTitleDate.Text.Trim();
                    checkRecordStatus = obj_Master.UpdateSyllabus();
                    if (checkRecordStatus >= 0)
                    {
                        lblMsg.Text = "Record Saved !";
                        Response.Redirect("SyllabusDetails.aspx", false);
                    }
                    else
                    {
                        lblMsg.ForeColor = Color.Red;
                        lblMsg.Text = "Product Already Exist ";
                        lblMsg.Visible = true;
                    }
        // SendSMSHomepage();
    }
    #endregion

    #region"not Activeed closed by rakesh panchal permission by RN Tiwari sir"
    //private void SendSMSHomepage()
    //{
    //    obj_Master.ClassId = Convert.ToInt32(Session["Classid"].ToString());
    //    obj_Master.SubjectName = ddlSubject.SelectedItem.ToString();
    //    DS = obj_Master.FillStudent();
    //    if (DS.Tables[0].Rows.Count > 0)
    //    {
    //        foreach (DataRow row in DS.Tables[0].Rows)
    //        {
    //            string mobile = row["Mobile"].ToString();
    //            SendSmsIderLearning(mobile); // send sms which student send homework
    //        }
    //    }
    //}
    #endregion

    #region"Sms Send"

    //private void SendSmsIderLearning(string mobile)
    //{

    //    string UserName = "IITILA";
    //    string Password = "fea00c9e4bXX";
    //    string mobileNumber = mobile;
    //    string Message = txtContent.Text.Trim();


    //    string strUrl = "http://bulksms.sainfotechnologies.com/sendsms.jsp?user=" + UserName + "&password=" + Password + "&mobiles=" + mobileNumber + "&sms=" + Message + "&senderid= IITILA ";
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
    //    string fullResponse = "";
    //    string SmsText = txtContent.Text.Trim();
    //    string uid = "ideaedukkr";
    //    string pwd = "ideakkr@123";
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

    #region"Select Index Change Courses list"
    protected void ddlCourseList_SelectedIndexChanged(object sender, EventArgs e)
    {

        FillSubject();
    }
    #endregion

    #region"Class Select Index Changed"
    protected void ddlClass_SelectedIndexChanged(object sender, EventArgs e)
    {
        FillClassCourses();
       
    }
    #endregion

    #region" Fill Subject by Class Id"
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
