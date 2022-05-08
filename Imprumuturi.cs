using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    [Serializable]
   public class Imprumuturi : Carti
    {
        private int perioadaImprumut;
        private int perioadaRamasa;

        public Imprumuturi() : base()
        {
            perioadaImprumut = 0;
            perioadaRamasa = 0;
        }

        public Imprumuturi(string n, int v, string s, string nume, int cod, int perioadaI, int perioadaR):base(n,v,s,nume,cod)
        {
            perioadaImprumut = perioadaI;
            perioadaRamasa = perioadaR;
        }


        public override string ToString()
        {
            return base.ToString() + " pe o perioada de " + perioadaImprumut + " luni, din care au mai ramas " + perioadaRamasa;
        }

    }
}
