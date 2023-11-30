namespace Algorithm_Csharp;

public class LargestRectangleInHistogram
{
    /*
    84. Largest Rectangle in Histogram
    Given an array of integers heights representing the histogram's bar height 
    where the width of each bar is 1, return the area of the 
    largest rectangle in the histogram.

    Example 1:

    Input: heights = [2,1,5,6,2,3]
    Output: 10
    Explanation: The above is a histogram where width of each bar is 1.
    The largest rectangle is shown in the red area, which has an area = 10 units.
    Example 2:

    Input: heights = [2,4]
    Output: 4

    Constraints:

    1 <= heights.length <= 105
    0 <= heights[i] <= 104*/

    public int LargestRectangleArea(int[] heights) 
    {
        Stack<int> stack = new Stack<int>(); // 스택 초기화
        int maxArea = 0; // 최대 면적 추적
        int i = 0; // 현재 막대의 인덱스

        // 모든 막대를 순회
        while (i < heights.Length) 
        {
            // 스택이 비어있거나 현재 막대가 스택의 맨 위 막대보다 높거나 같은 경우
            if (stack.Count == 0 || heights[stack.Peek()] <= heights[i]) 
            {
                stack.Push(i++); // 현재 인덱스를 스택에 푸시하고 i 증가
            } 
            else // 현재 막대가 스택의 맨 위 막대보다 낮은 경우
            {
                int top = stack.Pop(); // 스택의 맨 위 막대 팝
                // 해당 막대로 형성된 면적 계산
                int area = heights[top] * (stack.Count == 0 ? i : i - stack.Peek() - 1);
                maxArea = Math.Max(maxArea, area); // 최대 면적 업데이트
            }
        }
        // 스택에 남은 막대들에 대한 면적 계산
        while (stack.Count > 0) 
        {
            int top = stack.Pop(); // 스택의 맨 위 막대 팝
            // 해당 막대로 형성된 면적 계산
            int area = heights[top] * (stack.Count == 0 ? i : i - stack.Peek() - 1);
            maxArea = Math.Max(maxArea, area); // 최대 면적 업데이트
        }
        return maxArea; // 계산된 최대 면적 반환
    }
}