using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulatorOcenV1._0 {
    internal abstract class StudentABS {
        protected int delni1;
        public int Delni1 {
            get => delni1;
            set {
                if (value >= 0 && value <= 100) {
                    delni1 = value;
                } else {
                    throw new Exception("Napačna ocena");
                }//Konec if-else     
            }//Konec set
        }//Konec Delni1

        //***********************************************************************
        protected int delni2;
        public int Delni2 {
            get => delni2;
            set {
                if (value >= 0 && value <= 100) {
                    delni2 = value;
                } else {
                    throw new Exception("Napačna ocena");
                }//Konec if-else     
            }//Konec set
        }//Konec Delni2

        //***********************************************************************
        protected int seminar;
        public int Seminar {
            get => seminar;
            set {
                if (value >= 0 && value <= 100) {
                    seminar = value;
                } else {
                    throw new Exception("Napačna ocena");
                }//Konec if-else     
            }//Konec set
        }//Konec Seminar

        //***********************************************************************
        protected int ustna;
        public int Ustna {
            get => ustna;
            set {
                if (value >= 0 && value <= 100) {
                    ustna = value;
                } else {
                    throw new Exception("Napačna ocena");
                }//Konec if-else     
            }//Konec set
        }//Konec Ustna

        //***********************************************************************
        public abstract double KoncnaOcena();
        public abstract string KoncnaCrka();
        public abstract string Izpis();

    }//Konec abstract class StudwentABS
}
