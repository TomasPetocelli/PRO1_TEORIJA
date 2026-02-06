internal class Program
{
    static void Main(String[] args)
    {
        Console.Write("koliko denarja si prinesel za zastaviti? Vnesi: ");
        int stanje = int.Parse(Console.ReadLine());

        Console.Write("Zacetna stava: ");
        int stava = int.Parse(Console.ReadLine());

        int zacStanje = stanje;
        int zacStava = stava;
        int min = 10000000;
        int max = -10000;
        Random r = new Random();

        for (int k = 0; k <= 10; k++)
        {
            int stevilo = r.Next();

            if (stevilo % 2==0 && stevilo != 0) {
                zacStanje += stava;
                stava = zacStava;

                Console.WriteLine(k+ ". rdeča - zmaga " +stanje);
            } else {
                zacStanje -= stava;
                stava = 2*stava;

                Console.WriteLine(k + ". črna - izguba " + stanje);
            }

            if (stanje < min)
            {
                min = stanje;
            } else
            {
                max = stanje;
            }

            Console.WriteLine("Število metov" +k);
            Console.WriteLine("Začetno stanje: " +zacStanje);
            Console.WriteLine("Končno stanje: " + stanje);
            Console.WriteLine("Min: " + min);
            Console.WriteLine("Max: " + max);
            Console.WriteLine("Dobiček: " +(stanje - zacStanje));
        }
    }
}