﻿class Music
{
    public string Name;
    public string Artist;
    public int Duration;
    private bool Available;

    public void ViewTechnicalSheet()
    {
        Console.WriteLine($"\nName: {Name}");
        Console.WriteLine($"Artist: {Artist}");
        Console.WriteLine($"Duration: {Duration}");

        if(Available)
        {
            Console.WriteLine("Available in plan");
        } else
        {
            Console.WriteLine("Purchase the Plus plan");
        }
    }
}