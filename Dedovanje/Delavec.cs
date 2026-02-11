using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dedovanje {
    internal class Delavec{
        protected string delID;
        protected string ime;
        private double stUr;
        private double urnaPostavka;
        protected double brutoPlaca;

        public string DelID { get => delID; set => delID = value; }
        public string Ime { get => ime; set => ime = value; }
        public double StUr { get => stUr; set => stUr = value; }
        public double UrnaPostavka { get => urnaPostavka; set => urnaPostavka = value; }
        public double BrutoPlaca { get {return urnaPostavka * stUr; }}

        public Delavec() {
            Console.WriteLine("Konstruktor delavec");
        }//Konec konstruktor Delavec

        public void Izpis() {
            Console.WriteLine("Del id: "      + delID);
            Console.WriteLine("Ime: "         + ime);
            Console.WriteLine("Št ur:       " + stUr);
            Console.WriteLine("Na uro:      " + urnaPostavka);
            Console.WriteLine("Bruto plača: " + BrutoPlaca);
            Console.WriteLine("********************************************");
        }//Konec Izpis
    }//Konec class Delavec
}
