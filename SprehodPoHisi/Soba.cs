using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprehodPoHisi {
    internal class Soba:Lokacija {
        public string dekoracija;

        public Soba(string i, string d):base(i) {
            dekoracija = d;
        }//konec Soba

        public new string Opis() {
            string r = base.Opis();
            r += Environment.NewLine + "Vidiš" + dekoracija;
            return r;
        }//Konec Opis
    }//Konec class Soba
}
