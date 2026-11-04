using System;
using System.Collections.Generic;
using System.Text;

namespace EF_02.Models
{
    public enum BadgeTier
    {
        Standard,
        VIP
    }
    internal class Badge
    {
        public int Id { get; set; }

        public int BadgeNumber { get; set; }

        public DateTime IssuedAt { get; set; }
        public BadgeTier Tier { get; set; }

        public int AttendeId { get; set; }
        public Attende Attendee { get; set; } = null!;

    }
}
