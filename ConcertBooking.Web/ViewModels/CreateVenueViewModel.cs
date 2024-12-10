using System.ComponentModel.DataAnnotations;

namespace ConcertBooking.Web.ViewModels
{
    public class CreateVenueViewModel
    {
        public required string Name { get; set; }
        [Required]
        public string Adress { get; set; }
        [Required]
        public int SeatCapacity { get; set; }
    }
}
