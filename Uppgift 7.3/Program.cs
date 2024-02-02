using System;
using System.Collections.Generic;

namespace Uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> länder = new Dictionary<string, int>();

            länder["Sverige"] = 450;
            länder["Norge"] = 385;
            länder["Danmark"] = 43;
            länder["Finland"] = 338;

            Console.WriteLine("Skriv in Sverige, Norge, Danmark eller Finland");
            string val = Console.ReadLine().ToLower();

            switch (val)
            {
                case "sverige":
                    Console.WriteLine("Arean (10^5 km^2) på Sverige är:");
                    Console.WriteLine(länder["Sverige"]);
                    break;

                case "norge":
                    Console.WriteLine("Arean (10^5 km^2) på Norge är:");
                    Console.WriteLine(länder["Norge"]);
                    break;

                case "danmark":
                    Console.WriteLine("Arean (10^5 km^2) på Danmark är:");
                    Console.WriteLine(länder["Danmark"]);
                    break;

                case "finland":
                    Console.WriteLine("Arean (10^5 km^2) på Finland är:");
                    Console.WriteLine(länder["Finland"]);
                    break;

                default:
                    Console.WriteLine("Du valde ej ett giltigt alternativ.");
                    break;
            }
        }
    }
}