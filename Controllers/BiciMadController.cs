using System;
using MásMovilidad.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MásMovilidad.Controllers
{
    public class BiciMadController : Controller
    {        
        private readonly ILogger<BiciMadController> _logger;

        public BiciMadController(ILogger<BiciMadController> logger)
        {
            _logger = logger;
        }

        public IActionResult ShowDetailBiciMad()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ShowDetailBiciMad(IFormCollection form)
        {
            var biciMad = Http_EMT_Client.GetBiciMadDetail(form["idStation"]).Result;

            return PartialView("BiciMad/_ShowBiciMadDetail", biciMad);
        }
    }
}