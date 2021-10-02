using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserApplication;

namespace MoodAnalyserApplicationMSTesting
{

    [TestClass]
    public class UnitTest1
    {
        // TC-1.1: Given message is "I am in sad mood" and it should return SAD
        [TestMethod]
        [TestCategory("sadgroup")]
        // Creating a test method
        public void Given_Sad_Message_Should_Return_Sad()
        {
            // Arrange
            string expected = "SAD";
            string message = "I am in sad mood";

            // Act
            MoodAnalyser moodCheck = new MoodAnalyser(message);
            string actual = moodCheck.AnalyseMood(); // Calling a method

            // Assert
            Assert.AreEqual(expected, actual);
        }

        // TC-1.2: Given message is "I am in any mood" and it should return HAPPY
        [TestMethod]
        [TestCategory("happygroup")]
        // Creating a test method

        public void Given_Any_Message_Should_Return_Happy()
        {
            // Arrange
            string expected = "HAPPY";
            string message = "I am in any mood";

            // Act
            MoodAnalyser moodCheck = new MoodAnalyser(message);
            string actual = moodCheck.AnalyseMood();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
