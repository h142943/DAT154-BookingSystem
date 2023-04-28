using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BookingSystem.Models
{
    public partial class Service
    {
        public int ServiceId { get; set; }
        public int RoomNumber { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }

        public virtual Rooms RoomNumberNavigation { get; set; }
    }
}
