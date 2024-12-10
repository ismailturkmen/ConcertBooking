using ConcertBooking.Application.Services.Interfaces;
using ConcertBooking.Domain.Models;
using ConcertBooking.Web.ViewModels;
using ConcertBooking.Web.ViewModels.ArrtistViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ConcertBooking.Web.Controllers
{
    [Authorize(Roles = "Admin")]
    public class VenuesController : Controller
    {
        private IVenueService _venueService;

        public VenuesController(IVenueService venueService)
        {
            _venueService = venueService;
        }

        public IActionResult Index()
        {
            List<VenueViewModel> vm = new List<VenueViewModel>();
            var venues = _venueService.GetAllVenue();
            foreach (var item in venues)
            {
                vm.Add(new VenueViewModel { Id = item.Id, Name = item.Name, Adress = item.Address, SeatCapacity = item.SeatCapacity });

            }
            return View(vm);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateVenueViewModel vm)
        {
            var venue = new Venue
            { Name = vm.Name, Address = vm.Adress, SeatCapacity = vm.SeatCapacity };
            _venueService.SaveVenue(venue);

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var venue = _venueService.GetVenue(id);
            var vm = new VenueViewModel
            { Id = venue.Id, Name = venue.Name, Adress = venue.Address, SeatCapacity = venue.SeatCapacity };
            return View(vm);
        }
        [HttpPost]
        public IActionResult Edit(VenueViewModel vm)
        {
            var venue = _venueService.GetVenue(vm.Id);
            _venueService.UpdateVenue(venue);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var venue = _venueService.GetVenue(id);
            _venueService.DeleteVenue(venue);
            return RedirectToAction("Index");
        }
    }
}
