using Microsoft.AspNetCore.Mvc;

namespace Ark.News.Web.Api
{
    public class NewsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
