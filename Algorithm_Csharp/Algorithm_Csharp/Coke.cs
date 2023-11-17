namespace Algorithm_Csharp;

public class Coke
{
    public int solution(int a, int b, int n)
    {
        int exchangeCoke = 0; // 교환하여 얻은 콜라의 수

        while (n >= a) // 보유한 빈 병의 수가 교환에 필요한 빈 병의 수보다 클 때까지 반복
        {
            checked
            {
                // 교환할 수 있는 횟수를 계산
                int exchange = n / a; // 여기서 a = 3, n = 20 -> exchange = 6

                // 교환으로 얻은 콜라의 수를 더함
                exchangeCoke += exchange * b; // 여기서 b = 1, exchangeCoke += 6 * 1 -> exchangeCoke = 6

                // 남은 빈 병의 수를 업데이트
                n = n % a + exchange * b; // 여기서 n = 20 % 3 + 6 * 1 -> n = 2 + 6 -> n = 8

                // 다음 루프에서는 n = 8 이 되어 다시 계산을 시작
            }
        }
        return exchangeCoke; // 최종적으로 얻은 콜라의 수를 반환
    }
}