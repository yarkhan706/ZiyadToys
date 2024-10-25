using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Ziyad's Car Command Console!");
        Console.WriteLine("Available Commands: start, stop, accelerate, brake, right, left");
        Console.WriteLine("Note: This car does not support 'left' turn.");
        Console.WriteLine("Enter commands (separated by space) or 'exit' to quit:");

        while (true)
        {
            Console.Write("\nEnter Commands: ");
            string input = Console.ReadLine()?.ToLower();

            if (input == "exit")
                break;

            List<string> commands = new List<string>(input.Split(' '));

            if (ValidateCommands(commands))
            {
                Console.WriteLine("All commands are valid.");
                ExecuteCommands(commands);
            }
            else
            {
                Console.WriteLine("Invalid command sequence detected! Check your input.");
            }
        }
    }

    static bool ValidateCommands(List<string> commands)
    {
        string[] validCommands = { "start", "stop", "accelerate", "brake", "right", "left" };

        foreach (string cmd in commands)
        {
            if (!Array.Exists(validCommands, c => c == cmd))
                return false;

            if (cmd == "left")
            {
                Console.WriteLine("Error: The car does not support 'left' turn!");
                return false;
            }
        }

        return true;
    }

    static void ExecuteCommands(List<string> commands)
    {
        foreach (string command in commands)
        {
            switch (command)
            {
                case "start":
                    Console.WriteLine("Car started.");
                    break;
                case "stop":
                    Console.WriteLine("Car stopped.");
                    break;
                case "accelerate":
                    Console.WriteLine("Car is accelerating.");
                    break;
                case "brake":
                    Console.WriteLine("Car is braking.");
                    break;
                case "right":
                    Console.WriteLine("Car turned right.");
                    break;
                case "left":
                    
                    Console.WriteLine("This car cannot turn left!");
                    break;
                default:
                    Console.WriteLine($"Unknown command: {command}");
                    break;
            }
        }
    }
}