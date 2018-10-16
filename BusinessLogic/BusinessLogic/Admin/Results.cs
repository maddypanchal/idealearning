using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLogic.Admin
{
    public class Results
    {
        #region "Variables Declaration"
        cDataAccess obj_cDataAccess;
        private DataSet DS;
        private SqlDataReader DR;
        private int RecordStatus;
        private DataTable DT;
        #endregion

        #region Constructor
        public Results()
        {
            obj_cDataAccess = new cDataAccess();
        }
        #endregion

        #region "Properties"
        public int RegularTestId { get; set; }
        public string TestTitle { get; set; }
        public string TestType { get; set; }
        public string TestName { get; set; }
        public string DPP { get; set; }
        public string Syllabus { get; set; }
        public string RegularTestDate { get; set; }
        public string ClassRegular { get; set; }
        public string FilePath { get; set; }
        public bool IsActive { get; set; }

        public int ScholerTestResultId { get; set; }
        public string ScholerTesttype { get; set; }
        public string ScholerTestCode { get; set; }
        public string ScholerTestName { get; set; }
        public DateTime ScholerTestDate { get; set; }
        public string ScholerFilePath { get; set; }

        public int DristhiTestResultId { get; set; }
        public string DristhiTesttype { get; set; }
        public string DristhiTestCode { get; set; }
        public string DristhiTestName { get; set; }
        public DateTime DristhiTestDate { get; set; }
        public string DristhiSyllabus { get; set; }
        public string DristhiFilePath { get; set; }
        public string ClassDristhi { get; set; }

        public string Year { get; set; }
        public string RollNumber { get; set; }

        public int ItseResultId { get; set; }
        public string Name { get; set; }
        public string School { get; set; }
        public string FatherName { get; set; }
        public string MobileNo { get; set; }
        public string MaxMark { get; set; }
        public string ObtainMark { get; set; }
        public decimal PercentageMark { get; set; }
        public string Rank { get; set; }
        public string ScholoarShip { get; set; }
        public string year { get; set; }

        public string Class { get; set; }
        public string Additional_ScholoarShip { get; set; }
        public string Total_ScholoarShip { get; set; }
        public string RollNo { get; set; }
        public string RegistrationNo { get; set; }

        public int DristhiTestSheetId { get; set; }
        //  public int   DristhiTestResultId { get; set; }
        //  public string  Name { get; set; }
        public string RegNo { get; set; }
        public string MmPhy { get; set; }
        public string MmChe { get; set; }
        public string MmMath { get; set; }
        public string MmBio { get; set; }
        public string MmGk { get; set; }
        public string MmEng { get; set; }
        public string MmScience { get; set; }
        public string MoPhy { get; set; }
        public string MoChe { get; set; }
        public string MoMath { get; set; }
        public string MoBio { get; set; }
        public string MoGk { get; set; }
        public string MoEng { get; set; }
        public string MoScience { get; set; }
        public string TotalMaxMarks { get; set; }
        public string TotalMarks { get; set; }
        public string CutOfMarks { get; set; }
        public string Percentage { get; set; }
        public string AIRRank { get; set; }
        public string TotolMarksOfTopper { get; set; }

        public int  RegularTestSheetId  { get; set; }
        public int ScholerTestSheetId  { get; set; }
     
        #endregion

        #region "Search Itse Result"
        public DataSet SearchItseResult()
        {
            DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_Result",
                   new SqlParameter("@RollNo", RollNumber)
                        , new SqlParameter("@Year", Year)
                   , new SqlParameter("CallType", "ItseResult")
            );
            return DS;
        }
        #endregion

        #region "Search Scholer Result"
        public DataSet SearchScholerResult()
        {
            DS = obj_cDataAccess.RunSPReturnDataSet("USP_I_Result",
                  new SqlParameter("@RollNo", RollNumber)
                  , new SqlParameter("@ScholerTestResultId", ScholerTestResultId)
                  , new SqlParameter("CallType", "ScholerShipResult")
           );
            return DS;
        }
        #endregion

        #region"Add ScholerTestSheet Test"
        public int AddScholerTestSheet()
        {
            try
            {
                int ProductID = 0;
                DS = obj_cDataAccess.RunSPReturnDataSet("IdeaMasterInsert"
                   , new SqlParameter("@ScholerTestSheetId", ScholerTestSheetId)
                   , new SqlParameter("@ScholerTestResultId", ScholerTestResultId)
                   , new SqlParameter("@RollNumber", RollNumber)
                   , new SqlParameter("@Name", Name)
                   , new SqlParameter("@School", School)
                   , new SqlParameter("@FatherName", FatherName)
                   , new SqlParameter("@MobileNo", MobileNo)
                   , new SqlParameter("@MaxMark", MaxMark)
                   , new SqlParameter("@ObtainMark", ObtainMark)
                   , new SqlParameter("@PercentageMark", PercentageMark)
                   , new SqlParameter("@Rank", Rank)
                   , new SqlParameter("@ScholoarShip", ScholoarShip)
                   , new SqlParameter("@CallType", "ADD_ScholerTestSheet")

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
            catch (Exception)
            {
                throw;
            }
        }
        #endregion


        #region"Add ITSE Test"
        public int AddITSETest()
        {
            try
            {
                int ProductID = 0;
                DS = obj_cDataAccess.RunSPReturnDataSet("IdeaMasterInsert"
                   , new SqlParameter("@ItseResultId", ItseResultId)
                   , new SqlParameter("@RollNumber", RollNumber)
                   , new SqlParameter("@Name", Name)
                   , new SqlParameter("@School", School)
                   , new SqlParameter("@FatherName", FatherName)
                   , new SqlParameter("@MobileNo", MobileNo)
                   , new SqlParameter("@MaxMark", MaxMark)
                   , new SqlParameter("@ObtainMark", ObtainMark)
                   , new SqlParameter("@PercentageMark", PercentageMark)
                   , new SqlParameter("@Rank", Rank)
                   , new SqlParameter("@ScholoarShip", ScholoarShip)
                   , new SqlParameter("@year", year)
                   , new SqlParameter("@class",Class)
                   , new SqlParameter("@Additional_ScholoarShip", Additional_ScholoarShip )
                   , new SqlParameter("@Total_ScholoarShip", Total_ScholoarShip)

                   , new SqlParameter("@CallType", "ADD_ISET")
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
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region"Add RegularSheet Test"
        public int AddRegularSheet()
        {
            try
            {
                int ProductID = 0;
                DS = obj_cDataAccess.RunSPReturnDataSet("IdeaMasterInsert"
                   , new SqlParameter("@RegularTestSheetId", RegularTestSheetId)
                   , new SqlParameter("@RegularTestId", RegularTestId)
                   , new SqlParameter("@Name", Name)
                   , new SqlParameter("@RegNo", RegNo)
                   , new SqlParameter("@MaxMark", MaxMark)
                   , new SqlParameter("@ObtainMark", ObtainMark)
                   , new SqlParameter("@Percentage", Percentage)
                   , new SqlParameter("@Rank", Rank)
                   , new SqlParameter("@CallType", "ADD_RegularSheet")
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
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region"Add DristhiTestSheet Test"
        public int AddDristhiTestSheet()
        {
            try
            {
                int ProductID = 0;
                DS = obj_cDataAccess.RunSPReturnDataSet("IdeaMasterInsert"
                   , new SqlParameter("@DristhiTestSheetId", DristhiTestSheetId)
                   , new SqlParameter("@DristhiTestResultId", DristhiTestResultId)
                   , new SqlParameter("@Name", Name)
                   , new SqlParameter("@RegNo", RegNo)
                   , new SqlParameter("@MmPhy", MmPhy)
                   , new SqlParameter("@MmChe", MmChe)
                   , new SqlParameter("@MmMath", MmMath)
                   , new SqlParameter("@MmBio", MmBio)
                   , new SqlParameter("@MmGk", MmGk)
                   , new SqlParameter("@MmEng", MmEng)
                   , new SqlParameter("@MmScience", MmScience)
                   , new SqlParameter("@MoPhy", MoPhy)
                   , new SqlParameter("@MoChe", MoChe)
                   , new SqlParameter("@MoMath", MoMath)
                   , new SqlParameter("@MoBio", MoBio)
                   , new SqlParameter("@MoGk", MoGk)
                   , new SqlParameter("@MoEng", MoEng)
                   , new SqlParameter("@MoScience", MoScience)
                   , new SqlParameter("@TotalMaxMarks", TotalMaxMarks)
                   , new SqlParameter("@TotalMarks", TotalMarks)
                   , new SqlParameter("@CutOfMarks", CutOfMarks)
                   , new SqlParameter("@Percentage", Percentage)
                   , new SqlParameter("@AIRRank", AIRRank)
                   , new SqlParameter("@TotolMarksOfTopper", TotolMarksOfTopper)
                   , new SqlParameter("@CallType", "ADD_DristhiTestSheet")
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
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region"Add Regular test Result"
        public int AddRegularTest()
        {
            int ProductID = 0;
            DS = obj_cDataAccess.RunSPReturnDataSet("IdeaMasterInsert"
               , new SqlParameter("@TestTitle", TestTitle)
               , new SqlParameter("@TestType", TestType)
               , new SqlParameter("@TestName", TestName)
               , new SqlParameter("@RegularTestDate", RegularTestDate)
               , new SqlParameter("@FilePath", FilePath)
               , new SqlParameter("@DPP", DPP)
               , new SqlParameter("@Syllabus", Syllabus)
               , new SqlParameter("@IsActive", IsActive)
               , new SqlParameter("@ClassRegular", ClassRegular)
               , new SqlParameter("@CallType", "RegularTest")
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

        #region"Add Dristhi Test"
        public int AddDristhiTest()
        {
            try
            {
                int ProductID = 0;
                DS = obj_cDataAccess.RunSPReturnDataSet("IdeaMasterInsert"
                   , new SqlParameter("@DristhiFilePath", DristhiFilePath)
                   , new SqlParameter("@DristhiTestCode", DristhiTestCode)
                   , new SqlParameter("@DristhiSyllabus", DristhiSyllabus)
                   , new SqlParameter("@DristhiTestDate", DristhiTestDate)
                   , new SqlParameter("@DristhiTestName", DristhiTestName)
                   , new SqlParameter("@DristhiTesttype", DristhiTesttype)
                   , new SqlParameter("@ClassDristhi", ClassDristhi)
                   , new SqlParameter("@CallType", "DristhiTest")
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
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region"Add Scholar Test"
        public int AddScholarTest()
        {
            try
            {
                int ProductID = 0;
                DS = obj_cDataAccess.RunSPReturnDataSet("IdeaMasterInsert"
                   , new SqlParameter("@ScholerFilePath", ScholerFilePath)
                   , new SqlParameter("@ScholerTestCode", ScholerTestCode)
                   , new SqlParameter("@ScholerTestDate", ScholerTestDate)
                   , new SqlParameter("@ScholerTestName", ScholerTestName)
                   , new SqlParameter("@ScholerTesttype", ScholerTesttype)
                   , new SqlParameter("@CallType", "ScholerTest")
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
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region"Display Itse Test"
        public DataSet DisplayItseResult()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("[USP_I_FillMasterDetails]"
                    , new SqlParameter("@Year", Year)
                    , new SqlParameter("@CALL_TYPE", "ItesTest")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        #endregion

        #region"Display Scholer Ship Result"
        public DataSet DisplayScholerShipResult()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("[USP_I_FillMasterDetails]"

                    , new SqlParameter("@CALL_TYPE", "ScholerTest")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        #endregion

        #region"Display Dristhi Test"
        public DataSet DisplayDristhiSheet()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("[USP_I_FillMasterDetails]"
                    , new SqlParameter("@DristhiTestResultId", DristhiTestResultId)
                    , new SqlParameter("@CALL_TYPE", "DristhiSheet")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        #endregion


        #region"Display Dristhi Report"
        public DataSet DisplayDristhiReport()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("[USP_I_FillMasterDetails]"
                    , new SqlParameter("@RegistrationNo", RegistrationNo)
                    , new SqlParameter("@DristhiTestResultId", DristhiTestResultId)
                    , new SqlParameter("@CALL_TYPE", "DristhiReport")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        #endregion

        #region"Display Dristhi Report Max"
        public DataSet DisplayDristhiReportMax()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("[USP_I_FillMasterDetails]"
                    // , new SqlParameter("@RegistrationNo", RegistrationNo)
                      , new SqlParameter("@DristhiTestResultId", DristhiTestResultId)
                      , new SqlParameter("@CALL_TYPE", "DristhiReportMax")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        #endregion

        #region"Display Dristhi Test"
        public DataSet DisplayDristhiTest()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("[USP_I_FillMasterDetails]"
                    , new SqlParameter("@DristhiTestCode", DristhiTestCode)
                    , new SqlParameter("@ClassDristhi", ClassDristhi)
                    , new SqlParameter("@CALL_TYPE", "DristhiTest")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        #endregion

        #region"Display Scholer Ship"
        public DataSet DisplayScholerShip()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("[USP_I_FillMasterDetails]"
                 , new SqlParameter("@CALL_TYPE", "Scholer")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        #endregion

        #region"Display Regular Test"
        public DataSet DisplayRegularTest()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("[USP_I_FillMasterDetails]"
                    , new SqlParameter("@TestType", TestType)
                    , new SqlParameter("@DPP", DPP)
                    , new SqlParameter("@ClassRegular", ClassRegular)
                    , new SqlParameter("@CALL_TYPE", "RegularTest")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        #endregion




        #region"Display Itse Test Year"
        public DataSet DisplayItseResultYear()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("[USP_I_FillMasterDetails]"

                    , new SqlParameter("@CALL_TYPE", "ItesTestYear")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        #endregion

        #region"Scholer Sheet Result "
        public DataSet DisplayScholerSheet()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("[USP_I_FillMasterDetails]"
                    , new SqlParameter("@ScholerTestResultId", ScholerTestResultId)
                    , new SqlParameter("@CALL_TYPE", "ScholerSheet")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        #endregion

        #region"Regular Sheet Result "
        public DataSet DisplayRegularSheet()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("[USP_I_FillMasterDetails]"
                    , new SqlParameter("@RegularTestId", RegularTestId)
                    , new SqlParameter("@CALL_TYPE", "RegularSheet")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        #endregion

        #region"Regular Sheet data  "
        public DataSet DisplayRegularDataSingalStudent()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("[USP_I_FillMasterDetails]"
                    , new SqlParameter("@RegularTestId", RegularTestId)
                    , new SqlParameter("@RegistrationNo", RegistrationNo)
                    , new SqlParameter("@CALL_TYPE", "RegularSheetSingalStudent")
                 );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        #endregion

        #region "DELETE Dristhi Reuslt"
        public int DeleteDristhiReuslt()
        {
            try
            {
                DR = obj_cDataAccess.RunSPReturnDR("USP_I_DeleteMasterDetails"
                    , new SqlParameter("@DristhiTestResultId", DristhiTestResultId)
                    , new SqlParameter("@CALL_TYPE", "DristhiResult")

                   );

            }
            catch (Exception ex)
            {
            }
            return RecordStatus;
        }
        #endregion


        #region "DELETE Regular Reuslt"
        public int DeleteRegularReuslt()
        {
            try
            {
                DR = obj_cDataAccess.RunSPReturnDR("USP_I_DeleteMasterDetails"
                    , new SqlParameter("@RegularTestId", RegularTestId)
                    , new SqlParameter("@CALL_TYPE", "RegularResult")

                   );

            }
            catch (Exception ex)
            {
            }
            return RecordStatus;
        }
        #endregion

        #region "DELETE ITSE Year Data"
        public int DeleteITSEYearData()
        {
            try
            {
                DR = obj_cDataAccess.RunSPReturnDR("USP_I_DeleteMasterDetails"
                    , new SqlParameter("@Year", Year)
                      , new SqlParameter("@CALL_TYPE", "ItseYear")

                   );

            }
            catch (Exception ex)
            {
            }
            return RecordStatus;
        }
        #endregion


    }
}
