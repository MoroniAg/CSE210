abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;
    private string _type;

    public Goal(string shortName, string description, int points, string type)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
        _type = type;
    }

    public string GetShortName()
    {
        return _shortName;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetPoints()
    {
        return _points;
    }

    public string GetGoalType()
    {
        return _type;
    }

    abstract public void RecordEvent();
    abstract public bool IsComplete();
    abstract public string GetStringRepresentation();
    abstract public string GetDetailString();
}