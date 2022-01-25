using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022_01_25_Fuvar
{
    class Fuvar1
    {
        public int TaxiID { get; set; }
        public string Indulas { get; set;   }
        public int Idotartam { get; set; }
        public double Tavolsag { get; set; }
        public double VitelDij { get; set; }
        public double Borravalo { get; set; }
        public string FizetesMod { get; set; }


        public Fuvar1(string sor)
        {
            string[] t = sor.Split(';');
            TaxiID = int.Parse(t[0]);
            Indulas = t[1];
            Idotartam = int.Parse(t[2]);
            Tavolsag = double.Parse(t[3]);
            VitelDij = double.Parse(t[4]);
            Borravalo = double.Parse(t[5]);
            FizetesMod = t[6];

        }
    }
}
