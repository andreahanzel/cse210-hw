using System;

class Program
{
    static void Main(string[] args)
    {
        // Create an address instance for use with all events
        Address eventAddress = new Address("123 Event St", "Cityville", "State", "Country");

        // Lecture Event
        Lecture techLecture = new Lecture(
            "Innovative Tech Trends",
            "Exploring the future of technology.",
            DateTime.Now.AddDays(30),
            new TimeSpan(18, 0, 0),
            eventAddress,
            "Dr. Tech Savvy",
            100);

        // Reception Event
        Reception galaReception = new Reception(
            "Annual Gala",
            "An evening of celebration and networking.",
            DateTime.Now.AddDays(60),
            new TimeSpan(19, 30, 0),
            eventAddress,
            "rsvp@galaevents.com");

        // Outdoor Gathering Event
        OutdoorGathering beachCleanup = new OutdoorGathering(
            "Beach Cleanup Day",
            "Join us to help clean our beautiful beaches.",
            DateTime.Now.AddDays(90),
            new TimeSpan(9, 0, 0),
            eventAddress,
            "Sunny skies expected");

        // Display marketing messages for each event
        DisplayMarketingMessages(techLecture);
        DisplayMarketingMessages(galaReception);
        DisplayMarketingMessages(beachCleanup);
    }

    static void DisplayMarketingMessages(Event eventItem)
    {
        Console.WriteLine("Standard Details:");
        Console.WriteLine(eventItem.GetStandardDetails());
        Console.WriteLine("\nFull Details:");
        Console.WriteLine(eventItem.GetFullDetails());
        Console.WriteLine("\nShort Description:");
        Console.WriteLine(eventItem.GetShortDescription());
        Console.WriteLine("-------------------------------------------");
    }
}
