using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using mini_big_mammas_pizzaria.Model;
using mini_big_mammas_pizzaria.Services;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace mini_big_mammas_pizzaria.Pages.ChangeItem
{
    public class ChangeItemModel : PageModel
    {
        public Menucard _repo;

        public ChangeItemModel(Menucard repo)
        {
            _repo = repo;
        }

        [BindProperty]
        public int NytPizzaNummer { get; set; }


        [BindProperty]
        [Required(ErrorMessage = "Der skal være et navn")]
        [StringLength(10, MinimumLength = 2, ErrorMessage = "Der skal være mindst to tegn i et navn")]
        public string NytPizzaNavn { get; set; }

        [BindProperty]
        public double NyPris { get; set; }

        [BindProperty]
        public List<string> NyDescription { get; set; }

        public void OnGet(int nummer)
        {
            Menuitems item = _repo.SearchItem(nummer);

            NytPizzaNummer = item.Number;
            NytPizzaNavn = item.Name;
            NyPris = item.Price;
            if (item is Pizza)
            {
                Pizza p = item as Pizza;
                NyDescription = p.Toppings;
            }
            else if (item is Burger)
            {
                Burger b = item as Burger;
                NyDescription = b.Description;
            }
            else if (item is Drinks) 
            {
                Drinks d = item as Drinks;

            }

        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            //Menucard nypizza = new Menucard();
            //Pizza pizza = new Pizza();
            Pizza newpizza = new Pizza(NytPizzaNummer, NytPizzaNavn, NyPris, [NyDescription]);

            _repo.AddItem(newpizza);

            return RedirectToPage("/PizzaMenu/Index");
        }
    }
}
