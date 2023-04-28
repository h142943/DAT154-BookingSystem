using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BookingSystem.Models
{
    public partial class Rooms
    {
        public Rooms()
        {
            Cleaning = new HashSet<Cleaning>();
            Maintenance = new HashSet<Maintenance>();
            Reservations = new HashSet<Reservations>();
            Service = new HashSet<Service>();
        }

        public int RoomNumber { get; set; }
        public int Beds { get; set; }
        public string Quality { get; set; }

        public virtual ICollection<Cleaning> Cleaning { get; set; }
        public virtual ICollection<Maintenance> Maintenance { get; set; }
        public virtual ICollection<Reservations> Reservations { get; set; }
        public virtual ICollection<Service> Service { get; set; }
    }
}
