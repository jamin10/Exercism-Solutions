using System;

static class LogLine
{
    public static string Message(string logLine) => logLine[(logLine.IndexOf(':') + 1)..].Trim();

    public static string LogLevel(string logLine) => logLine.Split('[', ']')[1].ToLower();

    public static string Reformat(string logLine) => $"{Message(logLine)} ({LogLevel(logLine)})";
}
