namespace mini_big_mammas_pizzaria.Model
{
    public class Burger:Menuitems
    {
        //properties
        public BunType Bun { get; set; }
        public List <string> Description = new List <string> ();
            

        //default constructor
        public Burger()
            { 
                Bun = BunType.Fuldkorn;
            }

        //Constructor
        public Burger(int number, string name, double price, BunType type, List<string> description):base(number, name, price)
        {
            Bun = type;
            Description = description; 
        }
        public string AddTopping(string topping)
        {
            Description.Add(topping);
            Price += 10;
            return topping;
        }
        public string GetToppings()
        {
            string topping = "";
            foreach (string top in Description)
            {
                topping += top == Description[Description.Count-1] ? top : top + ", ";
            }
            return topping;
        }

        //Tostring
        public override string ToString()
        {
            return $"{{{nameof(Number)}={Number.ToString()}, {nameof(Name)}={Name}, {nameof(Bun)}={Bun.ToString()}, {nameof(Price)}={Price.ToString()}, {nameof(GetToppings)}={GetToppings()}}}";
        }




    }
        public enum BunType { Fuldkorn, Portobello, Ciabatta, Brioche }
    }
