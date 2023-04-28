using BookingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace BookingSystem
{
    public partial class MyReservations : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Get the GuestId 
            int userId = int.Parse(Session["UserId"] as string);

            // Create a new instance of the database context
            var db = new fawltyTowersContext();

            // Build a LINQ query that retrieves the reservations
            var query = from reservation in db.Reservations
                        where reservation.GuestId == userId
                        select reservation;

            // Execute the query and return the results
            var reservations = query.ToList();

            if (reservations.Count <= 0)
            {
                lblMessage.Text = "You do not have any reservations.";
            }

            // Bind results to GridView
            gridReservations.DataSource = reservations;
            gridReservations.DataBind();

        }
        protected void gridReservations_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int reservationID = Convert.ToInt32(gridReservations.DataKeys[e.RowIndex].Value);
            using (var context = new fawltyTowersContext())
            {
                Reservations reservation = context.Reservations.SingleOrDefault(r => r.ReservationId == reservationID);
                if (reservation != null)
                {
                    context.Reservations.Remove(reservation);
                    context.SaveChanges();
                    Response.Redirect("MyReservations.aspx");
                }
            }
        }

        protected void logoutButton_Click(object sender, EventArgs e)
        {
            Session["UserId"] = null;
            Response.Redirect("Login.aspx");
        }
    }
}