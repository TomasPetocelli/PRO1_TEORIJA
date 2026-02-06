namespace Bankomat {
    using System.Windows.Forms;
    internal class Program {
        static decimal stanje = 100;
        static decimal znesek = 0;
        static void Main(string[] args) {
            Console.Write("Želiš opravljati transakcije da/ne: ");
            string odg = Console.ReadLine();
            while (odg.ToUpper() == "DA") {

                Console.Write("kaj želiš? 1-Dvig, 2-Polog, 3-Izpis stanja: ");

                int tip = int.Parse(Console.ReadLine());

                switch (tip) {
                    case 1: Dvig(); break;
                    case 2: Polog(); break;
                    case 3: IzpisStanja(); break;
                }

                Console.Write("Želiš opravljati transakcije da/ne: ");
                odg = Console.ReadLine();
            }//Konec while
        } // Konec metode Main

        static void Dvig() {
            Console.Write("Koliko boš dvignil? ");
            znesek = decimal.Parse(Console.ReadLine());
            stanje -= znesek;
            Console.WriteLine("Novo stanje je: " + stanje);
        } //Konec metode Dvig

        static void Polog()
        {
            Console.Write("Koliko boš dvignil? ");
            znesek = decimal.Parse(Console.ReadLine());
            stanje += znesek;
            Console.WriteLine("Novo stanje je: " + stanje);
        } //Konec metode polog

        static void IzpisStanja() {
            MessageBox.Show("Moje stanje je: " + stanje + " EURO", "Bankomat", MessageBoxButtons.OK, MessageBoxIcon.Information);
        } //Konec metode IzpisStanja
    } //Konec class Program
}
