class Fight: Context, Moves
{
    //Take the input for first fighter Punches
    public int firstPunches()
    {
        System.Console.WriteLine("Enter the amount of First fighter Punches:");
        int punches1 = Convert.ToInt32(Console.ReadLine());
        return punches1;
    }

//Take the input for Second fighter Punches
    public int secondPunches()
    {
        System.Console.WriteLine("Enter the amount of Second fighter Punches:");
        int punches2 = Convert.ToInt32(Console.ReadLine());
        return punches2;
    }

    //Take the input for First fighter Kicks
    public int firstKicks()
    {
        System.Console.WriteLine("Enter the amount of First fighter Kicks:");
        int kicks1 = Convert.ToInt32(Console.ReadLine());
        return kicks1;
    }

    //Take the input for Second fighter Kicks
    public int secondKicks()
    {
        System.Console.WriteLine("Enter the amount of Second fighter Kicks:");
        int kicks2 = Convert.ToInt32(Console.ReadLine());
        return kicks2;
    }

}