using System;
using System.Collections.Generic;

public static class ProteinTranslation
{
    private static Dictionary<string, string> map = new Dictionary<string, string>()
        {
            {"AUG", "Methionine"},
            {"UUU", "Phenylalanine"},
            {"UUC", "Phenylalanine"},
            {"UUA", "Leucine"},
            {"UUG", "Leucine"},
            {"UCU", "Serine"},
            {"UCC", "Serine"},
            {"UCA", "Serine"},
            {"UCG", "Serine"},
            {"UAU", "Tyrosine"},
            {"UAC", "Tyrosine"},
            {"UGU", "Cysteine"},
            {"UGC", "Cysteine"},
            {"UGG", "Tryptophan"},
            {"UAA", "STOP"},
            {"UAG", "STOP"},
            {"UGA", "STOP"}
        };

    public static string[] Proteins(string strand)
    {
        List<string> polypeptide = new List<string>();
        int i = 0;

        while (strand.Length > i && map[strand.Substring(i, 3)] != "STOP") {
            polypeptide.Add(map[strand.Substring(i, 3)]);
            i += 3;
        }
        return polypeptide.ToArray();
    }
}