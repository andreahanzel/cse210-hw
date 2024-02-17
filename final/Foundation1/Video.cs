using System;
using System.Collections.Generic;

public class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public TimeSpan Length { get; set; }
    private List<Comment> comments = new List<Comment>();

    public Video(string title, string author, TimeSpan length)
    {
        Title = title;
        Author = author;
        Length = length;
    }

    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    public void DisplayVideoDetails()
    {
        Console.WriteLine($"Title: {Title}, Author: {Author}, Length: {Length}");
        Console.WriteLine("Comments:");
        foreach (var comment in comments)
        {
            comment.DisplayComment();
        }
    }
}
