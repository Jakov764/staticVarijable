using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cvekŠpraljaJakovVjezba2
{
    class Program
    {
        static void Main(string[] args)
        {
            PrvaKlasa x = new PrvaKlasa("Ivan", "Ivancic");
            Console.WriteLine(x.ToString());
            PrvaKlasa y = new PrvaKlasa("Pero", "Peric");
            Console.WriteLine(y.ToString());
            PrvaKlasa z = new PrvaKlasa();


            z.Ime = "Milorad";
            z.Prezime = "Milić";

            Console.WriteLine(z.ToString());

            Console.ReadKey();
        }
    }
}
