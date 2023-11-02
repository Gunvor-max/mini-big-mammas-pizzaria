namespace mini_big_mammas_pizzaria.Model
{
    public class Burger:Menuitems
    {
        //properties
        public int Number { get; set; }
        public string Name { get; set; }
        public BunType Bun { get; set; }
        public double Price { get; set; }
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

        //methods
        public double PriceWithTaxes()
        {
            return Price * 1.25;
        }

        public string GetToppings()
        {
            string topping = "";
            foreach (string top in Description)
            {
                topping += top + ", ";
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
