using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    [Serializable]
    public abstract class Cititori
    {
        

        protected string nume;
        protected int varsta;
        protected string sex;

        public Cititori()
        {
            nume = "";
            varsta = 0;
            sex = null;
        }

        public Cititori(string n, int v, string s)
        {
            nume = n;
            varsta = v;
            sex = s;
        }

    

        public override string ToString()
        {
            return "Cititorul cu numele " + nume + " are varsta " + varsta + " si sexul " + sex;

        }

       


    }
}
