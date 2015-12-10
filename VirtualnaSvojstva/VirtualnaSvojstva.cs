using System;
using System.Diagnostics;

namespace Vsite.CSharp
{
    // primjer virtualnih svojstava

    class Program
    {
        static void Main(string[] args)
        {
            Osoba o = new Osoba("Janko");
            Console.WriteLine(o.Identifikacija);

            // : U definiciji klase Student pregaziti svojstvo Identifikacija tako da donja naredba Debug.Assert ne baci iznimku

            Student s = new Student("Pero", 5);
            Debug.Assert(s.Identifikacija == "Pero, 5. godina");
            Console.WriteLine(s.Identifikacija);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
