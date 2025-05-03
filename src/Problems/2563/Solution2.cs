namespace LeetCode.Problems._2563;

public class Solution2
{
    public long CountFairPairs(int[] nums, int lower, int upper)
    {
        long retVal = 0;
        if (nums.Length < 1)
            return 0;

        var sortedArray = nums.Order();

        int startIndex = 0;
        int EndIndex = nums.Length - 1;
        while ((sortedArray.ElementAt(startIndex) + sortedArray.ElementAt(EndIndex)) > upper)
        {
            EndIndex--;
            if (EndIndex <= startIndex)
                return 0;
        }
        while ((sortedArray.ElementAt(startIndex) + sortedArray.ElementAt(EndIndex)) < lower)
        {
            startIndex++;
            if (EndIndex <= startIndex)
                return 0;
        }
        if (EndIndex - startIndex < 2)
            return 0;

        long sum = 0;
        int roundTotal = 0;
        int curLowElem;
        int prevElem = int.MaxValue;
        for (int i = startIndex; i <= EndIndex; i++)
        {
            curLowElem = sortedArray.ElementAt(i);
            if (curLowElem == prevElem)
            {
                roundTotal = IntInRange(curLowElem + prevElem, lower, upper) ? roundTotal - 1 : roundTotal;
            }
            else
            {
                roundTotal = 0;
                for (int j = EndIndex; j > i; j--)
                {
                    sum = curLowElem + sortedArray.ElementAt(j);
                    if (IntInRange(sum, lower, upper))
                        roundTotal++;
                    if (sum < lower)
                        break;
                }
            }
            retVal += roundTotal;
            prevElem = curLowElem;
        }
        return retVal;
    }

    private bool IntInRange(long numTarget, int lower, int upper)
    {
        bool retVal = false;
        if (numTarget >= lower && numTarget <= upper)
            retVal = true;

        return retVal;
    }
}