using System;
using System.ComponentModel.DataAnnotations;

namespace BookWebinar.Shared
{
    public class Participant
    {
        [Required]
        [StringLength(10, ErrorMessage= "short names only")]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email {get; set;}
    }
}
