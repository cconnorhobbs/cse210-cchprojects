class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points) { }

    public override int RecordEvent()
    {
        return Points; // never completes
    }
    public override string SaveString()
    {
        return $"Eternal|{Name}|{Description}|{Points}";
    }
}