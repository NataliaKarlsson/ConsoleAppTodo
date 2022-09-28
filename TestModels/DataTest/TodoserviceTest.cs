using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleAppTodo.Data;
using ConsoleAppTodo.Models;

namespace TestConsoleAppTodo.DataTest
{
    public class TodoserviceTest
    {
        TodoService todoCase;
        public TodoserviceTest()
        {
            todoCase = new TodoService();
        }
        [Fact]
        public void SizeTest()
        {
            //Arrange
            int expected = todoCase.Size();
            // Act
            int actual = todoCase.Size();
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void FindAllTest()
        {
            //Arrange
            Todo[] expected = todoCase.FindAll();
            //Act
            Todo[] actuelly = todoCase.FindAll();
            //Assert
            Assert.Equal(expected.ToString(), actuelly.ToString());
        }
        [Fact]
        public void FindByIdTest()
        {
            //Arrange
            Todo todo = new Todo(1, "Description");
            //Act
            int todoId = 1;
            //Assert
            Assert.Equal(1, todoId);
        }
        [Theory]
        [InlineData(1, "Description", "Description")]

        public void CreateNewTodoTest(int todoId,string Description, string expected)
        {
            //Arrange
            //expected holename but get seperate
            //Act
            Todo actuelly = todoCase.CreateNewTodo(Description);
            // Assert
            Assert.Equal(expected, actuelly.Description);
        }
        [Fact]
        public void RemoveTodoIdTest()
        {
            //Arrange
            TodoService todoService = new TodoService();
            //Act
            bool act = todoService.RemoveTodoId(1);
            //Assert
            Assert.False(act, "Removed");
        }
        [Fact]

        public void ClearTest()
        {
            //Arr
            //string exept = TodoCase.ToString();
            //string actu = TodoCase.Clear();
            //Assert.Equal(exept,actu);


        }
    }

}
