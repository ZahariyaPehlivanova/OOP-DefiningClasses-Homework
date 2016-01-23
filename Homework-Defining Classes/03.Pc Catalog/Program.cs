using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Pc_Catalog
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Component> components = new List<Component>();

            components.Add(new Component("HDD", 340.30m));
            components.Add(new Component("CPU", 120.45m));
            components.Add(new Component("RAM", 45.50m,"8GB"));
            Computer pc = new Computer("Asus", components);
            List<Computer> catalog = new List<Computer>();
            catalog.Add(pc);

            List<Component> components1 = new List<Component>();
            components1.Add(new Component("CPU", 270));
            components1.Add(new Component("Motheboard", 120));
            components1.Add(new Component("Graphics card", 300));
            Computer pc1 = new Computer("HP", components1);
            catalog.Add(pc1);

            List<Component> components2 = new List<Component>();
            components2.Add(new Component("CPU", 150));
            components2.Add(new Component("RAM", 123.65m, "4GB"));
            Computer pc2 = new Computer("Lenovo", components2);
            catalog.Add(pc2);

            var catalogSort = catalog.OrderBy(x => x.Price);

            foreach (var item in catalogSort)
            {
                Console.WriteLine(item);
            }
        }
    }
}
