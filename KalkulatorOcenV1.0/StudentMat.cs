using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulatorOcenV1._0 {
    internal class StudentMat : StudentABS {
        public override double KoncnaOcena() {
            return delni1 * 0.5 + delni2 * 0.5;
        }//Konec Override KoncnaOcena

        public override string KoncnaCrka() {
            if (KoncnaOcena() >= 90)
                return "A";
            if (KoncnaOcena() >= 83)
                return "B";
            if (KoncnaOcena() >= 76)
                return "C";
            if (KoncnaOcena() >= 65)
                return "D";
            return "F";
        }//Konec Override KoncnaCrka

        public override string Izpis() {
            string r = "****************STUDENT MATEMATIKE****************" + Environment.NewLine;
            r += "Delni1 1:   " + delni1 + Environment.NewLine;
            r += "Delni 2:    " + delni2 + Environment.NewLine;
            r += "Ocena Točk: " + KoncnaOcena() + Environment.NewLine;
            r += "Črka:       " + KoncnaCrka() + Environment.NewLine;
            return r;
        }//Konec Override Izpis
    }
}
