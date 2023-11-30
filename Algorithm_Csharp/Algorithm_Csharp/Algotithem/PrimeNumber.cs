namespace Algorithm_Csharp;

public class PrimeNumber
{
    public int solution(int[] nums)
    {
        int answer = 0;
        int n = nums.Length;
        for (int i = 0; i < n - 2; i++)
        {
            for (int j = i  + 1; j < n-1; j++ )
            {
                for (int k = j + 1; k < n; k++)
                {
                    if (Prime(nums[i] + nums[j] + nums[k]))
                    {
                        answer++;
                    }
                }
            }
        }
        return answer;
    }

    private bool Prime(int number)
    {
        if (number % 2 == 0) return false;

        int prime = (int)Math.Sqrt(number);

        for (int i = 3; i <= prime; i += 2)
        {
            if (number % i == 0) return false;
        }
        return true;
    }
}