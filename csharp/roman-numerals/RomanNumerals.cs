using System;

public static class RomanNumeralExtension
{
    public static string ToRoman(this int value)
    {
        string numerals = "";

        while (value > 0) {
            if (value >= 1000) {
                value -= 1000;
                numerals += 'M';
            }
            else if (value >= 900 && value < 1000) {
                value -= 900;
                numerals += "CM";
            } else if (value >= 500 && value < 900) {
                value -= 500;
                numerals += 'D';
            } else if (value >= 400 && value < 500) {
                value -= 400;
                numerals += "CD";
            } else if (value >= 100 && value < 400) {
                value -= 100;
                numerals += 'C';
            } else if (value >= 90 && value < 100) {
                value -= 90;
                numerals += "XC";
            } else if (value >= 50 && value < 90) {
                value -= 50;
                numerals += "L";
            } else if (value >= 40 && value < 50) {
                value -= 40;
                numerals += "XL";
            } else if (value >= 10 && value < 40) {
                value -= 10;
                numerals += "X";
            } else if (value >= 9 && value < 10) {
                value -= 9;
                numerals += "IX";
            } else if (value >= 5 && value < 9) {
                value -= 5;
                numerals += "V";
            } else if (value >= 4 && value < 5) {
                value -= 4;
                numerals += "IV";
            } else {
                value -= 1;
                numerals += 'I';
            }
        }
        return numerals;
    }
}