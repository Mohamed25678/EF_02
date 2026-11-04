using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EF_02.Models
{
    internal class Organizer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(150)]
        [Required]
     
        public string compneyName { get; set; }

        public bool IsVerified { get; set; }
        public OrganizerProfile? Profile { get; set; } = null!;

        public ICollection<Event> Events { get; set; } = new List<Event>();

    }
}
