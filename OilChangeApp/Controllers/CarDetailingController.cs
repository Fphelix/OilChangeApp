using Microsoft.AspNetCore.Mvc;
using OilChangeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OilChangeApp.Controllers
{
    public class CarDetailingController : Controller
    {
        //Methods
        //Create

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(CarDetailing c)
        {  
            if(ModelState.IsValid)
            {
                return RedirectToAction("CarDetailingDetails", c);
            }

            return View(c);
        }

        [HttpGet]
        public IActionResult EditCarDetailing(int id)
        {  
            //Need To: Use "id" to go to the database and get an Education record.
            //For now..pretend...fake it
            CarDetailing c = new CarDetailing();

            c.Id = 1;
           // c.LastService = 10 - 22 - 2021;
            c.ProvidersName = "Don Joe";            
            c.CoompanyName = "Pep Boys";
            c.ContactInfo = "9102585746";
            return View(c);

        }

        [HttpPost]
        public IActionResult EditCarDetailing(CarDetailing updatedCarDetailing)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("CarDetailingDetails", updatedCarDetailing);
               
            }
            return View(updatedCarDetailing);

        }


        public IActionResult CarDetailingDetails(CarDetailing c)
        {
            return View(c);
        }
        //Read
      
    }
}
