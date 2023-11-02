using mini_big_mammas_pizzaria.Model;
using mini_big_mammas_pizzaria.Services;

namespace mini_big_mammas_pizzaria.Services
{
    public class Order
    {
        public Customer Customer {  get; set; }
        public List<Menucard> Food = new List<Menucard>();
        public Order()
        {
            
        }
        public Order(Customer customer, List<Menucard> food)
        {
            Customer = customer;
            Food = food;
        }
    }
}
