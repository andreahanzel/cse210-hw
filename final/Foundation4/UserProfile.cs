public class UserProfile
{
    public string UserName { get; set; }
    public double Weight { get; set; }
    public List<Activity> Activities { get; set; }

    public UserProfile(string userName, double weight)
    {
        UserName = userName;
        Weight = weight;
        Activities = new List<Activity>();
    }

    public void AddActivity(Activity activity)
    {
        Activities.Add(activity);
    }

    public void DisplayActivitiesSummary()
    {
        foreach (var activity in Activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
