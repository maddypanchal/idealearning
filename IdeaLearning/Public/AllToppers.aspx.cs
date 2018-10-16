using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using BusinessLogic.Admin;

public partial class Public_AllToppers : System.Web.UI.Page
{
    #region "VARIABLE DECLARATION"
    private clsToppers obj_clsImages = new clsToppers();
    private DataSet DS;
    private DataTable DT;
    private int CatID;
    private String CatIDOne;
    private int Course;
    private SqlDataReader DR;
    private string abc;
    #endregion "End VARIABLE DECLARATION"

    protected void Page_Load(object sender, EventArgs e)
    {

        if (string.IsNullOrEmpty(Request.QueryString["Cid"]) )
        {
            Response.Redirect("Default.aspx", false);
        }
        else
        {

            abc = Request.QueryString["Cid"].ToString();
            if (abc == "2005-2011")
            {
                CatIDOne = abc;
                if (!IsPostBack)
                {
                    //  FillLabel();
                    ShowcaseByCatIDProduct(abc);
                    //   ShowcaseHeros();
                    BindRepeaterCollections();
                }
            }
            else
            {
                CatID = Convert.ToInt32(abc);
                if (!IsPostBack)
                {
                    //  FillLabel();
                    ShowcaseByCatIDProduct();
                    //  ShowcaseHeros();
                    BindRepeaterCollections();
                }

            }
          
        }
        
    }

    #region " Display Menu Collection in Repeater Method"
    protected void BindRepeaterCollections()
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
    //#region "Display Products Method"
    //protected void ShowcaseHeros()
    //{
    //    try
    //    {

    //        DT = obj_clsImages.DisplayHeros();
    //        dtListCategoryTopers.DataSource = DT;
    //        dtListCategoryTopers.DataBind();
    //        dtListCategoryTopers.Dispose();
    //    }
    //    catch (Exception ex)
    //    {
    //        // lblMsg.Visible = true;
    //        // lblMsg.Text = ex.ToString();
    //    }
    //}
    //#endregion 
    #region "Display Products Method"
    protected void ShowcaseByCatIDProduct()
    {
        try
        {
            obj_clsImages.YearId = CatID;
            DT = obj_clsImages.DisplayProductShowcaseByCatID();

            dtListCategoryTopers.DataSource = DT;
            dtListCategoryTopers.DataBind();
            dtListCategoryTopers.Dispose();
        }
        catch (Exception ex)
        {
            //  lblMsg.Visible = true;
            //  lblMsg.Text = ex.ToString();
        }
    }

    protected void ShowcaseByCatIDProduct(string CidOne)
     {
        try
         {
             obj_clsImages.YearIdOne = CidOne;
            DT = obj_clsImages.DisplayProductShowcaseByCatIDOne();
            dtListCategoryTopers.DataSource = DT;
            dtListCategoryTopers.DataBind();
            dtListCategoryTopers.Dispose();
         }
        catch (Exception ex)
        {
            //  lblMsg.Visible = true;
            //  lblMsg.Text = ex.ToString();
        }
     }
    #endregion "End Display Products Method"

    #region "Fill Category Name in Label"
    private void FillLabel()
    {
        try
        {
     //      obj_clsProductManagment.CAT_ID = Convert.ToInt32(CatID);
     //   DR = obj_clsProductManagment.DisplayCatNameOnLabel();
     //     DR.Read();
     //      lblCatgoryName.Text = DR["CategoryName"].ToString();

        }
        catch (Exception ex)
        {
      //      lblMsg.Visible = true;
       //     lblMsg.Text = ex.ToString();
        }
    }
    #endregion "End Fill Product Records Details"
}