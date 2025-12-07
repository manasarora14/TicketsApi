using Microsoft.AspNetCore.Mvc;
using TicketsAPI.Models;

namespace TicketsAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TicketsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetTickets()
        {
            var tickets = new List<Ticket>
            {
                new Ticket
                {
                    Id = 1,
                    ShortDescription = "Login issue",
                    Description = "User cannot login with valid credentials",
                    CreatedDate = new DateTime(2025, 1, 10),
                    Severity = "High",
                    TargetDate = new DateTime(2025, 1, 15),
                    Status = "Open"
                },
                new Ticket
                {
                    Id = 2,
                    ShortDescription = "UI bug",
                    Description = "Alignment issue on dashboard",
                    CreatedDate = new DateTime(2025, 1, 5),
                    Severity = "Low",
                    TargetDate = new DateTime(2025, 1, 20),
                    Status = "In Progress"
                }
            };

            return Ok(tickets);
        }
    }
}
