using System;

public class SpaceAge
{
    private readonly int ageSeconds;

    public SpaceAge(int seconds)
    {
        ageSeconds = seconds;
    }

    public double OnEarth()
    {
        return ageSeconds / 60 / 60 / 24 / 365.25;
    }

    public double OnMercury()
    {
        return ageSeconds / 60 / 60 / 0.2408467 / 24 / 365.25;
    }

    public double OnVenus()
    {
        double earth = OnEarth();
        return OnEarth() / 0.61519726;
    }

    public double OnMars()
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public double OnJupiter()
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public double OnSaturn()
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public double OnUranus()
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public double OnNeptune()
    {
        throw new NotImplementedException("You need to implement this function.");
    }
}