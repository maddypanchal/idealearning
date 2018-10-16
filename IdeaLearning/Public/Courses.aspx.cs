using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using BusinessLogic.Admin;

public partial class Public_Courses : System.Web.UI.Page
{
    #region "VARIABLE DECLARATION"
    private clsToppers obj_clsImages = new clsToppers();
    private clsMaster objMaster = new clsMaster();
    private DataSet DS;
    private DataTable DT;
    #endregion "End VARIABLE DECLARATION"
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ShowCourses();
        }
    }


    
    #region "Display Products Method"
    protected void ShowCourses()
    {
        try
        {

            DT = objMaster.DisplayCourseshome();
            dtListCategoryTopers.DataSource = DT;
            dtListCategoryTopers.DataBind();
            dtListCategoryTopers.Dispose();
        }
        catch (Exception ex)
        {
            // lblMsg.Visible = true;
            // lblMsg.Text = ex.ToString();
        }
    }
    #endregion "End Display Products Method"

    
}