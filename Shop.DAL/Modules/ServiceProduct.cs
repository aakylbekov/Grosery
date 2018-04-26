using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.DAL.Modules
{
    public class ServiceProduct
    {
        private Random Rand = new Random();
        public void GenerateProduct(Grocery shop)
        {
            for (int i = 0; i < Rand.Next(5, 20); i++)
            {
                Product p = new Product();
                p.Barcode = Rand.Next(10000, 30000);
                //p.Cur.CurCode = 398;
                //p.Cur.CurName = "KZT";
                p.Cur = new Currency() { CurCode = 398, CurName = "KZT" };
                p.DateOfProduction = DateTime.Now.AddDays(-Rand.Next(0, 1000));
                p.ExpiredDay = Rand.Next(1, 10);
                p.ExpiredTime = DateTime.Now.AddDays(Rand.Next(0, 20));
                p.Name = string.Format("Product #{0}", Rand.Next());
                p.Price = Rand.NextDouble();

                shop.Products.Add(p);

            }

        }
        public List<Grocery> GenerateShop()
        {
            List<Grocery> Shops = new List<Grocery>();
            for (int i = 0; i < Rand.Next(1, 10); i++)
            {
                Grocery G = new Grocery();
                G.Name = "Shop #" + Rand.Next();
                GenerateProduct(G);
                Shops.Add(G);
            }
            return Shops;
        }
    }
}
