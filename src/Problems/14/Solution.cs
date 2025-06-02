using System;
using System.Text;

namespace LeetCode.Problems._14;

public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        string retVal = strs[0];
        for (int i = 1; i < strs.Length; i++)
        {
            retVal = GetCommonSubstring(retVal, strs[i]);
        }

        return retVal;
    }

    private string GetCommonSubstring(string str1, string str2)
    {
        StringBuilder retVal = new StringBuilder();
        var length = str1.Length > str2.Length ? str2.Length : str1.Length;
        for (int i = 0; i < length; i++)
        {
            if (str1[i] == str2[i])
            {
                retVal.Append(str1[i]);
            }
            else
                return retVal.ToString();
        }

        return retVal.ToString();
    }
}