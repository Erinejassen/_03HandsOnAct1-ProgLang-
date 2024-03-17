using System;
using System.Collections;

namespace _03HandsOnAct1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList primarycolors = new ArrayList() { "red", "yellow", "blue" };
            Dictionary<string, string> colorcombinations = new Dictionary<string, string>()
            {
                { "redblue", "violet" },
                { "redyellow", "orange" },
                { "blueyellow", "green" },
                { "bluered", "violet" },
                { "yellowred", "orange" },
                { "yellowblue", "green" }
            };

            Console.Write("Enter First Color: ");
            string color1 = Console.ReadLine().ToLower();
            Console.Write("\nEnter Second Color: ");
            string color2 = Console.ReadLine().ToLower();


            if (primarycolors.Contains(color1) && primarycolors.Contains(color2))
            {
                string combination = color1 + color2;

                if (colorcombinations.ContainsKey(combination))
                {
                    Console.WriteLine("\n"+color1+" + "+color2+ " = " + $"{colorcombinations[combination]}");

                }
                else
                {
                    Console.WriteLine("\n One or Either of them is not a primary color");
                };
            }
            else 
            {
                Console.WriteLine("\n no secondary colors");
            }
        }
    }
}
