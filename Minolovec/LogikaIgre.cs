using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minolovec {
    internal class LogikaIgre {
        public bool[,] mine = new bool[10 + 2, 10 + 2];
        public int[,] resitev = new int[12, 12];

        Random r = new Random();

        public LogikaIgre() {
            //napolni mine z verjetnostjo 0.25
            for (int i = 1; i <= 10; i++) {
                for (int j = 1; j <= 10; j++) {
                    double x = r.NextDouble();
                    mine[i, j] = x < 0.25;
                }//Konec for j
            }//Konec for i

            for (int k = 1; k <= 10; k++) {
                for (int j = 1; j <= 10; j++) {
                    //koliko je min v okolici
                    for (int m = k - 1; m <= k + 1; m++) {
                        for (int z = j - 1; z <= j + 1; z++) {
                            if (mine[m, z])
                                resitev[k, j]++;
                        }//Konec for z
                    }//Konec for m
                }//Konec for j
            }//Konec for k
        }//Konec LogikaIgre
    }//Konec class LogikaIgre
}
