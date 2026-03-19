using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VnosPodatkov {
    internal class Student {
        public string Ime { get; set; }
        public string Priimek { get; set; }
        public DateTime DatumRojstva { get; set; }

        private double povprecje;
        public double Povprecje {
            get { return povprecje; }//Konec get
            set {
                if (value < 6)
                    throw new Exception("Napacno povprecje");
                povprecje = value;
            }//konec set
        }//Konec Povprecje
        
        public string Izpis() {
            return Ime + " " + Priimek + " " + DatumRojstva + " " + Povprecje;
        }//Konec Izpis

    }//Konec class Student
}
