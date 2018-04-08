using System;
namespace ModifierKeywords
{
class ModifierKeywords
{
    static void Main(string[] args)
    {
        // Create a plain automobile
        var auto1 = new Automobile();
        var auto2 = new Automobile();

        auto1.Drive(40);
        auto2.Drive(50);

        //var winner = Automobile.Race(auto1, auto2, 2);
        var winner = Automobile.Race(auto1, auto2, 2);
        Console.WriteLine($"Winner speed: {winner.CurrentSpeed}");
    }
}

public class Automobile
{
    public const double MaxSpeed = 500.00;

    public double CurrentSpeed { get; private set; } = 0.0;

    /// <summary>
    /// Race the specified autos for a set distance and return the winner
    /// </summary>
    /// <returns>The winner</returns>
    /// <param name="a">The first auto</param>
    /// <param name="b">The second auto</param>
    /// <param name="distance">The distance in miles</param>
    public static Automobile Race(Automobile a, Automobile b, double distance)
    {
        var aSpeed = a.CurrentSpeed / distance;
        var bSpeed = b.CurrentSpeed / distance;

        return aSpeed < bSpeed ? b : a;
    }
    public void Drive(double speed)
    {
        speed = speed < 0 ? 0 : speed;
        CurrentSpeed = (speed > MaxSpeed) ? MaxSpeed : speed;
    }
}
}