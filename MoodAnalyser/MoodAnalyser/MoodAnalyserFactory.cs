using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
        public class MoodAnalyserFactory
        {
            public static object CreateMoodAnalyser(string className)
            {
                Assembly assembly = Assembly.GetExecutingAssembly();
                Type MoodAnalyserType = assembly.GetType(className);
                return Activator.CreateInstance(MoodAnalyserType);
            }
        }
}
