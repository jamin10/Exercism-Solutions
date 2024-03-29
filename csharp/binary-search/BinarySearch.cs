using System;
using System.Linq;

public static class BinarySearch
{
    public static int Find(int[] input, int value)
    {
        double length = (double)input.Length;
        double preIndex = (length - 1) / 2;
        int index = (int)Math.Round(preIndex, 0, MidpointRounding.AwayFromZero);
        if (input[index] == value)
        {
            return index;
        } else if (input[index] < value)
        {
            int[] newInput = input.Skip(index).ToArray();
            return Find(newInput, value);
        } else if (input[index] > value)
        {
            int[] newInput = input.Take(index + 1).ToArray();
            return Find(newInput, value);
        } else
        {
            return value;
        }
    }
}