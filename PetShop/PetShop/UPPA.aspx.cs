﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace PetShop
{
    public partial class UPPA : System.Web.UI.Page
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
            if (state == ConnectionState.Open)
                conn.Close();
            else
            {
                conn.Open();
                query = new SqlCommand("delete from tbl_Accessory where Category='" + DropDownList1.SelectedItem.Text.Trim() + "' and Name='" + DropDownList2.SelectedItem.Text.Trim() + "'", conn);
                reader = query.ExecuteReader();
                Response.Write("<script>alert('Records Deleted.!!!')</script>");
                reader.Close();
                conn.Close();
            }

            DropDownList1.SelectedItem.Text = "--Select--";
            DropDownList2.SelectedItem.Text = "--Select--";
            TextBox5.Text = ""; 
            TextBox4.Text = "";            
            Image2.ImageUrl = null;
            DropDownList1.Focus();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (state == ConnectionState.Open)
                conn.Close();
            else
            {
                conn.Open();
                query = new SqlCommand("Update tbl_Accessory set Description='" + TextBox4.Text.Trim() + "',Cost='"+TextBox5.Text.Trim()+"' where Category='" + DropDownList1.SelectedItem.Text.Trim() + "' and Name='" + DropDownList2.SelectedItem.Text.Trim() + "' ", conn);
                reader = query.ExecuteReader();
                Response.Write("<script>alert('Records Updated.!!!')</script>");
                reader.Close();
                conn.Close();
            }

            DropDownList1.SelectedItem.Text = "--Select--";
            DropDownList2.SelectedItem.Text = "--Select--";
            TextBox5.Text = ""; 
            TextBox4.Text = "";
            Image2.ImageUrl = null;
            DropDownList1.Focus();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (state == ConnectionState.Open)
                conn.Close();
            else
            {
                conn.Open();
                query = new SqlCommand("Select * from tbl_Accessory where Category='" + DropDownList1.SelectedItem.Text.Trim() + "' ", conn);
                reader = query.ExecuteReader();
                while (reader.Read())
                    DropDownList2.Items.Add(reader[1].ToString());
                reader.Close();
                conn.Close();
            }
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (state == ConnectionState.Open)
                conn.Close();
            else
            {
                conn.Open();
                query = new SqlCommand("Select * from tbl_Accessory where Category='" + DropDownList1.SelectedItem.Text.Trim() + "' and Name='" + DropDownList2.SelectedItem.Text.Trim() + "'", conn);
                reader = query.ExecuteReader();
                while (reader.Read())
                {
                    TextBox4.Text = reader[3].ToString();
                    TextBox5.Text = reader[2].ToString();
                    byte[] img = (byte[])(reader[4]);
                    if (img == null)
                    {
                        Image2.ImageUrl = null;
                    }

                    else
                    {
                        string base64String = Convert.ToBase64String(img, 0, img.Length);
                        Image2.ImageUrl = "data:image/jpg;base64," + base64String; ;
                    }

                }
                reader.Close();
                conn.Close();
            }
        }
    }
}