using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DataAccess;
using BusinessLogic.Admin;

namespace BusinessLogic.Admin
{
    public class clsSlider
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
        public int SliderImageId { get; set; }
        public string ImagesName { get; set; }
        public string ImagesTitle { get; set; }
        public string ImagesDescription { get; set; }
        public string name { get; set; }
        public bool IsActive { get; set; }

        #endregion "End Properties"

        //Constructing Object of cDataAccess Class File (DataAccess) 

        #region "Constructor"
        public clsSlider()
        {
            obj_cDataAccess = new cDataAccess();
        }
        #endregion "End Constructor"

        // Add New Prodcuct using USP_SAVE_PRODUCT StoreProcedure

        #region "Add New Product Detail"
        public int AddProduct()
        {

            int ProductID = 0;

            DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_AddSlider"
                , new SqlParameter("@ImagesName", ImagesName)
                , new SqlParameter("@ImagesTitle", ImagesTitle)
                , new SqlParameter("@ImagesDescription", ImagesDescription)

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

        #region "DELETE GALLERY IMAGES"
        public int DeleteImages()
        {
            try
            {
                DR = obj_cDataAccess.RunSPReturnDR("USP_I_DeleteMasterDetails"
                     , new SqlParameter("@SliderImageId", SliderImageId)
                     , new SqlParameter("@CALL_TYPE", "SLIDER")
            );

            }
            catch (Exception ex)
            {
            }
            return RecordStatus;
        }
        #endregion


        #region"New Repeter Slider"
        public DataSet RepeterSlider()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_REPETER"
                   , new SqlParameter("CallType", "SLIDER")
                );
            }
            catch (Exception ex)
            {

            }
            return DS;
        }
        #endregion

        #region"New Repeter"
        public DataSet RepterHeading()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_REPETER"
                   , new SqlParameter("CallType", "Heading")
                );
            }
            catch (Exception ex)
            {

            }
            return DS;
        }
        #endregion

        #region "Display Product Detail"
        public DataTable DisplayProductShowcase()
        {
            try
            {
                DT = obj_cDataAccess.RunSPReturnDataTable("USP_DISPLAY_IMAGES_SHOWCASE");

            }
            catch (Exception ex)
            {

            }
            return DT;
        }
        #endregion "End Display Product Detail"

        #region "Fill User grid View BY CallType...."
        public DataSet DisplayGalleryData()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                    , new SqlParameter("@CALL_TYPE", "SLIDER")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        #endregion "End Fill User Grid view ..."

          



        
    }
}
