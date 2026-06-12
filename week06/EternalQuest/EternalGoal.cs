class EternalGoal : Goal
{

    public EternalGoal(string shortName, string description, int points) : base(shortName, description, points, "EternalGoal")
    {
    }
    public override string GetDetailString()
    {
        return $"EternalGoal,{GetShortName()},{GetDescription()},{GetPoints()},False";
    }

    public override string GetStringRepresentation()
    {
        return $" [{(IsComplete() ? "X" : " ")}] {GetShortName()} ({GetDescription()})";
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override void RecordEvent()
    {
        // Eternal goals are never completed, so recording an event does not change their state.
    }
}