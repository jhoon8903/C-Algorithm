using System.Text;

public class PairNumber : KataBase
{                                                                                                                              
    public string solution(string X, string Y)
    {
        // 기본 반환값을 설정합니다. 이 값은 공통된 숫자가 없을 경우 반환됩니다.
        string answer = "-1";

        // X의 각 문자에 대한 카운트를 계산합니다.
        var xCharCounts = X.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
        // Y의 각 문자에 대한 카운트를 계산합니다.
        var yCharCounts = Y.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());

        // 두 문자열에서 공통으로 나타나는 문자를 저장할 리스트를 생성합니다.
        var commonChars = new List<char>();

        // X에 있는 모든 문자를 반복하여 확인합니다.
        foreach (var xChar in xCharCounts)
        {
            // Y에도 같은 문자가 있는지 확인하고, 그렇지 않으면 계속합니다.
            if (!yCharCounts.TryGetValue(xChar.Key, out int yCount)) continue;
            // X와 Y에서의 해당 문자의 최소 등장 횟수를 찾습니다.
            int minCount = Math.Min(xChar.Value, yCount);
            // 공통 문자를 최소 등장 횟수만큼 리스트에 추가합니다.
            commonChars.AddRange(Enumerable.Repeat(xChar.Key, minCount));
        }

        // 공통 문자가 없는 경우, 기본 반환값을 반환합니다.
        if (!commonChars.Any()) return answer;

        // 공통 문자를 내림차순으로 정렬합니다.
        var sortedCommonChars = commonChars.OrderByDescending(c => c).ToArray();
        // 만약 모든 공통 문자가 '0'이라면, 단일 '0'을 반환합니다.
        return sortedCommonChars.All(c => c == '0') ? "0" : new string(sortedCommonChars);
    }
    
    public string solution2(string X, string Y)
    {
        var xCharCounts = new Dictionary<char, int>();
        var commonChars = new Dictionary<char, int>();
        foreach (var c in X.Where(c => !xCharCounts.TryAdd(c, 1)))
        {
            xCharCounts[c]++;
        }
        foreach (var c in Y.Where(c => xCharCounts.ContainsKey(c)))
        {
            if (!commonChars.TryAdd(c, 1))
            {
                commonChars[c] = Math.Min(xCharCounts[c], commonChars[c] + 1);
            }
        }

        if (commonChars.Count == 0) return "-1";
        if (commonChars.All(pair => pair.Key == '0')) return "0";

        var sortedCommonChars = commonChars.ToList();
        sortedCommonChars.Sort((pair1, pair2) => pair2.Key.CompareTo(pair1.Key));
        
        var result = new StringBuilder();
        foreach (var pair in sortedCommonChars)
        {
            result.Append(pair.Key, pair.Value);
        }

        return result.ToString();
    }

    public override void Example()
    {
        string x = "100";
        string y = "203045";
        var result = solution(x,y);
        Console.WriteLine($"결괏값 : {result}"); 
    }
}