namespace mini_big_mammas_pizzaria.Model
{
    public class Drinks:Menuitems
    {
        //properties
        
        public string Size { get; set; }

        
        //constructor
        public Drinks()
        {
            Size = "";
        }
        public Drinks(int number, string name, double price, string size):base(number, name, price)
        {
            Size = size;
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

