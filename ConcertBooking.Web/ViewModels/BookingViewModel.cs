using ConcertBooking.Web.ViewModels.DashboardViewModels;

namespace ConcertBooking.Web.ViewModels
{
    public class BookingViewModel
    {
        public int BookingId { get; set; }
        public DateTime BookingDate { get; set; }
        public string ConcertName { get; set; }
        public List<TicketViewModel> Tickets { get; set; }
    }
}
