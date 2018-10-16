using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using BusinessLogic.Admin;

using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
using System.IO;

public partial class Employee_ShowScholerShipSheet : System.Web.UI.Page
{

    #region "Variable Decleration"
    private Results ObjResult = new Results();
    private DataSet DS;
    private int RecordStatus;
    private static int ScholerTestResultId;
    #endregion


    protected void Page_Load(object sender, EventArgs e)
    {
        ScholerTestResultId = int.Parse(Request.QueryString["Sid"]);
        if (!IsPostBack)
        {
            DisplayScholerSheet();
        }
    }

    #region " Fill contorole on Form"
    private void DisplayScholerSheet()
    {
        ObjResult.ScholerTestResultId = ScholerTestResultId;
        DS = ObjResult.DisplayScholerSheet();
        GvScholerShip.DataSource = DS;
        GvScholerShip.DataBind();
    }
    #endregion


    protected void ExportToPDF(object sender, EventArgs e)
    {
        using (StringWriter sw = new StringWriter())
        {
            using (HtmlTextWriter hw = new HtmlTextWriter(sw))
            {
                //To Export all pages
                GvScholerShip.AllowPaging = false;
                ObjResult.ScholerTestResultId = ScholerTestResultId;
                DS = ObjResult.DisplayRegularSheet();
                GvScholerShip.DataSource = DS;
                GvScholerShip.DataBind();

                //gvDetail1.BindGrid();

                // gvDetail1.RenderControl(hw);
                StringReader sr = new StringReader(sw.ToString());
                Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                HTMLWorker htmlparser = new HTMLWorker(pdfDoc);
                PdfWriter.GetInstance(pdfDoc, Response.OutputStream);
                pdfDoc.Open();
                htmlparser.Parse(sr);
                pdfDoc.Close();

                Response.ContentType = "application/pdf";
                Response.AddHeader("content-disposition", "attachment;filename=GridViewExport.pdf");
                Response.Cache.SetCacheability(HttpCacheability.NoCache);
                Response.Write(pdfDoc);
                Response.End();
            }
        }
    }
}