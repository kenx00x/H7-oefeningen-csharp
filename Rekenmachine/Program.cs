using System;

namespace Rekenmachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kies getal 1: ");
            double getal1 = double.Parse(Console.ReadLine());
            Console.Write("Kies getal 2: ");
            double getal2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Wat zou je willen doen?");
            Console.WriteLine("1) Optellen");
            Console.WriteLine("2) Aftrekken");
            Console.WriteLine("3) Vermenigvuldiggen");
            Console.WriteLine("4) Delen");
            int keuze = int.Parse(Console.ReadLine());
            double uitkomst=0;
            switch (keuze)
            {
                case 1:
                    uitkomst = TelOp(getal1, getal2);
                    break;
                case 2:
                    uitkomst = TrekAf(getal1, getal2);
                    break;
                case 3:
                    uitkomst = VermenigVuldig(getal1, getal2);
                    break;
                case 4:
                    uitkomst = Deel(getal1, getal2);
                    break;
                default:
                    break;
            }
            Console.WriteLine(uitkomst);
        }

        static double Deel(double getal1, double getal2)
        {
            return getal1 / getal2;
        }

        static double VermenigVuldig(double getal1, double getal2)
        {
            return getal1 * getal2;
        }

        static double TrekAf(double getal1, double getal2)
        {
            return getal1 - getal2;
        }

        static double TelOp(double getal1, double getal2)
        {
            return getal1 + getal2;
        }
    }
}
