//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Dedovanje {
//    internal class LetniDelavec : DelavecABS{
//        double letnaPlaca;
//        public double LetnaPlaca { get => letnaPlaca; set => letnaPlaca = value; }

//        public override double BrutoPlaca {
//            get { return letnaPlaca / 12; }
//        }//Konec Override BrutoPlaca
//        public override void Izpis() {
//            Console.WriteLine("******************LETNI DELAVEC******************");
//            Console.WriteLine("Del id: "      + DelID);
//            Console.WriteLine("Ime: "         + Ime);
//            Console.WriteLine("Letna Plača: " + letnaPlaca);
//            Console.WriteLine("Bruto plača: " + BrutoPlaca);
//        }//Konec Override Izpis
//    }//Konec class LetnaPlaca
//}
