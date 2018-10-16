using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DataAccess;


namespace BusinessLogic.Admin
{
   public class clsToppers
    {
        #region "Variables Declaration"
        cDataAccess obj_cDataAccess;
        private DataSet DS;
        private DataTable DT;
        private SqlDataReader DR;
        private int RecordStatus;
        #endregion "End Variables Declaration"

        // Passing Variable and Set Properties
        #region "Properties"
        public int MAIN_CATEGORY { get; set; }
        public int YearId { get; set; }
        public int ToppersId { get; set; }
        public string CALL_TYPE { get; set; }
        public string Name { get; set; } 
        public string ImagesName { get; set; }
        public string Rank { get; set; }
        public string RollNumber { get; set; }
        public string Courses { get; set; }
        public string Toppers { get; set; }
        public bool IsActive { get; set; }
        public string YearName { get; set; }
        public string CourseName { get; set; }
        public int HeroId { get; set; }
        public int HomeHerosId { get; set; }
        public string YearIdOne { get; set; }
       
        #endregion "End Properties"
        
        #region "Constructor"
        public clsToppers()
        {
            obj_cDataAccess = new cDataAccess();
        }
        #endregion "End Constructor"

        #region "Add heros"
        public int AddHeros()
        {

            int ProductID = 0;

            DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_AddHeros"
                , new SqlParameter("@ImagesName", ImagesName)
                , new SqlParameter("@Name", Name)
                , new SqlParameter("@Rank", Rank)
                , new SqlParameter("@Courses", Courses)
                , new SqlParameter("@Toppers", Toppers)
                , new SqlParameter("@RollNumber", RollNumber)
                , new SqlParameter("@IsActive", IsActive)
           );
            if (DS.Tables[0].Rows.Count > 0)
            {
                return ProductID = Convert.ToInt32(DS.Tables[0].Rows[0][0].ToString());
            }
            else
            {
                return ProductID;
            }
        }
        #endregion "End Add New Product Detail"
       
        #region "Fill Toppers Courses"
        public DataSet FillToppersCourses()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("[USP_I_FillMasterDetails]"
                    , new SqlParameter("@CALL_TYPE", "ToppersCourses")
                    );
                return DS;

            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        #endregion "End Main Category"

        #region "Display topper Detail By Cat-ID"
        public DataTable DisplayProductShowcaseByCatID()
        {
            try
            {
                DT = obj_cDataAccess.RunSPReturnDataTable("[USP_I_FillMasterDetails]"
                     , new SqlParameter("@CAT_ID", YearId)
                     , new SqlParameter("@CALL_TYPE", "Toppersy")
                    );

            }
            catch (Exception ex)
            {

            }
            return DT;
        }

        public DataTable DisplayProductShowcaseByCatIDOne()
        {
            try
            {
                DT = obj_cDataAccess.RunSPReturnDataTable("[USP_I_FillMasterDetails]"
                     , new SqlParameter("@CAT_IDOne", YearIdOne)
                     , new SqlParameter("@CALL_TYPE", "ToppersyOne")
                    );

            }
            catch (Exception ex)
            {

            }
            return DT;
        }


        #endregion "End Display Product Detail By Cat-ID"
        #region "Display topper Year"
        public DataTable FillToppersYear1()
        {
            try
            {
                DT = obj_cDataAccess.RunSPReturnDataTable("USP_I_FillMasterDetails"
                    ,new SqlParameter("CALL_TYPE","TopperYears")
                    );
            }
            catch (Exception ex)
            {
            }
            return DT;
        }

