using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    [Serializable]
   public class Carti : Cititori
    {
        
        private string numeCarte;
        private int codCarte;

        public String NumeCarte { get; set; }
        public int CodCarte { get; set; }

        public int[] CartiAnuale { get; set; }

        public Carti() : base()
        {
            numeCarte = "";
            codCarte = 0;
        }

        public Carti(string n, int v, string s, string nume, int cod) : base(n, v, s)
        {
            numeCarte = nume;
            codCarte = cod;
        }

        public override string ToString()
        {
            return base.ToString() + " a imprumutat cartea cu numele " + numeCarte + " cu codul " + codCarte;
        }

    

    


    }
}






