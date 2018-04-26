using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.DAL.Modules;

namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceProduct q = new ServiceProduct();
            List<Grocery> w = q.GenerateShop();
            foreach (Grocery item in w.OrderBy(o => o.Products.Count()))
            {
                item.Info();
            }
           
            Console.WriteLine("Enter SHOP NAME");
            string terp = Console.ReadLine();
            //Console.Clear();

            Grocery yt = w.FirstOrDefault(o => o.Name == terp);
            if (yt != null)
            {
                Console.WriteLine("Enter QR");
                int temp = Int32.Parse(Console.ReadLine());

                Product findProd = yt[temp];
                findProd.PrintInfo();
            }
        }
    }
}
