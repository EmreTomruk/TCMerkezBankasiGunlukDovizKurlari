using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using TCMBCurrencies.Models;

namespace TCMBCurrencies.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Currencies CurList;

            WebClient webClient = new WebClient();

            var json = webClient.DownloadString("http://hasanadiguzel.com.tr/api/kurgetir");

            //var result = JsonConvert.DeserializeObject<Dictionary<string, object>>(json);
            //List<CurrenciesModel> CurrencyList = JsonConvert.DeserializeObject<List<CurrenciesModel>>(json);

            CurList = JsonConvert.DeserializeObject<Currencies>(json);


            if (CurList == null)
                return null;

            return View(CurList);
        }
    }
}
