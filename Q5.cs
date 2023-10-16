// 213034 Muneeb Shahid

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Converting Decimal to Binary");
        Console.Write("Enter a decimal number: ");
        int decimalNumber = int.Parse(Console.ReadLine());
        string binaryResult = DecimalToBinary(decimalNumber);
        Console.WriteLine($"Binary representation: {binaryResult}");

        Console.WriteLine("\n Converting Binary to Decimal");
        Console.Write("Enter a Binary number: ");
        string binaryNumber = Console.ReadLine();
        int decimalResult = BinaryToDecimal(binaryNumber);
        Console.WriteLine($"Decimal representation: {decimalResult}");
    }

    static string DecimalToBinary(int decimalNumber)
    {
        return Convert.ToString(decimalNumber, 4);
    }

    static int BinaryToDecimal(string binaryNumber)
    {
        return Convert.ToInt32(binaryNumber, 4);
    }
}