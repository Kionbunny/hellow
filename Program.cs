using System.Diagnostics;

namespace ConsoleApp4;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Switch s = new Switch();
        s.DisplayFruitInfo();
        string name = "ajay ";

        switch(name)
        {
            case "ajay " : 
                Console.WriteLine($"My name is {name}");
                break;
            case "vijay" : 
                Console.WriteLine($"My name is {name}");
                break;
        }
    }
    
}