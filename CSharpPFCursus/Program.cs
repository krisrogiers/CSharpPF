using System;
using Firma;
using Firma.Materiaal;
using Firma.Personeel;


namespace CSharpPFCursus
{
    class Program
    {
        public static void Main(string[] args)
        {
            decimal getal1, getal2;
            try
            {
                Console.Write("eerste getal:");
                getal1 = decimal.Parse(Console.ReadLine());
                Console.Write("tweede getal:");
                getal2 = decimal.Parse(Console.ReadLine());
                if (getal2 != 0m)
                    Console.WriteLine("deling:" + getal1 / getal2);
                else
                    Console.WriteLine("Delen door nul niet toegelaten");

            }
            catch
            {
                Console.WriteLine("Je tikt geen getal");
                
            }

        }
    }
}
