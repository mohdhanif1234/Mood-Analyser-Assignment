using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserApplication
{
    // UC-3: To inform the user if he/she enters an invalid mood
    public class MoodAnalyser
    {
        public string message; // Declaring a variable

        // Creating a constructor to initialize a value
        public MoodAnalyser(string message)
        {
            this.message = message;
        }

        public string AnalyseMood()
        {
            try
            {
                if (this.message.Equals(string.Empty))
                {
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.EMPTY_TYPE_EXCEPTION, "Message should not be empty");
                }
                if (this.message.Contains("sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.INVALID_MOOD_EXCEPTION, "Message should not be null");
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

    }
}
