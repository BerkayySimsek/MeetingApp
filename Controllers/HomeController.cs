using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers;

public class HomeController : Controller
{
    // localhost
    // localhost/home
    // // localhost/home/index
    public IActionResult Index()
    {
        int clock = DateTime.Now.Hour;

        //ViewBag.Hello = clock > 12 ? "İyi Günler" : "Günaydın";
        //ViewBag.UserName = "Berkay";

        ViewData["Hello"] = clock > 12 ? "İyi Günler" : "Günaydın";
        ViewData["UserName"] = "Berkay";

        var meetingInfo = new MeetingInfo()
        {
            Id = 1,
            Location = "İstanbul, Haliç Kongre Merkezi",
            Date = new DateTime(2026, 03, 03, 20, 0, 0),
            NumberOfPeople = 100
        };

        return View(meetingInfo);
    }
}
