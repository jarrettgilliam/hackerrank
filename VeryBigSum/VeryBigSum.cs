using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        Console.ReadLine();
        ulong sum = 0;
        string[] numbers = Console.ReadLine().Split();
        foreach (string s in numbers)
            sum += ulong.Parse(s);
        Console.WriteLine(sum);
    }
}