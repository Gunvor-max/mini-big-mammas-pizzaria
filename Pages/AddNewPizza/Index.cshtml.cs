using Microsoft.AspNetCore.DataProtection.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using mini_big_mammas_pizzaria.Model;
using mini_big_mammas_pizzaria.Services;
using System.ComponentModel.DataAnnotations;

namespace mini_big_mammas_pizzaria.Pages.AddNewPizza
{
    public class IndexModel : PageModel
    {
        public PizzaRepository _repo;

        public IndexModel(PizzaRepository repo)
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
        public string NyDescription { get; set; }

        public void OnGet()
        {
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
