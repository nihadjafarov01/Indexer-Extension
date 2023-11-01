namespace ConsoleApp1.Models;

internal class Car
{
    public string Name { get; set; }
    public string Colour { get; set; }
    public int ProducedYear { get; set; }

    public override string ToString()
    {
        return $"Name: {Name}, Colour: {Colour}, Produced year: {ProducedYear}";
    }
}
