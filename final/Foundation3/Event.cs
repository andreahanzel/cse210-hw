public class Event
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime Date { get; set; }
    public TimeSpan Time { get; set; }
    public Address Location { get; set; }

    public Event(string title, string description, DateTime date, TimeSpan time, Address location)
    {
        Title = title;
        Description = description;
        Date = date;
        Time = time;
        Location = location;
    }

    
    public virtual string GetStandardDetails()
    {
        return $"{Title} - {Description} on {Date.ToShortDateString()} at {Time} located at {Location}";
    }

    
    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    
    public string GetShortDescription()
    {
        return $"{Title} on {Date.ToShortDateString()}";
    }
}
