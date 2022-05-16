using System;

//Namespace
namespace NumberGuessor
{
    //Main class
    internal class Program
    {
        //Entry Point Method
        static void Main(string[] args)
        {
            String appName = "Number Guessor";
            String appAuthor = "Karan Singh";
            String appVersion ="1.0.0";

            //Console Color
            Console.ForegroundColor = ConsoleColor.Green;
     
            //Write out app info
            Console.WriteLine("{0} made by {1}, version:{2}", appName,appAuthor, appVersion);

            //Reset Console Color
            Console.ResetColor();

            //Ask user their name
            Console.WriteLine("What is your name?");

            //Get user's input
            String inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game", inputName);

            //Init correct number
            int correctNumber = 7;

            //Init guess a number
            int guess = 0;

            Console.WriteLine("Guess a number between 1 - 10");
            

            while (guess != correctNumber)
            {

                //Get users input
                String input = Console.ReadLine();

                guess = Int32.Parse(input);

                //Match guess to correct number
                if (guess != correctNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Try again");
                    Console.ResetColor();
                }
                else { Console.WriteLine("Sucess!"); }
            }

        }
    }
}
