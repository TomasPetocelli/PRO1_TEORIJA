namespace Nogomet {
    internal class Program {
        static void Main(string[] args) {

            Liga nogomet = new Liga();
            //nogomet.IzpisiPare();
            nogomet.VnesiRezultate(1);
            nogomet.UrediLestvico();
            nogomet.IzpisLestvice();

        }//Konec Main
    }//Konec class Program
}
