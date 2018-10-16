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
   public class clsEvents
    {
        #region "Variables Declaration"
        cDataAccess obj_cDataAccess;
        private DataSet DS;
        private SqlDataReader DR;
        private int RecordStatus;
        #endregion
        #region Constructor
        public clsEvents()
        {
            obj_cDataAccess = new cDataAccess();
        }
        #endregion
        #region "Properties"
        public int EventsId { get; set; }
        public string CallType { get; set; }
        public string EventName { get; set; }
        public string Description { get; set; }
        public string EventDate { get; set; }
        public bool EventStatus { get; set; }
        #endregion
        #region"New Repeter"
        public DataSet RepeterEvents()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_REPETER"
                   , new SqlParameter("CallType", "HOMEEVENTS")
                );
            }
            catch (Exception ex)
            {

            }
            return DS;
        }
        #endregion
        #region "Insert Description"
        public int InsertEvents()
        {
            try
            {
                DR = obj_cDataAccess.RunSPReturnDR("USP_I_AddEvents"
                  , new SqlParameter("@EventName", EventName)
                  , new SqlParameter("@Description", Description)
                  , new SqlParameter("@EventDate", EventDate)
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
        public int DeleteEvents()
        {
            try
            {
                DR = obj_cDataAccess.RunSPReturnDR("USP_I_DeleteMasterDetails"
                     , new SqlParameter("@EventsId", EventsId)
                      , new SqlParameter("@CALL_TYPE", "EVENTS")
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
        public DataSet DisplayEvent()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                    , new SqlParameter("@CALL_TYPE", "EVENTS")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        #endregion "End Fill User Grid view ..."
        //#region"delete data"
        //public int DeleteItem()
        //{
        //    try
        //    {
        //        DR = obj_cDataAccess.RunSPReturnDR("USP_DeleteNews"
        //            , new SqlParameter("TitleId", TitleId)
        //       );
        //        while (DR.Read())
        //        {
        //            RecordStatus = Convert.ToInt32(DR[0]);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //    }
        //    return RecordStatus;
        //}
        //#endregion
    }
}
