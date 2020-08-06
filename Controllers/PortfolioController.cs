using Microsoft.AspNetCore.Mvc;

namespace Portfolio
{
    public class PortfolioController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View("Index");
        }

        [HttpGet("projects")]
        public ViewResult Projects()
        {
            return View("Projects");
        }

        [HttpGet("{word}")]
        public ViewResult Word(string word)
        {
            return View("Contact", word);
        }
    }
}