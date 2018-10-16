using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DataAccess;

namespace BusinessLogic.Admin
{
    public class clsCounter
    {
        #region "Variables Declaration"
        cDataAccess obj_cDataAccess;
        private DataSet DS;
        private SqlDataReader DR;
        private int RecordStatus;
        #endregion

        #region Constructor
        public clsCounter()
        {
            obj_cDataAccess = new cDataAccess();
        }
        #endregion

        #region "Properties"
        public int VisiterId { get; set; }
        public string CallType { get; set; }
        public int VisiterNumber { get; set; }
        #endregion

        #region "Fill vister counter
        public DataSet DisplayCounter()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("[USP_FillVisitercount]"
                );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
        #endregion "End Fill User Grid view ..."
        public DataSet CounterVisiter()
        {
            try
            {
                DS = obj_cDataAccess.RunSPReturnDataSet("USP_UpdateCounter"
                   , new SqlParameter("@VisiterNumber", VisiterNumber)
                   );
                return DS;
            }
            catch (Exception ex)
            {
                return DS;
            }
        }
    }
}
