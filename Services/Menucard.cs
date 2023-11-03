using mini_big_mammas_pizzaria.Model;

namespace mini_big_mammas_pizzaria.Services
{
    public class Menucard
    {
        public Dictionary<int, Menuitems> Menu = new Dictionary<int, Menuitems>();

        public Menucard()
        {
            Menu.Clear();
            PopulatePizzaRepository();
            PopulateBurgerRepository();
            PopulateDrinksRepository();
        }
        

        public void PopulatePizzaRepository()
        {
            Menu.Add(1, new Pizza(1, "Margherita", 69, ["tomato", "cheese"]));
            Menu.Add(2, new Pizza(2, "Vesuvio", 75, ["tomato", "cheese", "ham"]));
            Menu.Add(3, new Pizza(3, "Capricciosa", 80, ["tomato", "cheese", "ham", "mushrooms"]));
            Menu.Add(4, new Pizza(4, "Calzone", 80, ["baked pizza with tomat", "cheese", "ham", "mushrooms"]));
            Menu.Add(5, new Pizza(5, "Quattro Stagioni", 85, ["tomato", "cheese", "ham", "mushrooms", "shrimp", "peppers"]));
            Menu.Add(6, new Pizza(6, "Marinara", 85, ["tomato", "cheese", "shrimp", "mussels", "garlic"]));
            Menu.Add(7, new Pizza(7, "Vegetatian", 80, ["tomato", "cheese", "vegetables"]));
            Menu.Add(8, new Pizza(8, "Italiana", 75, ["tomato", "cheese", "onion", "meat sauce"]));
            Menu.Add(9, new Pizza(9, "Gorgonzola", 85, ["tomato", "gorgonzola", "onion", "mushroom"]));
            Menu.Add(10, new Pizza(10, "Contadina", 75, ["tomato", "cheese", "mushrooms", "olives"]));
            Menu.Add(11, new Pizza(11, "Naples", 79, ["tomato", "cheese", "anchovies", "olives"]));
            Menu.Add(12, new Pizza(12, "Vichinga", 80, ["tomato", "cheese", "ham", "mushrooms", "peppers", "garlic", "chili"]));
            Menu.Add(13, new Pizza(13, "Calzone Special", 80, ["tomato", "cheese", "shrimp", "ham", "meat sauce"]));
            Menu.Add(14, new Pizza(14, "Esotica", 80, ["tomato", "cheese", "ham", "shrimp", "pinapple"]));
            Menu.Add(15, new Pizza(15, "Tonno", 85, ["tomato", "cheese", "tuna", "shrimp"]));
            Menu.Add(16, new Pizza(16, "Sardegna", 80, ["tomato", "cheese", "cocktail sausages", "bacon", "onions", "eggs"]));
            Menu.Add(17, new Pizza(17, "Romana", 78, ["tomato", "cheese", "ham", "bacon", "onion"]));
            Menu.Add(18, new Pizza(18, "Sole", 78, ["tomato", "cheese", "ham", "bacon", "eggs"]));
            Menu.Add(19, new Pizza(19, "Big Mamma", 90, ["tomato", "gorgonzola", "shrimp", "asparagus", "parma ham"]));
            Menu.Add(20, new Pizza(20, "Dej i pose", 69, ["Pizzadej"]));
        }
        public void PopulateBurgerRepository()
        {
            Menu.Add(21, new Burger(21, "Big Mac", 40, BunType.Ciabatta, ["tomato", "beef"]));
            Menu.Add(23, new Burger(23, "Tasty Cheese", 25, BunType.Ciabatta, ["cheese"]));
            Menu.Add(24, new Burger(24, "Hamburger", 25, BunType.Ciabatta, ["ham"]));
        }
        private void PopulateDrinksRepository()
        {
            Menu.Add(69, new Drinks(69, "Cola", 15, "Small"));
        }

        public Menuitems AddItem(Menuitems item)
        {
            Menu.Add(item.Number, item);
            return item;
        }


        public Menuitems DeleteItem(int item)
        {
            if (Menu.ContainsKey(item))
            {
                Menuitems slettetpizza = Menu[item];
                Menu.Remove(item);
                return slettetpizza;
            }
            else
            {
                return null;
            }
        }

        public Menuitems SearchItem(int item)
        {
            Menuitems resItem = null;
            foreach (Menuitems m in Menu.Values)
            {
                if (m.Number == item)
                    return m;
            }
            return resItem;
        }
        public List<Menuitems> GetAllItems()
        {
            return Menu.Values.ToList();
        }

        public override string ToString()
        {
            string Output = string.Join(", ", Menu.Values);
            return $"{{{nameof(Menu)}={Output}}}";
        }
    }
}
