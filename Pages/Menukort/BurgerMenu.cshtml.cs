using mini_big_mammas_pizzaria;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using mini_big_mammas_pizzaria.Model;
using mini_big_mammas_pizzaria.Services;

namespace mini_big_mammas_pizzaria.Pages.Menukort
{
    public class BurgerMenuModel : PageModel
    {

        public List<Burger> BurgerMenukort { get; set; }

        public void OnGet()
        {
            BurgerRepository repo = new BurgerRepository();
            BurgerMenukort = repo.GetAllItems();
        }
    }
}
