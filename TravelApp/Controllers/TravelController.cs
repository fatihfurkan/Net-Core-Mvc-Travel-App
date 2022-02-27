using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using TravelApp.Models;
using TravelServices.Logic.Models;
using Journey = TravelApp.Models.Journey;

namespace TravelApp.Controllers
{
    public class TravelController : Controller
    {
        private readonly ITravelService _travelService;
        private List<SelectListItem> originLocations;
        private List<SelectListItem> destinationLocations;
        private List<Journey> journeys;

        public TravelController(ITravelService travelService)
        {
            _travelService = travelService;
        }
        public IActionResult Index()
        {

            if (GetLocation().Result)
            {
                ViewData["Title"] = "Index";
                ViewBag.origin = originLocations;
                ViewBag.destination = destinationLocations;
                TempData["DepartureDate"] = TempData["DepartureDate"] ?? DateTime.Now.Date.ToString("dd/MM/yyyy");
            }


            return View();
        }

        /*
         * lists journeys
         */
        public IActionResult Journey(TravelInput travel)
        {

            if (GetJourney(travel).Result && GetLocation().Result)
            { 
                ViewData["OriginText"] = originLocations.Where(x => x.Value == travel.OriginId.ToString()).Select(y => y.Text).FirstOrDefault();
                ViewData["DestinationText"] = destinationLocations.Where(x => x.Value == travel.DestinationId.ToString()).Select(y => y.Text).FirstOrDefault();      
                TempData["OriginId"] = travel.OriginId;
                TempData["DestinationId"] = travel.DestinationId;
                TempData["DepartureDate"] = travel.DepartureDate;
                ViewData["Date"] = DateTime.Parse(travel.DepartureDate).ToString("dd/MM/yyyy");
                ViewData["Title"] = "Journey";
                ViewBag.journeys = journeys;
            }
            
            //@ViewData["Title"] = "33333";
            //if (!ModelState.IsValid)
            //{
            //    return null;
            //}
            return View();
        }

        public async Task<bool> GetLocation()
        {
            var location = await _travelService.GetLocation();

            TempData["OriginId"] = TempData["OriginId"] ?? 349;
            TempData["DestinationId"] = TempData["DestinationId"] ?? 356;
            originLocations = (from x in location.Data.ToList()
                      select new SelectListItem
                      {
                          Text = x.Name,
                          Value = x.Id.ToString(),
                          Selected = x.Id ==  Int32.Parse(TempData["OriginId"].ToString())
                      }).ToList();

            destinationLocations = (from x in location.Data.ToList()
                                    select new SelectListItem
                                    {
                                        Text = x.Name,
                                        Value = x.Id.ToString(),
                                        Selected = x.Id == Int32.Parse(TempData["DestinationId"].ToString())
                                    }).ToList();
            return true;

        }

        /*
         * Brings the journeys according to the search criteria.
         */
        public async Task<bool> GetJourney(TravelInput travel)
        {
            var journey = await _travelService.GetJourney(travel);

            journeys = (from x in journey.Data.ToList()
                        select new Journey
                        {
                            Origin = x.Journey.Origin,
                            Destination = x.Journey.Destination,
                            Arrival = DateTime.Parse(x.Journey.Arrival).ToString("HH:mm"),
                            Departure = DateTime.Parse(x.Journey.Departure).ToString("HH:mm"),
                            OriginalPrice = x.Journey.OriginalPrice.ToString() + " " + x.Journey.Currency
                        }).OrderBy(x => x.Departure).ToList();

            return true;

        }
    }
}
