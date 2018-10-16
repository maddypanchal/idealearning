using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using BusinessLogic.Admin;
using DataAccess;



public partial class Public_Gallery : System.Web.UI.Page
{
    #region "VARIABLE DECLARATION"

    private clsMaster obj_Gallery = new clsMaster();
    private DataSet DS;
    private DataTable DT;
    private int RecordStatus;
    private SqlDataReader DR;
    public string alertmsg = "Thank you for your interest! Enquiry Mail Successfully send. We will contact you soon...";
    public string alertfail = "Error:// Opps! Sorry Enquiry Mail Sending Fail";
    private int checkRecordStatus;


    #endregion
    protected void Page_Load(object sender, EventArgs e)
    {
        Gallery();
    }
    #region "Showcase Gallery"
    protected void Gallery()
    {
        try
        {

            DS = obj_Gallery.DisplayGallery();
            dtListCategoryTopers.DataSource = DS;
            dtListCategoryTopers.DataBind();
            dtListCategoryTopers.Dispose();
        }
        catch (Exception ex)
        {
            // lblMsg.Visible = true;
            // lblMsg.Text = ex.ToString();
        }
    }
    #endregion 
}