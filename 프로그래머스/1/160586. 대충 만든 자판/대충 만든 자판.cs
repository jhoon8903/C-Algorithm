using System;
using System.Collections.Generic;

public class KeyPressInfo
{
    public int Key { get; set; }
    public int Press { get; set; }

    public KeyPressInfo(int key, int press)
    {
        Key = key;
        Press = press;
    }
}

public class Solution 
{
    public int[] solution(string[] keymap, string[] target)
    { 
        Dictionary<char, List<KeyPressInfo>> saveToKeymap = new Dictionary<char, List<KeyPressInfo>>();

        for (int i = 0; i < keymap.Length; i++)
        {
            for (int j = 0; j < keymap[i].Length; j++)
            {
                char c = keymap[i][j];
                if (!saveToKeymap.ContainsKey(c))
                {
                    saveToKeymap[c] = new List<KeyPressInfo>();
                }
                saveToKeymap[c].Add(new KeyPressInfo(i + 1, j+ 1));
            }
        }

        int[] result = new int [target.Length];

        for (int i = 0; i < target.Length; i++)
        {
            int presses = 0;
            foreach (char c in target[i])
            {
                if (!saveToKeymap.ContainsKey(c))
                {
                    presses = -1;
                    break;
                }
                int minPress = int.MaxValue;
                foreach (KeyPressInfo keyPressInfo in saveToKeymap[c])
                {
                    minPress = Math.Min(minPress, keyPressInfo.Press);
                }
                presses += minPress;
            }
            result[i] = presses;
        }
        return result;
    }
}