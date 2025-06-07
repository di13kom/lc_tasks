using System;

namespace LeetCode.Problems._386;

public class Solution
{
    IList<int> retVal = [];
    int maxValue;
    public IList<int> LexicalOrder(int n)
    {
        maxValue = n;
        retVal.Add(1);

        Traverse(1);

        return retVal;
    }

    private void Traverse(int lastValue)
    {
        int vl;
        if (lastValue >= maxValue)
            return;
        if (lastValue * 10 <= maxValue)
        {
            vl = lastValue * 10;
            retVal.Add(vl);
            Traverse(vl);
        }

        int vl0 = lastValue - lastValue / 10 * 10;
        if (vl0 < 9)
        {
            vl = lastValue + 1;
            retVal.Add(vl);
            Traverse(vl);
        }

    }
}