using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nogomet {
    internal class Liga {
        Ekipa[] vse = new Ekipa[10];
        Ekipa[] original = new Ekipa[10];
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
            IzdelajTurnir();
        }//Konec konstruktor Liga

        public void IzdelajTurnir() {
            for (int kolo = 1; kolo <= 9; kolo++) {
                NapolniPare(kolo);
            }//Konec for

            for (int k = 0; k <= 9; k++) {
                original[k] = vse[k];
            }//Konec for
        }//Konec IzdelajTurnir

        private void NapolniPare(int kolo) {
            //zapisi podatek v tabelo pari
            pari[x, y] = kolo;
            for (int k = 0; k < 4; k++) {
                pari[gor[k], dol[k]] = kolo;
            }//Konec for
            int temp = y;
            y = dol[0]; 
            dol[0] = dol[1]; dol[1] = dol[2]; dol[2] = dol[3]; dol[3] = gor[3]; 
            gor[3] = gor[2]; gor[2] = gor[1]; gor[1] = gor[0]; gor[0] = temp;
        }//Konec NapolniPare

        public void IzpisiPare() {
            for (int k = 1; k <= 9; k++) {
                Console.WriteLine("Pari kola: " +k);
                for (int j = 0; j < 10; j++) {
                    for (int m = 0; m < 10; m++) {
                        if (pari[j,m] == k) {
                            Ekipa x = vse[j];
                            Ekipa y = vse[m];
                            Console.WriteLine(x.Ime + " : " + y.Ime);
                        }//Konec if
                    }//Konec for m
                }//Konec for j
                Console.WriteLine("------------------------------------------------");
            }//Konec for k
        }//Konec IzpisiPare

        public void VnesiRezultate(int k) {
            for (int j = 0; j < 10; j++) {
                for (int m = 0; m < 10; m++) {
                    if (pari[j, m] == k) {
                        Ekipa x = original[j];
                        Ekipa y = original[m];
                        Console.Write("Vnesi rezultat v obliki x:y -> ");
                        Console.WriteLine(x.Ime + " : " + y.Ime);

                        //3:4
                        string rezultat = Console.ReadLine();
                        string[] r = rezultat.Split(":"); //v r[0] = '3' v r[1] = '4'
                        int goli1 = int.Parse(r[0]);
                        int goli2 = int.Parse(r[1]);

                        x.VnesiRezultat(goli1, goli2);
                        y.VnesiRezultat(goli2, goli1);

                    }//Konec if
                }//Konec for m
            }//Konec for j
        }//Konec VnesiRezultate

        public void IzpisLestvice() {
            for (int k = 0; k < 10; k++) {
                Console.WriteLine(vse[k].Izpis());
            }//Konec for
        }//Konec IzpisLestvice

        public void UrediLestvico() {
            for (int i = 0; i < vse.Length -1; i++) {
            //poisci najmanjsi element od i do konca tabele
                Ekipa min = vse[i];
                int minIndeks = i;
                for (int j = i + 1; j < vse.Length; j++) {
                    if (vse[j].BoljsaEkipa(min)) {
                        min = vse[j];
                        minIndeks = j;
                    }//Konec if
                }//Konec for j
                //najmanjsi eleent preostanka tabele je a[minIndeks]
                //zamenjaj ga s prvim elementom preostanka tabele
                Ekipa temp = vse[i];
                vse[i] = vse[minIndeks];
                vse[minIndeks] = temp;
                IzpisLestvice();
            }//Konec for i
        }//Konec UrediLestvico
    }//Konec class Liga
}
