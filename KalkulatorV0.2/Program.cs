using System;
using System.Globalization;
using System.Windows.Forms;

internal class Program {
    private static void Main(string[] args) {
        string seEnStudent = "";
        do
        {

            Console.Write("Vnesi oddelek študenta 1-ang, 2-mat, 3-nar: ");
            int oddelek = int.Parse(Console.ReadLine());

            int delni1 = 0;
            int delni2 = 0;
            int seminar = 0;
            int ustna = 0;
            double koncna = 0;
            string crka;

            //glede na oddelek študenta
            switch (oddelek)
            {
                case 1:
                    Console.Write("Vnesi oceno delnega izpita 1: ");
                    delni1 = int.Parse(Console.ReadLine());

                    Console.Write("Vnesi oceno delnega izpita 2: ");
                    delni2 = int.Parse(Console.ReadLine());

                    Console.Write("Vnesi oceno seminarske: ");
                    seminar = int.Parse(Console.ReadLine());

                    Console.Write("Vnesi oceno ustnega: ");
                    ustna = int.Parse(Console.ReadLine());

                    koncna = 0.25 * delni1 + 0.25 * delni2 + 0.3 * seminar + 0.2 * ustna;

                    if (koncna >= 93)
                    {
                        crka = "A";
                    }
                    else if (koncna >= 85)
                    {
                        crka = "B";
                    }
                    else if (koncna >= 78)
                    {
                        crka = "C";
                    }
                    else if (koncna >= 70)
                    {
                        crka = "D";
                    }
                    else
                    {
                        crka = "F";
                    }
                    break; //Konec case 1

                case 2:
                    Console.WriteLine("Vnesi oceno delnega izpita 1");
                    delni1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Vnesi oceno delnega izpita 2");
                    delni2 = int.Parse(Console.ReadLine());

                    koncna = 0.5 * delni1 + 0.5 * delni2;

                    if (koncna >= 90)
                    {
                        crka = "A";
                    }
                    else if (koncna >= 83)
                    {
                        crka = "B";
                    }
                    else if (koncna >= 76)
                    {
                        crka = "C";
                    }
                    else if (koncna >= 65)
                    {
                        crka = "D";
                    }
                    else
                    {
                        crka = "F";
                    }
                    break; //Konec case 2
                case 3:
                    Console.Write("Vnesi oceno delnega izpita 1: ");
                    delni1 = int.Parse(Console.ReadLine());

                    Console.Write("Vnesi oceno delnega izpita 2: ");
                    delni2 = int.Parse(Console.ReadLine());

                    Console.Write("Vnesi oceno seminarske: ");
                    seminar = int.Parse(Console.ReadLine());

                    koncna = 0.4 * delni1 + 0.4 * delni2 + 0.2 * seminar;

                    if (koncna >= 90)
                    {
                        crka = "A";
                    }
                    else if (koncna >= 80)
                    {
                        crka = "B";
                    }
                    else if (koncna >= 70)
                    {
                        crka = "C";
                    }
                    else if (koncna >= 60)
                    {
                        crka = "D";
                    }
                    else
                    {
                        crka = "F";
                    }

                    MessageBox.Show("Končna ocena: " +koncna +Environment.NewLine +"Končna črka: "+crka, "VSŠ", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break; //Konec case 3
            } // Konec Switch
            Console.Write("Še kakšen študent? DA/NE ");
            seEnStudent = Console.ReadLine();
        } while (seEnStudent == "DA"); // Konec Do

    }// Konec Main
}// Konec class Program