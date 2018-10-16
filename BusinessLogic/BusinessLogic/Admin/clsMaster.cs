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
    public class clsMaster
    {
        #region "Variables Declaration"
        cDataAccess obj_cDataAccess;
        private DataSet DS;
        private SqlDataReader DR;
        private int RecordStatus;
        private DataTable DT;
        #endregion
        #region Constructor
        public clsMaster()
        {
            obj_cDataAccess = new cDataAccess();
        }
        #endregion
        #region "Properties"
        public int CourseId { get; set; }
        public int NewsEventId { get; set; }
        public int NewsTitleId { get; set; }
        public string CallType { get; set; }
        public string TitleName { get; set; }
        public string Description { get; set; }
        public string TitleDate { get; set; }
        public bool TitleStatus { get; set; }
        public int TitleType { get; set; }
        public int HeadingId { get; set; }
        public string ClassName { get; set; }
        public int ClassId { get; set; }
        public string SubjectName { get; set; }
        public int SubjectId { get; set; }

        public int CountryId { get; set; }
        public int StateId { get; set; }
        public int RegionId { get; set; }
        public string CountryName { get; set; }
        public string RegionName { get; set; }
        public string StateName { get; set; }
        public bool IsActive { get; set; }

        public int ExamInfoId { get; set; }
        public string Syllabus { get; set; }
        public string TestDate { get; set; }
        public string TypeOfTest { get; set; }

        // add properties ClassSchedule

        public int ClassScheduleId { get; set; }
        public string FormDate { get; set; }
        public string TillDate { get; set; }
        public string pdffile { get; set; }

        // add proferties home work

        public int HomeWorkId { get; set; }
        public string DocFile { get; set; }
        public int StudentId { get; set; }
        public string Absent { get; set; }
        public string Date { get; set; }
        public int AttendanceId { get; set; }
        public string Venue { get; set; }

        //ebook properties
        public int EbookId { get; set; }
        public string EbookTitle { get; set; }


        /// <summary>
        /// For Carrer properties
        /// </summary>

        public int CarrerId { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string CurrentEmployee { get; set; }
        public string Phone { get; set; }
        public string PositionAppliying { get; set; }
        public string Degree { get; set; }
        public string Degree2 { get; set; }
        public string Experience { get; set; }
        public string CurrentCTC { get; set; }
        public string ExpectedCTC { get; set; }
        public string Resume { get; set; }
        public string JobTitle { get; set; }
        public string UploadImages { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
        public string CoverPage { get; set; }
        public string price { get; set; }
        public string Descriptions { get; set; }
        public string CurrentDeisgnation { get; set; }

        /// <summary>
        /// this properties of employee daily report
        /// </summary>
        public int EmployeeWorkId { get; set; }
        public string Topic { get; set; }
        public int EmployeeId { get; set; }

        public int workby { get; set; }
        public int WorkFor { get; set; }
        public string WorkDone { get; set; }
        public string WorkPending { get; set; }
        public string ReasonPending { get; set; }
        public string Remark { get; set; }
        public DateTime LastDateOfComplate { get; set; }

        public string TaskUpdateDate { get; set; }

        public string Instruction { get; set; }



        public int EmployeeWorkDetailsId { get; set; }
        // public int EmployeeWorkId { get; set; }
        public string EmployeeName { get; set; }
        // public int EmployeeId { get; set; }
        //   public string WorkDone { get; set; }
        public string PendingWork { get; set; }
        public string ReasonForPending { get; set; }
        // public string Remark { get; set; }




        public int CourseDetailsId { get; set; }
        public string CourseName { get; set; }
        public string ImagesName { get; set; }
        //public string  Description { get; set; } 
        public string CoursesDetails { get; set; }
        public string CourseDuration { get; set; }

        public int ClassCoursesId { get; set; }
        public string CoursesName { get; set; }
        public int HomeHerosId { get; set; }

        /// <summary>
        /// gallery details
        /// </summary>


        public int GalleryId { get; set; }
        //public string TitleName { get; set; }
        public string ImageName { get; set; }
        //public string Description { get; set; }

        public int YoutubeId { get; set; }
        public string Link { get; set; }
        public int SyllabusId { get; set; }
        // public string ClassId { get; set; }
        public int CoursesId { get; set; }
        // public string SubjectId { get; set; }
        public string ContentBy { get; set; }
        public string SyllabusDescription { get; set; }
        //   public string Date { get; set; }
        //  public string EmployeeId { get; set; }

        public int ParentsSpeaksId { get; set; }
        public int StudentSpeaksId { get; set; }


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


        #endregion

        #region "Fill CoursesHome"
        public DataSet FillCoursesHome()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("[USP_I_FillMasterDetails]"
                    , new SqlParameter("@CourseDetailsId", CourseDetailsId)
                    , new SqlParameter("@CALL_TYPE", "CoursesDetailsById")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        #endregion "End Fill User Grid view ..."

        #region "UPDATE Home Courses"
        public DataSet UpdateHomeCourses()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("IdeaMasterUpdate"
                     , new SqlParameter("@CourseName", CourseName)
                     , new SqlParameter("@ImagesName", ImagesName)
                     , new SqlParameter("@Description", Description)
                     , new SqlParameter("@CoursesDetails", CoursesDetails)
                     , new SqlParameter("@CourseDuration", CourseDuration)
                     , new SqlParameter("@CourseDetailsId", CourseDetailsId)
                     , new SqlParameter("@CallType", "UpdateHomeCourses")
               );
            }
            catch (Exception ex)
            {

            }
            return DS;
        }
        #endregion
        #region "Update Parents Speaks"
        public DataSet UpdateParentsSpeaks()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("IdeaMasterUpdate"
                     , new SqlParameter("@ImageName", ImageName)
                     , new SqlParameter("@Description", Description)
                     , new SqlParameter("@TitleName", TitleName)
                     , new SqlParameter("@ParentsSpeaksId", ParentsSpeaksId)
                     , new SqlParameter("@CallType", "UpdateParentsSpeaks")
               );
            }
            catch (Exception ex)
            {

            }
            return DS;
        }
        #endregion
        #region "Update Student Speaks"
        public DataSet UpdateStudentSpeaks()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("IdeaMasterUpdate"
                     , new SqlParameter("@ImageName", ImageName)
                     , new SqlParameter("@Description", Description)
                     , new SqlParameter("@TitleName", TitleName)
                     , new SqlParameter("@StudentSpeaksId", StudentSpeaksId)
                     , new SqlParameter("@CallType", "UpdateStudentSpeaks")
               );
            }
            catch (Exception ex)
            {

            }
            return DS;
        }
        #endregion
        #region "Fill Iset Results"
        public DataSet FillItseResult()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("[USP_I_FillMasterDetails]"
                    , new SqlParameter("@CALL_TYPE", "ItseResult")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        public DataSet FillDristhiTestSheet()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("[USP_I_FillMasterDetails]"
                    , new SqlParameter("@CALL_TYPE", "DristhiTestSheet")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        public DataSet FillRegularSheet()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("[USP_I_FillMasterDetails]"
                    , new SqlParameter("@CALL_TYPE", "RegularSheet")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        public DataSet FillScholerTestSheet()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("[USP_I_FillMasterDetails]"
                    , new SqlParameter("@CALL_TYPE", "ScholerTestSheet")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        #endregion 
        #region "Update Gallery"
        public DataSet UpdateGallery()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("IdeaMasterUpdate"
                     , new SqlParameter("@ImageName", ImageName)
                     , new SqlParameter("@Description", Description)
                     , new SqlParameter("@TitleName", TitleName)
                     , new SqlParameter("@GalleryId", GalleryId)
                     , new SqlParameter("@CallType", "UpdateGallery")
               );
            }
            catch (Exception ex)
            {

            }
            return DS;
        }
        #endregion
        #region "Fill Courses"
        public DataSet FillCourses()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("[USP_I_FillMasterDetails]"
                    , new SqlParameter("@CALL_TYPE", "Courses")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        #endregion "End Fill User Grid view ..."
        #region "Fill HomeHeros"
        public DataSet FillHomeHeros()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("[USP_I_FillMasterDetails]"
                    , new SqlParameter("@CALL_TYPE", "HomeHeros")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        #endregion "End Fill User Grid view ..."
        #region " FillCoursesDetails"
        public DataSet FillCoursesDetails()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("[USP_I_FillMasterDetails]"
                    , new SqlParameter("@CALL_TYPE", "CoursesDetails")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        #endregion "End Fill User Grid view ..."

        public DataSet FillAttendenceStudent()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                    , new SqlParameter("@CALL_TYPE", "FillAttendenceStudent")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }

        #region "Fill Display Exam Info BY CallType...."
        public DataSet DisplayExamInfo()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("[USP_I_FillMasterDetails]"
                    , new SqlParameter("@ClassId", ClassId)
                    , new SqlParameter("@ClassCoursesId", ClassCoursesId)
                    , new SqlParameter("@SubjectId", SubjectId)
                    
                    , new SqlParameter("@CALL_TYPE", "Examinfo")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        #endregion "End Fill User Grid view ..."

        #region "Fill User grid View BY CallType...."
        public DataSet DisplayStudentAbsent()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("[USP_I_FillMasterDetails]"
                    , new SqlParameter("StudentId", StudentId)
                    , new SqlParameter("@CALL_TYPE", "StudentAbsent")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        #endregion "End Fill User Grid view ..."

        #region"Repeter for Class Schdeule"
        public DataSet RepeterCs()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_REPETER"
                    , new SqlParameter("@ClassId", ClassId)
                   , new SqlParameter("CallType", "ClassSchedule")
                );
            }
            catch (Exception ex)
            {

            }
            return DS;
        }
        #endregion

        #region"Repeter for Home Work"
        public DataSet RepeterHw()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_REPETER"
                    , new SqlParameter("@ClassId", ClassId)
                    , new SqlParameter("@ClassCoursesId", ClassCoursesId)
                     , new SqlParameter("@SubjectId", SubjectId)
                    
                    , new SqlParameter("CallType", "homeWork")
                );
            }
            catch (Exception ex)
            {

            }
            return DS;
        }

        public DataSet FillHomeWopkId()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_REPETER"
                    , new SqlParameter("@HomeWorkId", HomeWorkId)
                     , new SqlParameter("CallType", "homeWorkId")
                );
            }
            catch (Exception ex)
            {

            }
            return DS;
        }

        public DataSet FillExamId()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                    , new SqlParameter("@ExamInfoId", ExamInfoId)
                     , new SqlParameter("@CALL_TYPE", "ExaminfoById")
                );
            }
            catch (Exception ex)
            {

            }
            return DS;
        }

        public DataSet DeleteHw()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_DeleteMasterDetails"
                    , new SqlParameter("@ClassId", ClassId)
                   , new SqlParameter("CallType", "DeleteHw")
                );
            }
            catch (Exception ex)
            {

            }
            return DS;
        }
        #endregion

        #region"Repeter for Home Work Answers"
        public DataSet RepeterHwAnswers()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_REPETER"
                    , new SqlParameter("@ClassId", ClassId)
                    , new SqlParameter("@SubjectId", SubjectId)
                    , new SqlParameter("@ClassCoursesId", ClassCoursesId)
                   , new SqlParameter("CallType", "homeWorkAnswers")
                );
            }
            catch (Exception ex)
            {

            }
            return DS;
        }
        #endregion

        #region"News and Event Repeter"
        public DataSet RepeterEvents()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_REPETER"
                    , new SqlParameter("@ClassId", ClassId)
                   , new SqlParameter("CallType", "news_event")
                );
            }
            catch (Exception ex)
            {

            }
            return DS;
        }
        #endregion

        #region"Fill News or Event "
        public DataSet FillNewsAndEvent()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                   // , new SqlParameter("@ClassId", ClassId)
                   , new SqlParameter("@CALL_TYPE", "NewsAndEvent")
                );
            }
            catch (Exception ex)
            {

            }
            return DS;
        }
        #endregion

        #region "Add New Gallary Detail"
        public int AddGallery()
        {
            int ProductID = 0;
            DS = obj_cDataAccess.RunSPReturnDataSet("IdeaMasterInsert"
               , new SqlParameter("@TitleName", TitleName)
               , new SqlParameter("@ImageName", ImageName)
               , new SqlParameter("@Description", Description)
               , new SqlParameter("@CallType", "Gallery")
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
        #endregion 

        #region "Add New Parents Detail"
        public int AddParentsSpeaks()
        {
            int ProductID = 0;
            DS = obj_cDataAccess.RunSPReturnDataSet("IdeaMasterInsert"
               , new SqlParameter("@TitleName", TitleName)
               , new SqlParameter("@ImageName", ImageName)
               , new SqlParameter("@Description", Description)
               , new SqlParameter("@CallType", "ParentsSpeaks")
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
        #endregion

        #region "Add New Parents Detail"
        public int AddStudentSpeaks()
        {
            int ProductID = 0;
            DS = obj_cDataAccess.RunSPReturnDataSet("IdeaMasterInsert"
               , new SqlParameter("@TitleName", TitleName)
               , new SqlParameter("@ImageName", ImageName)
               , new SqlParameter("@Description", Description)
               , new SqlParameter("@CallType", "StudentSpeaks")
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
        #endregion
        #region "Add New Courses Detail"
        public int AddCourses()
        {
            int ProductID = 0;
            DS = obj_cDataAccess.RunSPReturnDataSet("IdeaMasterInsert"
               , new SqlParameter("@CourseName", CourseName)
               , new SqlParameter("@ImagesName", ImagesName)
               , new SqlParameter("@Description", Description)
               , new SqlParameter("@CoursesDetails", CoursesDetails)
               , new SqlParameter("@CourseDuration", CourseDuration)
               , new SqlParameter("@IsActive", IsActive)
               , new SqlParameter("@CallType", "CoursesDetails")
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

        #region "Add Attendance Gridview"
        public int AddAttendanceGridview()
        {
            int ProductID = 0;
            DS = obj_cDataAccess.RunSPReturnDataSet("IdeaMasterInsert"
                //  , new SqlParameter("@StudentId", StudentId)
                //  , new SqlParameter("@ClassId", ClassId)
                // , new SqlParameter("@Absent", Absent)
                , new SqlParameter("@Date", Date)
                // , new SqlParameter("@StudentName", StudentName)
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
        #region "Add Home Work Ans"
        public int AddHomeWorkAns()
        {
            int ProductID = 0;
            DS = obj_cDataAccess.RunSPReturnDataSet("IdeaMasterInsert"
                , new SqlParameter("@SubjectId", SubjectId)
                , new SqlParameter("@ClassCoursesId", ClassCoursesId)
                , new SqlParameter("@ClassId", ClassId)
                , new SqlParameter("@DocFile", DocFile)
                , new SqlParameter("@Date", Date)
                , new SqlParameter("@CallType", "AddHomeWorkAns")
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

        #region "Add Syllabus"
        public int AddSyllabus()
        {
            int ProductID = 0;
            DS = obj_cDataAccess.RunSPReturnDataSet("IdeaMasterInsert"
               , new SqlParameter("@SubjectId", SubjectId)
               , new SqlParameter("@CoursesId", CoursesId)
               , new SqlParameter("@ClassId", ClassId)
               , new SqlParameter("@Date", Date)
               , new SqlParameter("@SyllabusDescription", SyllabusDescription)
                , new SqlParameter("@ContentBy", ContentBy)
                 , new SqlParameter("@EmployeeId", EmployeeId)
               , new SqlParameter("@CallType", "Syllabus")
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
        #endregion
        #region "Add Home Work"
        public int AddHomeWork()
        {
            int ProductID = 0;
            DS = obj_cDataAccess.RunSPReturnDataSet("IdeaMasterInsert"
                , new SqlParameter("@SubjectId", SubjectId)
                , new SqlParameter("@ClassCoursesId", ClassCoursesId)
                , new SqlParameter("@ClassId", ClassId)
                , new SqlParameter("@DocFile", DocFile)
                , new SqlParameter("@Description", Description)
                , new SqlParameter("@CallType", "AddHomeWork")
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
        #endregion
        #region "Add E-Book"
        public int AddEbook()
        {
            int ProductID = 0;
            DS = obj_cDataAccess.RunSPReturnDataSet("IdeaMasterInsert"
                , new SqlParameter("@EbookTitle", EbookTitle)
                , new SqlParameter("@pdffile", pdffile)
                 , new SqlParameter("@CoverPage", CoverPage)
                  , new SqlParameter("@price", price)
                   , new SqlParameter("@Descriptions", Descriptions)
                , new SqlParameter("@CallType", "Ebook")
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
        #region "Insert Carrer data"
        public int AddCarrer()
        {
            try
            {
                DR = obj_cDataAccess.RunSPReturnDR("IdeaMasterInsert"
                 , new SqlParameter("@Email", Email)
                 , new SqlParameter("@CurrentCTC", CurrentCTC)
                 , new SqlParameter("@ExpectedCTC", ExpectedCTC)
                 , new SqlParameter("@CurrentEmployee", CurrentEmployee)
                 , new SqlParameter("@UploadImages", UploadImages)
                 , new SqlParameter("@Degree", Degree)
                 , new SqlParameter("@Degree2", Degree2)
                 , new SqlParameter("@PositionAppliying", PositionAppliying)
                 , new SqlParameter("@Experience", Experience)
                 , new SqlParameter("@Name", Name)
                 , new SqlParameter("@FatherName", FatherName)
                 , new SqlParameter("@Gender", Gender)
                 , new SqlParameter("@Resume", Resume)
                 , new SqlParameter("@Mobile", Mobile)
                 , new SqlParameter("@JobTitle", JobTitle)
                 , new SqlParameter("@Address", Address)
                 , new SqlParameter("@CurrentDeisgnation", CurrentDeisgnation)
                 , new SqlParameter("@CallType", "Resume")

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
        #region "Insert Add Employee Work Upadte"
        public int AddEmployeeWorkUpadte()
        {
            try
            {
                DR = obj_cDataAccess.RunSPReturnDR("IdeaMasterInsert"

                , new SqlParameter("@EmployeeWorkId", EmployeeWorkId)
                , new SqlParameter("@PendingWork", PendingWork)
                , new SqlParameter("@WorkDone", WorkDone)
                , new SqlParameter("@EmployeeId", EmployeeId)
                , new SqlParameter("@TaskUpdateDate", TaskUpdateDate)
                , new SqlParameter("@ReasonForPending", ReasonForPending)
                , new SqlParameter("@Remark", Remark)
                , new SqlParameter("@EmployeeName", EmployeeName)
                , new SqlParameter("@CallType", "EmployeeWorkDetails")
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
        #region "Insert Employee daily work"
        public int AddEmployeeDailyWork()
        {
            try
            {
                DR = obj_cDataAccess.RunSPReturnDR("IdeaMasterInsert"
                , new SqlParameter("@Name", CurrentEmployee)
                , new SqlParameter("@Description", Description)
                , new SqlParameter("@Date", Date)
                , new SqlParameter("@Topic", Topic)
                , new SqlParameter("@EmployeeId", EmployeeId)
                // , new SqlParameter("@workby", workby)
                , new SqlParameter("@LastDateOfComplate", LastDateOfComplate)
                , new SqlParameter("@WorkFor", WorkFor)
                , new SqlParameter("@Instruction", Instruction)
                , new SqlParameter("@CallType", "DailyReport")
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
        #region "Display Product Detail"
        public DataTable DisplayCourseshome()
        {
            try
            {
                DT = obj_cDataAccess.RunSPReturnDataTable("USP_I_FillMasterDetails"
                      , new SqlParameter("@CALL_TYPE", "CoursesDetails")
                    );
            }
            catch (Exception ex)
            {

            }
            return DT;
        }
        #endregion "End Display Product Detail"
        #region "FILL COUNTRY IN DROPDOWN IN REGION PAGE"
        public DataSet DisplayCoursesForStudent()
        {
            DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                 , new SqlParameter("@CALL_TYPE", "CoursesDetailsForStudent")

              );
            return DS;
        }
        #endregion
        #region "Fill Ebook "
        public DataSet FillEbook()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                    , new SqlParameter("@CALL_TYPE", "Ebook")
                    );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        #endregion "End Main Category"
        #region "DELETE Ebook"
        public int DeleteBook()
        {
            try
            {
                DR = obj_cDataAccess.RunSPReturnDR("USP_I_DeleteMasterDetails"
                      , new SqlParameter("@EbookId", EbookId)
                      , new SqlParameter("@CALL_TYPE", "Ebook")
                   );
            }
            catch (Exception ex)
            {
            }
            return RecordStatus;
        }
        #endregion
        #region "DELETE Ebook"
        public int DeleteExamINFO()
        {
            try
            {
                DR = obj_cDataAccess.RunSPReturnDR("USP_I_DeleteMasterDetails"
                      , new SqlParameter("@ExamInfoId", ExamInfoId)
                      , new SqlParameter("@CALL_TYPE", "ExamInfoId")
                   );
            }
            catch (Exception ex)
            {
            }
            return RecordStatus;
        }
        #endregion
        #region "Add Class Schedule"
        public int AddClassSchedule()
        {
            int ProductID = 0;
            DS = obj_cDataAccess.RunSPReturnDataSet("IdeaMasterInsert"
                , new SqlParameter("@FormDate", FormDate)
                , new SqlParameter("@ClassId", ClassId)
                , new SqlParameter("@TillDate", TillDate)
                , new SqlParameter("@pdffile", pdffile)
                , new SqlParameter("@CallType", "AddClassSchedule")
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
        #region "FILL COUNTRY IN DROPDOWN IN REGION PAGE"
        public DataSet StateListDropdown1()
        {
            DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillCountryStateCity1"
                 , new SqlParameter("@CountryId", CountryId)

              );
            return DS;
        }
        #endregion
        #region "FILL city IN DROPDOWN IN city PAGE"
        public DataSet CityList()
        {
            DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillCountryCity"
                 , new SqlParameter("@StateId", StateId)
                 , new SqlParameter("@CountryId", CountryId)


              );
            return DS;
        }
        #endregion
        #region "FILL COUNTRY City"
        public DataSet StateListDropdown2()
        {
            DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillCity"
                 , new SqlParameter("@StateId", StateId)
              );
            return DS;
        }
        #endregion
        #region "FILL COUNTRY State"
        public DataSet CountryListDropdown()
        {
            DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillCountryState"
                , new SqlParameter("@CallType", "CountryState")
                );
            return DS;
        }
        #endregion
        #region "FILL COUNTRY "
        public DataSet CountryList()
        {
            DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillCountryState"
                , new SqlParameter("@CallType", "Country")
                  );
            return DS;
        }
        #endregion
        #region "FILL State "
        public DataSet StateList()
        {
            DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillCountryState"
                , new SqlParameter("@CountryId", CountryId)
                , new SqlParameter("@CallType", "State")
                  );
            return DS;
        }
        #endregion
        #region "FILL City "
        public DataSet CityLists()
        {
            DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillCountryState"
                , new SqlParameter("@CountryId", CountryId)
                 , new SqlParameter("@StateId", StateId)
                , new SqlParameter("@CallType", "City")
                  );
            return DS;
        }
        #endregion
        #region "INSERT REGION"
        public int AddRegion()
        {
            try
            {
                DR = obj_cDataAccess.RunSPReturnDR("USP_I_ADD_REGION"

                      , new SqlParameter("@CountryId", CountryId)
                       , new SqlParameter("@StateId", StateId)
                        , new SqlParameter("RegionName", RegionName)

                   //, new SqlParameter("UniqueIdentification", UniqueIdentification)
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
        #region "INSERT COUNTRY"
        public int AddCountry()
        {
            try
            {
                DR = obj_cDataAccess.RunSPReturnDR("USP_I_ADD_COUNTRY"
                      , new SqlParameter("@CountryName", CountryName)

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
        #region"News Repeter"
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
        #region "Add Youtube"
        public int AddYoutube()
        {
            int ProductID = 0;
            DS = obj_cDataAccess.RunSPReturnDataSet("IdeaMasterInsert"
                , new SqlParameter("@Link", Link)
                , new SqlParameter("@CallType", "Youtube")
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
        #endregion 
        #region "Add Class"
        public int AddClass()
        {
            int ProductID = 0;
            DS = obj_cDataAccess.RunSPReturnDataSet("IdeaMasterInsert"
                , new SqlParameter("@ClassName", ClassName)
                , new SqlParameter("@CallType", "addclass")
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
        #region "INSERT STATE"
        public int AddState()
        {
            try
            {
                DR = obj_cDataAccess.RunSPReturnDR("USP_I_ADD_STATE"

                      , new SqlParameter("@CountryId", CountryId)
                      , new SqlParameter("StateName", StateName)

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
        #region "Add ExamInfo BY Employee"
        public int AddExamInfoByEmployee()
        {
            int ProductID = 0;
            DS = obj_cDataAccess.RunSPReturnDataSet("IdeaMasterInsert"
                , new SqlParameter("@SubjectName", SubjectName)
                , new SqlParameter("@ClassId", ClassId)
                , new SqlParameter("@SubjectId", SubjectId)
                , new SqlParameter("@ClassCoursesId", ClassCoursesId)
                , new SqlParameter("@Syllabus", Syllabus)
                , new SqlParameter("@TestDate", TestDate)
                , new SqlParameter("@TypeOfTest", TypeOfTest)
                , new SqlParameter("@Venue", Venue)
                , new SqlParameter("@CallType", "addExamInfo")
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
        #region "Add Class Cousese"
        public int AddClassCousese()
        {
            int ProductID = 0;
            DS = obj_cDataAccess.RunSPReturnDataSet("IdeaMasterInsert"
                , new SqlParameter("@CoursesName", CoursesName)
                , new SqlParameter("@ClassId", ClassId)
                 , new SqlParameter("@CallType", "AddClassCourses")
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
        #region "Add Subject"
        public int AddSubject()
        {
            int ProductID = 0;
            DS = obj_cDataAccess.RunSPReturnDataSet("IdeaMasterInsert"
                , new SqlParameter("@SubjectName", SubjectName)
                , new SqlParameter("@ClassId", ClassId)
                , new SqlParameter("@ClassCoursesId", ClassCoursesId)
                 , new SqlParameter("@CallType", "addSubject")
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
        #region "DELETE DeleteEbook"
        public int DeleteEbook()
        {
            try
            {
                DR = obj_cDataAccess.RunSPReturnDR("USP_I_DeleteMasterDetails"
                     , new SqlParameter("@EbookId", EbookId)
                     , new SqlParameter("@CALL_TYPE", "EBook")
                   );
            }
            catch (Exception ex)
            {
            }
            return RecordStatus;
        }
        #endregion
        #region "DELETE DailyReport"
        public int DeleteDailyReport()
        {
            try
            {
                DR = obj_cDataAccess.RunSPReturnDR("USP_I_DeleteMasterDetails"
                     , new SqlParameter("@EmployeeWorkId", EmployeeWorkId)
                     , new SqlParameter("@CALL_TYPE", "DailyReport")
                   );
            }
            catch (Exception ex)
            {
            }
            return RecordStatus;
        }
        #endregion
        #region "DELETE Carrer"
        public int DeleteCarrer()
        {
            try
            {
                DR = obj_cDataAccess.RunSPReturnDR("USP_I_DeleteMasterDetails"
                     , new SqlParameter("@CarrerId", CarrerId)
                     , new SqlParameter("@CALL_TYPE", "Carrer")
                   );
            }
            catch (Exception ex)
            {
            }
            return RecordStatus;
        }
        #endregion
        #region "DELETE Class Courses"
        public int DeleteClassCourses()
        {
            try
            {
                DR = obj_cDataAccess.RunSPReturnDR("USP_I_DeleteMasterDetails"
                     , new SqlParameter("@ClassCoursesId", ClassCoursesId)
                     , new SqlParameter("@CALL_TYPE", "ClassCourses")
                   );
            }
            catch (Exception ex)
            {
            }
            return RecordStatus;
        }
        #endregion
        #region "Delete Subject"
        public int DeleteSubject()
        {
            try
            {
                DR = obj_cDataAccess.RunSPReturnDR("USP_I_DeleteMasterDetails"
                     , new SqlParameter("@SubjectId", SubjectId)
                     , new SqlParameter("@CALL_TYPE", "SubjectDel")
                   );
            }
            catch (Exception ex)
            {
            }
            return RecordStatus;
        }
        #endregion
        #region "DELETE Class"
        public int DeleteClass()
        {
            try
            {
                DR = obj_cDataAccess.RunSPReturnDR("USP_I_DeleteMasterDetails"
                     , new SqlParameter("@ClassId", ClassId)
                     , new SqlParameter("@CALL_TYPE", "Class")
                   );
            }
            catch (Exception ex)
            {
            }
            return RecordStatus;
        }
        #endregion
        #region "DELETE Country"
        public int DeleteCountry()
        {
            try
            {
                DR = obj_cDataAccess.RunSPReturnDR("USP_I_DeleteMasterDetails"
                     , new SqlParameter("@CountryId", CountryId)
                     , new SqlParameter("@CALL_TYPE", "Country")
                   );
            }
            catch (Exception ex)
            {
            }
            return RecordStatus;
        }
        #endregion
        #region "DELETE Country State"
        public int DeleteState()
        {
            try
            {
                DR = obj_cDataAccess.RunSPReturnDR("USP_I_DeleteMasterDetails"
                     , new SqlParameter("@CountryId", CountryId)
                     , new SqlParameter("@StateId", StateId)
                     , new SqlParameter("@CALL_TYPE", "State")
                   );
            }
            catch (Exception ex)
            {
            }
            return RecordStatus;
        }
        #endregion
        #region "DELETE Country"
        public int DeleteCity()
        {
            try
            {
                DR = obj_cDataAccess.RunSPReturnDR("USP_I_DeleteMasterDetails"
                      , new SqlParameter("@CountryId", CountryId)
                        , new SqlParameter("@StateId", StateId)
                        , new SqlParameter("@CityId", RegionId)
                     , new SqlParameter("@CALL_TYPE", "City")
                   );
            }
            catch (Exception ex)
            {
            }
            return RecordStatus;
        }
        #endregion
        #region "Delete News And Event"
        public int DeleteNewsAndEvent()
        {
            try
            {
                DR = obj_cDataAccess.RunSPReturnDR("USP_I_DeleteMasterDetails"
                     , new SqlParameter("@NewsEventId", NewsEventId)
                     , new SqlParameter("@CALL_TYPE", "NewsAndEvent")
                   );
            }
            catch (Exception ex)
            {
            }
            return RecordStatus;
        }
        #endregion
        #region "Add Subject"
        public int AddNewsEvent()
        {
            int ProductID = 0;
            DS = obj_cDataAccess.RunSPReturnDataSet("IdeaMasterInsert"
                , new SqlParameter("@Description", Description)
                , new SqlParameter("@ClassCoursesId", ClassCoursesId)
                , new SqlParameter("@ClassId", ClassId)
                , new SqlParameter("@TitleDate", TitleDate)
                , new SqlParameter("@TitleName", TitleName)
                , new SqlParameter("@SubjectId", SubjectId)
                , new SqlParameter("@CallType", "addNewsEvent")
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
        #region "DELETE News"
        public int DeleteNews()
        {
            try
            {
                DR = obj_cDataAccess.RunSPReturnDR("USP_I_DeleteMasterDetails"
                     , new SqlParameter("@NewTitleId", NewsTitleId)
                      , new SqlParameter("@CALL_TYPE", "NEWS")

                   );
            }
            catch (Exception ex)
            {
            }
            return RecordStatus;
        }

        #endregion
        #region "DELETE Syllabus"
        public int DeleteSylabus()
        {
            try
            {
                DR = obj_cDataAccess.RunSPReturnDR("USP_I_DeleteMasterDetails"
                     , new SqlParameter("@SyllabusId", SyllabusId)
                      , new SqlParameter("@CALL_TYPE", "Syllabus")

                   );
            }
            catch (Exception ex)
            {
            }
            return RecordStatus;
        }

        #endregion
        #region "DELETE Youtube"
        public int DeleteYoutube()
        {
            try
            {
                DR = obj_cDataAccess.RunSPReturnDR("USP_I_DeleteMasterDetails"
                     , new SqlParameter("@YoutubeId", YoutubeId)
                      , new SqlParameter("@CALL_TYPE", "Youtube")

                   );
            }
            catch (Exception ex)
            {
            }
            return RecordStatus;
        }
        #endregion
        #region "DELETE Gallery"
        public int DeleteStudentSpeaks()
        {
            try
            {
                DR = obj_cDataAccess.RunSPReturnDR("USP_I_DeleteMasterDetails"
                     , new SqlParameter("@StudentSpeaksId", StudentSpeaksId)
                      , new SqlParameter("@CALL_TYPE", "StudentSpeaks")

                   );
            }
            catch (Exception ex)
            {
            }
            return RecordStatus;
        }
        #endregion
        #region "DELETE Gallery"
        public int DeleteGallery()
        {
            try
            {
                DR = obj_cDataAccess.RunSPReturnDR("USP_I_DeleteMasterDetails"
                     , new SqlParameter("@GalleryId", GalleryId)
                      , new SqlParameter("@CALL_TYPE", "Gallery")

                   );
            }
            catch (Exception ex)
            {
            }
            return RecordStatus;
        }

        public int DeleteParentsSpeaks()
        {
            try
            {
                DR = obj_cDataAccess.RunSPReturnDR("USP_I_DeleteMasterDetails"
                     , new SqlParameter("@ParentsSpeaksId", ParentsSpeaksId)
                      , new SqlParameter("@CALL_TYPE", "ParentsSpeaks")

                   );
            }
            catch (Exception ex)
            {
            }
            return RecordStatus;
        }

        
        #endregion
        #region "DELETE Courses"
        public int DeleteCourses()
        {
            try
            {
                DR = obj_cDataAccess.RunSPReturnDR("USP_I_DeleteMasterDetails"
                     , new SqlParameter("@CourseId", CourseId)
                      , new SqlParameter("@CALL_TYPE", "Course")

                   );
            }
            catch (Exception ex)
            {
            }
            return RecordStatus;
        }
        #endregion
        #region "DELETE Home Heros"
        public int DeleteHomeHeros()
        {
            try
            {
                DR = obj_cDataAccess.RunSPReturnDR("USP_I_DeleteMasterDetails"
                      , new SqlParameter("@HomeHerosId", HomeHerosId)
                      , new SqlParameter("@CALL_TYPE", "HomeHeros")

                   );
            }
            catch (Exception ex)
            {
            }
            return RecordStatus;
        }
        public int DeleteHomeWork()
        {
            try
            {
                DR = obj_cDataAccess.RunSPReturnDR("USP_I_DeleteMasterDetails"
                      , new SqlParameter("@HomeWorkId", HomeWorkId)
                      , new SqlParameter("@CALL_TYPE", "DeleteHomeWorkById")

                   );
            }
            catch (Exception ex)
            {
            }
            return RecordStatus;
        }
        #endregion
        public int DeleteHomeWorkById()
        {
            try
            {
                DR = obj_cDataAccess.RunSPReturnDR("USP_I_DeleteMasterDetails"
                      , new SqlParameter("@HomeWorkId", HomeWorkId)
                      , new SqlParameter("@CALL_TYPE", "DeleteHomeWorkById")

                   );
            }
            catch (Exception ex)
            {

            }
            return RecordStatus;
        }
        #region "DELETE Courses Details"
        public int DeleteCoursesDetails()
        {
            try
            {
                DR = obj_cDataAccess.RunSPReturnDR("USP_I_DeleteMasterDetails"
                     , new SqlParameter("@CourseDetailsId", CourseDetailsId)
                      , new SqlParameter("@CALL_TYPE", "CourseDetails")

                   );
            }
            catch (Exception ex)
            {
            }
            return RecordStatus;
        }
        #endregion
        #region "Fill Home Courses"
        public DataSet FillHomeCourses()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                    , new SqlParameter("@CourseDetailsId", CourseDetailsId)
                    , new SqlParameter("@CALL_TYPE", "Fill_Home_Courses")
                    );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        #endregion
        #region "Edit Gallery"
        public DataSet EditGallery()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                    , new SqlParameter("@GalleryId", GalleryId)
                    , new SqlParameter("@CALL_TYPE", "GalleryBYId")
                    );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        #endregion
        #region "Edit Student Speaks"
        public DataSet EditStudentSpeaks()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                    , new SqlParameter("@StudentSpeaksId", StudentSpeaksId)
                    , new SqlParameter("@CALL_TYPE", "StudentSpeaksBYId")
                    );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        #endregion
        #region "Edit Parents Speaks"
        public DataSet EditParentsSpeaks()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                    , new SqlParameter("@ParentsSpeaksId", ParentsSpeaksId)
                    , new SqlParameter("@CALL_TYPE", "ParentsSpeaksBYId")
                    );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
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
        #region "Display Syllabus by id"
        public DataSet DisplaySyllabusbyid()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("[USP_I_FillMasterDetails]"
                    , new SqlParameter("@SyllabusId", SyllabusId)
                    , new SqlParameter("@CALL_TYPE", "SyllabusId")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        #endregion 
        #region "Display Syllabus"
        public DataSet DisplaySyllabus()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("[USP_I_FillMasterDetails]"
                    , new SqlParameter("@CALL_TYPE", "Syllabus")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        #endregion 
        #region "Display Syllabus for Students"
        public DataSet DisplaySyllabusCourseOneSubjectOne()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("[USP_I_FillMasterDetails]"
                    , new SqlParameter("@ClassId", ClassId)
                    , new SqlParameter("@CourseOne", CourseOne)
                    , new SqlParameter("@CourseOneSubjectOne", CourseOneSubjectOne)
                    , new SqlParameter("@CALL_TYPE", "SyllabusCourseOneSubjectOne")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }


        public DataSet DisplaySyllabusCourseOneSubjectTwo()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("[USP_I_FillMasterDetails]"
                    , new SqlParameter("@ClassId", ClassId)
                    , new SqlParameter("@CourseOne", CourseOne)
                    , new SqlParameter("@CourseOneSubjectTwo", CourseOneSubjectTwo)
                    , new SqlParameter("@CALL_TYPE", "SyllabusCourseOneSubjectTwo")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }

        public DataSet DisplaySyllabusCourseOneSubjectThree()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("[USP_I_FillMasterDetails]"
                    , new SqlParameter("@ClassId", ClassId)
                    , new SqlParameter("@CourseOne", CourseOne)
                    , new SqlParameter("@CourseOneSubjectThree", CourseOneSubjectThree)
                    , new SqlParameter("@CALL_TYPE", "SyllabusCourseOneSubjectThree")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }


        public DataSet DisplaySyllabusCourseOneSubjectFour()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("[USP_I_FillMasterDetails]"
                    , new SqlParameter("@ClassId", ClassId)
                    , new SqlParameter("@CourseOne", CourseOne)
                    , new SqlParameter("@CourseOneSubjectFour", CourseOneSubjectFour)
                    , new SqlParameter("@CALL_TYPE", "SyllabusCourseOneSubjectFour")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }


        public DataSet DisplaySyllabusCourseTwoSubjectOne()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("[USP_I_FillMasterDetails]"
                    , new SqlParameter("@ClassId", ClassId)
                    , new SqlParameter("@CourseTwo", CourseTwo)
                    , new SqlParameter("@CourseTwoSubjectOne", CourseTwoSubjectOne)
                    , new SqlParameter("@CALL_TYPE", "SyllabusCourseTwoSubjectOne")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }

        }

        public DataSet DisplaySyllabusCourseTwoSubjectTwo()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("[USP_I_FillMasterDetails]"
                    , new SqlParameter("@ClassId", ClassId)
                    , new SqlParameter("@CourseTwo", CourseTwo)
                    , new SqlParameter("@CourseTwoSubjectTwo", CourseTwoSubjectTwo)
                    , new SqlParameter("@CALL_TYPE", "SyllabusCourseTwoSubjectTwo")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }



        public DataSet DisplaySyllabusCourseTwoSubjectThree()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("[USP_I_FillMasterDetails]"
                    , new SqlParameter("@ClassId", ClassId)
                    , new SqlParameter("@CourseTwo", CourseTwo)
                    , new SqlParameter("@CourseTwoSubjectThree", CourseTwoSubjectThree)
                    , new SqlParameter("@CALL_TYPE", "SyllabusCourseTwoSubjectThree")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }


        public DataSet DisplaySyllabusCourseTwoSubjectFour()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("[USP_I_FillMasterDetails]"
                    , new SqlParameter("@ClassId", ClassId)
                    , new SqlParameter("@CourseTwo", CourseTwo)
                    , new SqlParameter("@CourseTwoSubjectFour", CourseTwoSubjectFour)
                    , new SqlParameter("@CALL_TYPE", "SyllabusCourseTwoSubjectFour")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }


        public DataSet DisplaySyllabusCourseThreeSubjectOne()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("[USP_I_FillMasterDetails]"
                    , new SqlParameter("@ClassId", ClassId)
                    , new SqlParameter("@CourseThree", CourseThree)
                    , new SqlParameter("@CourseThreeSubjectOne", CourseThreeSubjectOne)
                    , new SqlParameter("@CALL_TYPE", "SyllabusCourseThreeSubjectOne")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }


        public DataSet DisplaySyllabusCourseThreeSubjectTwo()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("[USP_I_FillMasterDetails]"
                    , new SqlParameter("@ClassId", ClassId)
                    , new SqlParameter("@CourseThree", CourseThree)
                    , new SqlParameter("@CourseThreeSubjectTwo", CourseThreeSubjectTwo)
                    , new SqlParameter("@CALL_TYPE", "SyllabusCourseThreeSubjectTwo")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }


        public DataSet DisplaySyllabusCourseThreeSubjectThree()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("[USP_I_FillMasterDetails]"
                    , new SqlParameter("@ClassId", ClassId)
                    , new SqlParameter("@CourseThree", CourseThree)
                    , new SqlParameter("@CourseThreeSubjectThree", CourseThreeSubjectThree)
                    , new SqlParameter("@CALL_TYPE", "SyllabusCourseThreeSubjectThree")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }

        public DataSet DisplaySyllabusCourseThreeSubjectFour()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("[USP_I_FillMasterDetails]"
                    , new SqlParameter("@ClassId", ClassId)
                    , new SqlParameter("@CourseThree", CourseThree)
                    , new SqlParameter("@CourseThreeSubjectFour", CourseThreeSubjectFour)
                    , new SqlParameter("@CALL_TYPE", "SyllabusCourseThreeSubjectFour")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }


        public DataSet DisplaySyllabusCourseFourSubjectOne()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("[USP_I_FillMasterDetails]"
                    , new SqlParameter("@ClassId", ClassId)
                    , new SqlParameter("@CourseFour", CourseFour)
                    , new SqlParameter("@CourseFourSubjectOne", CourseFourSubjectOne)
                    , new SqlParameter("@CALL_TYPE", "SyllabusCourseFourSubjectOne")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }



        public DataSet DisplaySyllabusCourseFourSubjectTwo()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("[USP_I_FillMasterDetails]"
                    , new SqlParameter("@ClassId", ClassId)
                    , new SqlParameter("@CourseFour", CourseFour)
                    , new SqlParameter("@CourseFourSubjectTwo", CourseFourSubjectTwo)
                    , new SqlParameter("@CALL_TYPE", "SyllabusCourseFourSubjectTwo")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }



        public DataSet DisplaySyllabusCourseFourSubjectThree()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("[USP_I_FillMasterDetails]"
                    , new SqlParameter("@ClassId", ClassId)
                    , new SqlParameter("@CourseFour", CourseFour)
                    , new SqlParameter("@CourseFourSubjectThree", CourseFourSubjectThree)
                    , new SqlParameter("@CALL_TYPE", "SyllabusCourseFourSubjectThree")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }


        public DataSet DisplaySyllabusCourseFourSubjectFour()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("[USP_I_FillMasterDetails]"
                    , new SqlParameter("@ClassId", ClassId)
                    , new SqlParameter("@CourseFour", CourseFour)
                    , new SqlParameter("@CourseFourSubjectFour", CourseFourSubjectFour)
                    , new SqlParameter("@CALL_TYPE", "SyllabusCourseFourSubjectFour")
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
        #region "Display Student Speaks"
        public DataSet DisplayStudentSpeaks()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("[USP_I_FillMasterDetails]"
                    , new SqlParameter("@CALL_TYPE", "StudentSpeaks")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        #endregion 
        #region "Display Parents Speaks"
        public DataSet DisplayParentsSpeaks()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("[USP_I_FillMasterDetails]"
                    , new SqlParameter("@CALL_TYPE", "ParentsSpeaks")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        #endregion 
        #region "Display Gallery"
        public DataSet DisplayGallery()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("[USP_I_FillMasterDetails]"
                    , new SqlParameter("@CALL_TYPE", "Gallery")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        #endregion 
        #region "Display Youtube"
        public DataSet DisplayYoutube()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("[USP_I_FillMasterDetails]"
                    , new SqlParameter("@CALL_TYPE", "Youtube")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        #endregion 
        #region "Display Home Youtube"
        public DataSet DisplayHomeYoutube()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("[USP_I_FillMasterDetails]"
                    , new SqlParameter("@CALL_TYPE", "Home_Youtube")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        #endregion 
        #region "Display Gallery"
        public DataSet DisplayHomeGallery()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("[USP_I_FillMasterDetails]"
                    , new SqlParameter("@CALL_TYPE", "HomeGallery")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        #endregion
        #region "Fill Display Carrer"
        public DataSet DisplayCarrer()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("[USP_I_FillMasterDetails]"
                    , new SqlParameter("@CALL_TYPE", "FillCareer")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        #endregion 
        #region "Fill Display Employee Work"
        public DataSet DisplayEmployeeWork()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("[USP_I_FillMasterDetails]"
                    , new SqlParameter("@EmployeeId", EmployeeId)
                    , new SqlParameter("@CALL_TYPE", "EmployeeWork")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        #endregion 
        #region "Fill Display Employee Work"
        public DataSet DisplayUpateTask()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("[USP_I_FillMasterDetails]"
                    , new SqlParameter("@EmployeeWorkId", EmployeeWorkId)
                    , new SqlParameter("@CALL_TYPE", "UpdateEmployeeTask")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        #endregion 
        #region "Active / Inactive Account For Pack Type"
        public int TaskStatusActiveInactive() // METHOD FOR ACTIVE\DEACTIVE
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("IdeaMasterUpdate"
                      , new SqlParameter("@CallType", "Task_ActiveInactive")
                      , new SqlParameter("@RECORD_ID", EmployeeWorkId)
                        );
                RecordStatus = Convert.ToInt32(DS.Tables[0].Rows[0][0]);
            }
            catch (Exception ex)
            { }
            return RecordStatus;
        }
        #endregion
        #region "Fill Display DailyReport"
        public DataSet DisplayDailyReport()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("[USP_I_FillMasterDetails]"
                    , new SqlParameter("@EmployeeId", EmployeeId)
                    , new SqlParameter("@CALL_TYPE", "DailyReport")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        #endregion 
        #region "Fill Display DailyReport For Employee"
        public DataSet DisplayDailyStatusReportEmployee()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("[USP_I_FillMasterDetails]"
                    , new SqlParameter("@CurrentEmployee", CurrentEmployee)
                    , new SqlParameter("@EmployeeId", EmployeeId)
                    , new SqlParameter("@CALL_TYPE", "DailyReportDetailsForEmployee")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        #endregion 
        #region "Fill Display DailyReport"
        public DataSet DisplayDailyStatusReport()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("[USP_I_FillMasterDetails]"
                    , new SqlParameter("@CALL_TYPE", "DailyReportDetails")
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
        public DataSet DisplayClass()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("[USP_I_FillMasterDetails]"
                    , new SqlParameter("@CALL_TYPE", "FillClass")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        #endregion "End Fill User Grid view ..."
        #region "Update Syllabus"
        public int UpdateSyllabus()
        {
            int ProductID = 0;
            DS = obj_cDataAccess.RunSPReturnDataSet("IdeaMasterUpdate"
               , new SqlParameter("@SubjectId", SubjectId)
               , new SqlParameter("@CoursesId", CoursesId)
               , new SqlParameter("@ClassId", ClassId)
               , new SqlParameter("@Date", Date)
               , new SqlParameter("@SyllabusDescription", SyllabusDescription)
                , new SqlParameter("@ContentBy", ContentBy)
                 , new SqlParameter("@EmployeeId", EmployeeId)
                 , new SqlParameter("@SyllabusId", SyllabusId)
               , new SqlParameter("@CallType", "UpdateSyllabus")
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
        #endregion
        #region "UPDATE Class"
        public DataSet UpdateClass()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("IdeaMasterUpdate"
                     , new SqlParameter("@ClassId", ClassId)
                     , new SqlParameter("@ClassName", ClassName)
                     , new SqlParameter("@CallType", "Updateclass")

                 );

            }
            catch (Exception ex)
            {
            }
            return DS;
        }
        #endregion
        #region "UPDATE Youtube"
        public DataSet UpdateYoutube()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("IdeaMasterUpdate"
                     , new SqlParameter("@YoutubeId", YoutubeId)
                     , new SqlParameter("@Link", Link)
                     , new SqlParameter("@CallType", "UpdateYoutube")

                 );

            }
            catch (Exception ex)
            {
            }
            return DS;
        }
        #endregion
        #region "UPDATE Country"
        public DataSet UpdateCountry()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("IdeaMasterUpdate"
                     , new SqlParameter("@CountryId", CountryId)
                     , new SqlParameter("@CountryName", CountryName)
                     , new SqlParameter("@CallType", "UpdateCountry")

                 );

            }
            catch (Exception ex)
            {
            }
            return DS;
        }
        #endregion
        #region "UPDATE State"
        public DataSet UpdateState()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("IdeaMasterUpdate"
                     , new SqlParameter("@StateId", StateId)
                     , new SqlParameter("@StateName", StateName)
                     , new SqlParameter("@CountryId", CountryId)
                     , new SqlParameter("@CallType", "UpdateState")

                 );

            }
            catch (Exception ex)
            {
            }
            return DS;
        }
        #endregion
        #region "UPDATE City"
        public DataSet UpdateCity()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("IdeaMasterUpdate"
                     , new SqlParameter("@StateId", StateId)
                     , new SqlParameter("@RegionId", RegionId)
                     , new SqlParameter("@CountryId", CountryId)
                     , new SqlParameter("@RegionName", RegionName)
                     , new SqlParameter("@CallType", "UpdateCity")

                 );

            }
            catch (Exception ex)
            {
            }
            return DS;
        }
        #endregion
        #region "Fill Class DDL"
        public DataSet FillCoursesddl()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                    , new SqlParameter("@CALL_TYPE", "Courses")
                    );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        #endregion "End Main Category"
        #region "Fill Class DDL"
        public DataSet FillClassDdl()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                    , new SqlParameter("@CALL_TYPE", "Fill_ddl_class")
                    );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        #endregion "End Main Category"
        #region "Fill Student DDL"
        public DataSet FillStudentDdl()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                    , new SqlParameter("@ClassId", ClassId)
                    , new SqlParameter("@CALL_TYPE", "Fill_ddl_Student")
                    );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        #endregion "End Main Category"
        #region "Fill Student"
        public DataSet FillStudent()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                    , new SqlParameter("@ClassId", ClassId)
                    , new SqlParameter("SubjectName", SubjectName)
                    , new SqlParameter("@CALL_TYPE", "Fill_Student_for_Sms")
                    );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }


        public DataSet Fill_Student_for_HomeWork()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                    , new SqlParameter("@ClassId", ClassId)
                    , new SqlParameter("@ClassCoursesId", ClassCoursesId)
                    , new SqlParameter("@SubjectId", SubjectId)
   
                    , new SqlParameter("@CALL_TYPE", "Fill_Student_for_HomeWork")
                    );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
         public DataSet FillStudentByExamInfo()
           {
            try
             {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                    , new SqlParameter("@ClassId", ClassId)
                    , new SqlParameter("@ClassCoursesId", ClassCoursesId)
                    , new SqlParameter("@CALL_TYPE", "Fill_Student_for_Exam_Info")
                    );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        #endregion "End Main Category"
        #region "Fill Class Courses Grid"
        public DataSet FillClassCoursesGrid()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                    , new SqlParameter("@ClassId", ClassId)
                    , new SqlParameter("@CALL_TYPE", "Fill_Courses_Grid")
                    );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        #endregion "End Main Category"
        #region "Fill Subject DDL"
        public DataSet FillClassCourses()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                    , new SqlParameter("@ClassId", ClassId)
                    , new SqlParameter("@CALL_TYPE", "Fill_Courses")
                    );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        #endregion
        #region "Fill Subject for gridview"
        public DataSet FillSubjectGridView()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                    , new SqlParameter("@ClassId", ClassId)
                    , new SqlParameter("@CALL_TYPE", "Fill_Subject_Gridview")
                    );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        #endregion "End Main Category"
        #region "Fill Subject DDL"
        public DataSet FillSubjectDdl()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                    , new SqlParameter("@ClassId", ClassId)
                    , new SqlParameter("@CALL_TYPE", "Fill_ddl_Subject")
                    );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        #endregion "End Main Category"
        #region "Fill Class Courses DDL"
        public DataSet FillClassCoursesDdl()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                    , new SqlParameter("@ClassId", ClassId)
                    //,new SqlParameter("@ClassCoursesId", ClassCoursesId)
                    , new SqlParameter("@CALL_TYPE", "Fill_ClassCourses")
                    );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        #endregion "End Main Category"
        #region "Fill Class Courses DDL"
        public DataSet FillSubjectCoursesGrid()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                    , new SqlParameter("@ClassId", ClassId)
                    , new SqlParameter("@ClassCoursesId", ClassCoursesId)
                    , new SqlParameter("@CALL_TYPE", "Fill_CoursesSujectGrid")
                    );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        #endregion "End Main Category"
        #region "Fill Class Courses DDL"
        public DataSet FillSubjectCourses()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                    , new SqlParameter("@ClassId", ClassId)
                    , new SqlParameter("@ClassCoursesId", ClassCoursesId)
                    , new SqlParameter("@CALL_TYPE", "Fill_CoursesSuject")
                    );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        #endregion "End Main Category"
        #region "Fetch Date"
        public DataSet FetchDate()
        {
            DS = obj_cDataAccess.RunSPReturnDataSet("ideaDate"
             //  ,new SqlParameter("@ExamId", ExamId)
             );
            return DS;
        }
        #endregion
        #region "Fill NTSE_OLYMPIAD "
        public DataSet NTSEOLYMPIAD()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                    , new SqlParameter("@CALL_TYPE", "NTSE_OLYMPIAD")
                    );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        #endregion "End Main Category"
        #region "Fill SYLLABUS11_12 "
        public DataSet FillSYLLABUS1112()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                    , new SqlParameter("@CALL_TYPE", "SYLLABUS11_12")
                    );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        #endregion "End Main Category"
        #region "Fill SYLLABUS9TH10TH "
        public DataSet FillSYLLABUS9TH10TH()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                    , new SqlParameter("@CALL_TYPE", "SYLLABUS9TH10TH")
                    );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        #endregion "End Main Category"
        #region "Fill IITJEE"
        public DataSet IITJEE()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                    , new SqlParameter("@CALL_TYPE", "IITJEE")
                    );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        #endregion "End Main Category"
        #region "Fill NONTEACHINGSTAFF "
        public DataSet FillNONTEACHINGSTAFF()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_FillMasterDetails"
                    , new SqlParameter("@CALL_TYPE", "NONTEACHINGSTAFF")
                    );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        #endregion "End Main Category"
        #region "DELETE ALL"
        public DataSet DeleteAllStudent()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("[USP_I_DeleteMasterDetails]"
                    , new SqlParameter("@CALL_TYPE", "DeleteAllStudent")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        public DataSet DeleteSyllabus()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("[USP_I_DeleteMasterDetails]"
                    , new SqlParameter("@CALL_TYPE", "DeleteSyllabus")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        public DataSet DeleteAllCarrer()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("[USP_I_DeleteMasterDetails]"
                    , new SqlParameter("@CALL_TYPE", "DeleteAllCareer")
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
        public DataSet SearchCareerMultiple()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_SEARCH_MULTIPLE"

                , new SqlParameter("@Name", Name)
                , new SqlParameter("@Mobile", Mobile)
                , new SqlParameter("@Degree", Degree)
                , new SqlParameter("@PositionAppliying", PositionAppliying)
                , new SqlParameter("@Call_Type", "Career")
                );
            }
            catch (Exception)
            { }
            return DS;
        }
        #endregion
        #region "Search Student Multiple"
        public DataSet SearchSyllabusMultiple()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_SEARCH_MULTIPLE"
                //, new SqlParameter("@EmployeeId", EmployeeId)
                , new SqlParameter("@ClassId", ClassId)
                , new SqlParameter("@SubjectId", SubjectId)
                , new SqlParameter("@CoursesId", CoursesId)
                , new SqlParameter("@Call_Type", "Syllabus")

                );
            }
            catch (Exception)
            { }
            return DS;
        }
        #endregion

    }
}
