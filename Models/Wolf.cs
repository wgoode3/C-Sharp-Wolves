using System;
using System.ComponentModel.DataAnnotations;

namespace Wolves.Models
{
    public class Wolf
    {
        [Key]
        public int WolfId { get; set; }
        [Required]
        [MinLength (2)]
        public string Name {get;set;}
        [Required]
        [MinLength (3)]
        public string Type {get;set;}
        [Required]
        [InPast]
        public DateTime DOB {get;set;}

    }
}