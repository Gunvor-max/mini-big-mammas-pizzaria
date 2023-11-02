namespace mini_big_mammas_pizzaria.Model
{
    public class Customer
    {
        public string Name { get; set; }
        public string Tlf { get; set; }

        public Customer()
        {
            Name = "";
            Tlf = "";
        }
        public Customer(string name, string tlf)
        {
            Name = name;
            Tlf = tlf;
        }

        public override string ToString()
        {
            return $"{{{nameof(Name)}={Name}, {nameof(Tlf)}={Tlf}}}";
        }
    }
}
