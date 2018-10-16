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
using DataAccess;
using BusinessLogic.Admin;
using System.Globalization;
//using System.ComponentModel.Win32Exception;


public partial class Employee_AddResult : System.Web.UI.Page
{
    #region "VARIABLE DECLARATION"
    private Results obj_Result = new Results();
    private clsMaster obj_Master = new clsMaster();
    private DataSet DS;
    private DataTable DT;
    private int checkRecordStatus;
    #endregion


    DataSet ds;
    DataTable Dt;

    #region"Page load "
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
           // BindGrid();
             // BindGrid1();
              FillClassDristhi();
              FillClassRegular();
           // DristhiBindGrid();
        }
    }
    #endregion

    public static DataTable GetDataTableFromExcel(string path)
    {
        bool hasHeader = true;
        using (var pck = new OfficeOpenXml.ExcelPackage())
        {
            using (var stream = File.OpenRead(path))
            {
                pck.Load(stream);
            }
            var ws = pck.Workbook.Worksheets.First();
            DataTable tbl = new DataTable();
            foreach (var firstRowCell in ws.Cells[1, 1, 1, ws.Dimension.End.Column])
            {
                tbl.Columns.Add(hasHeader ? firstRowCell.Text : string.Format("Column {0}", firstRowCell.Start.Column));
            }
            var startRow = hasHeader ? 2 : 1;
            for (int rowNum = startRow; rowNum <= ws.Dimension.End.Row; rowNum++)
            {
                var wsRow = ws.Cells[rowNum, 1, rowNum, ws.Dimension.End.Column];
                DataRow row = tbl.Rows.Add();
                foreach (var cell in wsRow)
                {
                    row[cell.Start.Column - 1] = cell.Text;
                }
            }
            return tbl;
        }
    }

    #region "Fill Class Dristhi"
    protected void FillClassDristhi()
    {
        try
        {
            DS = obj_Master.FillClassDdl();
            ddlClassDristhi.DataSource = DS;
            DS.Tables[0].Merge(DS.Tables[1]);
            ddlClassDristhi.DataTextField = DS.Tables[0].Columns[1].ToString();
            ddlClassDristhi.DataValueField = DS.Tables[0].Columns[0].ToString();
            ddlClassDristhi.DataBind();
            ddlClassDristhi.Dispose();
        }
        catch (Exception ex)
        {
            //lblMsg.Text = ex.ToString();
        }
    }
    #endregion

    #region "Fill Class Regular"
    protected void FillClassRegular()
    {
        try
        {
            DS = obj_Master.FillClassDdl();
            ddlClassRegular.DataSource = DS;
            DS.Tables[0].Merge(DS.Tables[1]);
            ddlClassRegular.DataTextField = DS.Tables[0].Columns[1].ToString();
            ddlClassRegular.DataValueField = DS.Tables[0].Columns[0].ToString();
            ddlClassRegular.DataBind();
            ddlClassRegular.Dispose();
        }
        catch (Exception ex)
        {
           // lblMsg.Text = ex.ToString();
        }
    }
    #endregion

    #region"For Result Select Index Change"
    protected void ddlResult_SelectedIndexChanged(object sender, EventArgs e)
    {      // ScholarShip Test
        if (ddlResult.SelectedValue == "1")
        {
            lblResults.Text = "ADD SCHOLAR SHIP TEST RESULT";
            lblTestName.Text = ddlResult.SelectedItem.ToString();
            UpScholarShipTest.Visible = true;
            UpItseTest.Visible = false;
            UpRegularTest.Visible = false;
            UpDristhiTest.Visible = false;
        }
        // For ITSE TEST
        else if (ddlResult.SelectedValue == "2")
        {
            lblResults.Text = "ADD ITSE TEST RESULT";
            UpScholarShipTest.Visible = false;
            UpItseTest.Visible = true;
            UpRegularTest.Visible = false;
            UpDristhiTest.Visible = false;
        }
        // For DRISHTI TEST
        else if (ddlResult.SelectedValue == "3")
        {
            lblResults.Text = "ADD DRISTHI TEST RESULT";
            lblTestName.Text = ddlResult.SelectedItem.ToString();
            UpDristhiTest.Visible = true;
            UpScholarShipTest.Visible = false;
            UpItseTest.Visible = false;
            UpRegularTest.Visible = false;
        }
        // For REGULAR TEST
        else if (ddlResult.SelectedValue == "4")
        {
            lblResults.Text = "ADD REGULAR TEST RESULT";
            UpScholarShipTest.Visible = false;
            UpItseTest.Visible = false;
            UpRegularTest.Visible = true;
            UpDristhiTest.Visible = false;
        }
        // For KBPY/NTSE/Loympiad/other Test
        else if (ddlResult.SelectedValue == "5")
        {
            lblResults.Text = "ADD KVPY/NTSE/Olympiad/Other TEST RESULT";
        
            lblTestName.Text = ddlResult.SelectedItem.ToString();
            UpScholarShipTest.Visible = true;
            UpItseTest.Visible = false;
            UpRegularTest.Visible = false;
            UpDristhiTest.Visible = false;
        }
    }
    #endregion
    
    #region" ITSE Import to data table"
    private void ImporttoDatatable()
    {
        try
        {
            if (FlUploadcsv.HasFile)
            {
                string FileName = FlUploadcsv.FileName;
                string FileNamekey = DateTime.Now.Ticks.ToString().Substring(12) + FileName;
                FlUploadcsv.SaveAs(MapPath("~/Employee/Document/" + "CM-" + FileNamekey));
                string path = string.Concat(Server.MapPath("~/Employee/Document/" + "CM-" + FileNamekey));
                Dt = GetDataTableFromExcel(path);
            }
        }
        catch (Exception ex)
        {
            lblError.Visible = true;
        }
    }
    #endregion

    #region"ITSE Check data"
    private void CheckData()
    {
        try
        {
            for (int i = 0; i < Dt.Rows.Count-1; i++)
            {
                if (Dt.Rows[i][0].ToString() == "")
                {
                    int RowNo = i + 2;
                    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "InvalidArgs", "alert('Please enter ItseResultId in row " + RowNo + "');", true);
                    return;
                }
            }
            for (int i = 0; i < Dt.Rows.Count-1; i++)
            {
                if (Dt.Rows[i][1].ToString() == "")
                {
                    int RowNo = i + 2;
                    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "InvalidArgs", "alert('Please enter RollNo in row " + RowNo + "');", true);
                    return;
                }
            }

            for (int i = 0; i < Dt.Rows.Count-1; i++)
            {
                if (Dt.Rows[i][2].ToString() == "")
                {
                    int RowNo = i + 2;
                    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "InvalidArgs", "alert('Please enter StudentName in row " + RowNo + "');", true);
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

            for (int i = 0; i < Dt.Rows.Count-1; i++)
            {
                if (Dt.Rows[i][3].ToString() == "")
                {
                    int RowNo = i + 2;
                    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "InvalidArgs", "alert('Please Enter Rank in Row " + RowNo + "');", true);
                    return;
                }
            }
        }
        catch (Exception ex)
        {

        }
    }
    #endregion

    #region"ITSE Validate Date"
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
    #endregion

    #region"ITSE  Insert Data"
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
            if (columns[1] != null && columns[1].Length > 0)
            {
                Decimal perceate = Convert.ToInt32(columns[7]) * 100;
                decimal per = perceate / Convert.ToInt32(columns[6]);

                obj_Result.ItseResultId =Convert.ToInt32(columns[0]);
                obj_Result.RollNumber = columns[1];
                obj_Result.Name = columns[2];
                obj_Result.School = columns[3];
                obj_Result.FatherName = columns[4];
                obj_Result.MobileNo = columns[5];
                obj_Result.MaxMark = columns[6];
                obj_Result.ObtainMark = columns[7];
                obj_Result.PercentageMark = per;// columns[8];
                obj_Result.Rank = columns[9];
                obj_Result.ScholoarShip = columns[10];
                obj_Result.year = columns[11];
                obj_Result.Class= columns[12];
                obj_Result.Additional_ScholoarShip = columns[13];
                obj_Result.Total_ScholoarShip = columns[14];
                obj_Result.AddITSETest();
                
          
            }
        }
    }
    #endregion

    #region"ITSE File Upload"
    protected void btnIpload_Click(object sender, EventArgs e)
    {
        ImporttoDatatable();
        CheckData();
        InsertData();
        BindGrid();
    }
    #endregion

    #region " Fill Grid View"
    public void BindGrid()
    {
        ds = obj_Master.FillItseResult();
        gvDetail1.DataSource = ds;
        gvDetail1.DataBind();

    }
    #endregion
  
    /// <summary>
    /// for Dristhi test data 
    /// </summary>

    #region"Evnet of Dristhi test"
    protected void btnDristhi_Click(object sender, EventArgs e)
    {
        try
        {

            //obj_Result.DristhiTestDate = DateTime.ParseExact(txtDristhiDate.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            if (FuDristhi.HasFile)
            {
                string FileName = FuDristhi.FileName;
                string FileNamekey = DateTime.Now.Ticks.ToString().Substring(12) + FileName;
                FuDristhi.SaveAs(MapPath("~/Employee/Document/" + "CM-" + FileNamekey));
                string path = string.Concat(Server.MapPath("~/Employee/Document/" + "CM-" + FileNamekey));
                Dt = GetDataTableFromExcel(path);
                obj_Result.DristhiTesttype = ddlResult.SelectedIndex.ToString();
                obj_Result.DristhiTestDate = DateTime.ParseExact(txtDristhiDate.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture);
                obj_Result.DristhiSyllabus = txtSyllabus.Text.Trim();
                obj_Result.DristhiTestCode = ddlDrishti.SelectedItem.ToString();
                obj_Result.DristhiTestName = txtDristhiTestName.Text.Trim();
                obj_Result.ClassDristhi = ddlClassDristhi.SelectedValue;
                obj_Result.DristhiFilePath = FileName;
                checkRecordStatus = obj_Result.AddDristhiTest();
                Session["checkRecordStatus"] = checkRecordStatus;

                if (checkRecordStatus > 0)
                {
                    DristhiCheckData();
                    DristhiInsertData();
                    DristhiBindGrid();
                    lblError.Text = "Record Save !";
                }
                else if (checkRecordStatus == 0)
                {
                    lblError.Visible = true;
                    lblError.Text = "Test Name Already exists Save !";
                }
            }
        }
        catch (Exception ex)
        {

        }
    }
    #endregion

    #region"Dristhi Check data"
    private void DristhiCheckData()
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
    #endregion

    #region"Dristhi Validate Date"
    private bool DristhiValidateDate(string date)
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
    #endregion
    
    #region"Dristhi Insert Data"
    private void DristhiInsertData()
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
                 obj_Result.DristhiTestSheetId= Convert.ToInt32(columns[0]);
                 obj_Result.DristhiTestResultId = Convert.ToInt32(Session["checkRecordStatus"]);
                obj_Result.Name=columns[2];
                obj_Result.RegNo=columns[3];
                obj_Result.MmPhy=columns[4];
                obj_Result.MmChe=columns[5];
                obj_Result.MmMath=columns[6];
                obj_Result.MmBio=columns[7];
                obj_Result.MmGk=columns[8];
                obj_Result.MmEng=columns[9];
                obj_Result.MmScience=columns[10];
                obj_Result.MoPhy=columns[11];
                obj_Result.MoChe=columns[12];
                obj_Result.MoMath=columns[13];
                obj_Result.MoBio=columns[14];
                obj_Result.MoGk=columns[15];
                obj_Result.MoEng=columns[16];
                obj_Result.MoScience=columns[17];
                obj_Result.TotalMaxMarks=columns[18];
                obj_Result.TotalMarks=columns[19];
                obj_Result.CutOfMarks=columns[20];
                obj_Result.Percentage=columns[21];
                obj_Result.AIRRank=columns[22];
                obj_Result.TotolMarksOfTopper=columns[23];
                obj_Result.AddDristhiTestSheet();
       
            }
        }
        Session["checkRecordStatus"] = null;
    }
    #endregion

    #region"Dristhi Bind Data Brid"
    private void DristhiBindGrid()
    {
        ds = obj_Master.FillDristhiTestSheet();
        GridView1.DataSource = ds;
        GridView1.DataBind();
     }
    #endregion

    /// <summary>
    /// for Regular test data 
    /// </summary>

    #region"Event for Regular test"
    protected void btnRegularTest_Click(object sender, EventArgs e)
    {
        try
        {
           // obj_Result.RegularTestDate = txtRegularDate.Text.Trim();

            if (FURegular.HasFile)
            {

                string FileName = FURegular.FileName;
                string FileNamekey = DateTime.Now.Ticks.ToString().Substring(12) + FileName;
                FURegular.SaveAs(MapPath("~/Employee/Document/" + "CM-" + FileNamekey));
                string path = string.Concat(Server.MapPath("~/Employee/Document/" + "CM-" + FileNamekey));
                Dt = GetDataTableFromExcel(path);

                obj_Result.TestTitle = ddlResult.SelectedIndex.ToString();
                obj_Result.RegularTestDate =  txtRegularDate.Text.Trim();//DateTime.ParseExact(txtRegularDate.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture);
                obj_Result.TestType = ddlRegularTestType.SelectedItem.ToString();
                obj_Result.TestName = TxtRegularTestName.Text.Trim();
                obj_Result.Syllabus = txtRegularSyllabus.Text.Trim();
                obj_Result.ClassRegular = ddlClassRegular.SelectedValue;

                obj_Result.DPP = ddlDpp.SelectedItem.ToString();

                obj_Result.FilePath = FileName;

                checkRecordStatus = obj_Result.AddRegularTest();
                Session["checkRecordStatus"] = checkRecordStatus;

                if (checkRecordStatus > 0)
                {
                    RegularCheckData();

                    RegularInsertData();

                    RegularBindGrid();

                    lblError.Text = "Record Save !";
                }
                else if (checkRecordStatus == 0)
                {
                    lblError.Visible = true;
                    lblError.Text = "Test Name Already exists Save !";
                }
            
            }
        }
        catch (Exception ex)
        {

        }
    }
    
    #endregion
      
    #region"Import to For Regular test data table"
    private void RegularImporttoDatatable()
    {
        try
        {
            if (FURegular.HasFile)
            {
                string FileName = FURegular.FileName;
                string FileNamekey = DateTime.Now.Ticks.ToString().Substring(12) + FileName;
                FURegular.SaveAs(MapPath("~/Employee/Document/" + "CM-" + FileNamekey));
                string path = string.Concat(Server.MapPath("~/Employee/Document/" + "CM-" + FileNamekey));
                Dt = GetDataTableFromExcel(path);

            }
        }
        catch (Exception ex)
        {
            lblError.Visible = true;
        }
    }
    #endregion

    #region"Regular Check data"
    private void RegularCheckData()
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
    #endregion

    #region"Regular Validate Date"
    private bool RegularValidateDate(string date)
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
    #endregion

    #region"Regular Insert Data"
    private void RegularInsertData()
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
                obj_Result.RegularTestSheetId =Convert.ToInt32(columns[0]);
                obj_Result.RegularTestId = Convert.ToInt32(Session["checkRecordStatus"]);
                obj_Result.RegNo  =columns[2];
                obj_Result.Name =columns[3];
                obj_Result.MaxMark  =columns[4];
                obj_Result.ObtainMark   =columns[5];
                obj_Result.Percentage =columns[6];
                obj_Result.Rank = columns[7];
                obj_Result.AddRegularSheet();
                 
                //conn.Open();
                //string sql = "INSERT INTO TBL_I_RegularSheet (RegularTestSheetId , RegularTestId , RegNo , Name, MaxMark , ObtainMark  , Percentage, Rank)";
                //sql += "VALUES('" + columns[0] + "','" + Session["checkRecordStatus"] + "','" + 
                //    columns[2] + "','" +
                //    columns[3] + "','" +
                //    columns[4] + "','" +
                //    columns[5] + "','" +
                //    columns[6] + "','" +
                //    columns[7] + "')";
                //SqlCommand cmd = new SqlCommand(sql, conn);
                //cmd.ExecuteNonQuery();
                //conn.Close();
                SendSMS(columns[5]);
            }
        }
        Session["checkRecordStatus"] = null;
    }
    #endregion

    #region"Bind Data Brid"
    private void RegularBindGrid()
    {
        ds = obj_Master.FillRegularSheet();
        GridView2.DataSource = ds;
        GridView2.DataBind();
    
    }
    #endregion"End for Regular test data"



    #region"For Send SMS Use Only Number"
    public string SendSMS(string number)
    {
        string fullResponse = "";
        string SmsText = "Your Result upload form your IDEA ERP ";
        string uid = "ideaedukkr";
        string pwd = "ideakkr@123";
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
            lblError.Visible = true;
            //logger.Error(ex.Message.ToString());
            fullResponse = "";
        }
        return fullResponse;
    }
    #endregion

    // Start Scholer ship test data

     #region"Scholar Ship Test Insert"
    protected void Scholar_Click(object sender, EventArgs e)
    {
        try
        {
            if (FuScholar.HasFile)
            {

                string FileName = FuScholar.FileName;
                string FileNamekey = DateTime.Now.Ticks.ToString().Substring(12) + FileName;
                FuScholar.SaveAs(MapPath("~/Employee/Document/" + "CM-" + FileNamekey));
                string path = string.Concat(Server.MapPath("~/Employee/Document/" + "CM-" + FileNamekey));
                Dt = GetDataTableFromExcel(path);

                obj_Result.ScholerTesttype = ddlResult.SelectedIndex.ToString();
                obj_Result.ScholerTestCode = txtScholarCode.Text.Trim();
                obj_Result.ScholerTestDate = DateTime.ParseExact(txtScholarDate.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture);
                obj_Result.ScholerTestName = txtScholarName.Text.Trim();
                obj_Result.ScholerFilePath = FileName;
                checkRecordStatus = obj_Result.AddScholarTest();
                Session["checkRecordStatus"] = checkRecordStatus;

                if (checkRecordStatus > 0)
                {
                    ScholerCheckData();
                    ScholerInsertData();
                    ScholerBindGrid();

                    lblError.Text = "Record Saved !";
                }
                else if (checkRecordStatus == 0)
                {
                    lblError.Visible = true;
                    lblError.Text = "Test Name Already exists Save !";
                }

                // RegularImporttoDatatable();
           }
        }
        catch (Exception ex)
        {

        }
    }
    #endregion

     #region"Scholer Insert Data"
    private void ScholerInsertData()
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

                Decimal perceate = Convert.ToInt32(columns[8]) * 100;
                decimal per = perceate / Convert.ToInt32(columns[7]);

                obj_Result.ScholerTestSheetId =Convert.ToInt32(columns[0]);
                obj_Result.ScholerTestResultId = Convert.ToInt32(Session["checkRecordStatus"]);
                obj_Result.RollNumber = columns[2];
                obj_Result.Name = columns[3];
                obj_Result.School = columns[4];
                obj_Result.FatherName = columns[5];
                obj_Result.MobileNo = columns[6];
                obj_Result.MaxMark = columns[7];
                obj_Result.ObtainMark = columns[8];
                obj_Result.PercentageMark = per;
                obj_Result.Rank =columns[10];
                obj_Result.ScholoarShip = columns[11];
                obj_Result.AddScholerTestSheet();
              
              
            }
        }
        Session["checkRecordStatus"] = null;
    }
    #endregion

     #region"Scholer Check data"
    private void ScholerCheckData()
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
    #endregion

    #region"Scholer Data Brid"
    private void ScholerBindGrid()
    {
        ds = obj_Master.FillScholerTestSheet();
        GvScholerShip.DataSource = ds;
        GvScholerShip.DataBind();
     
    }
    #endregion

    // Start Scholer ship test data
}