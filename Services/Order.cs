using mini_big_mammas_pizzaria.Model;
using mini_big_mammas_pizzaria.Services;
using System.Xml.Linq;

namespace mini_big_mammas_pizzaria.Services
{
    public class Order
    {
        private Customer Customer {  get; set; }
        private List<Menuitems> Food = new List<Menuitems>();
        public bool TakeAway {  get; set; }
        public Order()
        {
            
        }
        public Order(Customer customer, List<Menuitems> food)
        {
            Customer = customer;
            Food = food;
        }

        public double getprice()
        {
            double price = 0;
            foreach (Menuitems menuitem in Food)
            {
                price += menuitem.Price*1.25;
            }
            return TakeAway ? price + 40: price;
        }
        public string GetFood()
        {
            string food = "";
                foreach(Menuitems item in Food)
            {
                food += item == Food[Food.Count-1] ? item : item + ", ";
            }
            return food;
        }
        public override string ToString()
        {
            return $"{Customer}, {GetFood()}";
         
        }
    }
}
