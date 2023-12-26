class Music
{
    public string Name { get; set; }
    public string Artist { get; set; }
    public int Duration { get; set; }
    public bool Available { get; set; }
    public string BriefDescription => 
        $"The {Name} music belongs to the {Artist} band";

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