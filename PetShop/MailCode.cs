using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Net;
using System.Net.Mail;
using System.IO;

namespace PetShop
{
    public class MailCode
    {
        public void MailStudent(String std_Email, String UserId, String Pass)
        {
            MailMessage mm = new MailMessage("shriank16@gmail.com", std_Email);
            mm.Subject = "LOGIN CREDENTIALS";
            mm.Body = "Your Bill Number is : '" + UserId + "' And Cost Is : '" + Pass + "'. You Have to pay cash on delivery.    ";
            mm.IsBodyHtml = false;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            NetworkCredential NetworkCred = new NetworkCredential("shriank16@gmail.com", "meenank123");
            smtp.UseDefaultCredentials = true;
            smtp.Credentials = NetworkCred;
            smtp.Port = 587;
            smtp.Send(mm);


        }
       
    }
}