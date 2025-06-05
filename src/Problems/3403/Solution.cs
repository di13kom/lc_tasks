using System;
using System.Net;

namespace LeetCode.Problems._3403;

public class Solution
{
    public string AnswerString(string word, int numFriends)
    {
        var length = word.Length;
        if (numFriends == 1)
            return word;
        Span<char> retVal = ['a'];
        int step = length - numFriends + 1;//length / numFriends;

        for (int i = 0; i < length; i++)
        {
            var subString = word.AsSpan(i, Math.Min(step, length - i));
            if (IsFirstSubstringGreaterThenSecond(subString, retVal))
                retVal = subString.ToArray();
        }


        return retVal.ToString();

    }

    private bool IsFirstSubstringGreaterThenSecond(ReadOnlySpan<char> firstString, Span<char> secondString)
    {
        if (firstString == secondString)
            return false;
        var diffStringsLength = Math.Min(firstString.Length, secondString.Length);
        for (int i = 0; i < diffStringsLength; i++)
        {
            if (firstString[i] > secondString[i])
                return true;
            else if (firstString[i] < secondString[i])
                return false;
        }
        return firstString.Length > secondString.Length;
    }
}