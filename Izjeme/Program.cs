namespace Izjeme {
    internal class Program {
        static void Main(string[] args) {
            try {
                Console.Write("Vnesi stevilo med 1 in 100 - deljenec: ");
                string x = Console.ReadLine();
                int d = int.Parse(x);
                if (d < 1 || d > 100) {
                    throw new Exception("Stevilo ni med 1 in 100");
                }//Konec if

                Console.Write("Vnesi stevilo med 1 in 10 - delitelj: ");
                x = Console.ReadLine();
                int de = int.Parse(x);
                if (de < 1 || de > 10) {
                    throw new Exception("Stevilo ni med 1 in 10");
                }//Konec if

                int k = d / de;
                Console.WriteLine("Kolicnik je: " + k);
            } catch (FormatException) {
                Console.WriteLine("Napacen vnos");
            } catch (DivideByZeroException) {
                Console.WriteLine("Ne smemo deliti z 0");
            } catch (Exception e) {
                Console.WriteLine("Prislo je do napake!");
                Console.WriteLine(e.Message);
            } finally {
                Console.WriteLine("Hvala, ker ste racunali z nami");
            }//Konec try-catch-finally


        }//Konec Main
    }//Konec class Program
}
