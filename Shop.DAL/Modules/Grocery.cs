using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.DAL.Modules
{
    public class Grocery
    {
        public Grocery()
        {
            Products = new List<Product>();
        }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public List<Product> Products { get; set; }

        public Product this[int QR]
        {
            get { return Products.FirstOrDefault(o => o.Barcode == QR); }
        }

        public void Info()
        {
            Console.WriteLine("{0} \n{1} ({2}) ", Name, Adress, Phone);
            foreach (Product item in Products)
            {
                item.PrintInfo();
            }
        }
    }
}
