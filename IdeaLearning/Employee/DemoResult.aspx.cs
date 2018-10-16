using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;
using System.Data.SqlClient;
using System.Data.OleDb;


using System.Net;
using System.Text;
using System.Configuration;
using System.Web.Security;
using System.Web.UI.HtmlControls;
using System.Collections;

using System.Design;
using System.Drawing.Design;
using System.Drawing.Text;

public partial class Employee_DemoResult : System.Web.UI.Page
{
    // SqlConnection conn = new SqlConnection("Data Source=198.71.266.2;Initial Catalog=ideaedu ;Integrated Security=True;uid=idea;pwd=maddy@1234");
    SqlConnection conn = new SqlConnection("Data Source=RAKESH-PC;Initial Catalog=IdeaNew ;Integrated Security=True;uid=sa; pwd=maddy");
    DataSet ds;
    DataTable Dt;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindGrid();
        }
    }

    private void ImporttoDatatable()
    {
        try
        {
            if (FlUploadcsv.HasFile)
            {
                string FileName = FlUploadcsv.FileName;
                string path = string.Concat(Server.MapPath("~/Employee/Document/" + FlUploadcsv.FileName));
                FlUploadcsv.PostedFile.SaveAs(path);
                OleDbConnection OleDbcon = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Extended Properties=Excel 12.0;");
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM [Sheet1$]", OleDbcon);
                OleDbDataAdapter objAdapter1 = new OleDbDataAdapter(cmd);
                ds = new DataSet();
                objAdapter1.Fill(ds);
                Dt = ds.Tables[0];
            }
        }
        catch (Exception ex)
        {

        }
    }

    private void CheckData()
    {
        try
        {
            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                if (Dt.Rows[i][0].ToString() == "")
                {

                    int RowNo = i + 2;
                    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "InvalidArgs", "alert('Please enter SR_NO_ID in row " + RowNo + "');", true);
                    return;
                }
            }

            for (int i = 0; i < Dt.Rows.Count; i++)
            {

                if (Dt.Rows[i][1].ToString() == "")
                {
                    int RowNo = i + 2;
                    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "InvalidArgs", "alert('Please enter ROLL_NO in row " + RowNo + "');", true);
                    return;
                }
            }

            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                if (Dt.Rows[i][2].ToString() == "")
                {
                    int RowNo = i + 2;
                    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "InvalidArgs", "alert('Please enter ICT_RANK in row " + RowNo + "');", true);
                    return;
                }
            }

            //for (int i = 0; i < Dt.Rows.Count; i++)
            //{
            //    string date = DateTime.Parse(Dt.Rows[i][3].ToString()).ToString("dd/MM/yyyy");

            //    if (!ValidateDate(date))
            //    {
            //        int RowNo = i + 2;
            //        ScriptManager.RegisterStartupScript(Page, Page.GetType(), "InvalidArgs", "alert('Wrong Date format in row " + RowNo + "');", true);

            //        return;
            //    }
            //}

            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                if (Dt.Rows[i][4].ToString() == "")
                {
                    int RowNo = i + 2;
                    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "InvalidArgs", "alert('Please Enter STUDENT_NAME in Row " + RowNo + "');", true);
                    return;
                }
            }
        }
        catch (Exception ex)
        {

        }
    }

    private bool ValidateDate(string date)
    {
        try
        {
            string[] dateParts = date.Split('/');
            DateTime testDate = new DateTime(Convert.ToInt32(dateParts[2]), Convert.ToInt32(dateParts[1]), Convert.ToInt32(dateParts[0]));
            return true;
        }
        catch
        {
            return false;
        }
    }

    private void InsertData()
    {
        for (int i = 0; i < Dt.Rows.Count; i++)
        {
            DataRow row = Dt.Rows[i];
            int columnCount = Dt.Columns.Count;
            string[] columns = new string[columnCount];
            for (int j = 0; j < columnCount; j++)
            {
                columns[j] = row[j].ToString();
            }
            if (columns[1] != null && columns[1].Length > 1)
            {
                conn.Open();

                string sql = "INSERT INTO Result (RollNo,StudentName,Rank)";
                sql += "VALUES('" + columns[0] + "','" + columns[1] + "','" + columns[2] + "')";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.ExecuteNonQuery();
                conn.Close();


               // SendSMS(columns[5]);

            }
        }
    }

    public string SendSMS(string number)
    {
        string fullResponse = "";
        string SmsText = "Your Result upload form your IDEA ERP ";
        string uid = "ideaedu1";
        string pwd = "1234567";
        string sid = "IDEAed";

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
            //logger.Error(ex.Message.ToString());
            fullResponse = "";
        }
        return fullResponse;
    }

    protected void btnIpload_Click(object sender, EventArgs e)
    {
        ImporttoDatatable();
        CheckData();
        InsertData();
        BindGrid();
    }

    private void BindGrid()
    {
        DataSet ds = new DataSet();
        conn.Open();
        string cmdstr = "Select * from TBL_I_Results";
        SqlDataAdapter adp = new SqlDataAdapter(cmdstr, conn);
        adp.Fill(ds);
        gvEmployee.DataSource = ds;
        gvEmployee.DataBind();
        ds.Dispose();
        conn.Close();
    }
}