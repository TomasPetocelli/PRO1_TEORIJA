using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeriRazredov {
    internal class Tocka {
        double x;
        double y;
        double r;
        int kot;

        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }
        public double R { get => r; set => r = value; }
        public int Kot { get => kot; set => kot = value; }

        public Tocka(double x1, double y1) {
            x = x1;
            y = y1;
            IzKvP();
        }//Konec Tocka

        public Tocka(double r1, int k) {
            r = r1;
            kot = k;
            IzPvK();
        }//Konec Tocka

        public void Izpis() {
            Console.WriteLine("********************************TOCKA********************************");

            Console.WriteLine("Kartezične:    (" + x + ", " + y + ")");
            Console.WriteLine("Polare:        (" + r + ", " + kot + ")");

            Console.WriteLine("*********************************************************************");
        }//Konec Izpis

        public void IzKvP() {
            //x, y poznam, racunam r in kot
            r = Math.Sqrt(x * x + y * y);
            kot = (int)(Math.Atan(y / x) * 180 / Math.PI);
        }

        public void IzPvK() {
            //r in kot poznam, racunam x in y
            x = r * Math.Cos(kot * Math.PI / 180);
            y = r * Math.Sin(kot * Math.PI / 180);
        }
    }
}
