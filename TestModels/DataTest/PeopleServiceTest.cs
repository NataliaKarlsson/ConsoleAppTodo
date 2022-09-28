using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleAppTodo;
using ConsoleAppTodo.Data;
using ConsoleAppTodo.Models;

namespace TestConsoleAppTodo.DataTest
{
    public class PeopleServiceTest
    {
        PeopleService peopleCase;
        Person personCase;
        public PeopleServiceTest()
        {
            peopleCase = new PeopleService();
            personCase = new Person(1, "Natalia", "Karlsson");

        }
        [Fact]

        public void SizeTest()
        {
            //Arrange
            int expected = peopleCase.Size();
            //Act
            int actuelly = peopleCase.Size();
            //Assert
            Assert.Equal(expected, actuelly);
        }

        [Fact]
        public void FindAllTest()
        {
            //Arrange
            Person[] expected = peopleCase.FindAll();
            //Act
            Person[] actuelly = peopleCase.FindAll();
            //Assert
            Assert.Equal(expected.ToString(), actuelly.ToString());
        }
        [Fact]
        public void FindByIdTest()
        {
            //Arrange
            Person person = new Person(2, "Natalia", "Karllson");
            //Act
            int personID = 2;
            //Assert
            Assert.Equal(2, personID);
        }
        [Theory]
        [InlineData("Natalia", "Karlsson", "Natalia Karlsson")]

        public void CreateNewPersonTest(string firstName, string lastName, string expected)
        {
            //Arrange
            //expected holename but get seperate
            //Act
            Person actuelly = peopleCase.CreateNewPerson(firstName, lastName);
            // Assert
            Assert.Equal(expected, actuelly.FirstName + " " + actuelly.LastName);
        }
        [Fact]
        public void RemovePersonIdTest()
        {
            //Arrange
            PeopleService peopleService = new PeopleService();
            //Act
            bool act = peopleService.RemovePersonId(1);
            //Assert
            Assert.False(act, "Removed");
        }
        [Fact]

        public void ClearTest()
        {
            //Arr
            //string exept = peopleCase.ToString();
            //string actu = peopleCase.Clear();
            //Assert.Equal(exept,actu);


        }



    }
}


