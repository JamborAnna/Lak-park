using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LakoparkProjek
{
    class Lakopark
    {

        private string nev;
        private int utcakSzama;
        private int maxHazSzam;
        private int[,] hazak;

        public Lakopark(string nev, int utcakSzama, int maxHazSzam, int[,] hazak)
        {
            this.nev = nev;
            this.utcakSzama = utcakSzama;
            this.maxHazSzam = maxHazSzam;
            this.hazak = hazak;
        }

        public string Nev { get => nev; set => nev = value; }
        public int UtcakSzama { get => utcakSzama; set => utcakSzama = value; }
        public int MaxHazSzam { get => maxHazSzam; set => maxHazSzam = value; }
        public int[,] Hazak { get => hazak; set => hazak = value; }

    }
}
