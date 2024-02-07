using System;
using System.Linq;
using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        string control ="";
        for (int i = 0; i < identifier.Length; i++)
        {
            if (identifier[i] == ' ') {
                control += '_';
            } else if (char.IsControl(identifier[i])) {
                control += "CTRL";
            } else if (identifier[i] == '-') {
                i ++;
                control += char.ToUpper(identifier[i]);
            } else if (!char.IsLetter(identifier[i]))
            {
            } else if (identifier[i] >= 'α' && identifier[i] <= 'ω')
            {
            } else
            {
                control += identifier[i];
            }
        }
        return control;
    }
}
