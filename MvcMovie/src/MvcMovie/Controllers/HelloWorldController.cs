using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome(string name = "User", int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, numTimes: {numTimes}");
        }
    }
}