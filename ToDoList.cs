using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class ToDoList
    {
        private List<ToDo> _toDos;

        public ToDoList()
        {
            _toDos = new List<ToDo>();
        }

        public void AddToDo(ToDo toDo, int repeat)
        {
            _toDos.Add(toDo);
            Thread thread = new Thread(() => toDo.CheckDeadline(repeat));
            thread.Start();
        }

        public void RemoveToDo(ToDo toDo)
        {
            _toDos.Remove(toDo);
        }

        public void UpdateToDo(ToDo toDo, string newDescription, DateTime newDeadline)
        {
            toDo.Description = newDescription;
            toDo.Deadline = newDeadline;
        }

        public List<ToDo> GetToDos()
        {
            return _toDos;
        }
    }

}
