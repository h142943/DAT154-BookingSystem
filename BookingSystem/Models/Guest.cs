using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BookingSystem.Models
{
    public partial class Guest
    {
        public Guest()
        {
            Reservations = new HashSet<Reservations>();
        }

        public int GuestId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Reservations> Reservations { get; set; }
    }
}
