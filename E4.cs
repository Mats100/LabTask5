// 213034 Muneeb Shahid
using System;
class array
{
    static void Main(string[] args)
    {

        string[] weekDays = { "sun", "Mon", "tue", "wed", "thu", "Fri", "sat" };
        PrintArray(weekDays);
        ChangeArray(weekDays);
        Console.WriteLine();
        PrintArray(weekDays);
        System.Console.WriteLine();
        ChangeArrayElements(weekDays);
        Console.WriteLine("Array week days after the call to ChangeArray:");
        PrintArray(weekDays);


    }

    private static void ChangeArrayElements(string[] weekDays)
    {
        weekDays[0] = "sat";
        weekDays[1] = "fri";
        weekDays[2] = "Thu";

        Console.WriteLine("arr[0] is {0} in ChangeArrayElements.", weekDays[0]);

    }

    private static void ChangeArray(string[] weekDays)
    {
        weekDays = (weekDays.Reverse()).ToArray();
        Console.WriteLine("arr[0] is {0} in ChangeArray.", weekDays[0]);
    }
    public static void PrintArray(string[] weekDays)
    {
        for (int i = 0; i < weekDays.Length; i++)
        {
            Console.Write(weekDays[i] + "{0}", i < weekDays.Length - 1 ? " " : "");
        }
        Console.WriteLine();



    }
}
