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
            string message = null;
            MoodAnalyser1 analyser = new MoodAnalyser1();
            string expected = "Mood should not be Null";

            //Act
            string actual = analyser.analyseMood();

            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}


