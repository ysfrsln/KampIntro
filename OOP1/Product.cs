﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Product
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }     //hangi kategoriye dahil oldugu

        public string ProductName { get; set; }  //Ürün ismi

        public double UnitPrice { get; set; }   //Ürünün birim fiyatı

        public int UnitsInStock { get; set; }   //Ürünün stokadedi

    }
}
