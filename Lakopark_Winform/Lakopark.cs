﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Lakopark(int lakoparkid, string lakoparkneve, int utcakszama, int telkekszama)
        {
            this.lakoparkid = lakoparkid;
            Lakoparkneve = lakoparkneve;
            Utcakszama = utcakszama;
            Telkekszama = telkekszama;
            this.hazak = new int[utcakszama, telkekszama];
        }
    }
}