namespace Todolist
{
    public class TaskOperations
    {
        public static void AddTask(List<TodoTask> tasks)
        {
            Console.Write("Enter event title: ");
            string eventTitle = Console.ReadLine()!;

            Console.Write("Enter description: ");
            string description = Console.ReadLine()!;

            int newId = tasks.Count + 1;
            TodoTask newTask = new TodoTask(newId, eventTitle, description);
            tasks.Add(newTask);

            Console.WriteLine("Task added successfully.");
        }

        public static void ViewTasks(List<TodoTask> tasks)
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks available.");
                return;
            }

            Console.WriteLine("\nTasks:");
            foreach (var task in tasks)
            {
                Console.WriteLine(task);
            }
        }

        public static void MarkTaskCompleted(List<TodoTask> tasks)
        {
            Console.Write("Enter the ID of the task to mark as completed: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                TodoTask task = tasks.Find(t => t.Id == id)!;
                if (task != null)
                {
                    task.IsCompleted = true;
                    Console.WriteLine("Task marked as completed.");
                }
                else
                {
                    Console.WriteLine("Task not found.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }

        public static void DeleteTask(List<TodoTask> tasks)
        {
            Console.Write("Enter the ID of the task to delete: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                TodoTask task = tasks.Find(t => t.Id == id)!;
                if (task != null)
                {
                    tasks.Remove(task);
                    for (int i = 0; i < tasks.Count; i++)
                    {
                        tasks[i].Id = i + 1;
                    }

                    Console.WriteLine("Task deleted successfully and IDs reordered.");
                }
                else
                {
                    Console.WriteLine("Task not found.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}