using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    public class TicketController : Controller
    {
        private readonly IList<Ticket> tickets;

        public TicketController()
        {
            tickets = new List<Ticket>()
            {
                new Ticket(){Id = 1, Name = ".Net meet up", Date = DateTime.Now, Cost = 40.5f, Description = ".Net"},
                new Ticket(){Id = 2, Name = "JS meet up", Date = DateTime.Now, Cost = 30.5f, Description = ".Net"},
                new Ticket(){Id = 3, Name = "ReactJs meet up", Date = DateTime.Now, Cost = 10.4f, Description = ".Net"},
            };
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(tickets);
        }

        public IActionResult BuyTicket(int? id)
        {
            if(id == null)
            {
                return NotFound("The identificator must be set");
            }
            var ticket = tickets.Where(x => x.Id.Equals(id)).FirstOrDefault();
            return Content($"You've bought ticket {ticket.Name} succesfully!");
        }
    }
}
