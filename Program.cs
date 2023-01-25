namespace ToDoList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ToDoList toDoList = new ToDoList();

            int choice;
            do
            {
                Console.WriteLine("1. Add ToDo");
                Console.WriteLine("2. Update ToDo");
                Console.WriteLine("3. Remove ToDo");
                Console.WriteLine("4. View ToDo List");
                Console.WriteLine("5. Exit");

                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter task description: ");
                        string description = Console.ReadLine();
                        Console.Write("Enter task deadline (yyyy-mm-dd): ");
                        DateTime deadline = DateTime.Parse(Console.ReadLine());
                        Console.Write("Enter the number of times to repeat the reminder: ");
                        int repeat = int.Parse(Console.ReadLine());

                        ToDo toDo = new ToDo(description, deadline);
                        toDoList.AddToDo(toDo, repeat);
                        Console.WriteLine("Task added successfully!");
                        break;
                    case 2:
                        Console.Write("Enter task description to update: ");
                        string descriptionToUpdate = Console.ReadLine();
                        Console.Write("Enter new taskdescription: ");
                        string newDescription = Console.ReadLine();
                        Console.Write("Enter new task deadline (yyyy-mm-dd): ");
                        DateTime newDeadline = DateTime.Parse(Console.ReadLine());
                        ToDo toDoToUpdate = toDoList.GetToDos().Find(t => t.Description == descriptionToUpdate);
                        if (toDoToUpdate != null)
                        {
                            toDoList.UpdateToDo(toDoToUpdate, newDescription, newDeadline);
                            Console.WriteLine("Task updated successfully!");
                        }
                        else
                            Console.WriteLine("Task not found!");
                        break;
                    case 3:
                        Console.Write("Enter task description to remove: ");
                        string descriptionToRemove = Console.ReadLine();

                        ToDo toDoToRemove = toDoList.GetToDos().Find(t => t.Description == descriptionToRemove);
                        if (toDoToRemove != null)
                        {
                            toDoList.RemoveToDo(toDoToRemove);
                            Console.WriteLine("Task removed successfully!");
                        }
                        else
                            Console.WriteLine("Task not found!");
                        break;
                    case 4:
                        Console.WriteLine("ToDo List:");
                        foreach (ToDo currentToDo in toDoList.GetToDos())
                        {
                            Console.WriteLine($"Task: {currentToDo.Description} - Deadline: {currentToDo.Deadline} - Created on: {currentToDo.Created}");
                        }
                        break;

                    case 5:
                        Console.WriteLine("Exiting the program...");
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Invalid choice! Please enter a valid choice.");
                        break;
                }
                Console.WriteLine();
            } while (choice != 5);
        }

    }
}
