using System;

namespace KeywordThis
{
    class KeywordThis
    {
        static void Main(string[] args)
        {
            // Create a plain automobile
            var auto = new Automobile();

            Console.WriteLine($"Auto speed: {auto.CurrentSpeed}");

            // Tell the automobile to drive at 40

            auto.Drive(40.0);

            Console.WriteLine($"Auto speed: {auto.CurrentSpeed}");

            // Create a motorcycle

            var motorcycle = new Automobile();

            Console.WriteLine($"Motorcycle speed: {motorcycle.CurrentSpeed}");

            // Tell the motorcycle to drive at 70

            motorcycle.Drive(70.0);

            Console.WriteLine($"Motorcycle speed: {motorcycle.CurrentSpeed}");
        }
    }

    public class Automobile
    {
        public const double MaxSpeed = 500.0;

        // Public instance variable CurrentSpeed public getter private setter
        // Note default value assignment after bracket.
        public double CurrentSpeed { get; private set; } = 0.0;

        // Concrete method
        public void Drive(double speed)
        {
			// Can be simplified to CurrentSpeed = speed;

            this.CurrentSpeed = speed;
        }
    }
}
