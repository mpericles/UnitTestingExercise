using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(2, 2, 2, 6)]
        [InlineData(1, 1, 1, 3)]
        public void AddTest(int number1, int number2, int number3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object. object same as instance
            Calculator instance = new Calculator();
            

            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual
                var actual = instance.Add(number1, number2, number3);

            //Assert
                Assert.Equal(expected, actual);
        }

        [Theory]
        // [InlineData()]//Add test data <-------
        [InlineData(15, 10, 5)]
        [InlineData(5, 2, 3)]
        [InlineData(10, 5, 5)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            Calculator instance1 = new Calculator();

            //Act
            var actual = instance1.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        //[InlineData()]//Add test data <-------
        [InlineData(5, 10, 50)]
        [InlineData(5, 2, 10)]
        [InlineData(5, 5, 25)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            Calculator instance2 = new Calculator();
            //Act
            var actual = instance2.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        //[InlineData()]//Add test data <-------
        [InlineData(10, 2, 5)]
        [InlineData(6, 2, 3)]
        [InlineData(8, 2, 4)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            Calculator instance3 = new Calculator();
            //Act
            var actual = instance3.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);

        }

    }
}
