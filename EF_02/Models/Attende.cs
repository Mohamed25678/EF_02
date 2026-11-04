using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EF_02.Models
{
    internal class Attende
    {
        
        public int Id { get; set; }
        [Required]
        [MaxLength(150)]

        public string FullName { get; set; }
        [Required]
        [MaxLength(150)]
        public string  Email { get; set; } = null!;
        [Required]
        [MaxLength(150)]
        public string Street { get; set; } = null!;
        [Required]
        [MaxLength(150)]
        public string City { get; set; } = null!;
        [Required]
        [MaxLength(150)]
        
        public string  Countrey { get; set; }
        [Required]
        [MaxLength(150)]
        [Column("ZipCode")]
        public int PostalCode { get; set; }
        public string FullAddress => $"{Street},{City},{Countrey},{PostalCode}";


        public Badge Badge { get; set; } = null!;
    }
}
