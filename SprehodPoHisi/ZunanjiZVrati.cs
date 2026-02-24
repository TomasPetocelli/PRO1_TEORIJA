using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprehodPoHisi {
    internal class ZunanjiZVrati:Zunanji,IZunanjaVrata{
        string vrata;
        Lokacija lok;

        public Lokacija lokacijaVrat() {
            return lok;
        }//Konec lokacijaVrat

        public string OpisVrat() {
            return vrata;
        }//Konec OpisVrat

        public ZunanjiZVrati(string i, bool v, string a):base(i,v) {
            vrata = a;
        }
    }//Konec class ZunanjiZVrati
}
