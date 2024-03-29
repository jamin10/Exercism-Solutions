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
        return OnEarth() / 1.8808158 ;
    }

    public double OnJupiter()
    {
        return OnEarth() / 11.862615;
    }

    public double OnSaturn()
    {
        return OnEarth() / 29.447498;
    }

    public double OnUranus()
    {
        return OnEarth() / 84.016846;
    }

    public double OnNeptune()
    {
        return OnEarth() / 164.79132 ;
    }
}