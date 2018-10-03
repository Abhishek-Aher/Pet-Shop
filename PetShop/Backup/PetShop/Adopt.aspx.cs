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
    public partial class Adopt : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection("Data Source=SGT-PC;Initial Catalog=PetDb;Integrated Security=True");
        SqlCommand query;
        SqlDataReader reader;
        ConnectionState state = new ConnectionState();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox1.Focus();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (!FileUpload1.HasFile)
                Response.Write("<script>alert('Please Select Image First..!!!')</script>");
            else
            {
                int length = FileUpload1.PostedFile.ContentLength;
                byte[] i = new byte[length];
                FileUpload1.PostedFile.InputStream.Read(i, 0, length);

                try
                {
                    if (state == ConnectionState.Open)
                        conn.Close();
                    else
                    {
                        conn.Open();
                        query = new SqlCommand("insert into tbl_Adopt values('" + TextBox1.Text.Trim() + "','" + TextBox2.Text.Trim() + "','" + TextBox3.Text.Trim() + "','" + TextBox4.Text.Trim() + "',@IMG,'" + TextBox5.Text.Trim() + "')", conn);
                        query.Parameters.Add(new SqlParameter("@IMG", i));
                        reader = query.ExecuteReader();
                        Response.Write("<script>alert('Your Request is saved!!!')</script>");
                        reader.Close();
                        conn.Close();
                    }
                }

                finally
                {
                    conn.Close();
                }
            }
        }
    }
}