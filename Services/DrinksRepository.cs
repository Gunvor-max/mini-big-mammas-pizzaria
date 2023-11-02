using System.ComponentModel.DataAnnotations.Schema;
using mini_big_mammas_pizzaria.Model;
namespace mini_big_mammas_pizzaria.Services;


public class DrinksRepository
{
    //Property
    public Dictionary<int, Drinks> Menukort = new Dictionary<int, Drinks>();

    //Constructor
    public DrinksRepository()
    {
        PopulateDrinksRepository();
    }

    private void PopulateDrinksRepository()
    {
        Menukort.Clear();
        Menukort.Add(1, new Drinks("Cola", "Small", 15));




    }
}
    
