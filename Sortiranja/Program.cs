namespace Sortiranja {
    internal class Program {
        static void Main(string[] args) {
            int[] tab = { 7, 3, 9, 8, 1, 12, 10, 4 };
            Bubble(tab);
            Console.WriteLine("Urejena tabela");
            Izpis(tab);

            //Random r = new Random();
            //int[] tab = new int[50000];
            //for (int i = 0; i < tab.Length; i++) { 
            //    tab[i] = r.Next(1000000);
            //}//Konec for

            //DateTime pred = DateTime.Now;
            //Izbiranje(tab);
            //DateTime po = DateTime.Now;

            //TimeSpan cas = (po - pred);
            //double razlika = cas.TotalMicroseconds;
            //Console.WriteLine("Izbiranje: " + tab.Length + " elementov, porabljen cas: " +razlika);
        }//Konec Main

        //----------------------------------------IZBIRANJE----------------------------------------
        static void Izbiranje(int[] a) {
            for (int i = 0; i < a.Length; i++) { 
                //poisci najmanjsi element od i do konca tabele
                int min = a[i];
                int minIndeks = i;

                for (int j = i + 1; j < a.Length; j++) {
                    if (a[j] < min) { 
                        min = a[j];
                        minIndeks = j;
                    }//Konec if
                }//Konec for j
                //najmanjsi eleent preostanka tabele je a[minIndeks]
                //zamenjaj ga s prvim elementom preostanka tabele
                int temp = a[i];
                a[i] = a[minIndeks];
                a[minIndeks] = temp;
                //Izpis(a);
            }//Konec for i
        }//Konec Izbiranje

        static void Izpis(int[] a) {
            for (int i = 0; i < a.Length; i++) {
                Console.Write(a[i] + "\t");
            }//Konec for
            Console.WriteLine();
        }//Konec Izpis

        //----------------------------------------VSTAVLJANJE----------------------------------------
        static void Vstavljanje(int[] a) {
            for (int k = 1; k < a.Length; k++) { 
                //vstavi a[k] na pravo mesto v tabeli
                int j = k;
                int temp = a[k];

                while (j > 0 && a[j - 1] >= temp) {
                    a[j] = a[j - 1];
                    j--;
                }//Konec while
                a[j] = temp;
                Izpis(a);
            }//Konec for k
        }//Konec Vstavljanje

        //----------------------------------------BUBBLE SORT----------------------------------------
        static void Bubble(int[] a) {
            for (int i = a.Length-1; i >=0; i--) { 
                for (int j = 0; j < i; j++) { 
                    if (a[j] > a[j + 1]) {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }//Konec if
                }//Konec for j
                Izpis(a);
            }//Konec for i
        }//Konec Bubble
    }//Konec class Program
}
