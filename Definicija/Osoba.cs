using System;

namespace Vsite.CSharp
{
    class Osoba
    {
        public Osoba(string ime, string prezime)
        {
            Ime = ime;
            Prezime = prezime;
        }

        // : Javno dostupno polje Prezime nadomjestiti svojstvom (property) koje se izvan klase može samo čitati, a mijenjati se može samo iz klase

        public  string Prezime
        {
            get;
            private set;

        }


        // : Javno dostupno polje Ime nadomjestiti svojstvom (property) koje se izvan klase može čitati i zadavati, ali prilikom zadavanja treba onemogućiti
        // zadavanje praznim znakovnim nizom

        public string Ime
        {
            get
            {
                return m_ime;
            }
            set
            { if (value == "")
                    return;
                m_ime = value;
            }
        }
        private string m_ime;
        // : Javno dostupno polje DatumRođenja nadomjestiti svojstvom (property) koje se izvan klase može čitati i zadavati, ali za slučaj zadavanja
        // datuma većeg od trenutnog treba baciti iznimku tipa ArgumentOutOfRangeException. U pozivajućem kodu staviti odogovarajući kod za hvatanje
        // iznimke koji će u slučaju iznimke ispisati odgovarajuću poruku.
        private DateTime m_datumRodjenja;
        public DateTime DatumRođenja
        {
            get
            { return m_datumRodjenja; }
            set
            {
                if (value >= DateTime.Now)
                    throw new ArgumentOutOfRangeException();
                m_datumRodjenja = value;
            }
        }
    }
}
