using System;
using System.Collections.Generic;
using System.Linq;

namespace OddEvenNumber;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        PrintNumbers("Numbers", numbers);
        PrintNumbers("Even No", numbers.Where(x => IsEven(x)));
        PrintNumbers("Odd No", numbers.Where(x => IsOdd(x)));
    }
    
    static void PrintNumbers(string x, IEnumerable<int> numbers)
    {
        Console.WriteLine(x + ":");
        foreach (int i in numbers) Console.Write(i + " ");
        Console.WriteLine();
    }
    
    static bool IsEven(int number) => number % 2 == 0;
    
    static bool IsOdd(int number) => !IsEven(number);
}

