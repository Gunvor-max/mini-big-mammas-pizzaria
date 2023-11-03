using mini_big_mammas_pizzaria.Services;
using System;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace mini_big_mammas_pizzaria.Model
{
    public class Items
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public double Price { get; set; }

        public Items()
        {
            Name = "";
            Price = 0;
        }
        public Items(string name, double price)
        {
            Price = price;
            Name = name;
        }
    }
}
