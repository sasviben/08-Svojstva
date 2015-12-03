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

        // TODO: Javno dostupno polje Prezime nadomjestiti svojstvom (property) koje se izvan klase može samo čitati, a mijenjati se može samo iz klase

        public string Prezime;


        // TODO: Javno dostupno polje Ime nadomjestiti svojstvom (property) koje se izvan klase može čitati i zadavati, ali prilikom zadavanja treba onemogućiti
        // zadavanje praznim znakovnim nizom

        public string Ime;

        // TODO: Javno dostupno polje DatumRođenja nadomjestiti svojstvom (property) koje se izvan klase može čitati i zadavati, ali za slučaj zadavanja
        // datuma većeg od trenutnog treba baciti iznimku tipa ArgumentOutOfRangeException. U pozivajućem kodu staviti odogovarajući kod za hvatanje
        // iznimke koji će u slučaju iznimke ispisati odgovarajuću poruku.

        public DateTime DatumRođenja;
    }
}
