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
        public int _nytpizzanummer;

        public ChangeItemModel(Menucard repo)
        {
            _repo = repo;
        }

        [BindProperty]
        public int NytPizzaNummer { get; set; }


        [BindProperty]
        [Required(ErrorMessage = "Der skal være et navn")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Der skal være mindst to tegn i et navn")]
        public string NytPizzaNavn { get; set; }

        [BindProperty]
        public double NyPris { get; set; }

        [BindProperty]
        public string NyDescription { get; set; }

        public void OnGet(int nummer)
        {
            Items item = _repo.SearchItem(nummer);


            NytPizzaNummer = item.Number;
            NytPizzaNavn = item.Name;
            NyPris = item.Price;
            if (item is Pizza)
            {
                Pizza p = item as Pizza;
                NyDescription = p.GetToppings();
            }
            else if (item is Burger)
            {
                Burger b = item as Burger;
                NyDescription = b.GetToppings();
            }
            else if (item is Drink) 
            {
                Drink d = item as Drink;
            }

        }
        public IActionResult OnPostChange()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            Items item = _repo.SearchItem(NytPizzaNummer);

            
            item.Name = NytPizzaNavn;
            item.Price = NyPris;
            //if (item is Pizza)
            //{
            //    Pizza p = item as Pizza;
            //    p.Toppings = NyDescription.Split(",").ToList();
            //    NyDescription = p.GetToppings();
            //}
            //else if (item is Burger)
            //{
            //    Burger b = item as Burger;
            //    NyDescription = b.GetToppings();
            //}
            //else if (item is Drinks)
            //{
            //    Drinks d = item as Drinks;
            //}

            return RedirectToPage("/PizzaMenu/Index");
        }

        public IActionResult OnPostCancel()
        {
            return RedirectToPage("/PizzaMenu/Index");
        }
    }
}
