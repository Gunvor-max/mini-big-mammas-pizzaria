using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using mini_big_mammas_pizzaria.Model;
using mini_big_mammas_pizzaria.Services;

namespace mini_big_mammas_pizzaria.Pages.Menukort
{
    public class PizzaMenuModel : PageModel
    {
        //instance field of Pizzarepository 
        private PizzaRepository _repo;

        //Dependency constructor 
        public PizzaMenuModel(PizzaRepository repo)
        {
            _repo = repo;
        }
        
        //property til viewet
        public List<Pizza> Pizza { get; set; }


        public void OnGet()
        {
            Pizza = _repo.GetAllItems();
        }
    }
}
