using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DataAccess;

namespace BusinessLogic.Admin
{
   public class clsAdmin
   {
       #region"Varible Declaration"
        cDataAccess obj_cDataAccess;
        private DataSet DS;
        private DataTable DT;
        private SqlDataReader DR;
        private int RecordStatus;
        #endregion

        #region"Contructor"
        public clsAdmin()
        {
            obj_cDataAccess = new cDataAccess();
        }
        #endregion
       
        #region"Properties"
        public string SR_NO_ID { get; set; }
        public string RollNo { get; set; }
        public string IctRank { get; set; }
        public string StudentName { get; set; }
        public string RegistrationNo { get; set; }
        public string Year { get; set; }
        #endregion

        #region "Login Method"
        public DataSet SearchResult()
        {
            DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_Result",
                   new SqlParameter("@RollNo", RollNo)
                   , new SqlParameter("@Year", Year)
                  
                     , new SqlParameter("@CallType", "ItseResult")

            );

            return DS;

        }
        #endregion

        #region "Fill Employee grid View BY DisplayPStudent CallType...."
        public DataSet DisplayStudent()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_Result"
                      , new SqlParameter("@RegistrationNo", RegistrationNo)
                  
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
