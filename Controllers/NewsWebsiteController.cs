using HtmlAgilityPack;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using System.Text;

using TCMBCurrencies.Models;

namespace TCMBCurrencies.Controllers
{
    public class NewsWebsiteController : Controller
    {
        public IActionResult Index()
        {
            
            string url = "https://www.bloomberght.com/kripto";

            HtmlDocument doc = new HtmlDocument();
            WebClient client = new WebClient();
            client.Encoding = Encoding.UTF8;
            client.Headers.Add("user-agent", Guid.NewGuid().ToString());
            string downloadString = client.DownloadString(url);
            doc.LoadHtml(downloadString);

            if (doc!=null)
            {
                for (int i = 0; i < 7; i++)
                {
                    string xpathAdi = "/html/body/header/div/div[1]/div[1]/div/div/div/ul/li[7]/a/span/small[1]";
                    string xpathFiyat = "/html/body/header/div/div[1]/div[1]/div/div/div/ul/li[7]/a/span/small[2]";
                    string resultTextAdi = doc.DocumentNode.SelectSingleNode(xpathAdi).InnerText;
                    string resultTextFiyat = doc.DocumentNode.SelectSingleNode(xpathFiyat).InnerText;

                    ViewData["Fiyat"] = resultTextFiyat;
                    ViewData["UrunAdi"] = resultTextAdi;

                    return View();
                }
            }
            return Content("hata");            
        }
    }
}
