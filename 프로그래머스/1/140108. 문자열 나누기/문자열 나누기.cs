using System;

public class Solution 
{
    public int solution(string s)
    {
        int count = 0;
        while (!string.IsNullOrEmpty(s))
        {
            char x = s[0];
            int xCount = 0;
            int otherCount = 0;
            
            int i;

            for (i = 0; i < s.Length; i++)
            {
                if (s[i] == x) xCount++;
                else otherCount++;
                if (xCount == otherCount)   break;
            }

            s = i < s.Length - 1 ? s.Substring(i + 1) : string.Empty;

            count++;
        }

        return count;
    }
}