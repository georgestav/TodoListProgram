using System;
using System.Collections.Generic;
using System.Reflection;

namespace TodoListProgram
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Assembly currentAssembly = Assembly.GetExecutingAssembly();
            string projectName = currentAssembly.FullName.Split(',')[0];

            List<string> taskList = new List<string>();
            string option = "";

            Console.WriteLine("Welcome to:");
            Console.WriteLine(projectName);

            while (option != "e")
            {
                Console.WriteLine("Options:");
                Console.WriteLine("Add item to the list: enter 1");
                Console.WriteLine("View list items: enter 2");
                Console.WriteLine("Delete list item: enter 3");
                Console.WriteLine("Enter 'e' to exit.");

                option = Console.ReadLine();
                if (option == "1")
                {
                    // save item to the list
                    Console.WriteLine("Enter the item todo, and i will add it to the list for you.");
                    string tempInput = Console.ReadLine();
                    taskList.Add(tempInput);
                    Console.WriteLine("Added!!");
                }
                if (option == "2")
                {
                    // view the list
                    int index = 0;
                    foreach (var item in taskList)
                    {
                        Console.WriteLine("item, " + index + ':' + item);
                        index++;
                    }
                    Console.WriteLine("End of the list!");
                }
                if (option == "3")
                {
                    // remove from the list
                    Console.WriteLine("Enter the number of item to delete:");
                    string selectedItem = Console.ReadLine();
                    int itemIndex = Convert.ToInt32(selectedItem);
                    
                    // todo find item in the array instead of try...catch
                    try
                    {
                        string item = taskList[itemIndex];

                        if (item != null)
                        {
                            taskList.RemoveAt(itemIndex);
                            Console.WriteLine("Removed");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Not found");
                    }
                }
            }
        }
    }
}