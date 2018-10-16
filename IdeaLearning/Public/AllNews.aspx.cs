using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using BusinessLogic.Admin;

public partial class Public_AllNews : System.Web.UI.Page
{
    #region "VARIABLE DECLARATION"
    private clsNews obj_News = new clsNews();

    private DataSet DS;
    private int RecordStatus;
    private SqlDataReader DR;
    private int checkRecordStatus;
    #endregion
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            RepeteDataNews();
        }
    }

    private void RepeteDataNews()
    {
        DS = obj_News.RepeterNews();
        Repeater.DataSource = DS;
        Repeater.DataBind();
    }
}