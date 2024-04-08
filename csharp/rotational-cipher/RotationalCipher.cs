using System;

public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        string shiftedText = "";
        int key = shiftKey % 26;

        foreach (char c in text) 
        {
            if (Char.IsLetter(c)) {
                char shiftedChar = (char)(c + key);
                if ((Char.IsLower(c) && shiftedChar > 'z') ||
                    (Char.IsUpper(c) && shiftedChar > 'Z')) {
                    shiftedChar = (char)(shiftedChar - 26);
                    }
                shiftedText += shiftedChar;
            } else {
                shiftedText += c;
            }
        }
        return shiftedText;
    }
}