using System;

namespace LeetCode.Problems._1432;

public class Solution
{
    public int MaxDiff(int num)
    {
        int maxValue = int.MinValue;
        int minValue = int.MaxValue;
        string strInt = num.ToString();

        for (int i = 0; i < strInt.Length; i++)
        {
            var newMaxValue = int.Parse(strInt.Replace(strInt[i], '9'));
            var newMinValue = int.Parse(strInt.Replace(strInt[i], i == 0 || strInt[0] == strInt[i] ? '1' : '0'));
            if (newMinValue == 0)
                newMinValue = int.Parse(strInt.Replace(strInt[i], '1'));

            maxValue = Math.Max(maxValue, newMaxValue);
            minValue = Math.Min(minValue, newMinValue);
        }

        return maxValue - minValue;

    }
}