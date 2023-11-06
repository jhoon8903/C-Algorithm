namespace Algorithm_Csharp;
using System.Collections.Generic;
using System.Linq;
using System;

public class NumberK
{
    public int[] solution(int[] array, int[,] commands) 
    {
        List<int> commandSelect = new List<int>();
        for (int targetIndex = 0; targetIndex < commands.GetLength(0); targetIndex++)
        {
            int i = commands[targetIndex, 0];
            int j = commands[targetIndex, 1];
            int k = commands[targetIndex, 2];
            int[] sliceArray = array.Skip(i - 1).Take(j - i + 1).ToArray();
            Array.Sort(sliceArray);
            commandSelect.Add(sliceArray[k-1]);
        }
        return commandSelect.ToArray();
    }
}