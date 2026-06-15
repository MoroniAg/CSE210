using System;

class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }


    public override double GetDistance()
    {
        double km = _laps * 50.0 / 1000.0;
        double miles = km * 0.62;
        return miles;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetMinutes()) * 60.0;
    }

    public override double GetPace()
    {
        double d = GetDistance();
        return d > 0 ? GetMinutes() / d : 0;
    }

    public override string GetSummary()
    {
        return $"{GetDate():yyyy-MM-dd} Swimming ({GetMinutes()} min): {GetDistance():0.00} miles, Speed: {GetSpeed():0.00} mph, Pace: {GetPace():0.00} min/mile";
    }
}
