using System;

namespace Basic_2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyIntro("Jos", 34, "Trammezantlei 21");
        }

        static void MyIntro(string naam, int leeftijd, string adres)
        {
            Console.WriteLine($"Ik ben {naam}, ik ben {leeftijd} jaar oud en woon in de {adres}");
        }
    }
}
