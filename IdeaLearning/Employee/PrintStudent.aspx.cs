using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Configuration;
using System.Data.SqlClient;
using System.IO;

using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html.simpleparser;

public partial class Employee_PrintStudent : System.Web.UI.Page
{
    private SqlConnection con;
    private SqlCommand com;
    private string constr, query;
    private void connection()
    {
        constr = ConfigurationManager.ConnectionStrings["getconn"].ToString();
        con = new SqlConnection(constr);
        con.Open();

    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Bindgrid();
        }
    }

    public override void VerifyRenderingInServerForm(Control control)
    {
        //required to avoid the runtime error "
        //Control 'GridView1' of type 'GridView' must be placed inside a form tag with runat=server."
    }

    private void Bindgrid()
    {
        connection();
        query = "select StudentName,Mobile,FatherName,Email,DateOfBirth,UserName,Password from TBL_I_Student";
        //not recommended this i have wrtten just for example,write stored procedure for security
        com = new SqlCommand(query, con);
        SqlDataReader dr = com.ExecuteReader();
        GridView1.DataSource = dr;
        GridView1.DataBind();
        con.Close();

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        ExportGridToword();
    }
    private void ExportGridToword()
    {

        Response.ContentType = "application/pdf";
        Response.AddHeader("content-disposition", "attachment;filename=Idea.pdf");
        Response.Cache.SetCacheability(HttpCacheability.NoCache);
        StringWriter sw = new StringWriter();
        HtmlTextWriter hw = new HtmlTextWriter(sw);
        GridView1.RenderControl(hw);
        StringReader sr = new StringReader(sw.ToString());
        Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
        HTMLWorker htmlparser = new HTMLWorker(pdfDoc);
        PdfWriter.GetInstance(pdfDoc, Response.OutputStream);
        pdfDoc.Open();
        htmlparser.Parse(sr);
        pdfDoc.Close();
        Response.Write(pdfDoc);
        Response.End();
        GridView1.AllowPaging = true;
        GridView1.DataBind();
    }
}