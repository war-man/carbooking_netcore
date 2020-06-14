using System;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using CarBooking.Data;
using CarBooking.Models;
using CarBooking.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarBooking.Admin.Controllers {
    [Route ("admin/book-ticket")]
    [Authorize (Roles = "Admin")]
    public class BookTicketController : Controller {

        private ApplicationDbContext _context;

        public BookTicketController (
            ApplicationDbContext context
        ) {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index () {
            var data = from car in _context.Cars
            join ticket in _context.Tickets on car.Id equals ticket.CarId
            join employee in _context.Employees.Where (e => e.Position == Position.MainDriver) on car.Id equals employee.CarId
            join route in _context.Routes on ticket.RouteId equals route.Id
            select new TicketViewModel () {
                Id = route.Id,
                CarCode = car.CarCode,
                RouteName = route.StartPoint + " - " + route.EndPoint,
                Phone = employee.Phone,
                CreatedAt = DateTime.Now
            };
            var result = data.Distinct ().ToList ();
            return View ("Views/Admin/BookTicket/Index.cshtml", result);
        }

        [HttpGet ("{id}")]

        public async Task<IActionResult> List (int id) {
            return View ("Views/Admin/BookTicket/List.cshtml");
        }

    }
}