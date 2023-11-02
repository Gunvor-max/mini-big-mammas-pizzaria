using mini_big_mammas_pizzaria.Model;

namespace mini_big_mammas_pizzaria.Services
{
    public class Menucard
    {
        public Dictionary<int, Menuitems> Menu = new Dictionary<int, Menuitems>();

        public Menucard()
        {
            
        }

        public Menuitems AddItem(Menuitems item)
        {
            Menu.Add(item.Number, item);
            return item;
        }
        
        public Menuitems DelItem(Menuitems item)
        {
            Menu.Remove(item.Number);
            return item;
        }

        public Menuitems SearchItem(int item)
        {
            Menuitems resItem = null;
            foreach (Menuitems m in Menu.Values)
            {
                if (m.Number == item)
                    return m;
            }
            return resItem;
        }

        public override string ToString()
        {
            string Output = string.Join(", ", Menu.Values);
            return $"{{{nameof(Menu)}={Output}}}";
        }
    }
}
