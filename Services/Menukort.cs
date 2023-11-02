using mini_big_mammas_pizzaria.Model;

namespace mini_big_mammas_pizzaria.Services
{
    public class Menukort
    {
        public Dictionary<int, Menuitems> Menu = new Dictionary<int, Menuitems>();

        public Menukort()
        {
            
        }
        public Pizza AddPizza(Pizza pizza)
        {
            Menu.Add(pizza.Number, pizza);
            return pizza;
        }

        public Pizza DelPizza(Pizza pizza)
        {
            Menu.Remove(pizza.Number);
            return pizza;
        }

        public Burger AddBurger(Burger burger)
        {
            Menu.Add(burger.Number, burger);
            return burger;
        }

        public Burger DelBurger(Burger burger)
        {
            Menu.Remove(burger.Number);
            return burger;
        }

        public Drinks AddDrikkevarer(Drinks drikkevarer)
        {
            Menu.Add(drikkevarer.Number, drikkevarer);
            return drikkevarer;
        }

        public Drinks DelDrikkevarer(Drinks drikkervarer)
        {
            Menu.Remove(drikkervarer.Number);
            return drikkervarer;
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

        public override string ToString()
        {
            string Output = string.Join(", ", Menu.Values);
            return $"{{{nameof(Menu)}={Output}}}";
        }
    }
}
