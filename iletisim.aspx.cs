using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class iletisim : System.Web.UI.Page
{

SqlConnection baglan = new SqlConnection("Data Source=.;Initial Catalog=teknobit;Integrated Security=True");
        DataTable Tablo = new DataTable();
        SqlDataAdapter adtr = new SqlDataAdapter();
        SqlCommand komut = new SqlCommand();

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        if (isimtxt.Text=="")
        {
            Label3.Visible = true;
        }

        else if (mailtxt.Text=="")
        {
            Label4.Visible = true;
        }

        else if (konutxt.Text=="")
        {
            Label5.Visible = true;
        }

        else if (mesajtxt.Text=="")
        {
            Label6.Visible = true;
        }

        else

        {
            try
            {
                baglan.Open();
                komut.Connection = baglan;
                komut.CommandText = ("INSERT INTO iletisim_tbl (isim,mail,konu,mesaj) values ('" + isimtxt.Text + "','" + mailtxt.Text + "','" + konutxt.Text + "','" + mesajtxt.Text + "')");
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglan.Close();
            }

            catch
            {

            }

            finally
            {
                Label1.Text = "Mesaj İletildi.";
                Label1.Visible = true;
            }


        }
        }

        

}
