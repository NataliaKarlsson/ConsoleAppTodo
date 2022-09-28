using Xunit;
using ConsoleAppTodo;
using System;
using ConsoleAppTodo.Models;
using ConsoleAppTodo.Data;


namespace TestConsoleAppTodo.ModelsTest
{
    public class PersonTest
    {
        Person personTest;

        public PersonTest()
        {
            personTest = new Person(1, "Natalia", "Karlsson");
            personTest.FirstName = "Natalia";
            personTest.LastName = "Karlsson";
        }

        [Fact]
        public void personIDTest()
        {
            //this is my person
            Person person = new Person(1, "Nataliia", "Karlsson");
            //just an int to check NotEqual
            int personId = 0;
            //Assert
            Assert.NotEqual(personId, personTest.PersonId);
            Assert.Equal(1, personTest.PersonId);
        }



        [Fact]
        public void PersonClassTest()
        {
            // Arrange
            string firstName1 = "Sally";
            string lastName1 = "Corey";
            string firstName2 = "Mona";
            string lastName2 = "Carlesson";




            // Act
            Person testPerson1 = new Person(PersonSequencer.NextPersonId(), firstName1,lastName1);
            Person testPerson2 = new Person(PersonSequencer.NextPersonId(), firstName2, lastName2);



            // Assert        
            Assert.Equal(firstName1, testPerson1.FirstName);
            Assert.Equal(lastName1, testPerson1.LastName);
            Assert.Equal(firstName2, testPerson2.FirstName);
            Assert.Equal(lastName2, testPerson2.LastName);




        }



    }
 }  
