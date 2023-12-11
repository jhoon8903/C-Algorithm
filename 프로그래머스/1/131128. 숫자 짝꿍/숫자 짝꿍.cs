using System;
using System.Linq;
using System.Collections.Generic;

public class Solution 
{
    public string solution(string X, string Y)
    {
        string answer = "-1";

        var xCharCounts = X.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
        var yCharCounts = Y.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());

        var commonChars = new List<char>();

        foreach (var xChar in xCharCounts)
        {
            if (!yCharCounts.TryGetValue(xChar.Key, out int yCount)) continue;
            int minCount = Math.Min(xChar.Value, yCount);
            commonChars.AddRange(Enumerable.Repeat(xChar.Key, minCount));
        }

        if (!commonChars.Any()) return answer;

        var sortedCommonChars = commonChars.OrderByDescending(c => c).ToArray();
        return sortedCommonChars.All(c => c == '0') ? "0" : new string(sortedCommonChars);
    }
}