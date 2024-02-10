public abstract class Goal
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Points { get; set; }

    protected Goal() { }

    protected Goal(string name, string description, int points)
    {
        Name = name;
        Description = description;
        Points = points;
    }

    public abstract Goal CreateGoal();
    public abstract bool CheckCompletion();
    public abstract void RecordEvent();
    public abstract int AwardPoints();
    public abstract string GetStatus();
    public abstract string Serialize();
}
