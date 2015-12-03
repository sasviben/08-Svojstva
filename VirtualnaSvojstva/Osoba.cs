using System;

namespace Vsite.CSharp
{
    class Osoba
    {
        public Osoba(string ime)
        {
            Identifikacija = ime;
        }

        public virtual string Identifikacija
        {
            get;
            private set;
        }
    }
}
