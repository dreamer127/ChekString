using System;

namespace ChekString
{
    class ChekString
    {
        public static int Sequence(string str)
        {
            char firsCh = str[0];
            int counter = 0;

            for (int i = 1; i < str.Length; i++)
            {
                if (firsCh != str[i])
                {
                    firsCh = str[i];
                    counter = 0;
                }
                else
                {
                    counter++;
                }
            }
            return counter;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------\n");
            bool endApp = false;
            while (!endApp)
            {
                Console.WriteLine("Add new string");
                string result = Console.ReadLine();
                Console.WriteLine("Count of duplicate chars = " + ChekString.Sequence(result));

                Console.WriteLine("------------------------\n");

                Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
                if (Console.ReadLine() == "n") endApp = true;
                Console.WriteLine("\n");
            }
        }
    }

}