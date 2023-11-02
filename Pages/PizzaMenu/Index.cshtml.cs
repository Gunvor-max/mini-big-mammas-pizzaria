using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using mini_big_mammas_pizzaria.Model;
using mini_big_mammas_pizzaria.Services;

namespace mini_big_mammas_pizzaria.Pages.Menukort
{
    public class PizzaMenuModel : PageModel
    {
        //Property
        public List<Pizza> PizzaMenukort {  get; set; }
        
        public void OnGet()
        {
            PizzaRepository repo = new PizzaRepository();
            PizzaMenukort = repo.GetAllItems();
        }
    }
}
