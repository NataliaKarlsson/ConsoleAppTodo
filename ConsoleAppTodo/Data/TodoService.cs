using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
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
        public Todo[] FindByDoneStatus(bool doneStatus)
        {
            if (doneStatus.Equals(doneStatus))
            {
                return todoArray;
            }
            else
            {
                return null;
            }
        }
        public Todo[] FindByAssignee(int personId)
        {

            for (int i = 0; i < todoArray.Length; i++)
            {
                Todo todo = todoArray[personId];
            }
            return todoArray;
        }
        public Todo[] FindbyAssignee(Person assignee)
        {

            for (int i = 0; i < todoArray.Length; i++)
            {
                if (todoArray[i].Assignee == assignee)
                {
                    return todoArray;
                }
            }
            return todoArray;



        }

        public Todo[] FindUnassignedTodoItems()
        {
            for (int i = 0; i < todoArray.Length; i++)
            {
                if (todoArray[i].TodoId != todoArray.Length)
                {
                    return todoArray;
                }
            }

            return todoArray.ToArray();
        }
        public Todo[] RemoveTodoIndex()
        {
            foreach (Todo todo in todoArray)
            {
                todoArray.Where(todo => todo.TodoId == todoArray[0].TodoId).ToList().Remove(todo);
                Array.Resize(ref todoArray, todoArray.Length - 1);
            }
            return todoArray;
        }

    }

}