namespace Classes;

public class Car
{
    public string Model { get; set; }
    public string Make { get; set; }
    public int Year { get; set; }

    public void CarType()
    {
        Console.WriteLine($"This is a {Year} {Make} {Model}!");
    }
}
