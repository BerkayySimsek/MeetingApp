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


        ViewData["Hello"] = clock > 12 ? "İyi Günler" : "Günaydın";
        int UserCount = Repository.Users.Where(x => x.WillAttend == true).Count();

        var meetingInfo = new MeetingInfo()
        {
            Id = 1,
            Location = "İstanbul, Haliç Kongre Merkezi",
            Date = new DateTime(2026, 03, 03, 20, 0, 0),
            NumberOfPeople = UserCount,
        };

        return View(meetingInfo);
    }
}
