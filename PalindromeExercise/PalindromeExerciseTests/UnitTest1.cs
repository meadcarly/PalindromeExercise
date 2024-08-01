using System;
using System.Runtime.InteropServices;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("mom", true)]
        [InlineData("bob", true)]
        [InlineData("Passion", false)]
        [InlineData("racecar", true)]
        [InlineData("", false)]
        [InlineData(null, false)]
        public void IsAPalindromeTest(string input, bool expected)
        {
            //Arrange
            var wordsmith = new WordSmith();
            //Act
            var actual = wordsmith.IsAPalindrome(input);
            //Assert
            Assert.Equal(expected, actual);

        }
    }
}
