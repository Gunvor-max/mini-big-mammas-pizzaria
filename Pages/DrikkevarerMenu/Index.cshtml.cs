using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using mini_big_mammas_pizzaria.Model;
using mini_big_mammas_pizzaria.Services;

namespace mini_big_mammas_pizzaria.Pages.DrikkevarerMenu
{
    public class DrinksMenuModel : PageModel
    {

        public List<Drinks> DrinksMenukort { get; set; }

        public void OnGet()
        {
            DrinksRepository repo = new DrinksRepository();
            DrinksMenukort = repo.GetAllItems();
        }
    }
}