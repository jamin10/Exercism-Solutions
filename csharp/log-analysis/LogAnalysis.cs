using System;

public static class LogAnalysis 
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string log, string delim)
    {
        return log.Split(delim)[1];
    }

    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    
    // TODO: define the 'Message()' extension method on the `string` type

    // TODO: define the 'LogLevel()' extension method on the `string` type
}