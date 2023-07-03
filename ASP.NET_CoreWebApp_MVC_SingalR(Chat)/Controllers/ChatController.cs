using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_CoreWebApp_MVC_SingalR_Chat_.Controllers
{
    public class ChatController : Controller
    {
        // Dictionary static
        public static Dictionary<int, string> Rooms = new Dictionary<int, string>() {
            {1, "Develop"},
            {2, "Video Game"},
            {3, "Technology"},
        };


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Room(int room)
        {
            return View("Roon", room);
        }
    }
}
