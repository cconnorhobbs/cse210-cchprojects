abstract class Goal
{
    public string Name { get; }
    public string Description { get; }
    public int Points { get; }
    public bool IsComplete { get; set; }

    public Goal(string name, string description, int points)
    {
        Name = name;
        Description = description;
        Points = points;
        IsComplete = false;
    }

    public abstract int RecordEvent();
    public abstract string SaveString();

    public virtual string Display()
    {
        string check = IsComplete ? "[X]" : "[ ]";
        return $"{check} {Name} - {Description}";
    }
}