using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using TestProject.Extensions;


namespace TestProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            DateTime paymentDate = new DateTime(2024, 04, 23);

            List<DateTime> holidays = new List<DateTime>
            {
                new DateTime(2024, 04, 23), // Ulusal Egemenlik ve Çocuk Bayramı
                new DateTime(2024, 05, 01), // İşçi Bayramı
                new DateTime(2024, 05, 19), // 19 Mayıs Gençlik ve Spor Bayramı
                new DateTime(2024, 10, 29), // Cumhuriyet Bayramı Bayramı
            };
            DateTime lastPaymentDate = paymentDate.CalculateLastPaymentDate(holidays);

            return View();
        }
    }
}
