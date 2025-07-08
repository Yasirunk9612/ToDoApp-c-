using System;
using System.Collections.Generic;

class program
{
    static List<ToDoItem> tasks = new List<ToDoItem>();

    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("To-Do List Application");
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. View Tasks");
            Console.WriteLine("3. Exit");
            Console.Write("Choose: ");
            string choice = Console.ReadLine();

            if (choice == "1") AddTask();
            else if (choice == "2") ViewTasks();
            else if (choice == "3") break;
            else Console.WriteLine("Invalid choice. Please try again.");

        }
    }

    static void AddTask()
    {
        Console.Write("Enter Task: ");
        string desc = Console.ReadLine();
        tasks.Add(new ToDoItem { Description = desc, IsDone = false });
    }


    static void ViewTasks()
    {
        Console.Clear();
        Console.WriteLine("Your Tasks:");
        for (int i = 0; i < tasks.Count; i++)
            Console.WriteLine($"{i + 1}. {tasks[i].Description} (Done: {tasks[i].IsDone})");

        Console.WriteLine("\nPress any key to return to the main menu...");
        Console.ReadKey();
    }
}