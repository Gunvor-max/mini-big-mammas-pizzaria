using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using mini_big_mammas_pizzaria.Model;
using mini_big_mammas_pizzaria.Services;

namespace mini_big_mammas_pizzaria.Pages.DrikkevarerMenu
{
    public class DrinksMenuModel : PageModel
    {

        public List<Items> DrinksMenukort { get; set; }

        public void OnGet()
        {
            Menucard repo = new Menucard();
            DrinksMenukort = repo.GetAllDrinks();
            repo.AddNumbers();
        }
    }
}