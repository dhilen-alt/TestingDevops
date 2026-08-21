using dotNetProject.Services;

namespace UnitTesting
{
    public class UnitTest1
    {
        [Fact]
        public void SayHello_ReturnGreeting()
        {
            //Arrange
            var greeter = new greeter();

            //Act
            string result = greeter.SayHello("John");

            //Assert
            Assert.Equal("Hello, John", result);
        }

        [Fact]
        public void IsEligibleToVote_Age17_ReturnsFalse()
        {
            //Arrange
            var greeter = new greeter();

            //Act
            bool result = greeter.IsEligibleToVote(17);

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void IsEligibleToVote_Age18_ReturnsTrue()
        {
            //Arrange
            var greeter = new greeter();

            //Act
            bool result = greeter.IsEligibleToVote(18);

            //Assert
            Assert.True(result);
        }

        [Theory]
        [InlineData(17, false)]
        [InlineData(18, true)]
        [InlineData(20, true)]
        [InlineData(100, true)]
        public void IsEligibleVariousAges_ReturnsExpectedResults(int age, bool expected)
        {
            //Arrange
            var greeter = new greeter();

            //Act
            bool result = greeter.IsEligibleToVote(age);

            //Assert
            Assert.Equal(expected, result);
        }
    }
}