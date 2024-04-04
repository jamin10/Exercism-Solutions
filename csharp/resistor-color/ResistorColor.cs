using System;
using System.Collections.Generic;

public static class ResistorColor
{
    private static Dictionary<string, int> bands = new Dictionary<string, int>
    {
        {"black", 0},
        {"brown", 1},
        {"red", 2},
        {"orange", 3},
        {"yellow", 4},
        {"green", 5},
        {"blue", 6},
        {"violet", 7},
        {"grey", 8},
        {"white", 9}
    };

    public static int ColorCode(string color)
    {
        return bands[color];
    }

    public static string[] Colors()
    {
        throw new NotImplementedException("You need to implement this function.");
    }
}