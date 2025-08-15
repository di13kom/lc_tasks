namespace LeetCode.Problems._40;

public class Solution
{
    public IList<IList<int>> CombinationSum2(int[] candidates, int target)
    {
        HashSet<string> memo = [];
        IList<IList<int>> retVal = [];

        Array.Sort(candidates);

        for (int i = 0; i < candidates.Length; i++)
        {
            if (i > 0 && candidates[i] == candidates[i - 1])
                continue;
            CombinationSumRecursive(candidates, i, target - candidates[i], retVal, memo, [candidates[i]]);
        }

        return retVal;
    }

    private void CombinationSumRecursive(int[] candidates, int startIdx, int target, IList<IList<int>> ints, HashSet<string> memo, List<int> parent)
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
            parent.Add(candidates[i]);
            var str = string.Concat(parent.Select(x => x.ToString()));
            if (memo.Add(str))
                CombinationSumRecursive(candidates, i, target - candidates[i], ints, memo, parent);
            parent.RemoveAt(parent.Count - 1);
        }
    }
}