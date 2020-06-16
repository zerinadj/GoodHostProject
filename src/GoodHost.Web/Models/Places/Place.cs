using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GoodHost.Web.Models.Places
{
    public class Place
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Rooms { get; set; }
        [Required]
        public int MaxOfGuests { get; set; }
        [Required]
        public string Kind { get; set; }
       
    }
}