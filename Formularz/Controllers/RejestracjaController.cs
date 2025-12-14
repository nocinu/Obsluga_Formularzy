using Microsoft.AspNetCore.Mvc;
using FormularzRejestracji.Models;

namespace FormularzRejestracji.Controllers
{
    public class RejestracjaController : Controller
    {
        [HttpGet]
        public IActionResult Formularz()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Formularz(DaneRejestracji dane)
        {
            if (ModelState.IsValid)
            {
                return View("Potwierdzenie", dane);
            }
            return View(dane);
        }

        public IActionResult Potwierdzenie(DaneRejestracji dane)
        {
            return View(dane);
        }
    }
}