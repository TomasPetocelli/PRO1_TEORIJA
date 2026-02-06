internal class Program{
    private static void Main(string[] args) {
        Izpisi();

        Izpisi1();
        int x = Izpisi1();
        Console.WriteLine("Metoda je vrnila: " + x);
        Console.WriteLine("Druga možnost: " + Izpisi1());

        //------------------------------------------------------------------
        Izpisi2("Alenka");
        Izpisi2("Mika");

        Console.Write("Vnesi svoje ime: ");
        string mojeIme = Console.ReadLine();

        Console.Write("Kako si: ");
        string kakoSi = Console.ReadLine();

        Izpisi2(mojeIme, kakoSi);

        Izpisi2(5);
    } //konec metode Main

    static void Izpisi() {
        Console.WriteLine("Hello World!");
        return; //V metodi Void "return" ga napišem le če potrebno
    } //Konec metode Izpisi

    static int Izpisi1() {
        return 1;
    } //Konec metode Izpisi1

    static void Izpisi2(string ime, string kakoSi) {
        Console.WriteLine("Pozdravljen/a "+ime);
        Console.WriteLine(kakoSi);
    } //Konec metode Izpisi2

    static void Izpisi2(string ime) {
        Console.WriteLine("Kako si, " + ime + "?");
    }

    static void Izpisi2(int x) {
        Console.WriteLine("Vrednost x: " + x);
    }
} // Konec class Program