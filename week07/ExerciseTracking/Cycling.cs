using System;

class Cycling : Activity
{
    private double _speed; 
    public Cycling(DateTime date, int minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return _speed * GetMinutes() / 60.0;
    }

    public override double GetSpeed() {
        return _speed;
    }

    public override double GetPace()
    {
        double distance = GetDistance();
        return distance > 0 ? GetMinutes() / distance : 0;
    }

    public override string GetSummary()
    {
        
        return $"{GetDate():yyyy-MM-dd} Cycling ({GetMinutes()} min): {GetDistance():0.00} miles, Speed: {GetSpeed():0.00} mph, Pace: {GetPace():0.00} min/mile";
    }
}
