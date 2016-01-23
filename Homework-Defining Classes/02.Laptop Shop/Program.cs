using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Laptop_Shop
{
    class Program
    {
        static void Main(string[] args)
        {     
            Battery lion = new Battery("Li-Ion, 4-cells, 2550 mAh");
            Battery nicd = new Battery("Ni-Cd", (float)4.5);
            Laptop lpt_first = new Laptop("Lenovo Yoga 2 Pro", (decimal)869.88, "Lenovo", "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)", "8 GB", "128GB SSD", "Intel HD Graphics 4400", lion, "13.3\" (33.78 cm) – 3200 x 1800 (QHD+), IPS sensor display");
            Laptop lpt_second = new Laptop("Aspire E3-111-C5GL", (decimal)259.49);
            Laptop lpt_third = new Laptop("HP 250 G2", (decimal)699.00, battery: nicd, processor: "3.2 GHz", ram: "16 GB");

            Console.WriteLine("{0}\n",lpt_first.ToString());
            Console.WriteLine("{0}\n",lpt_second.ToString());
            Console.WriteLine("{0}\n",lpt_third.ToString());
        }
    }
}
