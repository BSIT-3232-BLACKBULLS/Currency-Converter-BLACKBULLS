using Currency_Converter.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Currency_Converter.Controllers
{
    public class CurrencyController : Controller
    {
        private readonly ILogger<CurrencyController> _logger;

        public CurrencyController(ILogger<CurrencyController> logger)
        {
            _logger = logger;
        }

        public IActionResult Convert()
        {
            // Add logic to convert currencies
            return View();
        }

        public IActionResult History()
        {
            // Add logic to display conversion history
            return View();
        }
    }

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
