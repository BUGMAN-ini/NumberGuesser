using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuesser
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //string name = "Beqa Shaverdashvili";
            //int age = 23;

            //Console.WriteLine("{0} Is {1}",name,age + " Years Old!");


            string saxeli = "Ricxvebis Gamomcnobi";
            string version = "1.0";
            string author = "Beqa Shaverda";

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("{0}: Version {1} By {2}", saxeli, version, author);

            Console.ResetColor();

            Console.WriteLine("Ra gqvia?");

            string input = Console.ReadLine();

            Console.WriteLine("Gamarjoba {0} Modi Vitamashot...", input);

            int sworiricxvi = 7;

            int guess = 0;

            Console.WriteLine("Gamoicani Ricxvi 1 dan 10 mde");

            while (guess != sworiricxvi) { 
            
                string ricxvi = Console.ReadLine();

                guess = Int32.Parse(ricxvi);


                if (guess != sworiricxvi)
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Araswori Ricxvi {0}, Scade Xelaxla...", input);

                    Console.ResetColor();

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine("Sworia {0}", input);

                    Console.ResetColor();

                }

                


            }


        }
    }
}
