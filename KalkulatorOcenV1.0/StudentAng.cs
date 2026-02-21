using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulatorOcenV1._0 {
    internal class StudentAng : StudentABS {
        public override double KoncnaOcena() {
            return 0.25 * Delni1 + 0.25 * Delni2 + 0.3 * Seminar + 0.2 * Ustna;
        }//Konec KoncnaOcena

        public override string KoncnaCrka() {
            double koncna = KoncnaOcena();

            if (koncna >= 93) return "A";
            else if (koncna >= 85) return "B";
            else if (koncna >= 78) return "C";
            else if (koncna >= 70) return "D";
            else return "F";
        }//Konec KoncnaCrka

        public override string Izpis() {
            return "Končna ocena: " + KoncnaOcena() +
                   "\nKončna črka: " + KoncnaCrka();
        }//Konec Izpis
    }//Konec StudentAng
}//Konec NameSpace
