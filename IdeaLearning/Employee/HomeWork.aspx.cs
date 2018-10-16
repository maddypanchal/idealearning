﻿using System;
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

public partial class Employee_HomeWork : System.Web.UI.Page
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
        myFileExtension = Path.GetExtension(FileUploadPDF.PostedFile.FileName);
        if (FileUploadPDF.HasFile)
        {
            if (myFileExtension == ".doc" || myFileExtension == ".docx" || myFileExtension == ".DOC" || myFileExtension == ".DOCX")
            {
                if (FileUploadPDF.PostedFile.ContentLength < 10000000)
                {
                    string FileNamekey = DateTime.Now.Ticks.ToString().Substring(12) + ".docx";
                    FileUploadPDF.SaveAs(MapPath("~/Employee/DocFile/" + "HW-" + FileNamekey));
                    //Thumb Nail Genrator Coded By Rakesh Panchal
                    obj_Master.DocFile = Path.GetFileName("HW-" + FileNamekey);
                    obj_Master.ClassId = Convert.ToInt32(ddlClass.SelectedValue.ToString());
                    obj_Master.ClassCoursesId = Convert.ToInt32(ddlCourselist.SelectedValue.ToString());
                    obj_Master.SubjectId = Convert.ToInt32(ddlSubject.SelectedValue.ToString());
                    obj_Master.Description = txtDescriptions.Text.Trim();
                    checkRecordStatus = obj_Master.AddHomeWork();
                    if (checkRecordStatus >= 0)
                    {
                        lblMsg.Text = "Record Saved and Information sent";
                       // ddlClass.SelectedIndex = -1;
                    }
                    else
                    {
                        lblMsg.ForeColor = Color.Red;
                        lblMsg.Text = "Product Already Exist ";
                        lblMsg.Visible = true;
                    }
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this.Page, typeof(string), "Alert", "alert('The file has to be less than 2MB only!');", true);
                }
           }
         

            if (myFileExtension == ".pdf" || myFileExtension == ".PDF")
            {
                if (FileUploadPDF.PostedFile.ContentLength < 10000000)
                {
                    string FileNamekey = DateTime.Now.Ticks.ToString().Substring(12) + ".PDF";
                    FileUploadPDF.SaveAs(MapPath("~/Employee/DocFile/" + "HW-" + FileNamekey));
                    //Thumb Nail Genrator Coded By Rakesh Panchal
                    obj_Master.DocFile = Path.GetFileName("HW-" + FileNamekey);
                    obj_Master.ClassId = Convert.ToInt32(ddlClass.SelectedValue.ToString());
                    obj_Master.ClassCoursesId = Convert.ToInt32(ddlCourselist.SelectedValue.ToString());
                    obj_Master.SubjectId = Convert.ToInt32(ddlSubject.SelectedValue.ToString());
                    obj_Master.Description = txtDescriptions.Text.Trim();

                    checkRecordStatus = obj_Master.AddHomeWork();
                    if (checkRecordStatus >= 0)
                    {
                        lblMsg.Text = "Record Saved and Information sent";


                    }
                    else
                    {
                        lblMsg.ForeColor = Color.Red;
                        lblMsg.Text = "Product Already Exist ";
                        lblMsg.Visible = true;
                    }
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this.Page, typeof(string), "Alert", "alert('The file has to be less than 2MB only!');", true);
                }
            }


        }
       // SendSMSHomepage();
    }
    #endregion

    #region"Sms Send Event"
    private void SendSMSHomepage()
    {
        obj_Master.ClassId = Convert.ToInt32(ddlClass.SelectedValue);
        obj_Master.ClassCoursesId = Convert.ToInt32(ddlCourselist.SelectedValue);
        DS = obj_Master.FillStudent();
        if (DS.Tables[0].Rows.Count > 0)
        {
            foreach (DataRow row in DS.Tables[0].Rows)
            {
                object val = row["Mobile"];
                String values = Convert.ToString(val);
                if (values != null && values != "")
                {
                    string mobile = row["Mobile"].ToString();
                    SendSmsIderLearning(mobile); 
                }
                else
                {
                    lblMsg.Text = "Mobile number is not Found";
                }
            }
        }
    }



    private void SendSmsIderLearning(string mobile)
    {
        string ClassName = ddlClass.SelectedItem.ToString();
        string SubjectName= ddlCourselist.SelectedItem.ToString();
        string UserName = "IITILA";
        string Password = "fea00c9e4bXX";
        string mobileNumber = mobile;
        string Message = "Dear student, We have uploaded the Assignment/Homework for the class "+ ClassName + " , Subject "+ SubjectName + "and its due date for submission is ...... Do submit your home work on time to get  best results. Do not forget to get signature of your mentor on submitted copy/sheet/Register, Its mandatory .Thanks $ Regards: Team IDEA Learning";
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

   // private void SendSMSHomepage()
   // {
   //     obj_Master.ClassId = Convert.ToInt32(ddlClass.SelectedValue.ToString());
   //     obj_Master.SubjectName = ddlSubject.SelectedItem.ToString();
   //     DS = obj_Master.FillStudent();
   //     if (DS.Tables[0].Rows.Count > 0)
   //     {
   //         foreach (DataRow row in DS.Tables[0].Rows)
   //         {
   //             string mobile = row["Mobile"].ToString();
   //             SendSMS(mobile); // send sms which student send homework
   //         }
   //     }
   //}
    #endregion

    //#region"Sms Send"
    //public string SendSMS(string number)
    //{
    //    string fullResponse = "";
    //    string SmsText = txtDescriptions.Text.Trim();
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
    //#endregion

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
        //FillSubject();
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


            //Session["Classid"] = Convert.ToInt32(ddlClass.SelectedValue.ToString());
            //obj_Master.ClassId = Convert.ToInt32(ddlClass.SelectedValue.ToString());
            //DS = obj_Master.FillSubjectDdl();
            //ddlSubject.DataSource = DS;
            //ddlSubject.DataTextField = DS.Tables[0].Columns[1].ToString();
            //ddlSubject.DataValueField = DS.Tables[0].Columns[0].ToString();
            //ddlSubject.DataBind();
            //ddlSubject.Items.Add(new System.Web.UI.WebControls.ListItem("---Select Class---", "0"));
            //ddlSubject.SelectedValue = "0";
            //DS.Dispose();
            //ddlSubject.Dispose();
        }
        catch (Exception ex)
        {
            lblMsg.Text = ex.ToString();
        }
    }
    #endregion
}