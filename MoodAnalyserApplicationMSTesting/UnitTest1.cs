using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserApplication;

namespace MoodAnalyserApplicationMSTesting
{

    [TestClass]
    public class UnitTest1
    {
        // TC-2.1: Given null mood should return HAPPY
        [TestMethod]
        [TestCategory("negativescenario")]
        // Creating a test method
        public void Given_Null_Should_Return_Happy()
        {
            // Arrange
            string expected = "HAPPY";
            string message = null;

            // Act
            MoodAnalyser moodCheck = new MoodAnalyser(message);
            string actual = moodCheck.AnalyseMood(); // Calling a method

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
