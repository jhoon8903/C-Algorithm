namespace Algorithm_Csharp;
using System.Collections.Generic;
public class CardWallet
{
    public int solution(int[,] sizes)
    {
        // sizes의 각 원소에 대해 긴 변과 짧은 변을 구분하여 새로운 배열을 생성
        var reSize = from int i in Enumerable.Range(0, sizes.GetLength(0)) 
            let w = sizes[i, 0] 
            let h = sizes[i, 1]
            select new { w = Math.Max(w, h), h = Math.Min(w, h) };

        // 조정된 가로와 세로 중 최대 값을 찾음
        int maxW = reSize.Max(size => size.w);
        int maxH = reSize.Max(size => size.h);

        // 최소 지갑 크기 반환
        return maxW * maxH;
    }
}