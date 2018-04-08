using System;

namespace ClassExamples
{
    class CommandLineArgs
    {
        static void Main(string[] args)
        {
            var i=1;
            if(args.Length > 0) {
                Console.WriteLine("Command Line Arguments:"); 
                foreach(var arg in args) {
                    Console.WriteLine($"{i++}. {arg}");
                }
            }
            Console.WriteLine("Hello World Number 2");
        }
    }
}