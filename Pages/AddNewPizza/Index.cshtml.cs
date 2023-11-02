using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using mini_big_mammas_pizzaria.Model;
using mini_big_mammas_pizzaria.Services;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace mini_big_mammas_pizzaria.Pages.AddNewPizza
{
    public class IndexModel : PageModel
    {
        //    private PizzaRepository _repo;

        //    public IndexModel(PizzaRepository repo)
        //    {
        //        _repo = repo;
        //    }

        //    [BindProperty]
        //    public int NytPizzaNummer { get; set; }


        //    [BindProperty]
        //    [Required(ErrorMessage = "Der skal være et navn")]
        //    [StringLength(10, MinimumLength = 2, ErrorMessage = "Der skal være mindst to tegn i et navn")]
        //    public string NytPizzaNavn { get; set; }



        //    [BindProperty]
        //    public double NyPris { get; set; }

        //    [BindProperty]
        //    public string NyDescription { get; set; }

        //    public void OnGet()
        //    {
        //    }
        //    public IActionResult OnPost()
        //    {
        //        if (!ModelState.IsValid)
        //        {
        //            return Page();
        //        }
        //        Pizza nypizza = new Pizza(NytPizzaNummer, NytPizzaNavn, NyPris, [NyDescription]);

        //        KundeRepository repo = new KundeRepository(true);
        //        _repo.AddItem(NytPizzaNummer, NytPizzaNavn, NyPris, [NyDescription]);

        //        return RedirectToPage("PizzaMenu/Index");
        //    }
    }
}
