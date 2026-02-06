using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Vaja_05_02 {
    internal class Oseba{
        string ime;
        int Starost;

        public Oseba(String i, int st) {
            ime = i;
            Starost = st;
        }
        public int GetAgeInMonth() {
            return Starost * 12;
        }

        public bool IsAdult(){
            if(Starost >= 18) {
                return true;
            } else {
                return false;
            }
        }//Konec IsAdult
        
        
    }
}//Konec NameSpace
