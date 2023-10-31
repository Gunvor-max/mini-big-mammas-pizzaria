using mini_big_mammas_pizzaria.Model;
using System.Text;

namespace mini_big_mammas_pizzaria.Services
{
    public class PizzaRepository
    {
        //property
        public Dictionary<int, Pizza> Menukort = new Dictionary<int, Pizza>();

        //constructor
        public PizzaRepository()
        {
            PopulateRepository();
        }

        //Methods
        public Dictionary<int, Pizza> PopulatePizzaRepository()
        {
            Menukort.Clear();
            Menukort.Add(1, new Pizza(1, 69, "Margherita", ["tomato", "cheese"]));
            Menukort.Add(2, new Pizza(2, 75, "Vesuvio", ["tomato", "cheese", "ham"]));
            Menukort.Add(3, new Pizza(3, 80, "Capricciosa", ["tomato", "cheese", "ham", "mushrooms"]));
            Menukort.Add(4, new Pizza(4, 80, "Calzone", ["baked pizza with tomat", "cheese", "ham", "mushrooms"]));
            Menukort.Add(5, new Pizza(5, 85, "Quattro Stagioni", ["tomato", "cheese", "ham", "mushrooms", "shrimp", "peppers"]));
            Menukort.Add(6, new Pizza(6, 85, "Marinara", ["tomato", "cheese", "shrimp", "mussels", "garlic"]));
            Menukort.Add(7, new Pizza(7, 80, "Vegetatian", ["tomato", "cheese", "vegetables"]));
            Menukort.Add(8, new Pizza(8, 75, "Italiana", ["tomato", "cheese", "onion", "meat sauce"]));
            Menukort.Add(9, new Pizza(9, 85, "Gorgonzola", ["tomato", "gorgonzola", "onion", "mushroom"]));
            Menukort.Add(10, new Pizza(10, 75, "Contadina", ["tomato", "cheese", "mushrooms", "olives"]));
            Menukort.Add(11, new Pizza(11, 79, "Naples", ["tomato", "cheese", "anchovies", "olives"]));
            Menukort.Add(12, new Pizza(12, 80, "Vichinga", ["tomato", "cheese", "ham", "mushrooms", "peppers", "garlic", "chili"]));
            Menukort.Add(13, new Pizza(13, 80, "Calzone Special", ["tomato", "cheese", "shrimp", "ham", "meat sauce"]));
            Menukort.Add(14, new Pizza(14, 80, "Esotica", ["tomato", "cheese", "ham", "shrimp", "pinapple"]));
            Menukort.Add(15, new Pizza(15, 85, "Tonno", ["tomato", "cheese", "tuna", "shrimp"]));
            Menukort.Add(16, new Pizza(16, 80, "Sardegna", ["tomato", "cheese", "cocktail sausages", "bacon", "onions", "eggs"]));
            Menukort.Add(17, new Pizza(17, 78, "Romana", ["tomato", "cheese", "ham", "bacon", "onion"]));
            Menukort.Add(18, new Pizza(18, 78, "Sole", ["tomato", "cheese", "ham", "bacon", "eggs"]));
            Menukort.Add(19, new Pizza(19, 90, "Big Mamma", ["tomato", "gorgonzola", "shrimp", "asparagus", "parma ham"]));
            return Menukort;
        }

        public Pizza DeleteItem(int pizza)
        {
            if (Menukort.ContainsKey(pizza))
            {
                Pizza slettetpizza = Menukort[pizza]; 
                Menukort.Remove(pizza);
                return slettetpizza;
            }
            else
            { 
                return null; 
            }
        }

        public Pizza AddItem(int number, double price, string name, List<string> topping) 
        {
            Menukort.Add(number, new Pizza(number, price, name, topping));
            return Menukort[number];
        }

        public List<Pizza> GetAllItems()
        {
            return Menukort.Values.ToList();
        }

        public override string ToString()
        {
            String Output = String.Join(", ", Menukort.Values);

            return $"{{{nameof(Menukort)}={Output}}}";
        }

        //Tostring


    }
}

