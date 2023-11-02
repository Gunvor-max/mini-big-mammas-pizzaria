using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using mini_big_mammas_pizzaria.Services;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace mini_big_mammas_pizzaria.Pages.AddNewPizza
{
    public class IndexModel : PageModel
    {
            private PizzaRepository _repo;

            public IndexModel(PizzaRepository repo)
            {
                _repo = repo;
            }

            //[BindProperty] - dette er ikke g�ldende for pizzaer da pizzaen automatisk tilf�jes med nyt nummer til listen
            //public int PizzaNummer { get; set; }


            [BindProperty]
            [Required(ErrorMessage = "Der skal v�re et navn")]
            [StringLength(10, MinimumLength = 2, ErrorMessage = "Der skal v�re mindst to tegn i et navn")]
            public string NytPizzaNavn { get; set; }



            [BindProperty]
            public string NyPris { get; set; }

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
                Kunde nyKunde = new Kunde(NytKundeNummer, NytKundeNavn, NytKundetlf);

                //KundeRepository repo = new KundeRepository(true);
                _repo.Tilf�j(nyKunde);

                return RedirectToPage("Index");
            }
        }
        public void OnGet()
        {
        }
    }
}
