using mini_big_mammas_pizzaria.Model;
namespace mini_big_mammas_pizzaria.Services
{
    public class BurgerRepository
    {
        Dictionary<int, Burger> Menukort = new Dictionary<int, Burger>();

        public BurgerRepository()
        {
            PopulateBurgerRepository();
        }
        public Dictionary<int, Burger> PopulateBurgerRepository()
        {
            Menukort.Clear();
            Menukort.Add(1, new Burger(1, "Big Mac", BunType.Ciabatta, 40, ["tomato"]));
            Menukort.Add(2, new Burger(2, "Tasty Cheese", BunType.Ciabatta, 25, ["cheese"]));
            Menukort.Add(3, new Burger(3, "Hamburger", BunType.Ciabatta, 40, ["ham"]));
            return Menukort;
        }

        public Burger DeleteItem(int burger)
        {
            if(Menukort.ContainsKey(burger))
            {
                Burger slettetKunde = Menukort[burger];
                Menukort.Remove(burger);
                return slettetKunde;
            }
            else
            {
                return null;
            }
        }

        public Burger AddItem(int number, string name, BunType type, double price, List<string> description)
        {

            Menukort.Add(number, new Burger(number, name, type, price, description));
            return Menukort[number];
        }

        public List<Burger> GetAllItems()
        {
            return Menukort.Values.ToList();
        }

        public override string ToString()
        {
            return $"{{}}";
        }
    }
}
