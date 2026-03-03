using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nogomet {
    internal class Liga {
        Ekipa[] vse = new Ekipa[10];
        int[,] pari = new int[10,10]; //ce je pari[3,4]=8, pomeni da se ekipa vse[3] in vse[4] srecata v 8. kolu turnirja

        int x = 0;
        int y = 1;
        int[] gor = { 2, 3, 4, 5};
        int[] dol = { 9, 8, 7, 6};

        public Liga() {
            vse[0] = new Ekipa("Slovenija  ");
            vse[1] = new Ekipa("Skotska    ");
            vse[2] = new Ekipa("Italija    ");
            vse[3] = new Ekipa("Norveska   ");
            vse[4] = new Ekipa("Nemcija    ");
            vse[5] = new Ekipa("Spanija    ");
            vse[6] = new Ekipa("Portugalska");
            vse[7] = new Ekipa("Islandija  ");
            vse[8] = new Ekipa("Finska     ");
            vse[9] = new Ekipa("Anglija    ");
        }//Konec konstruktor Liga
    }//Konec class Liga
}
