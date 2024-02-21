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

    // Standard Details
    public virtual string GetStandardDetails()
    {
        return $"{Title} - {Description} on {Date.ToShortDateString()} at {Time} located at {Location}";
    }

    // Full Details - Designed to be overridden in derived classes
    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    // Short Description
    public string GetShortDescription()
    {
        return $"{Title} on {Date.ToShortDateString()}";
    }
}
