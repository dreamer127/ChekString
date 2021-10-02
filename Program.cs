using System;
using System.Diagnostics;

namespace ChekString
{
    class ChekString
    {
        public static int Sequence(string str)
        {
            char value = str[0];
            int counter = 1;
            int max = 0;

            for (int i = 1; i < str.Length; i++)
            {
                if (value != str[i])
                {
                    counter++;
                    if (max < counter)
                        max = counter;
                }
                else
                {
                    counter = 1;
                }
                value = str[i];
            }
            return max;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var sw = new Stopwatch();
            sw.Start();

            Console.WriteLine("------------------------");
            bool endApp = false;
            while (!endApp)
            {
                Console.WriteLine("Add new string");
                string result = Console.ReadLine();
                Console.WriteLine("------------------------");
                Console.WriteLine("Count of duplicate chars = " + ChekString.Sequence(result));

                Console.WriteLine("------------------------");
                sw.Stop();
                Console.WriteLine($"Seconds {sw.ElapsedMilliseconds}");

                Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
                if (Console.ReadLine() == "n") endApp = true;
                Console.WriteLine();
            }

            
        }
    }

}