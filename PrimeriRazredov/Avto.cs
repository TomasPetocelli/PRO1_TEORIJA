using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeriRazredov {
    internal class Avto {
        int najvecjaHitrost;
        double povprecnaPoraba;
        double kolicinaGoriva;
        int steviloPrevozenih;
        string regSt;

        public Avto(string r, int n, double p) { 
            najvecjaHitrost = n;
            povprecnaPoraba = p;
            regSt = r;
            steviloPrevozenih = 0;
            kolicinaGoriva = 0;
        }//Konec Avto

        public Avto(string r, int n, double p, double k, int s) {
            najvecjaHitrost = n;
            povprecnaPoraba = p;
            regSt = r;
            steviloPrevozenih = s;
            kolicinaGoriva = k;
        }//Konec Avto

        public void Izpis() {
            Console.WriteLine("********************************AVTO********************************");

            Console.WriteLine("Registerska številka: "   + regSt);
            Console.WriteLine("Največja hitrost: "       + najvecjaHitrost);
            Console.WriteLine("Povprečna poraba: "       + povprecnaPoraba);
            Console.WriteLine("Število prevoženih km: "  + steviloPrevozenih);
            Console.WriteLine("Količina goriva: "        + kolicinaGoriva);

            Console.WriteLine("********************************************************************");
        }//Konec Izpis

        public double Doseg() {
            return kolicinaGoriva * 100 / povprecnaPoraba;
        }//Konec Dosek

        public int NaslednjiServis(int n) {
            return n - steviloPrevozenih;
        }


    }//Konec class Avto
}
