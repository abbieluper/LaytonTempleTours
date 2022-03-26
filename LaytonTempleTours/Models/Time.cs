using System;
using System.ComponentModel.DataAnnotations;

namespace LaytonTempleTours.Models
{
    public class Time
    {
        [Key]
        [Required]
        public int TimeId { get; set; }
        public DateTime DateTime { get; set; }
        public bool SlotAvailable { get; set; }
    }
}
