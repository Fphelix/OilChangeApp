using OilChangeApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OilChangeApp.Controllers
{
    public class OilChangeLogController : Controller
    {   // Create

        // Read
        public ViewResult Add()
        {
            OilChange Smith = new OilChange();
            ViewResult answer = View(Smith);

            return answer;
        }
        public IActionResult Index()

        {
            //Go to the database and get all the References
            //Have the View list all those references
            return View();
        }
        public IActionResult Details(int id = 0)
        {
            // Go to the database and get 1 Reference based on the id that I received
            // HAve the view display that reference

            OilChange JohnDoe;
            JohnDoe = new OilChange();
            JohnDoe.id = id;
            JohnDoe.LastOilChange = "2020-12-05";
            JohnDoe.NextOilChange = "2021-03-31";
            JohnDoe.LastMileage = 50000;
            JohnDoe.NextMileage = 53000;
            JohnDoe.userid = 1;

            return View(JohnDoe);
        }

        // Update
        public IActionResult Edit(int id = 0)
        {
            // Go to the database and get 1 Reference based on the id that I received
            // HAve the view display that reference

            OilChange Alpha;
            Alpha = new OilChange();
            Alpha.id = id;
            Alpha.LastOilChange = "2020-12-05";
            Alpha.NextOilChange = "2021-03-31";
            Alpha.LastMileage = 50000;
            Alpha.NextMileage = 53000;
            Alpha.userid = 1;

            return View(Alpha);
        }

        // Delete
    }
}
