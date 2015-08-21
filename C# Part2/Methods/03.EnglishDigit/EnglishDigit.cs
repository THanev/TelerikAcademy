﻿//Write a method that returns the last digit of given integer as an English word.

using System;
class EnglishDigit
{
    static string NumberToWord(int a)
    {
        a = a % 10;
        switch(a)
        {
            case 0:
                return "Zero";
                break;
            case 1:
                return "One";
                break;
            case 2:
                return "Two";
                break;
            case 3:
                return "Three";
                break;
            case 4:
                return "Four";
                break;
            case 5:
                return "Five";
                break;
            case 6:
                return "Six";
                break;
            case 7:
                return "Seven";
                break;
            case 8:
                return "Eight";
                break;
            case 9:
                return "Nine";
                break;
            default: return "Not a digit";
                break;
            
        }
    }
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine(NumberToWord(a));
    }
}
