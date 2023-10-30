namespace mini_big_mammas_pizzaria.Model
{
    public class Burger
    {
        //instance fields
        private int _number_burger;
        private string _burger_name;
        private BunType _burger_type;
        private double _burger_price;
        private string _burger_description;

        //properties
        public int NumberBurgers
        {
            get { return _number_burger; }
            set { _number_burger = value; }
        }
        public string BurgerName
        {
            get { return _burger_name; }
            set { _burger_name = value; }
        }
        public BunType BurgerSize
        {
            get { return _burger_type; }
            set { _burger_type = value; }
        }
        public double BurgerPrice
        {
            get { return _burger_price; }
            set { _burger_price = value; }
        }

        public string BurgerDescription
            {
             get { return _burger_description; }
             set { _burger_description = value; }
            }

        //default constructor
        public Burger()
            {
                _number_burger = 0;
                _burger_name = "";
                _burger_type = BunType.Fuldkorn;
                _burger_price = 0;
                _burger_description = "";

        }

        //Constructor
        public Burger(int numberburgers, string name, BunType type, double price, string description)
        {
            _number_burger = numberburgers;
            _burger_name = name;
            _burger_type = type;
            _burger_price = price;
            _burger_description = description;

        }

        //methods
        public double PriceWithTaxes()
        {
            return _burger_price * 1.25;
        }

        //Tostring
        public override string ToString()
            {
                return $"{{{nameof(NumberBurgers)}={NumberBurgers.ToString()}, {nameof(BurgerName)}={BurgerName}, {nameof(BurgerSize)}={BurgerSize.ToString()}, {nameof(BurgerPrice)}={BurgerPrice.ToString()}}}";
            }


        }
        public enum BunType { Fuldkorn, Portobello, Ciabatta, Brioche }
    }
