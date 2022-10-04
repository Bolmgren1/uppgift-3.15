using System;

namespace inlämningsuppgift 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många timmar vill du hyra bilen?");
            int hej = int.Parse(Console.ReadLine());
            int pris = hej * 80;
            

            if (pris > 950)
            {
                Console.WriteLine("Du får inte hyra bilen");

            }
            else
            {
                Console.WriteLine("Du får låna bilen, det blir " + pris + " kronor");

            }
        }
    }
}
