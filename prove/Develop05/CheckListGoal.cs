class ChecklistGoal : Goal
{
    public int Target { get; }
    public int Count { get; private set; }
    public int Bonus { get; }

    public ChecklistGoal(string name, string description, int points, int target, int bonus, int count = 0)
        : base(name, description, points)
    {
        Target = target;
        Bonus = bonus;
        Count = count;
    }
    public override int RecordEvent()
    {
        if (!IsComplete)
        {
            Count++;

            if (Count >= Target)
            {
                IsComplete = true;
                return Points + Bonus;
            }
            return Points;
        }
        return Points; // if recording after finished
    }
    public override string Display()
    {
        string check = IsComplete ? "[X]" : "[ ]";
        return $"{check} {Name} ({Count}/{Target}) - {Description}";
    }
    public override string SaveString()
    {
        return $"Checklist|{Name}|{Description}|{Points}|{IsComplete}|{Target}|{Count}|{Bonus}";
    }
}