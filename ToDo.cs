using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    
        class ToDo
        {
            public DateTime Created { get; set; }
            public DateTime Deadline { get; set; }
            public string Description { get; set; }

            public ToDo(string description, DateTime deadline)
            {
                Description = description;
                Deadline = deadline;
                Created = DateTime.Now;
            }

            public void CheckDeadline(int repeat)
            {
                int counter = 0;
                while (counter < repeat)
                {
                    if (DateTime.Now >= Deadline)
                    {
                        Console.WriteLine($"Task '{Description}' has reached its deadline! Please take action.");
                        counter++;
                        Thread.Sleep(1000);
                    }
                }
            }
        }
}
