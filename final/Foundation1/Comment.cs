public class Comment
{
    public string CommenterName { get; set; }
    public string Message { get; set; }

    public Comment(string commenterName, string message)
    {
        CommenterName = commenterName;
        Message = message;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"{CommenterName}: {Message}");
    }
}
