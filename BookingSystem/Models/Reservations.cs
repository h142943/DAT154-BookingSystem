using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BookingSystem.Models
{
    public partial class Reservations
    {
        public int ReservationId { get; set; }
        public int RoomNumber { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int? GuestId { get; set; }

        public virtual Guest Guest { get; set; }
        public virtual Rooms RoomNumberNavigation { get; set; }
    }
}
