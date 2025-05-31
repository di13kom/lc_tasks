using System;

namespace LeetCode.Problems._2942;

public class Solution
{
    public IList<int> FindWordsContaining(string[] words, char x)
    {
        IList<int> retVal = [];

        for (int i = 0; i < words.Length; i++)
        {
            foreach (var item in words[i])
            {
                if (item == x)
                {
                    retVal.Add(i);
                    break;
                }
            }
        }


        return retVal;
    }
}