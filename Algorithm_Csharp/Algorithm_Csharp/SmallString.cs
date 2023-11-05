namespace Algorithm_Csharp;
 using System.Collections.Generic;
public class SmallString
{
    public int solution(string t, string p)
    {
        List<string> splitList = new List<string>();
        for (int i = 0; i <= t.Length - p.Length; i++)
        {
            splitList.Add(t.Substring(i, p.Length));
        }
        return splitList.Count(partString => long.Parse(partString) <= long.Parse(p));
    }
}