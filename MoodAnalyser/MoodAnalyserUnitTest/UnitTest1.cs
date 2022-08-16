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
            string expected = "Class not found";
            //Act
            string actual = (string)MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyser.MoodAnalyser1", "MoodAnalyser1");
            //Assert
            //expected.Equals(obj);
            Assert.AreEqual(expected, actual);
        }

    }
}


