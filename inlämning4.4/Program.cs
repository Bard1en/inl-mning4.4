using System;
 namespace Inlämning4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) {
                Console.WriteLine("Välj ett av följande alternativ");
                Console.WriteLine("1. Subtrahera ett tal med ett annat");
                Console.WriteLine("2. Dividera ett tal med ett annat");
                Console.WriteLine("3. Avsluta programmet");
                string alternativ = Console.ReadLine();
                if (alternativ == "1")
                {
                    Console.WriteLine("Skriv in ena talet");
                    int tal1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Skriv in det andra talet");
                    int tal2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Dina tal subtraherade blir " + (tal1 - tal2));
                }
                if (alternativ == "2")
                {
                    Console.WriteLine("Skriv in ena talet");
                    double tal3 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Skriv in det andra talet");
                    double tal4 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Dina tal dividerade blir " + (tal3 / tal4));
                    break;
                }
                if (alternativ == "3")
                {
                    Console.WriteLine("Programmet avlutas...");
                }
                else
                {
                    Console.WriteLine("Du valde inget av alternativen");
                }
            }
          
        }
    }
}