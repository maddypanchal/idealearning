using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess;
using System.Data;
using System.Data.SqlClient;
using BusinessLogic.Admin;


namespace BusinessLogic.Admin
{
    public class clsEmployee
    {
        #region "Variables Declaration"
        cDataAccess obj_cDataAccess;
        private DataSet DS;
        private SqlDataReader DR;
        private int RecordStatus;
        #endregion

        #region Constructor
        public clsEmployee()
        {
            obj_cDataAccess = new cDataAccess();
        }
        #endregion

        #region "Properties"
        public int EmployeeId { get; set; }
        public string CallType { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string DateOfBirth { get; set; }
        public string SequenceNumber { get; set; } 
        public string Address { get; set; }
        public int Gender { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public bool IsActive { get; set; }
        public string Email { get; set; }
        public string UploadImages { get; set; }
        public string Mobile { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Status { get; set; }
        public string MentorsOne { get; set; }
        public string MentorsTwo { get; set; }
        public string MentorsThree { get; set; }
        public string MentorsFour { get; set; }
        public string Descriptions { get; set; }
        public string Subject { get; set; }
        public string Designation { get; set; }
        public string DateOfJoin { get; set; }
        public string EmployeeCode { get; set; }
        public string EmployeeType { get; set; }
        public string WorkLocation { get; set; }
        public string Qualification { get; set; }
        public string Experience { get; set; }
        public string OtherDuties { get; set; }
        public string Interest { get; set; }

        #endregion
        #region "Insert Employee data"
        public int AddEmployee()
        {
            try
            {
                DR = obj_cDataAccess.RunSPReturnDR("USP_I_AddEmployee"

                 , new SqlParameter("@SequenceNumber", SequenceNumber)
                 , new SqlParameter("@Descriptions", Descriptions)
                 , new SqlParameter("@Designation", Designation)
                 , new SqlParameter("@Country", Country)
                 , new SqlParameter("@DateOfJoin", DateOfJoin)
                 , new SqlParameter("@EmployeeCode", EmployeeCode)
                 , new SqlParameter("@Email", Email)
                 , new SqlParameter("@Name", Name)
                 , new SqlParameter("@FatherName", FatherName)
                 , new SqlParameter("@Address", Address)
                 , new SqlParameter("@DateOfBirth", DateOfBirth)
                 , new SqlParameter("@Gender", Gender)
                 , new SqlParameter("@State", State)
                 , new SqlParameter("@City", City)
                 , new SqlParameter("@IsActive", IsActive)
                 , new SqlParameter("@UploadImages", UploadImages)
                 , new SqlParameter("@Mobile", Mobile)
                 , new SqlParameter("@UserName", UserName)
                 , new SqlParameter("@Password", Password)
                 , new SqlParameter("@Status", Status)
                 , new SqlParameter("@EmployeeType", EmployeeType)
                 , new SqlParameter("@MentorsOne", MentorsOne)
                 , new SqlParameter("@MentorsTwo", MentorsTwo)
                 , new SqlParameter("@MentorsThree", MentorsThree)
                 , new SqlParameter("@MentorsFour", MentorsFour)
                 , new SqlParameter("@WorkLocation", WorkLocation)
                 , new SqlParameter("@Qualification", Qualification)
                 , new SqlParameter("@Experience", Experience)
                 , new SqlParameter("@OtherDuties", OtherDuties)
                 , new SqlParameter("@Interest", Interest)
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




        #region "Fill EMPLOYEE WORK"
        public DataSet DisplayEmployeeWork()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                    , new SqlParameter("@CALL_TYPE", "EMPLOYEE_WORK")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        #endregion 
        
        #region "Fill EMPLOYEE SYLLBUS"
        public DataSet DisplayEmployeeSyllbus()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                    , new SqlParameter("@CALL_TYPE", "EMPLOYEE_SYLLBUS")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        #endregion 

        #region "Fill Employee grid View BY CallType...."
        public DataSet DisplayEmployee1()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                    , new SqlParameter("@CALL_TYPE", "EMPLOYEE1")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        #endregion "End Fill User Grid view ..."
        #region "Fill Employee grid View BY CallType...."
        public DataSet DisplayEmployee()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                    , new SqlParameter("@CALL_TYPE", "EMPLOYEE")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        #endregion "End Fill User Grid view ..."

        #region "Fill Employee grid View BY CallType...."
        public DataSet DisplayPEmployee()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                    , new SqlParameter("@CALL_TYPE", "PEMPLOYEE")
                    , new SqlParameter("@EmployeeId", EmployeeId)
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        #endregion "End Fill User Grid view ..."

            #region "Fill Employee grid View BY CallType...."
        public DataSet FillEmployee()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                    , new SqlParameter("@CALL_TYPE", "FillEmployee")
                    , new SqlParameter("@EmployeeId", EmployeeId)
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        #endregion 

            #region "Fill Employee BY ID"
        public DataSet FillEmployeeBYID()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                    , new SqlParameter("@CALL_TYPE", "FillEmployeeById")
                    , new SqlParameter("@EmployeeId", EmployeeId)
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        #endregion 
        

        

        #region "Delete Employee Date"
        public int DeleteEmployee()
        {
            try
            {
                DR = obj_cDataAccess.RunSPReturnDR("USP_I_DeleteMasterDetails"
                     , new SqlParameter("@EmployeeId", EmployeeId)
                      , new SqlParameter("@CALL_TYPE", "EMPLOYEE")

                   );
            }
            catch (Exception ex)
            {
            }
            return RecordStatus;
        }
        #endregion

        #region "Active / Inactive Account For Pack Type"
        public int AccountActiveInactiveAccount() // METHOD FOR ACTIVE\DEACTIVE
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("IdeaMasterUpdate"
                      , new SqlParameter("@CallType", "PACK_TYPE")
                      , new SqlParameter("@RECORD_ID", EmployeeId)
                        );
                RecordStatus = Convert.ToInt32(DS.Tables[0].Rows[0][0]);
            }
            catch (Exception ex)
            { }
            return RecordStatus;
        }
        #endregion

        #region "UPDATE CLIENT"
        public DataSet UpdateEmployee()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("IdeaMasterUpdate"
                  , new SqlParameter("@SequenceNumber", SequenceNumber)
                 , new SqlParameter("@Descriptions", Descriptions)
                 , new SqlParameter("@Designation", Designation)
                  , new SqlParameter("@DateOfJoin", DateOfJoin)
                     , new SqlParameter("@EmployeeType", EmployeeType)
                      , new SqlParameter("@MentorsOne", MentorsOne)
                 , new SqlParameter("@MentorsTwo", MentorsTwo)
                 , new SqlParameter("@MentorsThree", MentorsThree)
                 , new SqlParameter("@MentorsFour", MentorsFour)
                    , new SqlParameter("@WorkLocation", WorkLocation)
                 , new SqlParameter("@Qualification", Qualification)
                 , new SqlParameter("@Experience", Experience)
                 , new SqlParameter("@OtherDuties", OtherDuties)
                 , new SqlParameter("@Interest", Interest)
                 , new SqlParameter("@EmployeeCode", EmployeeCode)
                  , new SqlParameter("@Address", Address)
                   , new SqlParameter("@Country", Country)
                 , new SqlParameter("@State", State)
                  , new SqlParameter("@DateOfBirth", DateOfBirth)
                 , new SqlParameter("@City", City)
                 , new SqlParameter("@Email", Email)
                 , new SqlParameter("@Name", Name)
                 , new SqlParameter("@FatherName", FatherName)
                 , new SqlParameter("@Gender", Gender)
                      , new SqlParameter("@Mobile", Mobile)
                 , new SqlParameter("@UserName", UserName)
                 , new SqlParameter("@Password", Password)
                 , new SqlParameter("@UploadImages", UploadImages)
                , new SqlParameter("@EmployeeId", EmployeeId)
                 //, new SqlParameter("@IsActive", IsActive)
                 //, new SqlParameter("@Status", Status)
                   , new SqlParameter("@CallType", "UpdateEmployee")
                 );

            }
            catch (Exception ex)
            {
            }
            return DS;
        }
        #endregion
        #region "Search Student Multiple"
        public DataSet SearchEmployeeMultiple()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_SEARCH_MULTIPLE"
               
                , new SqlParameter("@Name", Name)
                , new SqlParameter("@Mobile", Mobile)
                , new SqlParameter("@EmployeeCode", EmployeeCode)
                , new SqlParameter("@Email", Email)
                , new SqlParameter("@Call_Type", "Employee")
                );
            }
            catch (Exception)
            { }
            return DS;
        }
        #endregion
    }

}
