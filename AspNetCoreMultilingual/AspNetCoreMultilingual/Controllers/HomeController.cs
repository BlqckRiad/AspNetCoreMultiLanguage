using AspNetCoreMultilingual.Languages;
using AspNetCoreMultilingual.Models;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.Extensions.Localization;
using System.Diagnostics;

namespace AspNetCoreMultilingual.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHtmlLocalizer<Lang> _htmlLocalizer;

        public HomeController(IHtmlLocalizer<Lang> htmlLocalizer)
            => _htmlLocalizer = htmlLocalizer;

        public IActionResult Index(string culture = "tr-TR")
        {
            ViewBag.PageAbout = _htmlLocalizer["page.About"];
            ViewBag.PageHome = _htmlLocalizer["page.Home"];
            return View();
        }
    }
}