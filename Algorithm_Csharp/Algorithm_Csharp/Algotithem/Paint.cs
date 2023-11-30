namespace Algorithm_Csharp;

public class Paint
{
    public int solution(int n, int m, int[] section)
    {
        int answer= 0;
        int Index = 0;

        while (Index < section.Length)
        {
            int start = section[Index];
            int end = Math.Min(start + m - 1, n);
            
            answer++;
            
            while (Index < section.Length && section[Index] <= end)
            {
                Index++;
            }
        }
        return answer;
    }
}