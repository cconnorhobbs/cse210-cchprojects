class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points)
        : base(name, description, points) { }

    public override int RecordEvent()
    {
        if (!IsComplete)
        {
            IsComplete = true;
            return Points;
        }
        return 0;
    }
    public override string SaveString()
    {
        return $"Simple|{Name}|{Description}|{Points}|{IsComplete}";
    }
}