        #endregion "End Display Product Detail"
        #region "Fill Toppers Years"
        public DataSet FillToppersYear()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                    ,new SqlParameter("@CALL_TYPE","TopperYears")
                    );
                return DS;

            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        #endregion "End Main Category"
        #region "Add Toppers"
        public int AddToppers()
        {
            int ProductID = 0;
            try
            {
               

                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_AddToppers"
                    , new SqlParameter("@ImagesName", ImagesName)
                    , new SqlParameter("@Name", Name)
                    , new SqlParameter("@Rank", Rank)
                    , new SqlParameter("@Courses", Courses)
                    , new SqlParameter("@Toppers", Toppers)
                    , new SqlParameter("@RollNumber", RollNumber)
                    //, new SqlParameter("@IsActive", IsActive)
               );
                if (DS.Tables[0].Rows.Count > 0)
                {
                    return ProductID = Convert.ToInt32(DS.Tables[0].Rows[0][0].ToString());
                }
                else
                {
                    return ProductID;
                }
            }
            catch (Exception ex)
            {

                return ProductID;
            }
           
        }
        #endregion "End Add New Product Detail"
        #region "Add New Courses Detail"
        public int AddCourses()
        {

            int ProductID = 0;

            DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_AddCourses"
                , new SqlParameter("@CourseName", CourseName)
                , new SqlParameter("@ImagesName", ImagesName)
                 , new SqlParameter("@IsActive", IsActive)
           );
            if (DS.Tables[0].Rows.Count > 0)
            {
                return ProductID = Convert.ToInt32(DS.Tables[0].Rows[0][0].ToString());
            }
            else
            {
                return ProductID;
            }
        }
        #endregion "End Add New Product Detail"
        #region "Add home heros Detail"
        public int AddHomeHeros()
        {

            int ProductID = 0;

            DS = obj_cDataAccess.RunSPReturnDataSet("[USP_I_AddHomeHeros]"
                , new SqlParameter("@Name", Name)
                ,new SqlParameter("@Rank",Rank)
                , new SqlParameter("@ImagesName", ImagesName)
                 , new SqlParameter("@IsActive", IsActive)
           );
            if (DS.Tables[0].Rows.Count > 0)
            {
                return ProductID = Convert.ToInt32(DS.Tables[0].Rows[0][0].ToString());
            }
            else
            {
                return ProductID;
            }
        }
        #endregion "End Add New Product Detail"
        #region "Add New Years Detail"
        public int AddYear()
        {

            int ProductID = 0;

            DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_AddYears"
                , new SqlParameter("@YearName", YearName)
                , new SqlParameter("@IsActive", IsActive)
           );
            if (DS.Tables[0].Rows.Count > 0)
            {
                return ProductID = Convert.ToInt32(DS.Tables[0].Rows[0][0].ToString());
            }
            else
            {
                return ProductID;
            }
        }
        #endregion "End Add New Product Detail"
        #region "DELETE Toppers IMAGES"
        public int DeleteToppers()
        {
            try
            {
                DR = obj_cDataAccess.RunSPReturnDR("USP_DeleteMasterDetails"
                     , new SqlParameter("@ToppersId", ToppersId)
                      , new SqlParameter("@CALL_TYPE", "TOPPERS")
                );
            }
            catch (Exception ex)
            {
            }
            return RecordStatus;
        }
        #endregion
        #region"New Repeter Toppers"
        public DataSet RepeterSlider()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_REPETER"
                   , new SqlParameter("CallType", "TOPPERS")
                );
            }
            catch (Exception ex)
            {

            }
            return DS;
        }
        #endregion
        #region "Display Display Courses"
        public DataTable DisplayCourses()
        {
            try
            {
                DT = obj_cDataAccess.RunSPReturnDataTable("USP_I_DisplayHeroImages"
                     , new SqlParameter("@CALL_TYPE", "Courses")
             );
            }
            catch (Exception ex)
            {

            }
            return DT;
        }
        #endregion "End Display Product Detail"
        #region "Display Home heros"
        public DataTable DisplayHomeHeros()
        {
            try
            {
                DT = obj_cDataAccess.RunSPReturnDataTable("USP_I_DisplayHeroImages"
                     , new SqlParameter("@CALL_TYPE", "toppperhome")
             );
            }
            catch (Exception ex)
            {

            }
            return DT;
        }
        #endregion 

        #region "Fill Home heros"
        public DataTable FillHomeHeros()
        {
            try
            {
                DT = obj_cDataAccess.RunSPReturnDataTable("USP_I_DisplayHeroImages"
                     , new SqlParameter("@CALL_TYPE", "HomeHeros")
             );
            }
            catch (Exception ex)
            {

            }
            return DT;
        }
        #endregion 

      
        #region "Display jee addvance Heros"
        public DataTable DisplayHerosJeeAdd()
        {
            try
            {
                DT = obj_cDataAccess.RunSPReturnDataTable("USP_I_DisplayHeroImages"
                     , new SqlParameter("@CALL_TYPE", "Show_JEE_Advanced")
             );
            }
            catch (Exception ex)
            {

            }
            return DT;
        }
        #endregion
        #region "Display heros"
        public DataTable DisplayHeros()
        {
            try
            {
                DT = obj_cDataAccess.RunSPReturnDataTable("USP_I_DisplayHeroImages"
                     , new SqlParameter("@CALL_TYPE", "TOPPERS")
             );
            }
            catch (Exception ex)
            {

            }
            return DT;
        }
        #endregion
        #region "Display heros of jee mains"
        public DataTable DisplayHerosJEEMAINS()
        {
            try
            {
                DT = obj_cDataAccess.RunSPReturnDataTable("USP_I_DisplayHeroImages"
                      , new SqlParameter("@CALL_TYPE", "Show_JEE_Mains")
                    );
            }
            catch (Exception ex)
            {

            }
            return DT;
        }
        #endregion "End Display Product Detail"
        #region "Display heros of Aiimst"
        public DataTable DisplayHerosAIIMST()
        {
            try
            {
                DT = obj_cDataAccess.RunSPReturnDataTable("USP_I_DisplayHeroImages"
                    , new SqlParameter("@CALL_TYPE", "Show_AIIMS_AIPMT")
                    );

            }
            catch (Exception ex)
            {

            }
            return DT;
        }
        #endregion "End Display Product Detail"

        #region "Display heros of other"
        public DataTable DisplayHerosOther()
        {
            try
            {
                DT = obj_cDataAccess.RunSPReturnDataTable("USP_I_DisplayHeroImages"
                    , new SqlParameter("@CALL_TYPE", "Show_OTHER_EXAM")
                    );

            }
            catch (Exception ex)
            {

            }
            return DT;
        }
        #endregion "End Display Product Detail"


        #region "Display topper of jee advance"
        public DataTable DisplayToppersJeeaAd()
        {
            try
            {
                DT = obj_cDataAccess.RunSPReturnDataTable("USP_I_DisplayTopperImages"
                    , new SqlParameter("@CALL_TYPE", "HomeToppers")
                    );

            }
            catch (Exception ex)
            {

            }
            return DT;
        }
        #endregion "End Display Product Detail"

         #region "Display topper of jee advance"
        public DataTable DisplayToppersJeeaAd111()
        {
            try
            {
                DT = obj_cDataAccess.RunSPReturnDataTable("USP_I_DisplayTopperImages"
                    , new SqlParameter("@CALL_TYPE", "HomeToppers")
                    );

            }
            catch (Exception ex)
            {

            }
            return DT;
        }
        #endregion "End Display Product Detail"
              


        #region "Display Display Gallery topper"
        public DataTable DisplayGalleryTopper()
        {
            try
            {
                DT = obj_cDataAccess.RunSPReturnDataTable("USP_I_DisplayTopperImages"
                    , new SqlParameter("@CALL_TYPE", "DisplayGallery")
                    );

            }
            catch (Exception ex)
            {

            }
            return DT;
        }
        #endregion "End Display Product Detail"

        #region "Display toppers of Aiimst"
        public DataTable DisplayToppersAIIMST()
        {
            try
            {
                DT = obj_cDataAccess.RunSPReturnDataTable("USP_I_DisplayTopperImages"
                    ,new SqlParameter ("@CALL_TYPE","AIIMST")
                    );
           }
            catch (Exception ex)
            {

            }
            return DT;
        }
        #endregion "End Display Product Detail"
        #region "Display topper of jee mains"
        public DataTable DisplayToppersJEEMAINS()
        {
            try
            {
                DT = obj_cDataAccess.RunSPReturnDataTable("USP_I_DisplayTopperImages"
                    ,new SqlParameter ("@CALL_TYPE","JEEMAINS")
                    );

            }
            catch (Exception ex)
            {

            }
            return DT;
        }
        #endregion "End Display Product Detail"


        #region "Display Other Toppers"
        public DataTable DisplayOtherToppers()
        {
            try
            {
                DT = obj_cDataAccess.RunSPReturnDataTable("USP_I_DisplayTopperImages"
                    , new SqlParameter("@CALL_TYPE", "OTHER_EXAM")
                    );

            }
            catch (Exception ex)
            {

            }
            return DT;
        }
        #endregion "End Display Product Detail"

        #region "display Gallery data"
        public DataSet DisplayGalleryData()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                    , new SqlParameter("@CALL_TYPE", "TOPPERS")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        #endregion "End Fill User Grid view ..."

        #region "DELETE Years"
        public int DeleteYear()
        {
            try
            {
                DR = obj_cDataAccess.RunSPReturnDR("USP_I_DeleteMasterDetails"
                      , new SqlParameter("@YearId", YearId)
                      , new SqlParameter("@CALL_TYPE", "TopperYear")
                   );
            }
            catch (Exception ex)
            {
            }
            return RecordStatus;
        }
        #endregion

        #region "DELETE Heros Images"
        public int DeleteHerosImage()
        {
            try
            {
                DR = obj_cDataAccess.RunSPReturnDR("USP_I_DeleteMasterDetails"
                     , new SqlParameter("@HeroId", HeroId)
                     , new SqlParameter("@CALL_TYPE", "HeroDelete")
            );

            }
            catch (Exception ex)
            {
            }
            return RecordStatus;
        }
        #endregion

        #region "DELETE Topper Images"
        public int DeleteTopperImage()
        {
            try
            {
                DR = obj_cDataAccess.RunSPReturnDR("USP_I_DeleteMasterDetails"
                     , new SqlParameter("@ToppersId", ToppersId)
                     , new SqlParameter("@CALL_TYPE", "TOPPERS")
            );

            }
            catch (Exception ex)
            {
            }
            return RecordStatus;
        }
        #endregion
       
        #region "Fill User grid View BY CallType...."
        public DataSet DisplayToppersData()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                    , new SqlParameter("@CALL_TYPE", "All_Heros")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        #endregion "End Fill User Grid view ..."
        #region "Fill "
        public DataSet FeatchToppers()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                    , new SqlParameter("@CALL_TYPE", "All_TOPPERS")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        #endregion "End Fill User Grid view ..."
        //// Add New Category using USP_SAVE_CATEGORY StoreProcedure
        //#region "Add Main Category Detail"
        //public int AddCategory()
        //{
        //    int CategoryID = 0;
        //    DS = obj_cDataAccess.RunSPReturnDataSet("USP_SAVE_CATEGORY"
        //        , new SqlParameter("@CATEGORY_NAME", CAT_NAME)
        //        , new SqlParameter("@IS_ACTIVE", CAT_ISACTIVE)
        //      );
        //    if (DS.Tables[0].Rows.Count > 0)
        //    {
        //        return CategoryID = Convert.ToInt32(DS.Tables[0].Rows[0][0].ToString());
        //    }
        //    else
        //    {
        //        return CategoryID;
        //    }
        //}
        //#endregion "End Main Category Detail"
        //#region "Display Category Detail"
        //public DataTable DisplayCategoryCollections()
        //{
        //    try
        //    {
        //        DT = obj_cDataAccess.RunSPReturnDataTable("USP_FILL_CATEGORY");
        //    }
        //    catch (Exception ex)
        //    {
        //    }
        //    return DT;
        //}
        //#endregion "End Display Product Detail"     // Fill Main Category using USP_FILL_CATEGORY StoreProcedure
        //#region "Fill Main Category"
        //public DataSet FillMainCategory()
        //{
        //    try
        //    {
        //        DS = obj_cDataAccess.RunSPReturnDataSet("USP_FILL_CATEGORY");
        //        return DS;
        //    }
        //    catch (Exception ex)
        //    {
        //        return DS;
        //    }
        //}
        //#endregion "End Main Category"        //Display NEW ARRIVAL Product Detail in Repeater using USP_DISPLAY_NEW_ARRIVAL_PRODUCT StoreProcedure
        //#region "Display NEW ARRIVAL Product Detail"
        //public DataTable DisplayNAProduct()
        //{
        //    try
        //    {
        //        DT = obj_cDataAccess.RunSPReturnDataTable("USP_DISPLAY_NEW_ARRIVAL_PRODUCT");
        //    }
        //    catch (Exception ex)
        //    {
        //    }
        //    return DT;
        //}
        //#endregion "End Display NEW ARRIVAL Product Detail"
        //#region "Display Scroll Products"
        //public DataTable DisplayRandomScrollProduct()
        //{
        //    try
        //    {
        //        DT = obj_cDataAccess.RunSPReturnDataTable("USP_DISPLAY_RANDOM_SCROLL_PRODUCT");
        //    }
        //    catch (Exception ex)
        //    {
        //    }
        //    return DT;
        //}
        //#endregion "End Display Scroll Products"
        //#region "Display Product Detail"
        //public DataTable DisplayOurProductShowcase()
        //{
        //    try
        //    {
        //        DT = obj_cDataAccess.RunSPReturnDataTable("USP_DISPLAY_OUR_PRODUCT_SHOWCASE");
        //    }
        //    catch (Exception ex)
        //    {
        //    }
        //    return DT;
        //}
        //#endregion "End Display Product Detail"
        //// Fetching Product Collection in DataList using USP_DISPLAY_PRODUCT_SHOWCASE StoreProcedure
        ////Display Product Details using USP_DISPLAY_PRODUCT_DETAIL StoreProcedure
        //#region "Display Product Record Details"
        //public SqlDataReader DisplayProductDetails()
        //{
        //    DR = obj_cDataAccess.RunSPReturnDR("USP_DISPLAY_PRODUCT_DETAIL"
        //          , new SqlParameter("@PRODUCT_ID", PRODUCT_ID)
        //            );
        //    return DR;
        //}
        //#endregion "End Display Product Record Details"
        //#region "ManageProduct"
        //public DataSet ManagePrdct() // GRIDVIEW MEMBER MANAGE  //
        //{
        //    DS = obj_cDataAccess.RunSPReturnDataSet("USP_MANAGE_PRODUCT"
        //          );
        //    return DS;
        //}
        //#endregion
        //#region "Active / Inactive Account"
        //public int ActiveInactiveAccount() //ACTIVE\DEACTIVE //
        //{
        //    DS = obj_cDataAccess.RunSPReturnDataSet("USP_STATUS_RECORD"
        //          , new SqlParameter("@CALL_TYPE", "PRODUCT")
        //          , new SqlParameter("@RECORD_ID", PRODUCT_ID)
        //            );
        //    RecordStatus = Convert.ToInt32(DS.Tables[0].Rows[0][0]);
        //    return RecordStatus;
        //}
        //#endregion        // Search Stock Detail using USP_STOCK_SEARCH StoreProcedure
        //#region "Search Stock Detail"
        //public DataSet SearchStockEntry()
        //{
        //    try
        //    {
        //        DS = obj_cDataAccess.RunSPReturnDataSet("USP_SEARCH_PRODUCT_LIST"
        //            , new SqlParameter("@PRODUCT_NAME", P_Name_naME)
        //            // , new SqlParameter("@PRODUCT_MODEL", P_Name_Model)
        //            , new SqlParameter("@PRODUCT_CATEGORYid", Catgory)
        //            , new SqlParameter("@STATUS", P_status)
        //       );
        //    }
        //    catch (Exception ex)
        //    {
        //    }
        //    return DS;
        //}
        //#endregion "End Search Stock Detail"
        //#region "Edit Category"
        //public int EditCAtg()
        //{
        //    int CheckValue = 0;
        //    try
        //    {
        //        DR = obj_cDataAccess.RunSPReturnDR("USP_CATGORY_EDIT"
        //            , new SqlParameter("@CAT_Id", CAT_ID)
        //            , new SqlParameter("@CAT_NAME", CAT_NAME)
        //           );
        //        if (DR.HasRows)
        //        {
        //            CheckValue = 1;
        //        }
        //        else
        //        {
        //            CheckValue = 0;
        //        }
        //        return CheckValue;
        //    }
        //    catch (Exception)
        //    {
        //        return CheckValue;
        //    }
        //}

        //#endregion
        //#region "Display Category"

        //public DataSet DisplayCATgory()
        //{
        //    try
        //    {
        //        DS = obj_cDataAccess.RunSPReturnDataSet("USP_DISPLAY_CATEGORY");
        //        return DS;
        //    }
        //    catch (Exception)
        //    {
        //        return DS;
        //    }

        //}
        //#endregion
        //#region "Active / Inactive Category"
        //public int ActiveInactiveCat() //ACTIVE\DEACTIVE //
        //{
        //    DS = obj_cDataAccess.RunSPReturnDataSet("USP_STATUS_RECORD"
        //          , new SqlParameter("@CALL_TYPE", "CaTgOry")
        //          , new SqlParameter("@RECORD_ID", CAT_ID)
        //            );
        //    RecordStatus = Convert.ToInt32(DS.Tables[0].Rows[0][0]);
        //    return RecordStatus;
        //}

        //#endregion
        //#region "View Product In Edit Mode"

        //public SqlDataReader ProductEditModeUpdate() //DISPLAY MEMBERDETAILS IN POP//
        //{
        //    DR = obj_cDataAccess.RunSPReturnDR("USP_DISPLAY_EIDIT_MODE_PRODUCT"
        //         , new SqlParameter("@PrOdUcT_ID", PRODUCT_ID)

        //           );
        //    return DR;
        //}
        //#endregion
        //#region "Update Product Record Detail"
        //public int UpdateProductDetail()
        //{

        //    try
        //    {
        //        DT = obj_cDataAccess.RunSPReturnDataTable("USP_SAVE_PRODUCT",
        //             new SqlParameter("@PRODUCT_ID ", PRODUCT_ID)
        //            , new SqlParameter("@PRODUCT_CODE ", PRODUCT_CODE)
        //           , new SqlParameter("@PRODUCT_TITTLE", PRODUCT_TITTLE)
        //           , new SqlParameter("@PRODUCT_MAIN_CATEGORY_ID", CAT_ID)
        //           , new SqlParameter("@IMAGE", P_IMAGE)
        //           , new SqlParameter("@PRODUCT_DESCRIPTION", PRODUCT_DESC)
        //           , new SqlParameter("@IS_ACTIVE", P_status)
        //           );
        //    }

        //    catch (Exception)
        //    {

        //    }

        //    return RecordStatus;
        //}
        //#endregion "End Update Product Record Detail"
        //#region "DISPLAY CATGORY NAME BY ID"
        //public SqlDataReader DisplayCatNameOnLabel()
        //{
        //    DR = obj_cDataAccess.RunSPReturnDR("USP_DISPLAY_CAT_NAME_BY_ID"
        //          , new SqlParameter("@CAT_ID", CAT_ID)

        //            );
        //    return DR;
        //}
        //#endregion "DISPLAY CATGORY NAME BY ID"
        //#region "Display Product Detail By Cat-ID"
        //public DataTable DisplayProductShowcaseByCatID()
        //{
        //    try
        //    {
        //        DT = obj_cDataAccess.RunSPReturnDataTable("USP_DISPLAY_PROD_SHOWCASE_BY_CAT_ID"
        //             , new SqlParameter("@CAT_ID", CAT_ID)
        //            );

        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //    return DT;
        //}

        //#endregion "End Display Product Detail By Cat-ID"
        //#region "DISPLAY PRODUCT NAME BY P-ID"
        //public SqlDataReader DisplayProNameOnLabel()
        //{
        //    DR = obj_cDataAccess.RunSPReturnDR("USP_DISPLAY_PROD_NAME_BY_P_ID"
        //          , new SqlParameter("@PRODUCT_ID", PRODUCT_ID)

        //            );
        //    return DR;
        //}
        //#endregion "DISPLAY PRODUCT NAME BY P-ID"
    }
}
