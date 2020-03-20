using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LakoparkProjek
{

    class HappyLiving
    {
        private List<Lakopark> lakoparkok;
        
        public HappyLiving(string fajlnev) {

            lakoparkok = new List<Lakopark>();

            using (var file = File.OpenText(fajlnev)) {
                while (!file.EndOfStream)
                {
                    string nev = file.ReadLine();
                    string masodikSor = file.ReadLine();
                    string[] masoidk = masodikSor.Split(';');
                    int utcaSzama = Convert.ToInt32(masoidk[0]);
                    int maxHazSzam = Convert.ToInt32(masoidk[1]);

                    int[,] hazak = new int[utcaSzama, maxHazSzam];

                    string harmadikSor = "";
                    while ((harmadikSor = file.ReadLine()) != "") {
                        string[] harmadik = harmadikSor.Split(';');
                        int utca = Convert.ToInt32(harmadik[0]);
                        int haz = Convert.ToInt32(harmadik[1]);
                        int szint = Convert.ToInt32(harmadik[2]);
                        hazak[utca - 1, haz - 1] = szint;
                    }
                    Lakoparkok.Add(new Lakopark(nev, utcaSzama, maxHazSzam, hazak));
                }
            }




        }

        internal List<Lakopark> Lakoparkok { get => lakoparkok; set => lakoparkok = value; }
    }
}
