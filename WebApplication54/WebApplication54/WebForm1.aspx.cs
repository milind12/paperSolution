using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication54
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=CELAB5;Initial Catalog=DDU;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from login where username='" + TextBox1.Text.ToString() + "' and password='" + TextBox2.Text.ToString() + "'", con);
            con.Open();
            SqlDataReader sqr = cmd.ExecuteReader();
            if (sqr.Read())
            {
                Session["unm"] = TextBox1.Text.ToString();
                Session["pass"] = TextBox2.Text.ToString();
                Response.Redirect("WebForm2.aspx");


            }

            con.Close();
            Response.Write("Wrong username and password");
        
        }
    }
}