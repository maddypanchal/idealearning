using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System;
using System.Text;

public partial class demo_Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

     Label1.Text  =   Label1.Text.Replace("Label", "ss");

    }
}