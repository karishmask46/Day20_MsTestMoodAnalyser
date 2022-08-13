using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class MoodAnalyser1
    {
        public string analyseMood(string message)
        {
            if (message.ToUpper().Contains("SAD"))
                return "SAD";
            else
                return "HAPPY";
        }
    }
}

