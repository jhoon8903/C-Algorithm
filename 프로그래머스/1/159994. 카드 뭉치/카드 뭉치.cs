using System;
using System.Linq;
using System.Collections.Generic;

public class Solution 
{
public string solution(string[] cards1, string[] cards2, string[] goal)
{
    // 카드 덱의 현재 위치를 추적하기 위해 인덱스 초기화
    int index1 = 0, index2 = 0;

    // 목표 배열의 각 단어를 반복
    foreach (var word in goal)
    {
        // 현재 목표 단어가 카드와 일치하는지 확인하는 플래그
        bool matched = false;

        // 목표의 현재 단어가 cards1의 현재 위치의 단어와 일치하는지 확인
        if (index1 < cards1.Length && cards1[index1] == word)
        {
            index1++; // cards1의 다음 단어로 이동
            matched = true; // 일치하는 경우 플래그를 true로 설정
        }
        // cards1과 일치하지 않는 경우 cards2와 일치하는지 확인
        else if (index2 < cards2.Length && cards2[index2] == word)
        {
            index2++; // cards2의 다음 단어로 이동
            matched = true; // 일치하는 경우 플래그를 true로 설정
        }

        // 목표의 현재 단어가 어떤 카드와도 일치하지 않는 경우 "No" 반환
        if (!matched)
        {
            return "No";
        }
    }

    // 목표의 모든 단어가 문제없이 일치하면 "Yes" 반환
    return "Yes";
}
}