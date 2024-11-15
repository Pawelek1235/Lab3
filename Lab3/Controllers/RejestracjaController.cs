using Microsoft.AspNetCore.Mvc;
using Lab3.Models;

namespace Lab3.Controllers
{
   
    public class RejestracjaController : Controller
    {

        [HttpGet]
        public IActionResult Formularz()
        {
            return View();
        }

     
        [HttpPost]
        public IActionResult Formularz(RejestracjaModel model)
        {
            if (ModelState.IsValid) 
            {
          
                return View("Wynik", model);
            }

          
            return View(model);
        }

  
        public IActionResult Wynik(RejestracjaModel model)
        {
            return View(model); 
        }
    }

}
