using System;
using System.Linq;

public class Solution 
{
    public int solution(string[] babbling) 
    {
        string[] babble = { "aya", "ye", "woo", "ma" };
        // 'babbling' 배열의 각 문자열에 대해 'Validate' 함수를 호출하여 유효한 단어의 수를 계산합니다.
        return babbling.Count(word => Validate(word, babble));
    }

    private bool Validate(string word, string[] canWords) 
    {
        string speakWord = word; // 현재 확인하고 있는 단어를 저장합니다.
        string lastPronunciation = null; // 마지막으로 확인한 발음을 저장합니다.

        while (!string.IsNullOrEmpty(speakWord))    // speakWord가 비어있지 않은 동안 반복합니다.
        { 
            bool found = false; // 현재 반복에서 유효한 발음을 찾았는지를 나타내는 플래그입니다.

            foreach (var canWord in canWords) // 가능한 발음들을 순회합니다.
            { 
                if (!speakWord.StartsWith(canWord)) continue; // 현재 발음이 speakWord로 시작하지 않으면 계속합니다.
                if (lastPronunciation == canWord) return false; // 이전 발음과 동일하면 false를 반환합니다.
                speakWord = speakWord.Substring(canWord.Length);// speakWord에서 현재 발음을 제거합니다.
                lastPronunciation = canWord; // 마지막 발음을 갱신합니다.
                found = true; // 유효한 발음을 찾았으므로 플래그를 true로 설정합니다.
                break; // 더 이상의 확인은 필요 없으므로 반복을 중단합니다.
            }
            if (!found) return false; // 유효한 발음을 찾지 못했다면 false를 반환합니다.
        }
        return true; // 모든 확인이 끝났고, 모든 발음이 유효하다면 true를 반환합니다.
    }
}