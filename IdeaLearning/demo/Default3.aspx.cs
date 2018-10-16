using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class demo_Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        int frist = Convert.ToInt32(txtFrist.Text);
        int second = Convert.ToInt32(txtSecond.Text);
        int sum = frist + second;
        txtSum.Text = sum.ToString();

    }
}