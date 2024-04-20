using Microsoft.AspNetCore.Mvc;

namespace Currency_Converter.Controllers
{
    public class ConversionRateController : Controller
    {
        private readonly ILogger<ConversionRateController> _logger;

        public ConversionRateController(ILogger<ConversionRateController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            // Add logic to display current conversion rates
            return View();
        }

        public IActionResult UpdateRates()
        {
            // Add logic to update conversion rates
            return RedirectToAction("Index");
        }
    }
}
