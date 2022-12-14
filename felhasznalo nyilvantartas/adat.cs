using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace felhasznalo_nyilvantartas
{
    internal class adat
    {
        int id;
        string nev;
        DateTime datum;
        string profilnev;

        public int Id { get => id; set => id = value; }
        public string Nev { get => nev; set => nev = value; }
        public DateTime Datum { get => datum; set => datum = value; }
        public string Profilnev { get => profilnev; set => profilnev = value; }
        public adat(int id, string nev, DateTime datum, string profilnev)
        {
            Id = id;
            Nev = nev;
            Datum = datum;
            Profilnev = profilnev;
        }
    }
}
