using CC_LAB1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CC_LAB1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Trucks = TruckList.Trucks;
            ViewBag.AvailRoutes = RouteList.Routes;
            return View();
        }

        [HttpPost]
        public IActionResult ChangeRoute(Truck truck)
        {
           
            Truck t = TruckList.Trucks.First(x => x.truck_num == truck.truck_num );
            t.route_number = truck.route_number;
            ViewBag.Trucks = TruckList.Trucks;
            ViewBag.AvailRoutes = RouteList.Routes;
            return View("Index");
        }

        [HttpPost]
        public IActionResult Delete(Truck truck)
        {

            Truck t = TruckList.Trucks.First(x => x.truck_num == truck.truck_num);
            t.route_number = null;
            ViewBag.Trucks = TruckList.Trucks;
            ViewBag.AvailRoutes = RouteList.Routes;
            return View("Index");
           
        }

        [HttpGet]
        public IActionResult Trucks()
        {
            ViewBag.AvailRoutes = RouteList.Routes;
            return View();
        }
        [HttpPost]
        public IActionResult Trucks(Truck truck)
        {

            if (ModelState.IsValid) 
            {
                TruckList.AddTrucks(truck);
                ViewBag.AvailRoutes = RouteList.Routes;
                ModelState.Clear();
                return View();
            }
            else
            {
                ViewBag.AvailRoutes = RouteList.Routes;
                return View();
            }
           
        }

        [HttpGet]
        public IActionResult Routes()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Routes(Route route)
        {
            
            if (ModelState.IsValid)
            {
                RouteList.AddRoutes(route);
                ModelState.Clear();
                return View();
            }
            else
            {
                return View();
            }

        }


        public IActionResult Summary()
        {
            ViewBag.Trucks = TruckList.Trucks;
            ViewBag.RouteList = RouteList.Routes;
            return View(TruckList.Trucks);
        }

       

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
