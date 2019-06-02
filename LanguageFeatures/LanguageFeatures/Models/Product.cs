﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageFeatures.Models
{
    public class Product
    {
        public string Name { get; set; }
        public decimal? Price { get; set; }

        public static Product[] GetProducts()
        {
            Product kayak = new Product
            {
                Name = "Kajak",
                Price = 275M
            };

            Product lifejacket = new Product
            {
                Name = "Kamizelka ratunkowa",
                Price = 48.95M
            };

            return new Product[] { kayak, lifejacket, null };
        }

    }
}