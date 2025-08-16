namespace LeetCode.Problems._47;

public class Solution
{
    public IList<IList<int>> PermuteUnique(int[] nums)
    {
        IList<IList<int>> retVal = [];
        HashSet<int> memo = [];

        Array.Sort(nums);

        BackTrack(nums, 0, retVal, memo);
        return retVal;
    }

    private void BackTrack(int[] ints, int idx, IList<IList<int>> retVal, HashSet<int> memo)
    {
        var length = ints.Length;
        if (idx == length - 1)
        {
            if (memo.Add(LstToInteger(ints)))
                retVal.Add(ints.ToList());
            return;
        }

        for (int i = idx; i < length; i++)
        {
            if (i != idx && ints[i] == ints[i - 1])
                continue;
            (ints[i], ints[idx]) = (ints[idx], ints[i]);
            // if (!memo.Add(LstToInteger(ints)))
            BackTrack(ints, idx + 1, retVal, memo);
            (ints[i], ints[idx]) = (ints[idx], ints[i]);
        }
    }

    private int LstToInteger(IEnumerable<int> ints)
    {
        int retVal = 0;
        var length = ints.Count();
        for (int i = 0; i < length; i++)
        {
            retVal += (int)(ints.ElementAt(i) * Math.Pow(10, i));
        }

        return retVal;
    }
}
