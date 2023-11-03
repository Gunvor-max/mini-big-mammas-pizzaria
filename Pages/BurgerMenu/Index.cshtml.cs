using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using mini_big_mammas_pizzaria.Model;
using mini_big_mammas_pizzaria.Services;

namespace mini_big_mammas_pizzaria.Pages.BurgerMenu
{
    public class BurgerMenuModel : PageModel
    {

        public List<Items> BurgerMenukort { get; set; }

        public void OnGet()
        {
            Menucard repo = new Menucard();
            BurgerMenukort = repo.GetAllBurgers();
            repo.AddNumbers();
        }
    }
}
