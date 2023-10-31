namespace mini_big_mammas_pizzaria.Model
{
    public class Burger
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
                Number = 0;
                Name = "";
                Bun = BunType.Fuldkorn;
                Price = 0;
            }

        //Constructor
        public Burger(int number, string name, BunType type, double price, List<string> description)
        {
            Number = number;
            Name = name;
            Bun = type;
            Price = price;
            Description = description; 

        }

        //methods
        public double PriceWithTaxes()
        {
            return Price * 1.25;
        }


        //Tostring
        public override string ToString()
        {
            return $"{{{nameof(Number)}={Number.ToString()}, {nameof(Name)}={Name}, {nameof(Bun)}={Bun.ToString()}, {nameof(Price)}={Price.ToString()}, {nameof(Description)}={Description}}}";
        }




    }
        public enum BunType { Fuldkorn, Portobello, Ciabatta, Brioche }
    }
