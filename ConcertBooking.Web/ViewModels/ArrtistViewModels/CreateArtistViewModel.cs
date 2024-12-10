namespace ConcertBooking.Web.ViewModels.ArrtistViewModels
{
    public class CreateArtistViewModel
    {
        public required string Name { get; set; }
        public string? Bio { get; set; }
        public IFormFile? ImageUrl { get; set; }
    }
}
