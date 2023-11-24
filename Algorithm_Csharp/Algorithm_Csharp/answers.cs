namespace Algorithm_Csharp;

public class answers
{
    public int[] solution(int[] answers) 
    {
        List<int> answer = new List<int>();
        int[] one = { 1, 2, 3, 4, 5 };
        int[] two = { 2, 1, 2, 3, 2, 4, 2, 5 };
        int[] three = { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };

        int oneAnswer = 0;
        int twoAnswer = 0;
        int threeAnswer = 0;

        for (int i = 0; i < answers.Length; i ++)
        {
            int indexOne = i % one.Length;
            int indexTwo = i % two.Length;
            int indexThree = i % three.Length;

            if (answers[i] == one[indexOne])
            {
                oneAnswer++;
            }

            if (answers[i] == two[indexTwo])
            {
                twoAnswer++;
            }

            if (answers[i] == three[indexThree])
            {
                threeAnswer++;
            }
        }

        int maxScore = Math.Max(oneAnswer, Math.Max(twoAnswer, threeAnswer));

        if (oneAnswer == maxScore) answer.Add(1);
        if (twoAnswer == maxScore) answer.Add(2);
        if (threeAnswer == maxScore) answer.Add(3);

        return answer.ToArray();
    } 
}