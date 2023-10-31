using mini_big_mammas_pizzaria.Model;

namespace mini_big_mammas_pizzaria.Services
{
    public class PizzaRepository
    {
        //property
        public Dictionary<int, Pizza> Menukort = new Dictionary<int, Pizza>();

        //constructor
        public PizzaRepository()
        {
            Menukort = new Dictionary<int, Pizza>();
        }


    }
}
