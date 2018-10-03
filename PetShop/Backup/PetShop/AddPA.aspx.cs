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
    public partial class AddPA : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-OL50V5R;Initial Catalog=PetDb;Integrated Security=True");
        SqlCommand query;
        SqlDataReader reader;
        ConnectionState state = new ConnectionState();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-OL50V5R;Initial Catalog=PetDb;Integrated Security=True");
            SqlCommand query;
            SqlDataReader reader;
            ConnectionState state = new ConnectionState();
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
                        query = new SqlCommand("insert into tbl_Accessory values('" + DropDownList1.SelectedItem.Text.Trim() + "','" + TextBox2.Text.Trim() + "','" + TextBox3.Text.Trim() + "','" + TextBox4.Text.Trim() + "',@IMG)", conn);
                        query.Parameters.Add(new SqlParameter("@IMG", i));
                        reader = query.ExecuteReader();
                        Response.Write("<script>alert('Your Accessory is Added!!!')</script>");
                        reader.Close();
                        conn.Close();
                    }
                }

                finally
                {
                    conn.Close();
                }
                DropDownList1.SelectedItem.Text = "--Select--";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
                DropDownList1.Focus();
            }
        }
    }
}