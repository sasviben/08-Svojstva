using System;

namespace Svojstva
{
    class Program
    {
        // .NET 2.0 dozvoljava različita prava pristupa get/set metodama
        public DateTime DanasnjiDatum
        {
            get { return DateTime.Now; }
            protected set { /* ... */ }
        }

        // modificirano pravo može biti samo restriktivnije
        private string DanUTjednu
        {
            public get { return DateTime.Now.ToString("dddd"); }
            set { /* ... */ }
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(p.DanUTjednu);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadLine();
        }
    }
}
