using Microsoft.AspNetCore.Mvc;
using MVCBooking.Models;

namespace MVCBooking.Controllers
{
    public class BookingController : Controller
    {
        private static List<HotelBooking> bookings = new List<HotelBooking>();
        private static int nextId = 1;
        public IActionResult Index()
        {
            return View(bookings);
        }
        public IActionResult Create()
        {
            return View();
        }

        public IActionResult CreateBooking(HotelBooking newBooking)
        {
            if (!ModelState.IsValid)
            {
                return View("Create", newBooking);
            }
            newBooking.Id = nextId++;
            bookings.Add(newBooking);

            return RedirectToAction("Index");
        }
    }
}
