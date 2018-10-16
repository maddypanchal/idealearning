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
    public class clsStudent
    {

        #region "Variables Declaration"
        cDataAccess obj_cDataAccess;
        private DataSet DS;
     
        private SqlDataReader DR;
        private int RecordStatus;
        #endregion

        #region Constructor
        public clsStudent()
        {
            obj_cDataAccess = new cDataAccess();
        }
        #endregion

        #region "Properties"
        public int StudentId { get; set; }
        public string CallType { get; set; }
        public string FatherNumber { get; set; }
        public string MotherNumber { get; set; }
        public string StudentName { get; set; }
        public string SubjectName { get; set; }
        //public string SubjectName1 { get; set; }
        //public string SubjectName2 { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string DateOfBirth { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        //public string Course { get; set; }
        //public string Course1 { get; set; }
        //public string Course2 { get; set; }
        public string CateGory { get; set; }
        public string Batch { get; set; }
        public string CourseDuration { get; set; }
       
        public bool IsActive { get; set; }
        public string Email { get; set; }
        public string UploadImages { get; set; }
        public string Photo { get; set; }
        public string Signature { get; set; }
        public string Mobile { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public int Status { get; set; }
        public int CURRENT_STUDENT_ID { get; set; }
        public string RegistrationNo { get; set; }
        public string DateofRegistration { get; set; }
        public string RollNo { get; set; }
        
        public string Absent { get; set; }
        public string Date { get; set; }
        public string DuePayment { get; set; }
        public string DueDate { get; set; }
        public string Alert { get; set; }
        public string PinCode { get; set; }
       
        public int ClassCoursesId { get; set; }
        public int SubjectId { get; set; }

        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public int ClassId { get; set; }

    
        public string CourseOne { get; set; }
        public string CourseTwo { get; set; }
        public string CourseThree { get; set; }
        public string CourseFour { get; set; }
        public string CourseOneSubjectOne { get; set; }
        public string CourseOneSubjectTwo { get; set; }
        public string CourseOneSubjectThree { get; set; }
        public string CourseOneSubjectFour { get; set; }
        public string CourseTwoSubjectOne { get; set; }
        public string CourseTwoSubjectTwo { get; set; }
        public string CourseTwoSubjectThree { get; set; }
        public string CourseTwoSubjectFour { get; set; }
        public string CourseThreeSubjectOne { get; set; }
        public string CourseThreeSubjectTwo { get; set; }
        public string CourseThreeSubjectThree { get; set; }
        public string CourseThreeSubjectFour { get; set; }
        public string CourseFourSubjectOne { get; set; }
        public string CourseFourSubjectTwo { get; set; }
        public string CourseFourSubjectThree { get; set; }
        public string CourseFourSubjectFour { get; set; }

        public string CountryText { get; set; }
        public string StateText { get; set; }
        public string CityText { get; set; }
        public string ClassText { get; set; }

        public string CourseOneText { get; set; }
        public string CourseTwoText { get; set; }
        public string CourseThreeText { get; set; }
        public string CourseFourText { get; set; }
        public string CourseOneSubjectOneText { get; set; }
        public string CourseOneSubjectTwoText { get; set; }
        public string CourseOneSubjectThreeText { get; set; }
        public string CourseOneSubjectFourText { get; set; }
        public string CourseTwoSubjectOneText { get; set; }
        public string CourseTwoSubjectTwoText { get; set; }
        public string CourseTwoSubjectThreeText { get; set; }
        public string CourseTwoSubjectFourText { get; set; }
        public string CourseThreeSubjectOneText { get; set; }
        public string CourseThreeSubjectTwoText { get; set; }
        public string CourseThreeSubjectThreeText { get; set; }
        public string CourseThreeSubjectFourText { get; set; }
        public string CourseFourSubjectOneText { get; set; }
        public string CourseFourSubjectTwoText { get; set; }
        public string CourseFourSubjectThreeText { get; set; }
        public string CourseFourSubjectFourText { get; set; }



        // online student Registration

      public int OnlineStudentRegistrationId  { get; set; }
   //  public string StudentName  { get; set; }
    // public string FatherName  { get; set; }
    //  public string MotherName  { get; set; }
    //  public DateTime DateOfBirth  { get; set; }
    //  public int Gender { get; set; }
      public int Category { get; set; }
   //   public int Country { get; set; }
  //    public int State { get; set; }
  //    public int City  { get; set; }
   //   public string Address  { get; set; }
      public string EmailID  { get; set; }
      public string MobileNumber  { get; set; }
     // public string UserName  { get; set; }
    //  public string Password  { get; set; }
      //public string Photo  { get; set; }
      public string Sign  { get; set; }
   //   public bool IsActive { get; set; }

        #endregion

        #region "Insert Student data"
        public int AddStudent()
        {
            try
            {
                DR = obj_cDataAccess.RunSPReturnDR("USP_I_AddStudent"
                 , new SqlParameter("@Email", Email)
                 , new SqlParameter("@StudentName", StudentName)
                 , new SqlParameter("@FatherName", FatherName)
                 , new SqlParameter("@MotherName", MotherName)
                 , new SqlParameter("@FatherNumber", FatherNumber)
                 , new SqlParameter("@Address", Address)
                 , new SqlParameter("@DateOfBirth", DateOfBirth)
                 , new SqlParameter("@Gender", Gender)
                 , new SqlParameter("@State", State)
                 , new SqlParameter("@City", City)
                 , new SqlParameter("@Country", Country)
                 , new SqlParameter("@PinCode", PinCode)
                 , new SqlParameter("@UploadImages", UploadImages)
                 , new SqlParameter("@Mobile", Mobile)
                 , new SqlParameter("@UserName", UserName)
                 , new SqlParameter("@Password", Password)

                 , new SqlParameter("@Status", Status)
                 , new SqlParameter("@RegistrationNo", RegistrationNo)
                 , new SqlParameter("@DateofRegistration", DateofRegistration)
                 , new SqlParameter("@RollNo", RollNo)
                 , new SqlParameter("@Category", CateGory)
                 , new SqlParameter("@ClassId", ClassId)
              
                 , new SqlParameter("@CourseDuration", CourseDuration)
                 , new SqlParameter("@IsActive", IsActive)
                 , new SqlParameter("@Alert", Alert)
                 , new SqlParameter("@DueDate", DueDate)
                 , new SqlParameter("@DuePayment", DuePayment)

                 , new SqlParameter("@CourseOne", CourseOne)
                 , new SqlParameter("@CourseTwo", CourseTwo)
                 , new SqlParameter("@CourseThree", CourseThree)
                 , new SqlParameter("@CourseFour", CourseFour)

                 , new SqlParameter("@CourseOneSubjectOne", CourseOneSubjectOne)
                 , new SqlParameter("@CourseOneSubjectTwo", CourseOneSubjectTwo)
                 , new SqlParameter("@CourseOneSubjectThree", CourseOneSubjectThree)
                 , new SqlParameter("@CourseOneSubjectFour", CourseOneSubjectFour)

                 , new SqlParameter("@CourseTwoSubjectOne", CourseTwoSubjectOne)
                 , new SqlParameter("@CourseTwoSubjectTwo", CourseTwoSubjectTwo)
                 , new SqlParameter("@CourseTwoSubjectThree", CourseTwoSubjectThree)
                 , new SqlParameter("@CourseTwoSubjectFour", CourseTwoSubjectFour)

                 , new SqlParameter("@CourseThreeSubjectOne", CourseThreeSubjectOne)
                 , new SqlParameter("@CourseThreeSubjectTwo", CourseThreeSubjectTwo)
                 , new SqlParameter("@CourseThreeSubjectThree", CourseThreeSubjectThree)
                 , new SqlParameter("@CourseThreeSubjectFour", CourseThreeSubjectFour)

                 , new SqlParameter("@CourseFourSubjectOne", CourseFourSubjectOne)
                 , new SqlParameter("@CourseFourSubjectTwo", CourseFourSubjectTwo)
                 , new SqlParameter("@CourseFourSubjectThree", CourseFourSubjectThree)
                 , new SqlParameter("@CourseFourSubjectFour", CourseFourSubjectFour)

                 , new SqlParameter("@StateText", StateText)
                 , new SqlParameter("@CityText", CityText)
                 , new SqlParameter("@CountryText", CountryText)

                 , new SqlParameter("@ClassText", ClassText)
                 , new SqlParameter("@CourseOneText", CourseOneText)
                 , new SqlParameter("@CourseTwoText", CourseTwoText)
                 , new SqlParameter("@CourseThreeText", CourseThreeText)
                 , new SqlParameter("@CourseFourText", CourseFourText)

                 , new SqlParameter("@CourseOneSubjectOneText", CourseOneSubjectOneText)
                 , new SqlParameter("@CourseOneSubjectTwoText", CourseOneSubjectTwoText)
                 , new SqlParameter("@CourseOneSubjectThreeText", CourseOneSubjectThreeText)
                 , new SqlParameter("@CourseOneSubjectFourText", CourseOneSubjectFourText)

                 , new SqlParameter("@CourseTwoSubjectOneText", CourseTwoSubjectOneText)
                 , new SqlParameter("@CourseTwoSubjectTwoText", CourseTwoSubjectTwoText)
                 , new SqlParameter("@CourseTwoSubjectThreeText", CourseTwoSubjectThreeText)
                 , new SqlParameter("@CourseTwoSubjectFourText", CourseTwoSubjectFourText)

                 , new SqlParameter("@CourseThreeSubjectOneText", CourseThreeSubjectOneText)
                 , new SqlParameter("@CourseThreeSubjectTwoText", CourseThreeSubjectTwoText)
                 , new SqlParameter("@CourseThreeSubjectThreeText", CourseThreeSubjectThreeText)
                 , new SqlParameter("@CourseThreeSubjectFourText", CourseThreeSubjectFourText)

                 , new SqlParameter("@CourseFourSubjectOneText", CourseFourSubjectOneText)
                 , new SqlParameter("@CourseFourSubjectTwoText", CourseFourSubjectTwoText)
                 , new SqlParameter("@CourseFourSubjectThreeText", CourseFourSubjectThreeText)
                 , new SqlParameter("@CourseFourSubjectFourText", CourseFourSubjectFourText)

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

        #region "Insert Student data"
        public int AddOnlineStudent()
        {
            try
            {
                DR = obj_cDataAccess.RunSPReturnDR("IdeaMasterInsert"
                 , new SqlParameter("@EmailID", EmailID)
                 , new SqlParameter("@StudentName", StudentName)
                 , new SqlParameter("@FatherName", FatherName)
                 , new SqlParameter("@MotherName", MotherName)
               
                 , new SqlParameter("@Address", Address)
                 , new SqlParameter("@DateOfBirth", DateOfBirth)
                 , new SqlParameter("@Gender", Gender)
                 , new SqlParameter("@State", State)
                 , new SqlParameter("@City", City)
                 , new SqlParameter("@Country", Country)


                 , new SqlParameter("@MobileNumber", MobileNumber)
                 , new SqlParameter("@UserName", UserName)
                 , new SqlParameter("@Password", Password)

                 , new SqlParameter("@Status", Status)
                 , new SqlParameter("@RegistrationNo", RegistrationNo)
                 , new SqlParameter("@DateofRegistration", DateofRegistration)
           
                 , new SqlParameter("@Category", CateGory)
                 

      
                 , new SqlParameter("@IsActive", IsActive)
              

               
                 , new SqlParameter("@CallType", "OnlineStudentRegistration")

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

        #region "Insert Student Photo"
        public int AddStudentPhoto()
        {
            try
            {
                DR = obj_cDataAccess.RunSPReturnDR("USP_I_UPLOAD_PHOTO"
                           , new SqlParameter("@UploadImages", UploadImages)

                 , new SqlParameter("@StudentId", StudentId)
                );


                while (DR.Read())
                {
                    CURRENT_STUDENT_ID = Convert.ToInt32(DR[0]);
                }
            }
            catch (Exception ex)
            { }
            return CURRENT_STUDENT_ID;

        }

        #endregion

        #region "Fill Student Preview "
        public DataSet FillStudentPreview()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("[USP_I_FillMasterDetails]"
                 , new SqlParameter("StudentId", StudentId)
                 , new SqlParameter("@CALL_TYPE", "PSTUDENT")
                    );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        #endregion

        #region "Insert Student Signature"
        public int AddStudentSignature()
        {
            try
            {
                DR = obj_cDataAccess.RunSPReturnDR("[USP_I_UPLOAD_SIGNATURE]"
                 , new SqlParameter("@Signature", Signature)
                 , new SqlParameter("@StudentId", StudentId)
                );


                while (DR.Read())
                {
                    CURRENT_STUDENT_ID = Convert.ToInt32(DR[0]);
                }
            }
            catch (Exception ex)
            { }
            return CURRENT_STUDENT_ID;


        }
        #endregion

        #region "Fill Student "
        public DataSet DisplayStudent()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                    , new SqlParameter("@CALL_TYPE", "STUDENT")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        #endregion 

        #region "Fill online Student "
        public DataSet DisplayOnlineStudent()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                    , new SqlParameter("@CALL_TYPE", "OnlineStudent")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        #endregion 

        #region "Add Attendance"
        public int AddAttendanceGridview()
        {
            int ProductID = 0;
            DS = obj_cDataAccess.RunSPReturnDataSet("IdeaMasterInsert"
                  , new SqlParameter("@ClassCoursesId", ClassCoursesId)
                  , new SqlParameter("@SubjectId", SubjectId)
                  , new SqlParameter("@StudentId", StudentId)
                  , new SqlParameter("@ClassId", ClassId)
                  , new SqlParameter("@Absent", Absent)
                  , new SqlParameter("RollNo", RollNo)
                  , new SqlParameter("@Date", Date)
                  , new SqlParameter("@StudentName", StudentName)
                  , new SqlParameter("@CallType", "AddAttendanceAbsent")
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

        #region "Fill Student grid View "
        public DataSet DisplayStudentByClassId()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                    , new SqlParameter("@ClassId", ClassId)
                    , new SqlParameter("@ClassCoursesId", ClassCoursesId)
                    , new SqlParameter("@SubjectId", SubjectId)
                    , new SqlParameter("@CourseOne", CourseOne)
                    , new SqlParameter("@SubjectName", SubjectName)
                    , new SqlParameter("@CALL_TYPE", "StudentByClassId")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        #endregion 

        #region "Student By ClassAttendence"
        public DataSet StudentByClassAttendence()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                    , new SqlParameter("@ClassId", ClassId)
                    , new SqlParameter("@ClassCoursesId", ClassCoursesId)
                    , new SqlParameter("@SubjectId", SubjectId)
                     // , new SqlParameter("@CourseOne", CourseOne)
                     // , new SqlParameter("@SubjectName", SubjectName)
                    , new SqlParameter("@CALL_TYPE", "StudentByClassAttendence")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        #endregion 

        #region "Fill Student By Attendance"
        public DataSet DisplayStudentByAttendance()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                   , new SqlParameter("@CALL_TYPE", "StudentByAttendance")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        #endregion

        #region "Fill Single Student By Attendance"
        public DataSet DisplaySingalStudentByAttendance()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                    , new SqlParameter("@StudentId", StudentId)
                   , new SqlParameter("@CALL_TYPE", "SingleStudentByAttendance")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        #endregion

        #region "Fill Employee grid View BY DisplayPStudent CallType...."
        public DataSet DisplayPStudent()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                      , new SqlParameter("@StudentId", StudentId)
                      , new SqlParameter("@CALL_TYPE", "PSTUDENT")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        #endregion 

        #region "Fill Student"
        public DataSet DisplayStudentForUpdate()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                      , new SqlParameter("@StudentId", StudentId)
                      , new SqlParameter("@CALL_TYPE", "FillStudentForUpdate")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        #endregion 

        #region "Fill Attendence_Student...."
        public DataSet AttendenceStudent()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                      , new SqlParameter("@StudentId", StudentId)
                      , new SqlParameter("@CALL_TYPE", "AttendenceStudent")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }

       

        public DataSet DeleteAttendenceStudent()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_DeleteMasterDetails"
                      , new SqlParameter("@CALL_TYPE", "DeleteAttendenceStudent")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        #endregion 

        #region "Fill Attendence Student By Subject ...."

        public DataSet AttendenceCoursesOneSubjectOne()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                      , new SqlParameter("@ClassId", ClassId)
                      , new SqlParameter("@CourseOne", CourseOne)
                      , new SqlParameter("@CourseOneSubjectOne", CourseOneSubjectOne)
                      , new SqlParameter("@StudentId", StudentId)
                      , new SqlParameter("@CALL_TYPE", "AttendenceCoursesOneSubjectOne")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }

        public DataSet AttendenceCoursesOneSubjectTwo()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                      , new SqlParameter("@ClassId", ClassId)
                      , new SqlParameter("@CourseOne", CourseOne)
                      , new SqlParameter("@CourseOneSubjectTwo", CourseOneSubjectTwo)
                      , new SqlParameter("@StudentId", StudentId)
                      , new SqlParameter("@CALL_TYPE", "AttendenceCoursesOneSubjectTwo")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }

        public DataSet AttendenceCoursesOneSubjectThree()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                      , new SqlParameter("@ClassId", ClassId)
                      , new SqlParameter("@CourseOne", CourseOne)
                      , new SqlParameter("@CourseOneSubjectThree", CourseOneSubjectThree)
                      , new SqlParameter("@StudentId", StudentId)
                      , new SqlParameter("@CALL_TYPE", "AttendenceCoursesOneSubjectThree")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }

        public DataSet AttendenceCoursesOneSubjectFour()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                      , new SqlParameter("@ClassId", ClassId)
                      , new SqlParameter("@CourseOne", CourseOne)
                      , new SqlParameter("@CourseOneSubjectFour", CourseOneSubjectFour)
                      , new SqlParameter("@StudentId", StudentId)
                      , new SqlParameter("@CALL_TYPE", "AttendenceCoursesOneSubjectFour")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }

        // For Courses Two 
        public DataSet AttendenceCoursesTwoSubjectOne()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                      , new SqlParameter("@ClassId", ClassId)
                      , new SqlParameter("@CourseTwo", CourseTwo)
                      , new SqlParameter("@CourseTwoSubjectOne", CourseTwoSubjectOne)
                      , new SqlParameter("@StudentId", StudentId)
                      , new SqlParameter("@CALL_TYPE", "AttendenceCoursesOneSubjectFour")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }

        public DataSet AttendenceCoursesTwoSubjectTwo()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                      , new SqlParameter("@ClassId", ClassId)
                      , new SqlParameter("@CourseTwo", CourseTwo)
                      , new SqlParameter("@CourseTwoSubjectTwo", CourseTwoSubjectTwo)
                      , new SqlParameter("@StudentId", StudentId)
                      , new SqlParameter("@CALL_TYPE", "AttendenceCoursesOneSubjectFour")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }

        public DataSet AttendenceCoursesTwoSubjectThree()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                      , new SqlParameter("@ClassId", ClassId)
                      , new SqlParameter("@CourseTwo", CourseTwo)
                      , new SqlParameter("@CourseTwoSubjectThree", CourseTwoSubjectThree)
                      , new SqlParameter("@StudentId", StudentId)
                      , new SqlParameter("@CALL_TYPE", "AttendenceCoursesOneSubjectFour")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }

        public DataSet AttendenceCoursesTwoSubjectFour()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                      , new SqlParameter("@ClassId", ClassId)
                      , new SqlParameter("@CourseTwo", CourseTwo)
                      , new SqlParameter("@CourseTwoSubjectFour", CourseTwoSubjectFour)
                      , new SqlParameter("@StudentId", StudentId)
                      , new SqlParameter("@CALL_TYPE", "AttendenceCoursesOneSubjectFour")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }

        // For Courses Two 

        public DataSet AttendenceCoursesThreeSubjectOne()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                      , new SqlParameter("@ClassId", ClassId)
                      , new SqlParameter("@CourseThree", CourseThree)
                      , new SqlParameter("@CourseThreeSubjectOne", CourseThreeSubjectOne)
                      , new SqlParameter("@StudentId", StudentId)
                      , new SqlParameter("@CALL_TYPE", "AttendenceCoursesThreeSubjectOne")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }

        public DataSet AttendenceCoursesThreeSubjectTwo()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                      , new SqlParameter("@ClassId", ClassId)
                      , new SqlParameter("@CourseThree", CourseThree)
                      , new SqlParameter("@CourseThreeSubjectTwo", CourseThreeSubjectTwo)
                      , new SqlParameter("@StudentId", StudentId)
                      , new SqlParameter("@CALL_TYPE", "AttendenceCoursesThreeSubjectTwo")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }

        public DataSet AttendenceCoursesThreeSubjectThree()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                      , new SqlParameter("@ClassId", ClassId)
                      , new SqlParameter("@CourseThree", CourseThree)
                      , new SqlParameter("@CourseThreeSubjectThree", CourseTwoSubjectThree)
                      , new SqlParameter("@StudentId", StudentId)
                      , new SqlParameter("@CALL_TYPE", "AttendenceCoursesThreeSubjectThree")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }

        public DataSet AttendenceCoursesThreeSubjectFour()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                      , new SqlParameter("@ClassId", ClassId)
                      , new SqlParameter("@CourseThree", CourseThree)
                      , new SqlParameter("@CourseThreeSubjectFour", CourseThreeSubjectFour)
                      , new SqlParameter("@StudentId", StudentId)
                      , new SqlParameter("@CALL_TYPE", "AttendenceCoursesThreeSubjectFour")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }

        // For Courses Four

        public DataSet AttendenceCoursesFourSubjectOne()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                      , new SqlParameter("@ClassId", ClassId)
                      , new SqlParameter("@CourseFour", CourseFour)
                      , new SqlParameter("@CourseTwoSubjectOne", CourseTwoSubjectOne)
                      , new SqlParameter("@StudentId", StudentId)
                      , new SqlParameter("@CALL_TYPE", "AttendenceCoursesOneSubjectOne")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }

        public DataSet AttendenceCoursesFourSubjectTwo()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                      , new SqlParameter("@ClassId", ClassId)
                      , new SqlParameter("@CourseFour", CourseFour)
                      , new SqlParameter("@CourseFourSubjectTwo", CourseFourSubjectTwo)
                      , new SqlParameter("@StudentId", StudentId)
                      , new SqlParameter("@CALL_TYPE", "AttendenceCoursesFourSubjectTwo")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }

        public DataSet AttendenceCoursesFourSubjectThree()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                      , new SqlParameter("@ClassId", ClassId)
                      , new SqlParameter("@CourseFour", CourseFour)
                      , new SqlParameter("@CourseFourSubjectThree", CourseFourSubjectThree)
                      , new SqlParameter("@StudentId", StudentId)
                      , new SqlParameter("@CALL_TYPE", "AttendenceCoursesFourSubjectThree")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }

        public DataSet AttendenceCoursesFourSubjectFour()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                      , new SqlParameter("@ClassId", ClassId)
                      , new SqlParameter("@CourseFour", CourseFour)
                      , new SqlParameter("@CourseFourSubjectFour", CourseFourSubjectFour)
                      , new SqlParameter("@StudentId", StudentId)
                      , new SqlParameter("@CALL_TYPE", "AttendenceCoursesFourSubjectFour")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }

        public DataSet AttendenceCoursesOneSubjectOneText()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                      , new SqlParameter("@ClassId", ClassId)
                      , new SqlParameter("@CourseOne", CourseOneText)
                      , new SqlParameter("@CourseOneSubjectOne", CourseOneSubjectOneText)
                      , new SqlParameter("@StudentId", StudentId)
                      , new SqlParameter("@CALL_TYPE", "AttendenceCoursesOneSubjectOne")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }

        public DataSet AttendenceCoursesOneSubjectTwoText()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                      , new SqlParameter("@ClassId", ClassId)
                      , new SqlParameter("@CourseOne", CourseOneText)
                      , new SqlParameter("@CourseOneSubjectTwo", CourseOneSubjectTwoText)
                      , new SqlParameter("@StudentId", StudentId)
                      , new SqlParameter("@CALL_TYPE", "AttendenceCoursesOneSubjectTwo")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }

        public DataSet AttendenceCoursesOneSubjectThreeText()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                      , new SqlParameter("@ClassId", ClassId)
                      , new SqlParameter("@CourseOne", CourseOneText)
                      , new SqlParameter("@CourseOneSubjectThree", CourseOneSubjectThreeText)
                      , new SqlParameter("@StudentId", StudentId)
                      , new SqlParameter("@CALL_TYPE", "AttendenceCoursesOneSubjectThree")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }

        public DataSet AttendenceCoursesOneSubjectFourText()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                      , new SqlParameter("@ClassId", ClassId)
                      , new SqlParameter("@CourseOne", CourseOneText)
                      , new SqlParameter("@CourseOneSubjectFour", CourseOneSubjectFourText)
                      , new SqlParameter("@StudentId", StudentId)
                      , new SqlParameter("@CALL_TYPE", "AttendenceCoursesOneSubjectFour")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }

        // For Courses Two 
        public DataSet AttendenceCoursesTwoSubjectOneText()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                      , new SqlParameter("@ClassId", ClassId)
                      , new SqlParameter("@CourseTwo", CourseTwoText)
                      , new SqlParameter("@CourseTwoSubjectOne", CourseTwoSubjectOneText)
                      , new SqlParameter("@StudentId", StudentId)
                      , new SqlParameter("@CALL_TYPE", "AttendenceCoursesOneSubjectFour")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }

        public DataSet AttendenceCoursesTwoSubjectTwoText()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                      , new SqlParameter("@ClassId", ClassId)
                      , new SqlParameter("@CourseTwo", CourseTwoText)
                      , new SqlParameter("@CourseTwoSubjectTwo", CourseTwoSubjectTwoText)
                      , new SqlParameter("@StudentId", StudentId)
                      , new SqlParameter("@CALL_TYPE", "AttendenceCoursesOneSubjectFour")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }

        public DataSet AttendenceCoursesTwoSubjectThreeText()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                      , new SqlParameter("@ClassId", ClassId)
                      , new SqlParameter("@CourseTwo", CourseTwoText)
                      , new SqlParameter("@CourseTwoSubjectThree", CourseTwoSubjectThreeText)
                      , new SqlParameter("@StudentId", StudentId)
                      , new SqlParameter("@CALL_TYPE", "AttendenceCoursesOneSubjectFour")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }

        public DataSet AttendenceCoursesTwoSubjectFourText()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                      , new SqlParameter("@ClassId", ClassId)
                      , new SqlParameter("@CourseTwo", CourseTwoText)
                      , new SqlParameter("@CourseTwoSubjectFour", CourseTwoSubjectFourText)
                      , new SqlParameter("@StudentId", StudentId)
                      , new SqlParameter("@CALL_TYPE", "AttendenceCoursesOneSubjectFour")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }

        // For Courses Two 

        public DataSet AttendenceCoursesThreeSubjectOneText()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                      , new SqlParameter("@ClassId", ClassId)
                      , new SqlParameter("@CourseThree", CourseThreeText)
                      , new SqlParameter("@CourseThreeSubjectOne", CourseThreeSubjectOneText)
                      , new SqlParameter("@StudentId", StudentId)
                      , new SqlParameter("@CALL_TYPE", "AttendenceCoursesThreeSubjectOne")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }

        public DataSet AttendenceCoursesThreeSubjectTwoText()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                      , new SqlParameter("@ClassId", ClassId)
                      , new SqlParameter("@CourseThree", CourseThreeText)
                      , new SqlParameter("@CourseThreeSubjectTwo", CourseThreeSubjectTwoText)
                      , new SqlParameter("@StudentId", StudentId)
                      , new SqlParameter("@CALL_TYPE", "AttendenceCoursesThreeSubjectTwo")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }

        public DataSet AttendenceCoursesThreeSubjectThreeText()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                      , new SqlParameter("@ClassId", ClassId)
                      , new SqlParameter("@CourseThree", CourseThreeText)
                      , new SqlParameter("@CourseThreeSubjectThree", CourseTwoSubjectThreeText)
                      , new SqlParameter("@StudentId", StudentId)
                      , new SqlParameter("@CALL_TYPE", "AttendenceCoursesThreeSubjectThree")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }

        public DataSet AttendenceCoursesThreeSubjectFourText()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                      , new SqlParameter("@ClassId", ClassId)
                      , new SqlParameter("@CourseThree", CourseThreeText)
                      , new SqlParameter("@CourseThreeSubjectFour", CourseThreeSubjectFourText)
                      , new SqlParameter("@StudentId", StudentId)
                      , new SqlParameter("@CALL_TYPE", "AttendenceCoursesThreeSubjectFour")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }

        // For Courses Four

        public DataSet AttendenceCoursesFourSubjectOneText()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                      , new SqlParameter("@ClassId", ClassId)
                      , new SqlParameter("@CourseFour", CourseFourText)
                      , new SqlParameter("@CourseTwoSubjectOne", CourseTwoSubjectOneText)
                      , new SqlParameter("@StudentId", StudentId)
                      , new SqlParameter("@CALL_TYPE", "AttendenceCoursesOneSubjectOne")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }

        public DataSet AttendenceCoursesFourSubjectTwoText()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                      , new SqlParameter("@ClassId", ClassId)
                      , new SqlParameter("@CourseFour", CourseFourText)
                      , new SqlParameter("@CourseFourSubjectTwo", CourseFourSubjectTwoText)
                      , new SqlParameter("@StudentId", StudentId)
                      , new SqlParameter("@CALL_TYPE", "AttendenceCoursesFourSubjectTwo")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }

        public DataSet AttendenceCoursesFourSubjectThreeText()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                      , new SqlParameter("@ClassId", ClassId)
                      , new SqlParameter("@CourseFour", CourseFourText)
                      , new SqlParameter("@CourseFourSubjectThree", CourseFourSubjectThreeText)
                      , new SqlParameter("@StudentId", StudentId)
                      , new SqlParameter("@CALL_TYPE", "AttendenceCoursesFourSubjectThree")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }

        public DataSet AttendenceCoursesFourSubjectFourText()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                      , new SqlParameter("@ClassId", ClassId)
                      , new SqlParameter("@CourseFour", CourseFourText)
                      , new SqlParameter("@CourseFourSubjectFour", CourseFourSubjectFourText)
                      , new SqlParameter("@StudentId", StudentId)
                      , new SqlParameter("@CALL_TYPE", "AttendenceCoursesFourSubjectFour")
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
        public int DeleteStudent()
        {
            try
            {
                DR = obj_cDataAccess.RunSPReturnDR("USP_I_DeleteMasterDetails"
                     , new SqlParameter("@StudentId", StudentId)
                      , new SqlParameter("@CALL_TYPE", "STUDENT")

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
                      , new SqlParameter("@CallType", "StudentActive")
                      , new SqlParameter("@RECORD_ID", StudentId)
                        );
                RecordStatus = Convert.ToInt32(DS.Tables[0].Rows[0][0]);
            }
            catch (Exception ex)
            { }
            return RecordStatus;
        }
        #endregion

        #region "UPDATE student"

        public DataSet UpdateStudent()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("IdeaMasterUpdate"
                 , new SqlParameter("@Email", Email)
                 , new SqlParameter("@StudentName", StudentName)
                 , new SqlParameter("@FatherName", FatherName)
                // , new SqlParameter("@MotherName", MotherName)
                 , new SqlParameter("@FatherNumber", FatherNumber)
                 , new SqlParameter("@Address", Address)
                 , new SqlParameter("@DateOfBirth", DateOfBirth)
                 , new SqlParameter("@Gender", Gender)
                 //, new SqlParameter("@State", State)
                 //, new SqlParameter("@City", City)
                 //, new SqlParameter("@Country", Country)
                 , new SqlParameter("@PinCode", PinCode)
                 , new SqlParameter("@UploadImages", UploadImages)
                 , new SqlParameter("@Mobile", Mobile)
                 , new SqlParameter("@UserName", UserName)
                 , new SqlParameter("@Password", Password)

                 , new SqlParameter("@Status", Status)
                 , new SqlParameter("@RegistrationNo", RegistrationNo)
                 , new SqlParameter("@DateofRegistration", DateofRegistration)
                 , new SqlParameter("@RollNo", RollNo)
                 , new SqlParameter("@Category", CateGory)
               //  , new SqlParameter("@ClassId", ClassId)

                 , new SqlParameter("@CourseDuration", CourseDuration)
                 //, new SqlParameter("@IsActive", IsActive)
                 , new SqlParameter("@Alert", Alert)
                 , new SqlParameter("@DueDate", DueDate)
                 , new SqlParameter("@DuePayment", DuePayment)

                 //, new SqlParameter("@CourseOne", CourseOne)
                 //, new SqlParameter("@CourseTwo", CourseTwo)
                 //, new SqlParameter("@CourseThree", CourseThree)
                 //, new SqlParameter("@CourseFour", CourseFour)

                 //, new SqlParameter("@CourseOneSubjectOne", CourseOneSubjectOne)
                 //, new SqlParameter("@CourseOneSubjectTwo", CourseOneSubjectTwo)
                 //, new SqlParameter("@CourseOneSubjectThree", CourseOneSubjectThree)
                 //, new SqlParameter("@CourseOneSubjectFour", CourseOneSubjectFour)

                 //, new SqlParameter("@CourseTwoSubjectOne", CourseTwoSubjectOne)
                 //, new SqlParameter("@CourseTwoSubjectTwo", CourseTwoSubjectTwo)
                 //, new SqlParameter("@CourseTwoSubjectThree", CourseTwoSubjectThree)
                 //, new SqlParameter("@CourseTwoSubjectFour", CourseTwoSubjectFour)

                 //, new SqlParameter("@CourseThreeSubjectOne", CourseThreeSubjectOne)
                 //, new SqlParameter("@CourseThreeSubjectTwo", CourseThreeSubjectTwo)
                 //, new SqlParameter("@CourseThreeSubjectThree", CourseThreeSubjectThree)
                 //, new SqlParameter("@CourseThreeSubjectFour", CourseThreeSubjectFour)

                 //, new SqlParameter("@CourseFourSubjectOne", CourseFourSubjectOne)
                 //, new SqlParameter("@CourseFourSubjectTwo", CourseFourSubjectTwo)
                 //, new SqlParameter("@CourseFourSubjectThree", CourseFourSubjectThree)
                 //, new SqlParameter("@CourseFourSubjectFour", CourseFourSubjectFour)
                 , new SqlParameter("@StudentId", StudentId)
                 , new SqlParameter("@CallType", "UpdateStudent")
                 );

            }
            catch (Exception ex)
            {
            }
            return DS;
        }

        public DataSet FeeUpdate()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("IdeaMasterUpdate"
               
                 , new SqlParameter("@DueDate", DueDate)
                 , new SqlParameter("@DuePayment", DuePayment)
                 , new SqlParameter("@StudentId", StudentId)
                 , new SqlParameter("@CallType", "UpdateFeeStudent")
                 );

            }
            catch (Exception ex)
            {
            }
            return DS;
        }

        public DataSet UpdateStudentFristCourses()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("IdeaMasterUpdate"
               
                      , new SqlParameter("@ClassId", ClassId)
                      , new SqlParameter("@CourseOne", CourseOne)
                      , new SqlParameter("@CourseOneSubjectOne", CourseOneSubjectOne)
                      , new SqlParameter("@CourseOneSubjectTwo", CourseOneSubjectTwo)
                      , new SqlParameter("@CourseOneSubjectThree", CourseOneSubjectThree)
                      , new SqlParameter("@CourseOneSubjectFour", CourseOneSubjectFour)

                      , new SqlParameter("@CourseOneText", CourseOneText)
                      , new SqlParameter("@CourseOneSubjectOneText", CourseOneSubjectOneText)
                      , new SqlParameter("@CourseOneSubjectTwoText", CourseOneSubjectTwoText)
                      , new SqlParameter("@CourseOneSubjectThreeText", CourseOneSubjectThreeText)
                      , new SqlParameter("@CourseOneSubjectFourText", CourseOneSubjectFourText)

           
                      , new SqlParameter("@StudentId", StudentId)
                      , new SqlParameter("@CallType", "UpdateStudentFristCourse")
                 );

            }
            catch (Exception ex)
            {
            }
            return DS;
        }

        public DataSet UpdateStudentSecondCourse()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("IdeaMasterUpdate"

                    , new SqlParameter("@ClassId", ClassId)
                    , new SqlParameter("@CourseTwo", CourseTwo)
                    , new SqlParameter("@CourseTwoSubjectOne", CourseTwoSubjectOne)
                    , new SqlParameter("@CourseTwoSubjectTwo", CourseTwoSubjectTwo)
                    , new SqlParameter("@CourseTwoSubjectThree", CourseTwoSubjectThree)
                    , new SqlParameter("@CourseTwoSubjectFour", CourseTwoSubjectFour)
                    , new SqlParameter("@CourseTwoText", CourseTwoText)
                    , new SqlParameter("@CourseTwoSubjectOneText", CourseTwoSubjectOneText)
                    , new SqlParameter("@CourseTwoSubjectTwoText", CourseTwoSubjectTwoText)
                    , new SqlParameter("@CourseTwoSubjectThreeText", CourseTwoSubjectThreeText)
                    , new SqlParameter("@CourseTwoSubjectFourText", CourseTwoSubjectFourText)
                  , new SqlParameter("@StudentId", StudentId)
                  , new SqlParameter("@CallType", "UpdateStudentSecondCourse")
                 );

            }
            catch (Exception ex)
            {
            }
            return DS;
        }

        public DataSet UpdateStudentThreeCourse()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("IdeaMasterUpdate"


                    , new SqlParameter("@ClassId", ClassId)
                    , new SqlParameter("@CourseThree", CourseThree)
                    , new SqlParameter("@CourseThreeSubjectOne", CourseThreeSubjectOne)
                    , new SqlParameter("@CourseThreeSubjectTwo", CourseThreeSubjectTwo)
                    , new SqlParameter("@CourseThreeSubjectThree", CourseThreeSubjectThree)
                    , new SqlParameter("@CourseThreeSubjectFour", CourseThreeSubjectFour)
                    , new SqlParameter("@CourseThreeText", CourseThreeText)
                    , new SqlParameter("@CourseThreeSubjectOneText", CourseThreeSubjectOneText)
                    , new SqlParameter("@CourseThreeSubjectTwoText", CourseThreeSubjectTwoText)
                    , new SqlParameter("@CourseThreeSubjectThreeText", CourseThreeSubjectThreeText)
                    , new SqlParameter("@CourseThreeSubjectFourText", CourseThreeSubjectFourText)

              
                 , new SqlParameter("@StudentId", StudentId)
                 , new SqlParameter("@CallType", "UpdateStudentThreeCourse")
                 );

            }
            catch (Exception ex)
            {
            }
            return DS;
        }
        
        public DataSet UpdateStudentFourCourse()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("IdeaMasterUpdate"

                    , new SqlParameter("@ClassId", ClassId)
                    , new SqlParameter("@CourseFour", CourseFour)
                    , new SqlParameter("@CourseFourSubjectOne", CourseFourSubjectOne)
                    , new SqlParameter("@CourseFourSubjectTwo", CourseFourSubjectTwo)
                    , new SqlParameter("@CourseFourSubjectThree", CourseFourSubjectThree)
                    , new SqlParameter("@CourseFourSubjectFour", CourseFourSubjectFour)

                       , new SqlParameter("@CourseFourText", CourseFourText)
                    , new SqlParameter("@CourseFourSubjectOneText", CourseFourSubjectOneText)
                    , new SqlParameter("@CourseFourSubjectTwoText", CourseFourSubjectTwoText)
                    , new SqlParameter("@CourseFourSubjectThreeText", CourseFourSubjectThreeText)
                    , new SqlParameter("@CourseFourSubjectFourText", CourseFourSubjectFourText)
                    , new SqlParameter("@StudentId", StudentId)
                    , new SqlParameter("@CallType", "UpdateStudentFourCourse")
                 );

            }
            catch (Exception ex)
            {
            }
            return DS;
        }

        public DataSet UpdateStudentAddress()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("IdeaMasterUpdate"

                    , new SqlParameter("@State", State)
                    , new SqlParameter("@City", City)
                    , new SqlParameter("@Country", Country)
                     , new SqlParameter("@StateText", StateText)
                    , new SqlParameter("@CityText", CityText)
                    , new SqlParameter("@CountryText", CountryText)
                    , new SqlParameter("@StudentId", StudentId)
                    , new SqlParameter("@CallType", "UpdateStudentAddress")
                 );

            }
            catch (Exception ex)
            {
            }
            return DS;
        }

        #endregion

        #region "Update Student CallType...."
        public DataSet StudentUpdate()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                    
                     , new SqlParameter("@DuePayment", DuePayment)
                      , new SqlParameter("@DueDate", DueDate)
                      , new SqlParameter("@StudentId", StudentId)
                      , new SqlParameter("@CALL_TYPE", "PSTUDENT")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }


        public DataSet StudentFeeUpdate()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"

                     , new SqlParameter("@DuePayment", DuePayment)
                      , new SqlParameter("@DueDate", DueDate)
                      , new SqlParameter("@StudentId", StudentId)
                      , new SqlParameter("@CALL_TYPE", "FeeUpdateStudent")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }

        
        #endregion "End Fill User Grid view ..."

        #region "Search Student Multiple"


       public DataSet deleteStudentMultiple()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_SEARCH_MULTIPLE"
                , new SqlParameter("@ClassId", ClassId)
                , new SqlParameter("@Call_Type", "DeleteStudent")
                );
            }
            catch (Exception)
            { }
            return DS;
        }
        public DataSet SearchStudentMultiple()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_SEARCH_MULTIPLE"
                //  , new SqlParameter("@CourseOne", CourseOne)
                //  , new SqlParameter("@CourseOneSubjectOne", CourseOneSubjectOne)
                , new SqlParameter("@ClassId", ClassId)
                , new SqlParameter("@StudentName", StudentName)
                , new SqlParameter("@Mobile",Mobile)
                , new SqlParameter("@RegistrationNo", RegistrationNo)
                , new SqlParameter("@Call_Type","Student")
                );
            }
            catch (Exception)
            { }
            return DS;
        }
       
        #endregion

        public DataSet deleteAllStudent()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_DeleteMasterDetails"
                 , new SqlParameter("@ClassId", ClassId)
                 , new SqlParameter("@Call_Type", "DeleteStudent")
                );
            }
            catch (Exception)
            {

            }
            return DS;
        }

        #region "Search Student Multiple"
        public DataSet SearchStudentAttendanceMultiple()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_SEARCH_MULTIPLE"
                , new SqlParameter("@StudentName", StudentName)
                , new SqlParameter("@RegistrationNo", RegistrationNo)
                , new SqlParameter("@Call_Type", "StudentAttendance")
                );
            }
            catch (Exception)
            { }
            return DS;
        }
        #endregion
    }
}
