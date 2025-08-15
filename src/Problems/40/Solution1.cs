namespace LeetCode.Problems._40;

public class Solution1
{
    public IList<IList<int>> CombinationSum2(int[] candidates, int target)
    {
        IList<IList<int>> retVal = [];

        Array.Sort(candidates);

        for (int i = 0; i < candidates.Length; i++)
        {
            if (i > 0 && candidates[i] == candidates[i - 1])
                continue;
            CombinationSumRecursive(candidates, i, target - candidates[i], retVal, [candidates[i]]);
        }

        return retVal;
    }

    private void CombinationSumRecursive(int[] candidates, int startIdx, int target, IList<IList<int>> ints, List<int> parent)
    {
        if (target == 0)
        {
            ints.Add(parent.ToList());
            return;
        }
        if (target < 0)
        {
            return;
        }

        for (int i = startIdx + 1; i < candidates.Length; i++)
        {
            if (i > startIdx + 1 && candidates[i] == candidates[i - 1])
                continue;
            parent.Add(candidates[i]);
            CombinationSumRecursive(candidates, i, target - candidates[i], ints, parent);
            parent.RemoveAt(parent.Count - 1);
        }
    }
}