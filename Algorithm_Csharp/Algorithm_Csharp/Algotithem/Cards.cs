using System.Linq;
using System.Collections.Generic;
namespace Algorithm_Csharp;

public class Cards
{
    public static string solution(string[] cards1, string[] cards2, string[] goal)
    {
        int index1 = 0, index2 = 0;

        foreach (var word in goal)
        {
            bool matched = false;

            if (index1 < cards1.Length && cards1[index1] == word)
            {
                index1++;
                matched = true;
            }
            else if (index2 < cards2.Length && cards2[index2] == word)
            {
                index2++;
                matched = true;
            }

            if (!matched)
            {
                return "No";
            }
        }

        return "Yes";
    }
}