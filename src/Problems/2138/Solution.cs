using System;

namespace LeetCode.Problems._2138;

public class Solution
{
    public string[] DivideString(string s, int k, char fill)
    {
        var length = s.Length;
        List<string> retVal = [];
        int i;
        int remain = length % k;
        for (i = 0; i < length / k; i++)
        {
            retVal.Add(new string(s.Skip(i * k).Take(k).ToArray()));
        }
        if (remain > 0)
        {
            retVal.Add(string.Concat(new string(s.Skip(i * k).Take(remain).ToArray()), new string(Enumerable.Repeat(fill, k - remain).ToArray())));
        }


        return retVal.ToArray();
    }
}