namespace Algorithm_Csharp;

public class TernaryReverser
{
    /*
     3진법 뒤집기
       문제 설명
       자연수 n이 매개변수로 주어집니다. n을 3진법 상에서 앞뒤로 뒤집은 후, 이를 다시 10진법으로 표현한 수를 return 하도록 solution 함수를 완성해주세요.
       
       제한사항
       n은 1 이상 100,000,000 이하인 자연수입니다.
       입출력 예
       n	result
       45	7
       125	229
       입출력 예 설명
       입출력 예 #1
       
       답을 도출하는 과정은 다음과 같습니다.
       n (10진법)	n (3진법)	앞뒤 반전(3진법)	10진법으로 표현
       45	1200	0021	7
       따라서 7을 return 해야 합니다.
       입출력 예 #2
       
       답을 도출하는 과정은 다음과 같습니다.
       n (10진법)	n (3진법)	앞뒤 반전(3진법)	10진법으로 표현
       125	11122	22111	229
       따라서 229를 return 해야 합니다.
     */

    public int solution(int n)
    {
        char[] ternary = ConvertToBase3(n).ToCharArray();
        Array.Reverse(ternary);
        return ConvertToBase10(ternary);
    }

    private string ConvertToBase3(int num)
    {
        string base3 = "";
        
        while (num > 0)
        {
            base3 = (num % 3) + base3;
            num /= 3;
        }
        return base3;
    }

    private int ConvertToBase10(char[] base3)
    {
        int base10Sum = 0;
        int pow = base3.Length - 1;

        foreach (var c in base3)
        {
            int digit = c - '0';
            base10Sum += digit * (int)Math.Pow(3, pow);
            pow--;
        }

        return base10Sum;
    }
}