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
    public partial class Buy1 : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection("Data Source=SGT-PC;Initial Catalog=PetDb;Integrated Security=True");
        SqlCommand query;
        SqlDataReader reader;
        ConnectionState state = new ConnectionState();
        MailCode doMail = new MailCode();
        String Id = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            Random rand = new Random();
            Id = Convert.ToString(rand.Next(10000, 99999));
            Label1.Text = Id;
            Label3.Text = Request.QueryString["Name"];
            Label4.Text = Request.QueryString["Cost"];
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            Label1.Visible = false;
            Label3.Visible = false;
            TextBox1.Focus();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            doMail.MailStudent(TextBox3.Text.Trim(), Id, Label4.Text);
            Response.Write("<script>alert('Your Product has been booked.!!!')</script>");
        }
    }
}