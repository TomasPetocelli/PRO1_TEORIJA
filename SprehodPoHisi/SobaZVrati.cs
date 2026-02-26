using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprehodPoHisi {
    internal class SobaZVrati : Soba, IZunanjaVrata {
        string vrata;
        public Lokacija lok;

        public Lokacija lokacijaVrat() {
            return lok;
        }//Konec lokacijaVrat

        public string OpisVrat() {
            return vrata;
        }//Konec OpisVrat

        public SobaZVrati(string i, string d, string v):base(i,d) {
            vrata = v;
        }//Konec Konstruktor SobaZVrati
    }//Konec class SobaZVrati
}
