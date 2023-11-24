namespace Algorithm_Csharp;

public static class MainApp
{
    public static void Main()
    {
        int[] score = { 1,2,3,1,2,3,1 };
        int k = 3;
        int m = 4;
        AppleBox.Instance.solution(k, m, score);
    }
}