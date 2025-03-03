using System; 

// In C#, System is a built-in namespace that provides basic functionality like input/output operations, data types, and other fundamental classes.
//   Required for Console.WriteLine()  Console.WriteLine() is a method that belongs to System.Console class.
// If we don’t include using System;, we must explicitly write System.Console.WriteLine() every time.
namespace ConsoleApp4
// namespace is like a container for organizing related classes , functions and interfaces 
// it helps in avoiding naming conflicts  below code is the example for naming conflicts 
// Example: Without Namespace (Name Conflict)
// csharp
// class Switch
// {
//     public void Display() => Console.WriteLine("Switch from file 1");
// }
//
// class Switch  // ERROR: Duplicate class name
// {
//     public void Display() => Console.WriteLine("Switch from file 2");
// }
/*   Example With Namespace 
 *  csharp 
 * namespace Project1 
 * class Switch 
 *  {
 *    public void Display () => Console.WriteLine("Switch from project 1"); 
 *  } 
 *  namespace Project2
 * class Switch
 * // (There will be no naming conflicts now bcz both classes even though they have  same name , but they belong to different namespace ) 
 * {
 * public void Display() => Console.WriteLine("Switch from project 2"); 
 * } 
 */
 
{
     class Switch
    {
        public void DisplayFruitInfo() // Create a method
        {
            string fruit = "apple";

            switch (fruit)
            {
                case "apple":
                    Console.WriteLine("App will display information for apple.");
                    break;

                case "banana":
                    Console.WriteLine("App will display information for banana.");
                    break;

                case "cherry":
                    Console.WriteLine("App will display information for cherry.");
                    break;

                default:
                    Console.WriteLine("No information available.");
                    break;
            } // end of the switch case  
        } // end of the class method 
    } // end of the class (Switch) 
} // end of the program (namespace ) 