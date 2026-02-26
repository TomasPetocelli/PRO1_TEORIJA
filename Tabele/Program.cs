using System.Runtime.Serialization.Formatters;

namespace Tabele {
    internal class Program {
        static void Main(string[] args) {
            int[] a = new int[10];

            for (int i = 0; i < a.Length; i++) {
                a[i] = i;
                Console.WriteLine(a[i]);
            }//Konec for

            int[,] b = new int[3, 4];
            Random random = new Random();

            for (int i = 0; i < b.GetLength(0); i++) { //dimezija 0 je vrstica
                for (int j = 0; j < b.GetLength(1); j++) { //dimenzija 1 je stolpec
                    b[i, j] = random.Next(101);
                    Console.Write(b[i, j] + "\t");
                }//Konec for j - stolpec
                Console.WriteLine();
            }//Konec for i - vrstica

            string[] student = { "adasdasdas", "sdasdasdsd", "sadasdsads" };
            double[] x = new double[5000];

            Napis[] vsiJeziki = new Napis[5];
            for (int k = 0; k < 5; k++) {
                vsiJeziki[k] = new Napis();
                vsiJeziki[k].jezik = "C#";
                vsiJeziki[k].Izpisi();
            }//Konec for
        }//Konec Main
    }//Konec class Program
}//Konec namespace Tabele
