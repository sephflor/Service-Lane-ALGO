using System;
using System.Collections.Generic;
using System.Linq;

class Result
{
    /*
     * Complete the 'serviceLane' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER n (length of highway)
     *  2. 2D_INTEGER_ARRAY cases (list of test cases with entry and exit indices)
     */
    public static List<int> serviceLane(int n, List<int> width, List<List<int>> cases)
    {
        List<int> result = new List<int>();

        foreach (var c in cases)
        {
            int entry = c[0];
            int exit = c[1];

      
            int minWidth = int.MaxValue;
            for (int i = entry; i <= exit; i++)
            {
                minWidth = Math.Min(minWidth, width[i]);
            }

            result.Add(minWidth);
        }

        return result;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
        int n = Convert.ToInt32(firstMultipleInput[0]);
        int t = Convert.ToInt32(firstMultipleInput[1]);

        List<int> width = Console.ReadLine().TrimEnd().Split(' ').Select(int.Parse).ToList();
        List<List<int>> cases = new List<List<int>>();

        for (int i = 0; i < t; i++)
        {
            cases.Add(Console.ReadLine().TrimEnd().Split(' ').Select(int.Parse).ToList());
        }

        List<int> result = Result.serviceLane(n, width, cases);

        Console.WriteLine(string.Join("\n", result));
    }
}
