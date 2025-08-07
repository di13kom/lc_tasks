namespace LeetCode.Problems._2951;

public class Solution
{
    public IList<int> FindPeaks(int[] mountain)
    {
        IList<int> retVal = [];

        for (int i = 1; i < mountain.Length - 1; i++)
        {
            if (mountain[i] > mountain[i - 1] && mountain[i] > mountain[i + 1])
            {
                retVal.Add(i);
            }
        }

        return retVal;
    }
}