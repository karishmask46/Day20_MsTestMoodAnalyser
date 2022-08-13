using MoodAnalyser;
Console.WriteLine("Enter User Mood: ");
string message = Console.ReadLine();
MoodAnalyser1 mood = new MoodAnalyser1(message);
Console.WriteLine(mood.analyseMood());
