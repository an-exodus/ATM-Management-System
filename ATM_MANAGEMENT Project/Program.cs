using System;

namespace ATM_MANAGEMENT_Project
{
    class Program:ATM
    {
        static void Main(string[] args)
        {
            // Changing Background Color of console
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            Intro i = new Intro();
            i.intro();

            ATM a = new ATM();

            a.Card();
            a.cardPin();
            a.mainMenu();


        }
    }
}
