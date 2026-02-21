namespace KalkulatorOcenV1._0 {
    internal class Program {
        static void Main(string[] args) {
            string seEnStudent = "DA";

            do {
                Console.Write("Vnesi oddelek študenta 1-ang, 2-mat, 3-nar: ");
                int oddelek = int.Parse(Console.ReadLine());

                StudentABS student = null;

                switch (oddelek) {
                    case 1:
                        student = new StudentAng();

                        Console.Write("Vnesi oceno delnega izpita 1: ");
                        student.Delni1 = int.Parse(Console.ReadLine());

                        Console.Write("Vnesi oceno delnega izpita 2: ");
                        student.Delni2 = int.Parse(Console.ReadLine());

                        Console.Write("Vnesi oceno seminarske: ");
                        student.Seminar = int.Parse(Console.ReadLine());

                        Console.Write("Vnesi oceno ustnega: ");
                        student.Ustna = int.Parse(Console.ReadLine());
                        break;

                    case 2:
                        student = new StudentMat();

                        Console.Write("Vnesi oceno delnega izpita 1: ");
                        student.Delni1 = int.Parse(Console.ReadLine());

                        Console.Write("Vnesi oceno delnega izpita 2: ");
                        student.Delni2 = int.Parse(Console.ReadLine());
                        break;

                    case 3:
                        student = new StudentNar();

                        Console.Write("Vnesi oceno delnega izpita 1: ");
                        student.Delni1 = int.Parse(Console.ReadLine());

                        Console.Write("Vnesi oceno delnega izpita 2: ");
                        student.Delni2 = int.Parse(Console.ReadLine());

                        Console.Write("Vnesi oceno seminarske: ");
                        student.Seminar = int.Parse(Console.ReadLine());
                        break;

                    default:
                        Console.WriteLine("Napačen oddelek!");
                        continue;
                }//Konec Switch

                Console.WriteLine("\n" + student.Izpis());

                Console.Write("Še kakšen študent? DA/NE: ");
                seEnStudent = Console.ReadLine();

            } while (seEnStudent == "DA"); //Konec While
        }//Konec Main
    }//Konec class Program
}//Konec NameSpace
