using System;

namespace Svojstva
{
    public class StringArray
    {
        // konstruktor koji inicijalizira duljinu niza
        public StringArray(int length)
        {
            m_items = new string[length];
        }
        // niz znakovnih brojeva
        private string[] m_items;
        // svojstvo s parametrom
        public string this[int index]
        {
            get
            {
                if (index < 0 || index >= m_items.Length)
                    throw new ArgumentOutOfRangeException();
                return m_items[index];
            }
            set
            {
                if (index < 0 || index >= m_items.Length)
                    throw new ArgumentOutOfRangeException();
                m_items[index] = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StringArray niz = new StringArray(3);
                niz[0] = "Nulti";
                niz[2] = "Drugi";
                Console.WriteLine("niz[2] = {0}", niz[2]);
                Console.WriteLine("niz[1] = {0}", niz[1]);
                niz[3] = "Treći";
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("GOTOVO!!!");
            Console.ReadLine();
        }
    }
}
