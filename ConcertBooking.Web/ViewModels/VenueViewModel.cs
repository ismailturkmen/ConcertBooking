using Microsoft.Build.Framework;

namespace ConcertBooking.Web.ViewModels
{
    public class VenueViewModel
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        [Required]
        public string Adress {  get; set; }
        [Required]
        public int SeatCapacity { get; set; }
    }
}
