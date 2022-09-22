using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using ConsoleAppTodo.Models;

namespace ConsoleAppTodo.Data
{
    internal class TodoService
    {
        private static Todo[] todoArray = new Todo[0];

        public Todo[] todo
        {
            get
            {
                return todoArray;

            }
            set
            {

                todoArray = value;

            }

        }

        public int size()
        {
            return todoArray.Length;
        }
        public Todo? FindAll(int todoId)
        {
            foreach (Todo todo in todoArray)

            {
                if (todo.TodoId == todoId)
                {
                    return todo;
                }
            }
            return null;
        }
        public Todo CreateNewTodo(string description)
        {
            Todo newTodo = new Todo(TodoSequencer.NextTodoId(1), description);
            Array.Resize(ref todoArray, todoArray.Length + 1);
            todoArray[todoArray.Length - 1] = newTodo;
            return newTodo;

        }
        public void Clear()
        {
            todoArray.ToList().Clear();

        }
    }
}