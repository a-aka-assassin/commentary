using System;

//NameSpace
namespace Commentary
{
    //Main Class
    class Program
    {
        //Entry Point of the Program
        static void Main(string[] args)
        {
            //Starting The Code Here

            //Set Application vars
            string appName = "Commentary";
            string appVersion = "1.0.0";
            string appAuthor = "Arsalan";

            //Application Header With changed Color
            Console.ForegroundColor = ConsoleColor.Blue;
            System.Console.WriteLine("{0}: version {1}, By {2}.", appName, appVersion, appAuthor);
            
            //Reset Console Color
            Console.ResetColor();

            //Taking Fighter Names
            Console.WriteLine("Whats the First Fighter Name:");
            string fighter1 = Console.ReadLine();

            Console.WriteLine("Enter Second Fighter Name");
            string fighter2 = Console.ReadLine();

            //Making The Fight happen
            Fight obj = new Fight();
            int punchesOne = obj.firstPunches();
            int punchesTwo = obj.secondPunches();
            int kicksOne = obj.firstKicks();
            int kicksTwo = obj.secondKicks();

            //Introduction
            obj.introduction(fighter1, fighter2);
            obj.combo(fighter1, fighter2);
            obj.conclusion(fighter1, fighter2, punchesOne,punchesTwo,kicksOne,kicksTwo);
            
        }
    }

}