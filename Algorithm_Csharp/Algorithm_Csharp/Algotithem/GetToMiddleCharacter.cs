namespace Algorithm_Csharp;

public class GetToMiddleCharacter
{
    /*
     *가운데 글자 가져오기
       문제 설명
       단어 s의 가운데 글자를 반환하는 함수, solution을 만들어 보세요. 단어의 길이가 짝수라면 가운데 두글자를 반환하면 됩니다.
       
       재한사항
       s는 길이가 1 이상, 100이하인 스트링입니다.
       입출력 예
       s	return
       "abcde"	"c"
       "qwer"	"we"
     */

    public string solution(string s) 
    {
        char[] words = s.ToCharArray();
        int centerIndex = words.Length / 2;

        return words.Length % 2 == 1 
            ? words[centerIndex].ToString()
            : words[centerIndex - 1] + words[centerIndex].ToString();
    }
}