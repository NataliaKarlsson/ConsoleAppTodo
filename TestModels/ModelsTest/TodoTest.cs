using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleAppTodo.Data;
using ConsoleAppTodo.Models;

namespace TestConsoleAppTodo.ModelsTest
{
    public class TodoTest
    {
        Todo todoTest;

        public TodoTest()
        {
            todoTest = new Todo(1, "Description will be here.");
            todoTest.Description = "Description";
            todoTest.Done = true;
        }

        [Fact]
        public void TodoIDTest()
        {
            //this is my person
            Todo todo = new Todo(0, "Description");
            //just an int to check NotEqual
            int todoId = 0;
            //Assert
            Assert.NotEqual(todoId, todoTest.TodoId);
            Assert.Equal(1, todoTest.TodoId);
        }
        [Fact]
        public void TestTodoDescrption()
        {
            //Arrange
            string? expected = "Description";
            //Act
            string? actual = todoTest.Description;
            //Assert
            Assert.Equal(expected, actual);



        }


        [Fact]
        public void TestBoolDone()
        {
            //Arrange
            bool expected = true;
            //Act
            bool actual = todoTest.Done;
            //Assert
            Assert.Equal(expected, actual);
        }



        [Fact]
        public void TestPersonAssignee()
        {



            //Arrange
            // Person expected = personCase.GetType(person.PersonId);
            //Act
            //string? actual = Todo.personId;
            //Assert
            //Assert.Equal(expected, actual);
        }



    }
}
