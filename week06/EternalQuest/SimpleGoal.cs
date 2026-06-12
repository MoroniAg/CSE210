class SimpleGoal : Goal
{

    private bool _isComplete;

    public SimpleGoal(string shortName, string description, int points) : base(shortName, description, points, "SimpleGoal")
    {
        _isComplete = false;
    }

    public override string GetDetailString()
    {
        return $"SimpleGoal,{GetShortName()},{GetDescription()},{GetPoints()},{_isComplete}";
    }

    public override string GetStringRepresentation()
    {
        return $" [{(_isComplete ? "X" : " ")}] {GetShortName()} ({GetDescription()})";
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }
}