using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dedovanje {
    internal class Urnidelavec : DelavecABS {
        int stUr;
        double urnaPostavka;

        public int StUr { get => stUr; set => stUr = value; }
        public double UrnaPostavka { get => urnaPostavka; set => urnaPostavka = value; }

        public override double BrutoPlaca {
            get { return urnaPostavka * stUr; }
        }//Konec Override BrutoPlaca

        public Urnidelavec(string d, string i, int s, int u) : base (d, i) {
            Console.WriteLine("Konstruktor Urni Delavec");
            stUr = s;
            urnaPostavka = u;
        }//Konec konstruktor UnriDelavec

        public override void Izpis() {
            Console.WriteLine("******************URNI DELAVEC******************");
            Console.WriteLine("Del id: "      + DelID);
            Console.WriteLine("Ime: "         + Ime);
            Console.WriteLine("Št ur:       " + stUr);
            Console.WriteLine("Na uro:      " + urnaPostavka);
            Console.WriteLine("Bruto plača: " + BrutoPlaca);
        }//Konec Override Izpis
    }//Konec class UrniDelavec
}
