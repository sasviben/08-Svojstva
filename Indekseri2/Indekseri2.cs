using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp.Svojstva
{
    // primjer svojstava sa stringom kao parametrom
    class PoštanskiBrojevi
    {
        private Dictionary<int, string> m_popis = new Dictionary<int,string>()
        {
            {10000, "Zagreb"},
            {10360, "Sesvete"},
            {10020, "Novi Zagreb"}
        };

        // TODO: Definirati svojstvo s int kao parametrom koje će za zadani poštanski broj vratiti mjesto
        public string this[int poštanskiBroj]
        {
            get
            {
                if (m_popis.ContainsKey(poštanskiBroj))
                    return m_popis[poštanskiBroj];
                throw new IndexOutOfRangeException(string.Format("Nepoznati poštanski broj: {0}", poštanskiBroj));
            }
        }

        // TODO: Definirati svojstvo sa string kao parametrom koje će za zadano mjesto vratiti poštanski broj
        public int this[string mjesto]
        {
            get {
                if (m_popis.ContainsValue(mjesto))
                    return m_popis.First(x => x.Value == mjesto).Key;
                throw new IndexOutOfRangeException(string.Format("Nepoznato mjesto: {0}", mjesto));
            }
        }

    }

    class Indekseri2
    {
        static void Main(string[] args)
        {
            try
            {
                PoštanskiBrojevi pb = new PoštanskiBrojevi();
                Console.WriteLine("Poštanski broj 10000 ima: {0}", pb[10000]);
                Console.WriteLine("Poštanski broj za Sesvete je: {0}", pb["Sesvete"]);
                Console.WriteLine("Poštanski broj za Nečujam je: {0}", pb["Nečujam"]);
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
