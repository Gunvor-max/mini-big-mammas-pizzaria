namespace mini_big_mammas_pizzaria.Model
{
    public class Pizza
    {
        //Properties
        public string Name { get; set; }
        public int Number { get; set; }
        public double Price { get; set; }
        //public List<string> Description = new List<string>();
        public string Description { get; set; }
        public List<string> Toppings = new List<string>();


        public Pizza()
        {
            Name = "";
            Number = 0;
            Price = 0;
            Description = "";
            Toppings = 

        }
        //Constructor
        public Pizza(string name, int number, string description, double price)
        {
            Name = name;
            Number = number;
            Description = description;
            Price = price; 
            
        }

        
        public override string ToString()
        {

            return $"[{Name}, {Number}, {Price}kr.]";
        }

    }
}
