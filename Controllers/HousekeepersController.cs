using Microsoft.AspNetCore.Mvc;
using SafeTips.Models; 

namespace SafeTips.Controllers;

public class HousekeeperController : Controller
{
    public IActionResult Index()
    {
        var housekeepers = new List<Housekeeper>
        {
          new Housekeeper
          {
              Id = 19863245,
              Name = "Marcyne",
              Hotel =  "Grand Vilalge",
              Description = "Has worked here for 5 years"
          },

          new Housekeeper
          {
              Id = 97393749,
              Name = "Garry",
              Hotel = "Bonneville Mount",
              Description = "Has worked here for 7 months"
          }  
        };

        return View(housekeepers);
    }
}
