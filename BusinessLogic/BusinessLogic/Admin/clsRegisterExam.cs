using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DataAccess;

namespace BusinessLogic.Admin
{
    public class clsRegisterExam
    {
        #region "Variables Declaration"
        cDataAccess obj_cDataAccess;
        private DataSet DS;
        private SqlDataReader DR;
        private int RecordStatus;
        #endregion

        #region Constructor
        public clsRegisterExam()
        {
            obj_cDataAccess = new cDataAccess();
        }
        #endregion

        #region "Properties"
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        #endregion
        #region "Insert Description"
        public int InsertNews()
        {
            try
            {
                DR = obj_cDataAccess.RunSPReturnDR("USP_I_REGISTER_EXAM"
                 , new SqlParameter("@FirstName", FirstName)
                 , new SqlParameter("@LastName", LastName)
                 , new SqlParameter("@UserName", UserName)
                 , new SqlParameter("@Mobile", Mobile)
                  , new SqlParameter("@Email", Email)
                   , new SqlParameter("@Password", Password)
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

        #region "Update Password "
        public int UpdatePassword()
        {
            try
            {
                DR = obj_cDataAccess.RunSPReturnDR("USP_I_UpdatePassword"
                 , new SqlParameter("@UserName", UserName)
                 , new SqlParameter("@Password", Password)
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
