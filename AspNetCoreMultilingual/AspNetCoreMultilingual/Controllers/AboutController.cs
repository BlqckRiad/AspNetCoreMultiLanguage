using AspNetCoreMultilingual.Languages;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace AspNetCoreMultilingual.Controllers
{
    public class AboutController : Controller
    {
        readonly IStringLocalizer<Lang> _stringLocalizer;

        public AboutController(IStringLocalizer<Lang> stringLocalizer)
        {
            _stringLocalizer = stringLocalizer;
        }

        public IActionResult Index()
        {
            ViewBag.TTitle = _stringLocalizer["Title"];
            return View();
        }
    }
}
