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

public partial class Public_IIT_JEE_MAINS_ADV_AIIMS_PMT : System.Web.UI.Page
{
    #region "VARIABLE DECLARATION"
    private clsMaster obj_Master = new clsMaster();
    private DataSet DS;
    private int checkRecordStatus;
    private string myFileExtension;
    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            FillTeaching();
        }
    }

    #region "Fill User Grid View"
    public void FillTeaching()
    {
        DS = obj_Master.IITJEE();
        DTTeachingStaff.DataSource = DS;
        DTTeachingStaff.DataBind();
    }
    #endregion "End Fill User GridView"
}