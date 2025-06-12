using System;

namespace LeetCode.Problems._2566;

public class Solution
{
    public int MinMaxDifference(int num)
    {
        var strInt = num.ToString();
        int? maxValue = null, minValue = null;

        foreach (var charInt in strInt)
        {
            if (charInt != '9')
            {
                maxValue = Convert.ToInt32(strInt.Replace(charInt, '9'));
                break;
            }
        }
        foreach (var charInt in strInt)
        {
            if (charInt != '0')
            {
                minValue = Convert.ToInt32(strInt.Replace(charInt, '0'));
                break;
            }
        }
        maxValue ??= num;
        minValue ??= num;

        return  maxValue.Value - minValue.Value;
    }
}