using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulatorOcenV1._0 {
    internal class StudentNar : StudentABS {
        public override double KoncnaOcena() {
            return 0.4 * Delni1 + 0.4 * Delni2 + 0.2 * Seminar;
        }//Konec KoncnaOcena

        public override string KoncnaCrka() {
            double koncna = KoncnaOcena();

            if (koncna >= 90) return "A";
            else if (koncna >= 80) return "B";
            else if (koncna >= 70) return "C";
            else if (koncna >= 60) return "D";
            else return "F";
        }//Konec KoncnaCrka

        public override string Izpis() {
            return "Končna ocena: " + KoncnaOcena() +
                   "\nKončna črka: " + KoncnaCrka();
        }//Konec Izpis
    }//Konec StudentNar
}//Konec NameSpace
