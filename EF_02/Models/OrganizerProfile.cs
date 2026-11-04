using System;
using System.Collections.Generic;
using System.Text;

namespace EF_02.Models
{
    internal class OrganizerProfile
    {
        public int Id { get; set; }
        public string? BioGraphy { get; set; }
        public string? WebsitUrl { get; set; }
        public string? LogUrl { get; set; }
        public int OrganizerId { get; set; }
        public Organizer Organizer { get; set; } = null!;


    }
}
