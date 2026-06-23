using System;

namespace SampleApplication
{
    /// <summary>
    /// A simple sample class demonstrating standard C# structure.
    /// </summary>
    public class Program
    {
        // Entry point of the application
        public static void Main(string[] args)
        {
            // Initialize sample variables
            string developerName = "Alex";
            int completedTasks = 5;

            // Output message to the console
            Console.WriteLine($"Hello, {developerName}!");
            Console.WriteLine($"You have completed {completedTasks} tasks today.");

            // Standard conditional logic
            if (completedTasks >= 5)
            {
                Console.WriteLine("Great job! You met your goal.");
            }
            else
            {
                Console.WriteLine("Keep going, you can do it!");
            }

            // Loop example
            Console.WriteLine("\nCounting down to launch:");
            for (int i = 3; i > 0; i--)
            {
                Console.WriteLine($"{i}...");
            }
            
            Console.WriteLine("Launch successful!");
        }
    }
}
