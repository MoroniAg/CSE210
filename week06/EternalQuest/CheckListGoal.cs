class CheckListGoal : Goal
{

    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public CheckListGoal(string shortName, string description, int points, int target, int bonus) : base(shortName, description, points, "CheckListGoal")
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public int GetBonus()
    {
        return _bonus;
    }

    public override string GetDetailString()
    {
        return $"CheckListGoal,{GetShortName()},{GetDescription()},{GetPoints()},{_amountCompleted},{_target},{_bonus},{IsComplete()}";
    }

    public override string GetStringRepresentation()
    {
        return $" [{(IsComplete() ? "X" : " ")}] {GetShortName()} ({GetDescription()}) -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override void RecordEvent()
    {
        if (!IsComplete())
        {
            _amountCompleted++;
        }

    }
}