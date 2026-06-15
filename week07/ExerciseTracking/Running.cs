using System;

class Running : Activity
{
    private double _distance; 

    public Running(DateTime date, int minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
    }

    public override double GetDistance() {
        return _distance;
    }

    public override double GetSpeed()
    {
        return GetDistance() / GetMinutes() * 60.0;
    }

    public override double GetPace()
    {
        double d = GetDistance();
        return d > 0 ? GetMinutes() / d : 0;
    }

    public override string GetSummary()
    {
        return $"{GetDate():yyyy-MM-dd} Running ({GetMinutes()} min): {GetDistance():0.00} miles, Speed: {GetSpeed():0.00} mph, Pace: {GetPace():0.00} min/mile";
    }
}
