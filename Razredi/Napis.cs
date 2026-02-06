using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Razredi {
    internal class Napis {
        public string najljubsiProgra; //atribut razreda

        public static int steviloIzvodov;
        //obnasanje
        public void Izpisi() {
            Console.WriteLine("Rad imam: " + najljubsiProgra);
        }

        //konstruktor -> je metoda, ki hlicemo ob besedi 'new' (ctor + TAB)
        public Napis() {
            Console.WriteLine("Sem v konstruktorju");
            najljubsiProgra = "Ne znamo";
            steviloIzvodov++;
        }

        public Napis(string jezik) {
            Console.WriteLine("Sem v drugem konstruktorju");
            najljubsiProgra = jezik;
            steviloIzvodov++;
        }

        public void koliko() {
            Console.WriteLine("Število izvodov: " +steviloIzvodov);
        }

        ~Napis() {
            Console.WriteLine("Destruktor napisa");
        }
    }
}
