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

public partial class Public_JEEMainsTopper : System.Web.UI.Page
{
    #region "VARIABLE DECLARATION"
    private clsToppers obj_clsImages = new clsToppers();
    private DataSet DS;
    private DataTable DT;
    #endregion "End VARIABLE DECLARATION"
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ShowcaseHeros();
            ShowcaseToppers();
            BindRepeaterYear();
        }
    }


    #region " Display Menu Collection in Repeater Method"
    protected void BindRepeaterYear()
    {
        try
        {

            DT = obj_clsImages.FillToppersYear1();
            CategoryNameRP.DataSource = DT;
            CategoryNameRP.DataBind();
            CategoryNameRP.Dispose();
        }
        catch (Exception ex)
        {
            //  lblError.Visible = true;
            //   lblError.Text = ex.ToString();
        }
    }
    #endregion "End Display Menu Collection in Repeater Method"
    #region "Display Products Method"
    protected void ShowcaseHeros()
    {
        try
        {

            DT = obj_clsImages.DisplayHerosJEEMAINS();
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

    #region "Display Products Method"
    protected void ShowcaseToppers()
    {
        try
        {

            DT = obj_clsImages.DisplayToppersJEEMAINS();
            DataList1.DataSource = DT;
            DataList1.DataBind();
            DataList1.Dispose();
        }
        catch (Exception ex)
        {
            // lblMsg.Visible = true;
            // lblMsg.Text = ex.ToString();
        }
    }
    #endregion "End Display Products Method"
}