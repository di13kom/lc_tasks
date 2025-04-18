using System;
using System.Text;

namespace LeetCode.Problems._38;

public class Solution
{
    public string CountAndSay(int n)
    {
        return StringRLE("1", n - 1);
    }

    private string StringRLE(string input, int step)
    {
        StringBuilder sBuilder = new StringBuilder();

        if (step == 0)
            return input;

        char prevChar = input[0];
        char curChar = input[0];
        byte repeat = 1;
        for (int i = 1; i < input.Length; i++)
        {
            curChar = input[i];
            if (prevChar == curChar)
            {
                repeat++;
            }
            else
            {
                sBuilder.Append($"{repeat}{prevChar}");
                repeat = 1;
            }
            prevChar = curChar;
        }
        sBuilder.Append($"{repeat}{curChar}");

        return StringRLE(sBuilder.ToString(), step - 1);

    }
}
