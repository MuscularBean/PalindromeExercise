using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("Level", true)]
        [InlineData("mOm", true)]
        [InlineData("Hello", false)]
        [InlineData("cIviC", true)]
        [InlineData("", false)]
        [InlineData("2", false)]
        public void Testing(string input, bool expected)
        {
            //arrange
            WordSmith challenge = new WordSmith();
            //act
            var actual = challenge.IsAPalindrome(input);
            //assert
            Assert.Equal(expected, actual);
        }
    }
}
