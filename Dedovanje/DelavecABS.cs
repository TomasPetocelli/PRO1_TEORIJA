using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dedovanje {
    internal abstract class DelavecABS {
        private string delID;
        private string ime;

        public string DelID { get => delID; set => delID = value; }
        public string Ime { get => ime; set => ime = value; }
        public abstract double BrutoPlaca {  get; }
        public abstract void Izpis();

        public DelavecABS(string d, string i) {
            Console.WriteLine("Konstruktor abstraktnega razreda");

            this.delID = d;
            this.ime = i;
        }//konstruktor DelavecABS
    }//Konec abstract class DelavecABS
}
