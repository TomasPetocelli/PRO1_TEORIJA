using System.Net.Http.Headers;

namespace SprehodPoHisi {
    class Program {
        static Lokacija trenutnaLokacija;
        static SobaZVrati dnevnaSoba;
        static Soba jedilnica;
        static SobaZVrati kuhinja;
        static ZunanjiZVrati zadnjeDvorišče;
        static ZunanjiZVrati sprednjeDvorišče;
        static Zunanji vrt;
        static void Main(string[] args) {
            UstvariHišo();
            PremakniSe(dnevnaSoba);
            trenutnaLokacija = dnevnaSoba;
            string nova = "";
            while (nova != "K") {
                Console.WriteLine("Kam naj grem? K = Konec");
                nova = Console.ReadLine();
                Lokacija novaLokacija = null;
                if (nova == "K") {
                    Console.WriteLine("Lep sprehod!");
                    break;
                }//Konec if
                if (nova == "I") {
                    //izhod
                    if (trenutnaLokacija is IZunanjaVrata) {
                        novaLokacija =
                       ((IZunanjaVrata)trenutnaLokacija).lokacijaVrat();
                    }//Konec if
                } else {
                    int l = int.Parse(nova);
                    novaLokacija = new Lokacija(trenutnaLokacija.izhodi[l].ime);
                }//Konec if-else
                switch (novaLokacija.ime)
                {
                    case "Dnevna soba":
                        novaLokacija = dnevnaSoba; break;
                    case "Jedilnica":
                        novaLokacija = jedilnica; break;
                    case "Kuhinja":
                        novaLokacija = kuhinja; break;
                    case "Sprednje dvorišče":
                        novaLokacija = sprednjeDvorišče; break;
                    case "Zadnje dvorišče":
                        novaLokacija = zadnjeDvorišče; break;
                    case "Vrt":
                        novaLokacija = vrt; break;
                }//Konec switch
                PremakniSe(novaLokacija);
            }//Konec while
        }//Konec Main
        public static void UstvariHišo() {
            dnevnaSoba = new SobaZVrati("Dnevna soba", "starinski tepih", "hrastova vrata");
            jedilnica = new Soba("Jedilnica", "kristalni luster");
            kuhinja = new SobaZVrati("Kuhinja", "nerjaveči pripomočki", "navadna vrata");
           
            sprednjeDvorišče = new ZunanjiZVrati("Sprednje dvorišče", false, "hrastova vrata");
           
            zadnjeDvorišče = new ZunanjiZVrati("Zadnje dvorišče", true, "navadna vrata");
           
            vrt = new Zunanji("Vrt", false);
            jedilnica.izhodi = new Lokacija[2];
            jedilnica.izhodi[0] = dnevnaSoba;
            jedilnica.izhodi[1] = kuhinja;
            dnevnaSoba.izhodi = new Lokacija[1];
            dnevnaSoba.izhodi[0] = jedilnica;
            kuhinja.izhodi = new Lokacija[1];
            kuhinja.izhodi[0] = jedilnica;
            sprednjeDvorišče.izhodi = new Lokacija[2];
            sprednjeDvorišče.izhodi[0] = zadnjeDvorišče;
            sprednjeDvorišče.izhodi[1] = vrt;
            zadnjeDvorišče.izhodi = new Lokacija[2];
            zadnjeDvorišče.izhodi[0] = sprednjeDvorišče;
            zadnjeDvorišče.izhodi[1] = vrt;
            vrt.izhodi = new Lokacija[2];
            vrt.izhodi[0] = zadnjeDvorišče;
            vrt.izhodi[1] = sprednjeDvorišče;
            dnevnaSoba.lok = sprednjeDvorišče;
            sprednjeDvorišče.lok = dnevnaSoba;
            kuhinja.lok = zadnjeDvorišče;
            zadnjeDvorišče.lok = kuhinja;
        }//Konec UstvariHišo
        public static void PremakniSe(Lokacija nova) {
            trenutnaLokacija = nova;
            string a = trenutnaLokacija.Opis();
            if (trenutnaLokacija is IZunanjaVrata)
                a += " (I) Pojdi skozi vrata .";
            Console.WriteLine(a);
        }//Konec PremakniSe
    }//Konec class Program
}//Konec NameSpace SprehodPoHisi
