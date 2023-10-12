using System;

namespace HomwWork1_ConsoleApp_withoutlib
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            if (name == String.Empty)
                name = "No name";
            Console.WriteLine("Welcome {0} to dotnet world", name);
        }
    }
}
