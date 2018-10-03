using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace PetShop
{
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection("Data Source=ABHISHEKS-PC\\SQLEXPRESS01;Initial Catalog=PetDb;Integrated Security=True");
        SqlCommand query;
        SqlDataReader reader;
        ConnectionState state = new ConnectionState();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String U = "";
            String P = "";

            if (RadioButton1.Checked == true)
            {
                if (state == ConnectionState.Open)
                    conn.Close();
                else
                {
                    conn.Open();
                    query = new SqlCommand("Select * from tbl_Register where User_Name='" + TextBox1.Text.Trim() + "'", conn);
                    reader = query.ExecuteReader();
                    while (reader.Read())
                    {

                        U = reader[0].ToString();
                        P = reader[1].ToString();
                    }
                    reader.Close();
                    conn.Close();
                }



                if (U.Equals(TextBox1.Text.Trim()) && P.Equals(TextBox2.Text.Trim()))
                {
                    Session["Name"] = U;
                    Response.Redirect("~/Home.aspx");
                }
                else
                {
                    Response.Write("<script>alert('Invalid User!!!')</script>");
                    TextBox1.Text = "";
                    TextBox2.Text = "";
                    TextBox1.Focus();

                }

            }


            else
            {

                if (TextBox1.Text.Trim().Equals("Abhishek") && TextBox2.Text.Trim().Equals("admin"))
                {
                    Response.Redirect("~/AHome.aspx");
                }
                else
                {
                    Response.Write("<script>alert('Invalid Admin!!!')</script>");
                    TextBox1.Text = "";
                    TextBox2.Text = "";
                    TextBox1.Focus();

                }

            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox1.Focus();
        }
    }
}