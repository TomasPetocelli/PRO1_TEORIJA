namespace Razredi {
    internal class Program {
        static void Main(string[] args) {
            Napis x = new Napis();
            x.najljubsiProgra = "C#";
            x.Izpisi();
            x.koliko();

            Napis y = new Napis("Java");
            y.Izpisi();
            y.koliko();
            x.koliko();

            Napis.steviloIzvodov = 7;
            x.koliko();
            y.koliko();

            Student marija = new Student();
            marija.Izpis();
            marija.Ime = "Marija Šaranova";
            marija.Starost = -3;
            Console.WriteLine(marija.PovprecnaOcena);
        }
    }
}
