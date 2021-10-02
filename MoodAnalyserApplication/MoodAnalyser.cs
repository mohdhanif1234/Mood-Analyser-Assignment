using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserApplication
{
    // UC-1: Given a message, ability to analyse the mood whether happy or sad
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
            if (this.message.Contains("sad"))
            {
                return "SAD";
            } 
            else
            {
                return "HAPPY";
            }
        }

    }
}
