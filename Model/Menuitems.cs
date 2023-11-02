using mini_big_mammas_pizzaria.Services;
using System.Xml.Linq;

namespace mini_big_mammas_pizzaria.Model
{
    public class Menuitems
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public double Price { get; set; }

        public Menuitems()
        {
            Name = "";
            Number = 0;
            Price = 0;
        }
        public Menuitems(int number, string name, double price)
        {
            Number = number;
            Price = price;
            Name = name;
        }
    }
}
