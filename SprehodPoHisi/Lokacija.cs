using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprehodPoHisi {
    internal class Lokacija {
        public string ime;
        public Lokacija[] izhodi;

        public Lokacija(string i) {
            ime = i;
            izhodi = new Lokacija[10]; //inicializacija tabele
        }//Konec konstruktor Lokacija

        public string Opis() {
            string s = "Trenutno si v " + ime +Environment.NewLine;
            s += "Od tu lahko greš: ";

            for (int k = 0; k < izhodi.Length; k++) {
                s += k+" - " + izhodi[k].ime +Environment.NewLine;
            }//konec for
            return s;
        }//Konec Opis

    }//Konec class Lokacija
}
