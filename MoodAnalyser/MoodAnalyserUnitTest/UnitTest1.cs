using MoodAnalyser;

namespace MoodAnalyserUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenAnyMoodMessage_WhenAnalyseShouldReturnHappy()
        {
            //Arrange
            MoodAnalyser1 analyser = new MoodAnalyser1();
            string message = "I am in Any Mood";
            string expected = "HAPPY";

            //Act
            string actual = analyser.analyseMood(message);

            //Assert
            Assert.AreEqual(expected, actual);
        }


    }

}
