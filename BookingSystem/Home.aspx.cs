using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookingSystem.Models;

namespace BookingSystem
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            // Take input from user
            string fromDate = checkinDate.Text;
            string toDate = checkoutDate.Text;
            int guests = int.Parse(numberOfGuests.Text);
            string roomType = selectRoomType.SelectedValue;

            //Redirect to the results page
                string url = "Results.aspx?fromDate=" + fromDate +
                             "&toDate=" + toDate +
                             "&guests=" + guests +
                             "&roomType=" + roomType;

                Response.Redirect(url);

        }
    }
}