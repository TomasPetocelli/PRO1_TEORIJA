using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nogomet {
    internal class Ekipa {
        public string Ime { get; set; } //<-- prop + tab
        public int DaniGoli { get; set; }
        public int PrejetiGoli { get; set; }
        public int StTekem { get; set; }
        public int StZmag { get; set; }
        public int StNedolocenih { get; set; }

        public Ekipa(string i) {
            Ime = i;
        }//Konec konstruktor Ekipa

        public void VnesiRezultat(int d, int p) {
            //Vnesi rezultat za to ekipo, ce je na tekmi dala d golov in prejela p golov
            StTekem++;
            DaniGoli += d;
            PrejetiGoli += p;

            if (d > p) {
                StZmag++;
            } else {
                if (d == p) {
                    StNedolocenih++;
                }//Konec if
            }//Konec if-esle
        }//Konec VnesiRezultat

        public int SteviloTock() {
            return StZmag * 3 + StNedolocenih;
        }//Konec SeviloTock

        public int GolaRazlika() {
            return DaniGoli - PrejetiGoli;
        }//Konec GolaRazlika

        public string Izpis() {
            return Ime + "\t" + StTekem + "\t" + SteviloTock() + "\t" + GolaRazlika() + "\t" + DaniGoli;
        }//Konec Izpis

        public bool BoljsaEkipa(Ekipa x) {
            if (this.SteviloTock() > x.SteviloTock()) {
                return true;
            }//Konec if
            if (this.SteviloTock() == x.SteviloTock() && this.GolaRazlika() > x.GolaRazlika()) {
                return true;
            }//Konec if
            if (this.SteviloTock() == x.SteviloTock() && this.GolaRazlika() == x.GolaRazlika() && this.DaniGoli > x.DaniGoli) {
                return true;
            }//Konec if
            return false;
        }//Konec BoljsaEkipa


    }//Konec class Ekipa
}
