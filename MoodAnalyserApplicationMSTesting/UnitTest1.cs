using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserApplication;

namespace MoodAnalyserApplicationMSTesting
{

    [TestClass]
    public class UnitTest1
    {
        // TC-3.1: Given null mood should throw custom mood analysis exception
        [TestMethod]
        [TestCategory("CustomException")]
        // Creating a test method
        public void Given_Null_Mood_Should_Throw_Custom_Null_Exception()
        {
            // Arrange
            string expected = "Message should not be null";
            string message = null;

            try
            {
                // Act
                MoodAnalyser moodCheck = new MoodAnalyser(message);
                string actual = moodCheck.AnalyseMood(); // Calling a method
            }
            catch (MoodAnalyserCustomException ex)
            {
                // Assert
                Assert.AreEqual(expected, ex.Message);
            }
        }

        // TC-3.2: Given empty mood should throw custom mood analysis exception indicating empty mood
        [TestMethod]
        [TestCategory("CustomException")]
        // Creating a test method

        public void Given_Empty_Mood_should_Throw_Custom_Empty_Exception()
        {
            // Arrange
            string expected = "Message should not be empty";
            try
            {
                // Act
                MoodAnalyser moodCheck = new MoodAnalyser(string.Empty);
                string actual = moodCheck.AnalyseMood(); // Calling a method
            }
            catch (MoodAnalyserCustomException ex)
            {
                // Assert
                Assert.AreEqual(expected, ex.Message);
            }
        }
    }
}
