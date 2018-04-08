using System;

namespace ClassExamples
{
class MethodOverloading
{
    static void Main(string[] args)
    {
        var auto = new Automobile1();
        auto.Drive();
        auto.Drive(40.0);

        LogNames("Cody", "Winton");
    }

    static void LogNames(params string[] names)
    {
        foreach (var name in names)
        {
            Console.WriteLine($"Name is: {name}");
        }
    }
}

public class Automobile1
{
    public const double MaxSpeed = 500.0;
    public const int NumberOfGears = 6;

    public double CurrentSpeed { get; private set; } = 0.0;

    public int CurrentGear { get; private set; } = 1;


    public static Automobile1 Race(Automobile1 a, Automobile1 b, double distance)
    {
        var aSpeed = a.CurrentSpeed / distance;
        var bSpeed = b.CurrentSpeed / distance;

        return aSpeed < bSpeed ? b : a;
    }

    public void Drive(double speed = 15.0)
    {
        Console.WriteLine("Called the speed method with speed: " + speed);
        speed = speed < 0 ? 0 : speed;
        CurrentSpeed = (speed > MaxSpeed) ? MaxSpeed : speed;
    }

    public void Drive(double speed, int gear)
    {
        Console.WriteLine("Called the gear method with gear: " + gear);
        Drive(speed);
        gear = gear < 1 ? 1 : gear;
        CurrentGear = (gear > NumberOfGears) ? NumberOfGears : gear;
    }
}
}
