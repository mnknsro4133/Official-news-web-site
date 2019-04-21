using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


public partial class deneme : System.Web.UI.Page
{
    SqlConnection baglan = new SqlConnection("Data Source=.;Initial Catalog=teknobit;Integrated Security=True");
    DataTable Tablo = new DataTable();
    SqlDataAdapter adtr = new SqlDataAdapter();
    SqlCommand komut = new SqlCommand();


    
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
    {

    }
}