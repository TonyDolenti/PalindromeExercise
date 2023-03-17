using System;
using Xunit;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("dumbass", false)]
        [InlineData("civic", true)]
        [InlineData("happy", false)]
        [InlineData("radar", true)]
        [InlineData("specialist", false)]
        [InlineData("tenet", true)]
        [InlineData("", false)]
        public void IsAPalindrome_Test(string str, bool expected)
        {
            //Arrange
            var test = new WordSmith();
            //Act
            var actual = test.IsAPalindrome(str);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
