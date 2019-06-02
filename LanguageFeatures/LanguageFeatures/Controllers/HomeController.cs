using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LanguageFeatures.Models;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            string[] names = new string[3];
            names


            //List<string> results = new List<string>();

            //foreach (Product p in Product.GetProducts())
            //{
            //    string name = p?.Name ?? "<brak>";
            //    decimal? price = p?.Price ?? 0;
            //    string realtedName = p?.Related?.Name ?? "<brak>";
            //    results.Add(string.Format($"Produkt: {name}, cena: {price}, powiązanie {realtedName}"));
            //}

            //return View(results);
        }
    }
}
