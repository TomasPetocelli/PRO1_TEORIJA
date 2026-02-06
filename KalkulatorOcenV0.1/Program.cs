internal class Program
{
    private static void Main(string[] args)
    {
        int delni1 = 70;
        int delni2 = 80;
        int seminar = 90;
        int ustna = 100;

        const double D1PROCENT = 0.25;
        const double D2PROCENT = 0.25;
        const double SPROCENT = 0.3;
        const double UPROCENT = 0.2;

        double koncaOcena = 
            D1PROCENT * delni1 +
            D2PROCENT * delni2 +
            SPROCENT * seminar +
            UPROCENT * ustna;
        Console.WriteLine("Končna ocena je:" + koncaOcena + ".");
        Console.WriteLine("Končna ocena je {0}.", koncaOcena);

    }
}