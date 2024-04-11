using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public string Index()
        {
            return "This is my default action..." +
                "Pique";
        }

       public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}
