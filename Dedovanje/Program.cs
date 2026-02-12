namespace Dedovanje {
    internal class Program {
        static void Main(string[] args) {

            Delavec d = new Delavec();
            d.DelID = "123";
            d.Ime = "Miha Kogoj";
            d.StUr = 168;
            d.UrnaPostavka = 8.16;
            d.Izpis();

            LDelavec ld = new LDelavec();
            ld.DelID = "345";
            ld.Ime = "Pippo";
            ld.LetnaPlaca = 300;
            ld.UrnaPostavka = 8.16;
            ld.Izpis();

            Urnidelavec u = new Urnidelavec("567", "Janez Novak", 168, 10);
            u.Izpis();

            //LetniDelavec l = new LetniDelavec();
            //l.DelID = "987";
            //l.Ime = "Marija Novak";
            //l.LetnaPlaca = 12000;
            //l.Izpis();

        }//Konec Main
    }//Konec class Program
}
