using System;

static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        var departmentName = (department ?? "OWNER").ToUpper();

        return id == null ? $"{name} - {departmentName}" : $"[{id}] - {name} - {departmentName}";
    }
}
