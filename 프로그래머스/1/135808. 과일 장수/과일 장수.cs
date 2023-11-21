using System;
using System.Collections.Generic;
using System.Linq;

public class Solution 
{
    public int solution(int k, int m, int[] score) 
    {
        int [] apples = score.OrderByDescending(a => a).ToArray();
        List<int[]> divisorAppleBox = new List<int[]>();
        for (int i = 0; i < apples.Length; i+= m)
        {
            int count = Math.Min(m, apples.Length - i);
            int[] box = new int[count];
            // SourceArray, SourceIndex, DestinationArray, DestinationIndex, Length
            Array.Copy(apples, i, box, 0,count);
            if (count == m)
            {
                divisorAppleBox.Add(box);
            }
        }
        return divisorAppleBox.Sum(appleBox => appleBox.Min() * m);
    } 
}