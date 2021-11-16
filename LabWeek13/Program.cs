using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWeek13
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phone_book = new Dictionary<string, string>();
            string input = "";
            while (true)
            {
                Console.WriteLine("Welcome to the Phone book. Enter 1 to add a phone number, 2 to delete a phone number,");
                Console.WriteLine("3 to find a phone number, or q to quit the program");
                input = Console.ReadLine().ToLower();
                if (input.Contains("1"))
                {
                    string temp_name, temp_number;
                    Console.WriteLine("Adding a Phone Number...");
                    Console.WriteLine("Enter the contact's name");
                    temp_name = Console.ReadLine();
                    Console.WriteLine("Enter the contact's phone number");
                    temp_number = Console.ReadLine();
                    phone_book.Add(temp_name, temp_number);
                }
                else if (input.Contains("2"))
                {
                    Console.WriteLine("Deleting a Phone Number...");
                    Console.WriteLine("Enter the name of the contact you would like to remove");
                    input = Console.ReadLine();
                    phone_book.Remove(input);
                    Console.WriteLine("Contact Removed!");
                }
                else if (input.Contains("3"))
                {
                    Console.WriteLine("Finding a Phone Number...");
                    Console.WriteLine("Enter the phone number or contact name you are trying to find");
                    input = Console.ReadLine();
                    string temp = "";
                    foreach (KeyValuePair<string, string> kvp in phone_book)
                    {
                        if (input.CompareTo(kvp.Key) == 0 || input.CompareTo(kvp.Value) == 0)
                        {
                            temp = "Item Found: " + kvp.Key + " " + kvp.Value;
                            break;
                        }
                    }
                    if (temp == "")
                    {
                        temp = "Item could not be found!";
                    }

                    Console.WriteLine(temp);
                }
                else if (input.Contains("q"))
                {
                    Console.WriteLine("Goodbye!");
                    Console.Read();
                    break;
                }
                else
                {
                    Console.WriteLine("Unrecognized command. Please try again.");
                }
                Console.WriteLine();
            }
        }
    }
}
