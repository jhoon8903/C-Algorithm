using System;
using System.Collections.Generic;
using System.Linq;

public class Solution 
{
    public int solution(int n, int[] lost, int[] reserve)
    {
        int[] orderByLost = lost.OrderBy(x => x).ToArray();
        HashSet<int> lostUniform = new HashSet<int>(orderByLost);
        int[] orderByReserve = reserve.OrderBy(x => x).ToArray();
        HashSet<int> reserveUniform = new HashSet<int>(orderByReserve);

        List<int> remove = lostUniform
            .Where(student => reserveUniform.Contains(student))
            .ToList();

        foreach (var student in remove)
        {
            lostUniform.Remove(student);
            reserveUniform.Remove(student);
        }

        foreach (var student in reserveUniform)
        {
            if (lostUniform.Contains(student - 1))
            {
                lostUniform.Remove(student - 1);
            }
            else if (lostUniform.Contains(student + 1))
            {
                lostUniform.Remove(student + 1);
            }
        }

        return n - lostUniform.Count;
    }
}