using System;

namespace Grootste_methode
{
    class Program
    {
        static void Main(string[] args)
        {
            int grootste = GrootsteGetal(5,50,60);
            Console.WriteLine(grootste);
        }

        static int GrootsteGetal(int v1, int v2, int v3)
        {
            int grootste = v1;
            if (grootste<v2)
            {
                grootste = v2;
            }
            if (grootste<v3)
            {
                grootste = v3;
            }
            return grootste;
        }
    }
}
