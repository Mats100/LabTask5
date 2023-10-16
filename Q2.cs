// 213034 Muneeb Shahid

using System;

class Program
{
    static void Main(string[] args)
    {
        string[] s = { "Hello ", "and ", "Welcome ", "to ", "this ", "Demo! " };
        string mergedString = Merge(s);

        Console.WriteLine(mergedString);
    }

    static string Merge(string[] inputArray)
    {
        return string.Concat(inputArray);
    }
}