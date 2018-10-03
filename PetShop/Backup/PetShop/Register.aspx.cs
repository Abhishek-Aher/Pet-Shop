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
    public partial class Register : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection("Data Source=SGT-PC;Initial Catalog=PetDb;Integrated Security=True");
        SqlCommand query;
        SqlDataReader reader;
        ConnectionState state = new ConnectionState();
        MailCode doMail = new MailCode();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox1.Focus();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (state == ConnectionState.Open)
                conn.Close();
            else
            {
                conn.Close();
                conn.Open();
                query = new SqlCommand("insert into tbl_Register values('" + TextBox1.Text.Trim() + "','" + TextBox2.Text.Trim() + "','" + TextBox4.Text.Trim() + "')", conn);
                reader = query.ExecuteReader();
                doMail.MailStudent(TextBox4.Text.Trim(), TextBox1.Text.Trim(), TextBox2.Text.Trim());
                reader.Close();
                Response.Write("<script>alert('Records Saved & send to your mail id...!!!!!!')</script>");
            }
        }
    }
}