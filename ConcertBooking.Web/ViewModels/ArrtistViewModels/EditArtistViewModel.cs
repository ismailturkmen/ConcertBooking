namespace ConcertBooking.Web.ViewModels.ArrtistViewModels
{
    public class EditArtistViewModel
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Bio { get; set; }
        public string? ImageUrl { get; set; }
        public IFormFile? ChooseImage { get; set; }
    }
}
