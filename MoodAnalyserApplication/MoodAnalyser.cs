using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserApplication
{
    // UC-2: Ability to handle exception if the user provides an invalid input like null
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
                return "HAPPY";
            }
        }

    }
}
