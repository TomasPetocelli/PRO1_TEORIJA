using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprehodPoHisi {
    internal class Zunanji:Lokacija {
        public bool vroce;
        public Zunanji(string i, bool v):base(i) { 
            vroce = v;
        }//Konec Konstruktor Zunanji

        public new string Opis() {
            string r = base.Opis();
            r += "Je vroče? " + vroce;
            return r;
        }//Konec Opis
    }//Konec Zunanji
}
