using MoodAnalyser;
Console.WriteLine("Enter User Mood: ");
string message = Console.ReadLine();
MoodAnalyser1 mood = new MoodAnalyser1();
Console.WriteLine(mood.analyseMood(message));
