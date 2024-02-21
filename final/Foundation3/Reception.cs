public class Reception : Event
{
    public string RsvpEmail { get; set; }

    public Reception(string title, string description, DateTime date, TimeSpan time, Address location, string rsvpEmail)
        : base(title, description, date, time, location)
    {
        RsvpEmail = rsvpEmail;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()} RSVP at: {RsvpEmail}";
    }
}
