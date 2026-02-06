internal class Program {
    private static void Main(string[] args) {
        //Console.Write("Vnesi svoj najljubši programski jezik: ");
        //string odgovor = Console.ReadLine();

        //if (odgovor == "C#") {
        //    Console.WriteLine("Imaš dober okus");
        //} else {
        //    Console.WriteLine("Tudi " + odgovor + "je v redu programski jezik");
        //}

        //---------------------------------------------------------------------------------------------------
        //Console.Write("Vnesi svoje starost: ");
        //int starost = int.Parse(Console.ReadLine());

        //if (starost >= 65) {
        //    Console.WriteLine("Moraš se upokojiti");
        //} else if (starost == 64) {
        //    Console.WriteLine("Še 1 leto");
        //} else if (starost == 63) {
        //    Console.WriteLine("Še 2 leti");
        //} else if (starost == 62) {
        //    Console.WriteLine("Še 3 leta");
        //} else if (starost <= 61) {
        //    Console.WriteLine("Še dolgo boš delal");
        //}

        //---------------------------------------------------------------------------------------------------
        Console.Write("Vnesi število (1-5): ");
        int st = int.Parse(Console.ReadLine());

        switch (st) {
            case 1: Console.WriteLine("Vnesel si 1"); break;
            case 2: Console.WriteLine("Vnesel si 2"); break;
            case 3: Console.WriteLine("Vnesel si 3"); break;
            case 4: case 5: Console.WriteLine("Vnesel si 4 ali 5"); break;
            default: Console.WriteLine("Število ni med 1 in 5"); break;
        }

    } //Konec Main
}