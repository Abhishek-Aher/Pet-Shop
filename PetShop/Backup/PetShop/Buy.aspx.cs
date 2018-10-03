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
    public partial class Buy : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection("Data Source=SGT-PC;Initial Catalog=PetDb;Integrated Security=True");
        SqlCommand query;
        SqlDataReader reader;
        ConnectionState state = new ConnectionState();
        MailCode doMail = new MailCode();
        String Name = "",OName="";
        protected void Page_Load(object sender, EventArgs e)
        {
            Random rand = new Random();
            String Id = Convert.ToString(rand.Next(10000, 99999));
            Label1.Text = Id;
            Name = Request.QueryString["Breed"];
            OName = Request.QueryString["Owner"];  
            Label3.Text = Name;
            
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
            //if (state == ConnectionState.Open)
            //    conn.Close();
            //else
            //{
            //    conn.Open();
            //    query = new SqlCommand("insert into tbl_Sell values('" + Label1.Text.Trim() + "','" + TextBox1.Text.Trim() + "','" + TextBox2.Text.Trim() + "','" + TextBox3.Text.Trim() + "','" + Label3.Text.Trim() + "','" + Label2.Text.Trim() + "')", conn);
            //    reader = query.ExecuteReader();
            //    doMail.MailStudent(TextBox3.Text.Trim(), Label1.Text.Trim(), Label2.Text.Trim());
            //    Response.Write("<script>alert('Your Booking has been don and bill number is sent on mail!!!')</script>");
            //    reader.Close();
            //    conn.Close();
            //}
            //TextBox1.Text = "";
            //TextBox2.Text = "";
            //TextBox3.Text = "";
            //Label1.Visible = false;            
            //Label3.Visible = false;
            //TextBox1.Focus();
            String E = "";
            if (state == ConnectionState.Open)
                conn.Close();
            else
            {
                conn.Open();
                query = new SqlCommand("Select * from tbl_Register where User_Name='" + OName + "'", conn);
                reader = query.ExecuteReader();
                while (reader.Read())
                    E = reader[2].ToString();
                   
                reader.Close();
                conn.Close();
            }


            //doMail.MailStudent(E, TextBox1.Text.Trim(), TextBox3.Text.Trim());
              Response.Write("<script>alert('Your Request has been don and send to owner!!!')</script>");



        }
    }
}