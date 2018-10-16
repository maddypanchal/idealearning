using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DataAccess;

namespace BusinessLogic.Admin
{
    public class clsHeader
    {
        #region "Variables Declaration"
        cDataAccess obj_cDataAccess;
        private DataSet DS;
        private SqlDataReader DR;
        private int RecordStatus;
        #endregion
        #region Constructor
        public clsHeader()
        {
            obj_cDataAccess = new cDataAccess();
        }
        #endregion
        #region "Properties"
        public int FooterId { get; set; }
        public string CallType { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public bool IsActive { get; set; }
        
        #endregion
        
        #region "Insert Description"
        public int InsertNews()
        {
            try
            {
                DR = obj_cDataAccess.RunSPReturnDR("USP_I_AddEvents"
                 , new SqlParameter("@Name",Name)
                 , new SqlParameter("@Message", Message)
                 , new SqlParameter("@Email", Email)
                 , new SqlParameter("@IsActive", IsActive)
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
        #region "DELETE GALLERY IMAGES"
        public int DeleteNews()
        {
            try
            {
                DR = obj_cDataAccess.RunSPReturnDR("USP_DeleteMasterDetails"
                    // , new SqlParameter("@NewTitleId", NewsTitleId)
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
        #region "Fill User grid View BY CallType...."
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
        #endregion "End Fill User Grid view ..."


        #region "Insert Description"
        public int InsertFooterContact()
        {
            try
            {
                DR = obj_cDataAccess.RunSPReturnDR("USP_I_FooterForm"
                 , new SqlParameter("@Name", Name)
                 , new SqlParameter("@Email", Email)
                 , new SqlParameter("@Message", Message)
                 , new SqlParameter("@IsActive", IsActive)
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
 

    }
}
