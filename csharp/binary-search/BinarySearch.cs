using System;
using System.Linq;

public static class BinarySearch
{
    static int output = 0;

    public static int Find(int[] input, int value)
    {
        int minIndex = 0;
        int maxIndex = input.Length - 1;

        while (minIndex <= maxIndex)
        {
            int midIndex = (minIndex + maxIndex) / 2;
            if (input[midIndex] == value)
            {
                return midIndex;
            } else if (input[midIndex] < value)
            {
                minIndex = midIndex + 1;
            } else if (input[midIndex] > value)
            {
                maxIndex = midIndex - 1;
            }
        }
        return -1;
    }
}