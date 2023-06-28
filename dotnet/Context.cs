abstract class Context
{
    public void introduction(string fighterOne = "Defender", string fighterTwo = "Challenger")
    {
        Console.WriteLine("Ladies And Gentlemen, Today we have the Fight between {0} and {1}.", fighterOne, fighterTwo);
    }

    public void combo(string fighterOne = "Defender", string fighterTwo = "Challenger")
    {
        System.Console.WriteLine("{0} throws a left punch, {1} slips it. {0} throws a beautiful Cross over But {1} ducks it.", fighterOne, fighterTwo);
        Console.WriteLine("{0} throws a one two one combo. {1} gets hit.", fighterTwo, fighterOne);
        Console.WriteLine("{0} throws a Kick to the face. {1} gets hit and looks hurt.", fighterTwo, fighterOne);
        Console.WriteLine("{0} hits with a over right hand. {1} is hit and goes down.", fighterTwo, fighterOne);
        
    }

    public void conclusion(string fighterOne = "Defender", string fighterTwo = "Challenger", int fighterOnePunches = 0, int fighterTwoPunches = 0, int fighterOneKicks = 0, int fighterTwoKicks = 0)
    {
        System.Console.WriteLine("{0} is the Winner and new Champion.", fighterTwo);
        Console.WriteLine("In Summary {0} threw a total of {1} Punches and {2} kicks.", fighterOne, fighterOnePunches, fighterOneKicks);
        Console.WriteLine("In Summary {0} threw a total of {1} Punches and {2} kicks.", fighterTwo, fighterTwoPunches, fighterTwoKicks);    
    }
}