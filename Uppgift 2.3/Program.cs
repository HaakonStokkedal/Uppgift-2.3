using System;

namespace Uppgift_2._3
{

    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Hur många kilometer ska du köra med bilen?");
            string kilometerText = Console.ReadLine();
            Console.WriteLine("Hur många dagar vill du hyra bilen?");
            string dagarText = Console.ReadLine();
            int kilometer = int.Parse(kilometerText);
            int dagar = int.Parse(dagarText);
            long totalt = 300 + (dagar * 500) - 500 + kilometer; 
            Console.WriteLine("Det kommer kosta " +  totalt + " kr.");

            Console.ReadKey();
        }
    }
}