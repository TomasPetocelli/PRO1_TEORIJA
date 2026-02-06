namespace Vaja_05_02 {
    internal class Program {
        static void Main(string[] args) {
            Oseba o = new Oseba("Pippo", 10);
            //o.GetAgeInMonth();

            Console.WriteLine("Starost v mesecih:" + o.GetAgeInMonth());
            Console.WriteLine("Je odrasel: " + o.IsAdult());
        }
    }
}
