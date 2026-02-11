using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dedovanje {
    internal class LDelavec : Delavec {
        private double letnaPlaca;

        public double LetnaPlaca { get => letnaPlaca; set => letnaPlaca = value; }

        public LDelavec() {
            Console.WriteLine("sem v konstruktorju LDelavec");
        }//Konec konstruktor Delavec

        public new double BrutoPlaca { get { return letnaPlaca / 12; } }

        public void Izpis() {
            Console.WriteLine("Del id: " + delID);
            Console.WriteLine("Ime: " + ime);
            Console.WriteLine("Letna plača:       " + letnaPlaca);
            Console.WriteLine("Bruto plača: " + BrutoPlaca);
            Console.WriteLine("********************************************");
        }//Konec Izpis
    }//Konec class LDelavec
}
