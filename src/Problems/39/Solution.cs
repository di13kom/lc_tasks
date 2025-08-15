namespace LeetCode.Problems._39;

public class Solution
{
    public IList<IList<int>> CombinationSum(int[] candidates, int target)
    {
        IList<IList<int>> retVal = [];

        Array.Sort(candidates);

        for (int i = 0; i < candidates.Length; i++)
        {
            CombinationSumRecursive(candidates[i..], target, retVal, []);
        }

        return retVal;
    }

    private void CombinationSumRecursive(int[] candidates, int target, IList<IList<int>> ints, int[] parent)
    {
        int multiplier = 1;
        int multipliedValue = candidates[0] * multiplier;
        int parentSum = parent.Sum();
        while (parentSum + multipliedValue <= target)
        {
            if (parentSum + multipliedValue == target)
            {
                ints.Add(Enumerable.Concat(parent, Enumerable.Repeat(candidates[0], multiplier)).ToList());
                break;
            }

            for (int i = 1; i < candidates.Length; i++)
            {
                if (parentSum + multipliedValue + candidates[i] > target)
                    break;
                CombinationSumRecursive(candidates[i..], target, ints, Enumerable.Concat(parent, Enumerable.Repeat(candidates[0], multiplier)).ToArray());
            }

            multipliedValue = candidates[0] * ++multiplier;
        }
    }
}