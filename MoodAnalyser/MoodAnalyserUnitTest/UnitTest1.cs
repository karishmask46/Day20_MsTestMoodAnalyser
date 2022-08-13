using MoodAnalyser;

namespace MoodAnalyserUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        public void GivenSadMoodMessage_WhenAnalyseShouldReturnSad()
        {
            //Arrange
            string message = "I am in Sad Mood";
            MoodAnalyser1 analyser = new MoodAnalyser1(message);
            string expected = "SAD";

            //Act
            string actual = analyser.analyseMood();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GivenAnyMoodMessage_WhenAnalyseShouldReturnHappy()
        {
            //Arrange
            string message = "I am in Any Mood";
            MoodAnalyser1 analyser = new MoodAnalyser1(message);
            string expected = "HAPPY";

            //Act
            string actual = analyser.analyseMood();

            //Assert
            Assert.AreEqual(expected, actual);
        }

    }


}


