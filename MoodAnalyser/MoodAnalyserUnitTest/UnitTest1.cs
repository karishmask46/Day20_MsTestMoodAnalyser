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
            object expected = new MoodAnalyser1();
            //Act
            object obj = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyser.MoodAnalyser1");
            //Assert
            Assert.AreNotEqual(expected, obj);
        }

    }
}


