using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text=="muhsin"&&TextBox2.Text=="12345")
        {
            Label1.Text = "Hoşgeldiniz";
            Label2.Text = "Muhsin Deniz";
            Label1.Visible = true;
            Label2.Visible = true;
            Image1.Visible = true;
        }
    }
}
