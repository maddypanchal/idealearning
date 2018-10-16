using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DataAccess;

namespace BusinessLogic.Admin
{
   public class clsLogin
    {
        #region "Variable Decleration"
        cDataAccess obj_cDataAccess;
        public SqlDataReader DR;
        public DataSet DS;
        public int RecordStatus;
        public string CallType ="Employee";
        #endregion

        #region "Constructor"
        public clsLogin()
        {
            obj_cDataAccess = new cDataAccess();
        }
        #endregion

        #region "Properties"
       public int     EMPLOYEE_ID { get; set; }
       public string  CALL_TYPE { get; set; }
       public string  FIRST_NAME{ get; set; }
       public string  LAST_NAME { get; set; }
       public string  EMAIL_ID{ get; set; }
       public string  MOBILE_NUMBER{ get; set; }
       public string  EMPLOYEEID{ get; set; }
       public string  DESIGNATION{ get; set; }
       public int DEPARTMENT { get; set; }
       public string EmployeeCode { get; set; }
       public string RegistrationNo { get; set; }
       public string UserName { get; set; }
       public string Password { get; set; }
       public string  DATE_OF_BIRTH { get; set; }
       public int     GENDER { get; set; }
       public int     USER_TYPE { get; set; }
       public bool IsActive { get; set; }
    
       #endregion

        #region "Fill Drop Dwon List"
       public DataSet Fill_ddl_User()
       {
           try
           {
               DS = obj_cDataAccess.RunSPReturnDataSet("[USP_Fill_ddl_Master]"
                      , new SqlParameter("CALL_TYPE", CallType)
                      );

               return DS;

           }
           catch (Exception ex)
           {
               return DS;
           }

       }
       #endregion

        #region "Fill Drop Dwon List"
       public DataSet Fill_ddl_Client()
       {
           try
           {
               DS = obj_cDataAccess.RunSPReturnDataSet("[USP_Fill_ddl_Master]"
                      , new SqlParameter("CALL_TYPE", "Client")
                      
                      );

               return DS;

           }
           catch (Exception ex)
           {
               return DS;
           }

       }
       #endregion "End Fill Drop Dwon List" 
        #region"Login Method for Student"
       public DataSet VarifyLoginSAccount()
       {
           DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_STUDENT_LOGIN"
                , new SqlParameter("@UserName", UserName)
                , new SqlParameter("@Password", Password)
                , new SqlParameter("@IsActive", IsActive)

            );

           return DS;

       }
        #endregion

        #region"Login Method for Student"
       public DataSet VarifyForgetPass()
       {
           DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                , new SqlParameter("@Mobile", MOBILE_NUMBER)
                , new SqlParameter("@CALL_TYPE", "StudentPassword")
               

            );

           return DS;

       }
       #endregion
        #region"Login Method For Employee"
       public DataSet VarifyLoginEmpPass()
       {
           DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                , new SqlParameter("@Mobile", MOBILE_NUMBER)
                , new SqlParameter("@CALL_TYPE", "EmployeePassword")

                
            );

           return DS;

       }
       #endregion
        #region"Login Method For Employee"
       public DataSet VarifyLoginEAccount()
       {
           DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_EMPLOYEE_LOGIN"
                , new SqlParameter("@UserName", UserName)
                , new SqlParameter("@Password", Password)
                , new SqlParameter("@IsActive", IsActive)
            );

           return DS;

       }
       #endregion
        #region"Login Method For Admin"
       public DataSet VarifyLoginAAccount()
       {
           DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_ADMIN_LOGIN"
              , new SqlParameter("@Name", UserName)
                , new SqlParameter("@Password", Password)
                , new SqlParameter("@IsActive", IsActive)

            );

           return DS;

       }
       #endregion
      
       
        #region "Fill User grid View BY CallType...."
        public DataSet DisplayData()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_FILL_GRID_EMPLOYEE"
                    , new SqlParameter("@EMPLOYEE_ID",EMPLOYEE_ID)
                    // , new SqlParameter("@USER_NAME", USER_NAME)
                     //, new SqlParameter("STATUS", Status)
                     //, new SqlParameter("@CALL_TYPE", CALL_TYPE)
                    
                    );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }


        #endregion "End Fill User Grid view ..."
        #region"update data"
        public DataSet UpdateData()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_FILL_UPDATE_EMPLOYEE"


                    , new SqlParameter("@CALL_TYPE", "EMPLOYEE")
                    , new SqlParameter("@EMPLOYEE_ID", EMPLOYEE_ID)
                    , new SqlParameter("@FIRST_NAME", FIRST_NAME)
                    , new SqlParameter("@LAST_NAME", LAST_NAME)
                    , new SqlParameter("@DESIGNATION", DESIGNATION)
                    , new SqlParameter("@DEPARTMENT", DEPARTMENT)
                    , new SqlParameter("@USER_TYPE", USER_TYPE)
                    , new SqlParameter("@GENDER", GENDER)
                   , new SqlParameter("@IS_ACTIVE", IsActive)
                 );
            }
            catch (Exception)
            {

            }
            return DS;
        }
        #endregion
        #region"delete data"
        public int DeleteItem()
        {
            try
            {
                DR = obj_cDataAccess.RunSPReturnDR("USP_DELETE_DATA_EMPLOYEE"

                    , new SqlParameter("@CALL_TYPE", "EMPLOYEE")
                    , new SqlParameter("@EMPLOYEE_ID", EMPLOYEE_ID)
                    , new SqlParameter("@FIRST_NAME", FIRST_NAME)
                    , new SqlParameter("@LAST_NAME", LAST_NAME)
                    , new SqlParameter("@DESIGNATION", DESIGNATION)
                    , new SqlParameter("@DEPARTMENT", DEPARTMENT)
                    , new SqlParameter("@USER_TYPE", USER_TYPE)
                    , new SqlParameter("@GENDER", GENDER)
                        , new SqlParameter("@IS_ACTIVE", IsActive)
                        );
                while (DR.Read())
                {
                    RecordStatus = Convert.ToInt32(DR[0]);
                }
            }

            catch (Exception ex)
            {
            }
            return RecordStatus;
        }
        #endregion
        #region "Fill Project Task Assign IN Grid view..."
        public DataSet FillProjectTaskAssign()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("[USP_Fill_GridView_Master]"
                  

                    , new SqlParameter("EMPLOYEE_ID", EMPLOYEE_ID)
                    );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }

        }

        #endregion "End Fill Project Task Assign..."
        #region "Fill user Information on Emp dask board "
        public DataSet FillEmployeeInformation()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_FILL_EMPLOYEE_INFORMATION"
                    , new SqlParameter("@EMPLOYEE_ID", EMPLOYEE_ID)
                     , new SqlParameter("@ UserName", UserName)
                   // , new SqlParameter("DEPARTMENT", DEPARTMENT)
                    );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        #endregion
        #region "Update on User/Employee "
        public int UpdateEmpInformation()
        {
            try
            {
                DR = obj_cDataAccess.RunSPReturnDR("[USP_Update_EmpInformation]"
                    , new SqlParameter("EMPLOYEE_ID", EMPLOYEE_ID)
                    , new SqlParameter("Password", Password)
                    , new SqlParameter("UserName", UserName)
                    );

                while (DR.Read())
                {
                    RecordStatus = Convert.ToInt32(DR[0]);
                }
            }
            catch (Exception)
            { }
            return RecordStatus;
        }
        #endregion "End Update on User/Employee Grid view "
    }
}
