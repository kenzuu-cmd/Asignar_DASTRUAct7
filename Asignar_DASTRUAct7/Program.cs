using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asignar_DASTRUAct7
{
    class Program
    {

            // ACTIVITY 7:  Inserting Nodes with Exception Handling
            // KENJI L. ASIGNAR IT402P
            // Problem: Create a program that lets users input classmate names into a Linked List 
            // using loops and displays them, following a procedural approach.

            static void Main(string[] args)
            {
                // Setting up the empty linked list
                LinkedList<string> myclassmates = new LinkedList<string>();

            // This is where we handle the number of classmates
            inputVal:
                try
                {
                    Console.ResetColor();
                    Console.Write("How many classmates do you have? (Enter 5-10): ");
                    // This line might crash if the user types a letter, so it's inside the 'try'
                    int numofclassmates = int.Parse(Console.ReadLine());

                    // Check if the number is within our specific range
                    if (numofclassmates < 5 || numofclassmates > 10)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n[Error] Please stay between 5 and 10 classmates.");
                        Console.WriteLine("Press any key to try again...");
                        Console.ResetColor();
                        Console.ReadKey();
                        Console.Clear();
                        goto inputVal;
                    }

                    // If the code gets here, the number is valid! 
                    // Now let's grab the names
                    Console.WriteLine("\nEnter the name of your classmate: ");
                    for (int i = 0; i < numofclassmates; i++)
                    {
                        Console.Write($"classmate #{i + 1}: ");
                        string classmatename = Console.ReadLine();
                        myclassmates.AddLast(classmatename);
                    }
                }
                catch (Exception)
                {
                    // This catches things like typing "abc" instead of a number
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n[Error] That's not a valid number! Try again.");
                    Console.WriteLine("Press any key to go back...");
                    Console.ResetColor();
                    Console.ReadKey();
                    Console.Clear();
                    goto inputVal;
                }

                // Sort them alphabetically (creating a list to work with)
                var sortedClassmates = myclassmates.OrderBy(name => name).ToList();

                // Clear the screen and show the final linked list
                Console.Clear();
                Console.WriteLine("Your classmates names are: ");
                foreach (string name in myclassmates)
                {
                    Console.Write(name + " --> ");
                }
                Console.WriteLine("null");
                Console.WriteLine("\nYour classmates' names in alphabetical order are: ");
                foreach (string name in sortedClassmates)
                {
                    Console.WriteLine("- " + name);
                }

            // Finished!
            Console.ReadKey();
            Environment.Exit(0);
            }
        }
    }


