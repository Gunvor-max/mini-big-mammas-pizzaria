namespace mini_big_mammas_pizzaria.Model
{
    public class Drinks
    {
        //properties
        public string Name { get; set; }
        
        public string Size { get; set; }
        public double Price { get; set; }
        
        //constructor
        public Drinks()
        {
            Name = "";
            Size = "";
            Price = 0;
        }
        public Drinks(string name, string size, double price)
        {
            Name = name;
            Size = size;
            Price = price;
        }

        public override string ToString()
        {
            return $"{{{nameof(Name)}={Name}, {nameof(Size)}={Size}, {nameof(Price)}={Price.ToString()}}}";
        }
    }
}

/*
 * Drinks drinks1 = new Drinks("Cola", "Small", 15);
 * 
 * 
 * 
 */

