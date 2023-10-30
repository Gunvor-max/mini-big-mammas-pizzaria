namespace mini_big_mammas_pizzaria.Model
{
    public class Drikkevarer
    {
        //properties
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        
        //constructor
        public Drikkevarer()
        {
            Name = "";
            Description = "";
            Price = 0;
        }
        public Drikkevarer(string name, string description, double price)
        {
            Name = name;
            Description = description;
            Price = price;
        }

        public override string ToString()
        {
            return $"{{{nameof(Name)}={Name}, {nameof(Description)}={Description}, {nameof(Price)}={Price.ToString()}}}";
        }
    }
}