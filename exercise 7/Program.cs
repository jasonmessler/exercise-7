using System;

namespace exercise_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            string answer;
            do
            {
                Console.WriteLine("Please enter your text");
                text = Console.ReadLine();
                Console.WriteLine(text);
                Console.WriteLine("Would you like to continue (y/n)?");
                answer = Console.ReadLine();
            } while (answer == "y");

            Console.WriteLine("Goodbye");
           

        }
    }
}
