namespace PrimeriRazredov {
    internal class Program {
        static void Main(string[] args) {

            //*********************************************AVTO*********************************************
            Avto a1 = new Avto("M3-915", 165, 6.8);
            a1.Izpis();

            Avto a2 = new Avto("LJ A1-123", 200, 7.25, 28.9, 87345);
            a2.Izpis();
            Console.WriteLine("Lajko prevoziš še: " +a2.Doseg() +"km");
            Console.WriteLine("Naslednji servis: " +a2.NaslednjiServis(15000));

            Console.WriteLine("\n\n\n");
            //*********************************************TOCKA*********************************************
            Tocka t = new Tocka(1.0, 1.0);
            t.Izpis();

            Tocka t1 = new Tocka(1.0, 1);
            t1.Izpis();

        }//Konec Main
    }//Konec class Program
}
