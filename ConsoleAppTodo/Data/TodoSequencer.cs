using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTodo.Data
{
    internal class TodoSequencer
    {
        private static int todoId;

        public static int NextTodoId(int todoId)
        {
            return todoId++;
        }
        public static void Reset()
        {
            todoId = 0;
        }

    }
}
    

