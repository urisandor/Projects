using System;
using System.Collections.Generic;

namespace Todolist
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, This is a To do list!");

            List<TodoTask> tasks = new List<TodoTask>();

            while (true)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Add a task");
                Console.WriteLine("2. View tasks");
                Console.WriteLine("3. Mark task as completed");
                Console.WriteLine("4. Delete a task");
                Console.WriteLine("5. Exit");

                string choice = Console.ReadLine()!;

                switch (choice)
                {
                    case "1":
                        TaskOperations.AddTask(tasks);
                        break;
                    case "2":
                        TaskOperations.ViewTasks(tasks);
                        break;
                    case "3":
                        TaskOperations.MarkTaskCompleted(tasks);
                        break;
                    case "4":
                        TaskOperations.DeleteTask(tasks); 
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
        }
    }   
}

