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
            //string message ="";
            string expected = "Constructor is not found";
            //Act
            string actual = (string)MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyser.MoodAnalyser1", "MoodAnalyser");
            //Assert
            //expected.Equals(obj);
            Assert.AreEqual(expected, actual);
        }

    }
}


