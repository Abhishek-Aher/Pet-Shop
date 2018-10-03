using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace PetShop
{

    public partial class Cp : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection("Data Source=ABHISHEKS-PC\\SQLEXPRESS01;Initial Catalog=PetDb;Integrated Security=True");
        SqlCommand query;
        SqlDataReader reader;
        ConnectionState state = new ConnectionState();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox2.Text = "";
            TextBox2.Focus();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (state == ConnectionState.Open)
                conn.Close();
            else
            {
                conn.Open();
                query = new SqlCommand("Update tbl_Register set Password='" + TextBox2.Text.Trim() + "' where User_Name='" + Session["Name"].ToString() + "'", conn);
                reader = query.ExecuteReader();
                Response.Write("<script>alert('Password has been changed Successfully.......!!!')</script>");
                reader.Close();
                conn.Close();
                TextBox2.Text = "";
                TextBox2.Focus();
            }
        }
    }
}