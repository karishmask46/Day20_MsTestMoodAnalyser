using MoodAnalyser;
MoodAnalyser1 mood = new MoodAnalyser1();
Console.WriteLine("Enter User Mood: ");
string message = Console.ReadLine();
Console.WriteLine(mood.analyseMood(message));
