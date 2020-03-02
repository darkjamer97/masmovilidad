using System;
using MásMovilidad.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MásMovilidad.Controllers
{
    public class EMTController : Controller
    {        
        private readonly ILogger<EMTController> _logger;

        public EMTController(ILogger<EMTController> logger)
        {
            _logger = logger;
        }
        public ViewResult Index()
        {
            return View();
        }

        public ViewResult ShowStopDetail()
        {
            return View();
        }


        [HttpPost]
        public IActionResult ShowStopDetail(IFormCollection form)
        {
            var busDetail = Http_EMT_Client.GetBusDetail(form["stopId"].ToString()).Result;

            return PartialView("StopDetail/_StopDetail", busDetail);
        }

        public ViewResult showTimeArrivalBus()
        {
            return View();
        }

        [HttpPost]
        public IActionResult showTimeArrivalBus(IFormCollection form)
        {
            var timeArrivalBus = Http_EMT_Client.PostTimeArrive(form["stopId"].ToString(), form["lineArrive"].ToString()).Result;
            
            if (timeArrivalBus.data[0].Incident.ListaIncident != null)
                foreach(var item in timeArrivalBus.data[0].Incident.ListaIncident.data)
                    item.pubDate = DateTime.Parse(item.pubDate).ToString("dd/MM/yyyy");

            return PartialView("TimeArrivalBus/_TimeArrivalBus", timeArrivalBus);
        }
    }
}