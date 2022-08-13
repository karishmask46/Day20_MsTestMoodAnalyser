using MoodAnalyser;

namespace MoodAnalyserUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
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

       
    }


}


