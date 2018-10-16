using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using BusinessLogic.Admin;
using DataAccess;


namespace BusinessLogic.Admin
{
    public  class clsNews
    {
        #region "Variables Declaration"
        cDataAccess obj_cDataAccess;
        private DataSet DS;
        private SqlDataReader DR;
        private int RecordStatus;
        #endregion

        #region Constructor
        public clsNews()
        {
            obj_cDataAccess = new cDataAccess();
        }
        #endregion

        #region "Properties"
        public int NewsTitleId { get; set; }
        public string CallType { get; set; }
        public string TitleName { get; set; }
        public string Description { get; set; }
        public string TitleDate { get; set; }
        public bool TitleStatus { get; set; }
        public int TitleType { get; set; }
        public int HeadingId { get; set; }
        public string name { get; set; }
        #endregion

        #region"New Repeter"
        public DataSet RepeterNews()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_REPETER"
                   , new SqlParameter("CallType", "HOMENEWS")
                );
            }
            catch (Exception ex)
            {

            }
            return DS;
        }
        #endregion
      
        #region"New Repeter"
        public DataSet FillNews()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_REPETER"
                    , new SqlParameter("@NewsTitleId", NewsTitleId)
                   , new SqlParameter("CallType", "EditHomeNews")
                );
            }
            catch (Exception ex)
            {

            }
            return DS;
        }
        #endregion
      
        #region "Insert Description"
        public int InsertNews()
        {
            try
            {
                DR = obj_cDataAccess.RunSPReturnDR("USP_I_AddEvents"
                 , new SqlParameter("@TitleName", TitleName)
                 , new SqlParameter("@Description", Description)
                 , new SqlParameter("@TitleDate", TitleDate)
               );
               while (DR.Read())
                {
                    RecordStatus = Convert.ToInt32(DR[0]);
                }
            }
            catch (Exception)
            {

            }
            return RecordStatus;
        }
        #endregion

        #region "Insert Home News"
        public int InsertHomeNews()
        {
            try
            {
                DR = obj_cDataAccess.RunSPReturnDR("USP_I_AddNews"
                 , new SqlParameter("@TitleName", TitleName)
                 , new SqlParameter("@Description", Description)
                 , new SqlParameter("@TitleDate", TitleDate)
               );
                while (DR.Read())
                {
                    RecordStatus = Convert.ToInt32(DR[0]);
                }
            }
            catch (Exception)
            {

            }
            return RecordStatus;
        }
        #endregion
      
        #region "UPDATE student"
        public DataSet UpdateHomeNews()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("IdeaMasterUpdate"
                  , new SqlParameter("@NewsTitleId", NewsTitleId)
                 , new SqlParameter("@TitleName", TitleName)
                 , new SqlParameter("@Description", Description)
                 , new SqlParameter("@TitleDate", TitleDate)
                 , new SqlParameter("@CallType", "UpdateNews")
                 );

            }
            catch (Exception ex)
            {
            }
            return DS;
        }
        #endregion

        #region "Add New Product Detail"
        public int AddHeading()
        {

            int ProductID = 0;

            DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_Add_Heading"
                , new SqlParameter("@name", name)
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

        #region "DELETE heading"
        public int DeleteHeading()
        {
            try
            {
                DR = obj_cDataAccess.RunSPReturnDR("USP_I_DeleteMasterDetails"
                     , new SqlParameter("@HeadingId", HeadingId)
                     , new SqlParameter("@CALL_TYPE", "Heading")
                   );

            }
            catch (Exception ex)
            {
            }
            return RecordStatus;
        }
        #endregion

        #region "UPDATE Heading"
        public DataSet UpdateHeading()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("IdeaMasterUpdate"
                     , new SqlParameter("@HeadingId", HeadingId)
                     , new SqlParameter("@name", name)
                     , new SqlParameter("@CallType", "UpdateHeading")

                 );

            }
            catch (Exception ex)
            {
            }
            return DS;
        }
        #endregion
   
        #region "DELETE News"
        public int DeleteNews()
        {
            try
            {
                DR = obj_cDataAccess.RunSPReturnDR("USP_I_DeleteMasterDetails"
                     , new SqlParameter("@NewsTitleId", NewsTitleId)
                      , new SqlParameter("@CALL_TYPE", "NEWS")

                   );
            }
            catch (Exception ex)
            {
            }
            return RecordStatus;
        }
        #endregion
   
        #region "Fill Student Preview "
        public DataSet FillTitleExamAlters()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_FillNewTitle"
                 , new SqlParameter("CallType", "ExamAlters")
                    );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        public DataSet FillTitleJobsAlters()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_FillNewTitle"
                      , new SqlParameter("CallType", "JobsAlters")
                    );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        public DataSet FillTitleAdmissionAlters()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_FillNewTitle"
                      , new SqlParameter("CallType", "AdmissionAlters")
                    );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        public DataSet FillTitleTrainingAlters()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_FillNewTitle"
                     , new SqlParameter("CallType", "TrainingAlters")
                    );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        #endregion

        #region "Display News"
        public DataSet DisplayNews()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("[USP_I_FillMasterDetails]"
                    , new SqlParameter("@CALL_TYPE", "NEWS")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        #endregion 

        #region "Fill Display Heading"
        public DataSet DisplayHeading()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("[USP_I_FillMasterDetails]"
                    , new SqlParameter("@CALL_TYPE", "Heading")
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
