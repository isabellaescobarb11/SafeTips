using Microsoft.AspNetCore.Mvc;
using SafeTips.Models;
using SafeTips.Data;

namespace SafeTips.Controllers;

public class HousekeeperController : Controller
{

    private readonly SafeTipsContext _context;

    public HousekeeperController(SafeTipsContext context)
    {
        _context = context;
    }
    public IActionResult SafeTips()
    {
        return View();
    }
    public IActionResult Housekeepers()
    {
        var housekeepers = _context.Housekeepers.ToList();

        return View(housekeepers);
    }

    public IActionResult Tip(string housekeeper)
    {
        ViewBag.housekeeper = housekeeper;
        return View();
    }

    [HttpPost]
    public IActionResult Tip(string housekeeper, decimal tip, string message)
    {
        ViewBag.Housekeeper = housekeeper;
        ViewBag.Tip = tip;
        ViewBag.Message = message;

        return View();
    }
}
