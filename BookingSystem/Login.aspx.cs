using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookingSystem.Models;
using System.Web.Security;

namespace BookingSystem
{
    public partial class Login : Page
    {

        protected void loginButton_Click(object sender, EventArgs e)
        {
            using (var db = new fawltyTowersContext())
            {
                var username = txtUsername.Text;
                var password = txtPassword.Text;

                var user = db.Guest.SingleOrDefault(u => u.UserName == username && u.Password == password);

                if (user != null)
                {
                    Session["UserId"] = user.GuestId.ToString();
                    Response.Redirect("home.aspx");
                }
                else
                {
                    lblMessage.Text = "Invalid username or password.";
                }
            }
        }
    }
}