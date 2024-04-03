using System;
using System.Collections.Generic;
using System.Linq;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        HashSet<int> values = new HashSet<int>();
        foreach (int multiple in multiples) 
        {
            int n = 2;
            if (multiple == 0) {
                break;
            } 
            int v = multiple;
            while (v < max)
            {
                values.Add(v);
                v = multiple * n;
                n++;
            }
        }
        
        return values.Sum();
    }
}