using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Understanding Abstraction", "Programming Guru", new TimeSpan(0, 14, 53));
        video1.AddComment(new Comment("Kate Smith", "Great explanation!"));
        video1.AddComment(new Comment("John Smith", "Thanks, this was very helpful."));

        Video video2 = new Video("Encapsulation in C#", "CodeMaster", new TimeSpan(0, 12, 30));
        video2.AddComment(new Comment("Alice Johnson", "Can you do a video on polymorphism?"));

        video1.DisplayVideoDetails();
        Console.WriteLine(); // Adding a blank line for readability
        video2.DisplayVideoDetails();
    }
}
