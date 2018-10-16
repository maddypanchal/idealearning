using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DataAccess;

namespace BusinessLogic.Admin
{
   public class clsLoginExam
    {
        #region "Variables Declaration"
        cDataAccess obj_cDataAccess;
        private DataSet DS;
        private SqlDataReader DR;
        private int RecordStatus;
        #endregion
       
        #region Constructor
        public clsLoginExam()
        {
            obj_cDataAccess = new cDataAccess();            
        }
        #endregion
 
        #region "Properties"
        public string UserName { get; set; }
        public string Password { get; set; }

        #endregion

        #region "Login Method"
        public DataSet VarifyLoginAccount()
        {
            DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_LOGIN_EXAM",
                   new SqlParameter("@UserName", UserName)
                 , new SqlParameter("@Password", Password)

             );

            return DS;

        }
        #endregion
    }
}
