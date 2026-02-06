using System.Xml;

namespace Spremenljivke{
    internal class Program{
        static void Main(String[] args){
            //int a = 12;
            //int b = 13;
            //Console.WriteLine("Vsota je: " + (a + b));

            short kratko = 17000;
            int celo = 2 * kratko;
            Console.WriteLine("16-bitno je: "+kratko);
            Console.WriteLine("32-bitno je: "+celo);
            
            kratko = (short)celo;

            Console.WriteLine("16-bitno je: " + kratko);
            Console.WriteLine("32-bitno je: " + celo);
        }
    }
}