namespace ConcertBooking.Web.ViewModels.ConcertViewModels
{
    public class EditConcertViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public IFormFile? ChooseImage { get; set; }
        public DateTime DateTime { get; set; }
        public int VenueId { get; set; }
        public int ArtistId { get; set; }
    }
}
