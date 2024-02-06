using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
namespace Lakopark_Winform
{
    class Lakopark
    {
        readonly int lakoparkid;
        string lakoparkneve;
        int utcakszama;
        int telkekszama;
        int[,] hazak;  //--- utca és telek érték alapján az emeletszámot adja vissza 

        //public int Lakoparkid { get => lakoparkid; set => lakoparkid = value; } nem kell mert ez id lesz
        public int Lakoparkid   => lakoparkid; 
        
        public string Lakoparkneve { get => lakoparkneve; set => lakoparkneve = value; }
        public int Utcakszama { get => utcakszama; set => utcakszama = value; }
        public int Telkekszama { get => telkekszama; set => telkekszama = value; }
        public int[,] Hazak { get => hazak; set => hazak = value; }

        public Image getNevadoKep()
        {
            return Image.FromFile($"Kepek{Path.DirectorySeparatorChar}{this.lakoparkneve}.jpg");
        }

        public Image getHazKep(int utca, int telek)
        {
            Image HazKep;
            switch (Hazak[utca, telek])
            {
                case 1:
                    HazKep = Image.FromFile($"Kepek{Path.DirectorySeparatorChar}Haz1.jpg");
                    break;
                case 2:
                    HazKep = Image.FromFile($"Kepek{Path.DirectorySeparatorChar}Haz2.jpg");
                    break;
                case 3:
                    HazKep = Image.FromFile($"Kepek{Path.DirectorySeparatorChar}Haz3.jpg");
                    break;

                default:
                    HazKep = Image.FromFile($"Kepek{Path.DirectorySeparatorChar}kereszt.jpg");
                    break;
            }
            return HazKep;
        }

        public Lakopark(int lakoparkid, string lakoparkneve, int utcakszama, int telkekszama)
        {
            this.lakoparkid = lakoparkid;
            Lakoparkneve = lakoparkneve;
            Utcakszama = utcakszama;
            Telkekszama = telkekszama;
            this.hazak = new int[utcakszama, telkekszama];
        }

        internal void HazAdat(int utcaSzam, int hazSzam, int emelet)
        {
            this.hazak[utcaSzam - 1, hazSzam - 1] = emelet;
        }
    }
}
