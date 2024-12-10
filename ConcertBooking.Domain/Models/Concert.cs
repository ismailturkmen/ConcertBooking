using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcertBooking.Domain.Models
{
    public class Concert
    {
        [Key]
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public string ImageUrl { get; set; }
        [Required]
        public DateTime DateTime { get; set; }
        [Required]
        [ForeignKey("VenueId")]

        public int VenueId { get; set; } //Default Convention , VenueId working as a foreign key
        public Venue Venue { get; set;}
        [Required]
        [ForeignKey("ArtistId")]

        public int ArtistId { get; set; } //Default Convention , ArtistId working as a foreign key
        public  Artist Artist { get; set; }

        public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
    }
}
