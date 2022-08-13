using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class MoodAnalyser1
    {
        public string message;
        public MoodAnalyser1()
        {

        }
        public MoodAnalyser1(string message)
        {
            this.message = message;
        }
        public string analyseMood()
        {
            if (this.message.ToUpper().Contains("SAD"))
                return "SAD";
            else
                return "HAPPY";
        }
    }
}