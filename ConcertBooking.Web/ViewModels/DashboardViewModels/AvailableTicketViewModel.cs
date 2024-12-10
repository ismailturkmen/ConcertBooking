namespace ConcertBooking.Web.ViewModels.DashboardViewModels
{
    public class AvailableTicketViewModel
    {
        public int ConcertId { get; set; }
        public string ConcertName { get; set; }
        public List<int> AvailableSeats { get; set; }
    }
}
