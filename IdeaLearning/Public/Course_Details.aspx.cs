using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using BusinessLogic.Admin;
using DataAccess;

public partial class Public_Course_Details : System.Web.UI.Page
{
    #region "VARIABLE DECLARATION"
  
    private clsMaster objMaster = new clsMaster();
    private DataSet DS;
 
    public int CourseDetailsId;
    #endregion "End VARIABLE DECLARATION"
   

    protected void Page_Load(object sender, EventArgs e)
    
    {
        if (string.IsNullOrEmpty(Request.QueryString["Cid"]))
        {
            Response.Redirect("Courses.aspx", false);
        }
        else
        {
            CourseDetailsId = Convert.ToInt32(Request.QueryString["Cid"].ToString());

            fillCourses();
          
        }

    }

    private void fillCourses()
    {
        objMaster.CourseDetailsId = CourseDetailsId;
        DS = objMaster.FillCoursesHome();

        if (DS.Tables[0].Rows.Count > 0)
        {
            foreach (DataRow row in DS.Tables[0].Rows)
            {
                lblCourseName.Text = row["CourseName"].ToString();
                lblCoursesDetails.Text = row["CoursesDetails"].ToString();
                lblCourseDuration.Text=row["CourseDuration"].ToString();
           
     
        
            }
        }

    }
}