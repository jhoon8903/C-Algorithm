using System;

public class Solution 
{
    public int solution(int a, int b, int n)
    {
        int exchangeCoke = 0;

        while (n >= a)
        {
            checked
            {
                int exchange = n / a;
                exchangeCoke += exchange * b;
                n = n % a + exchange * b;
            }
        }
        return exchangeCoke;
    }
}