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
            MoodAnalyser1 analyser = new MoodAnalyser1();
            string message = "I am in Sad Mood";
            string expected = "SAD";

            //Act
            string actual = analyser.analyseMood(message);

            //Assert
            Assert.AreEqual(expected, actual);
        }


    }

}
