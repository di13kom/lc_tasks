namespace LeetCode.Problems._955;

public class Solution
{
    private enum RemoveState
    {
        Unknown,
        GreaterNotConfirmed,
        Equals,
        Greater
    }

    public int MinDeletionSize(string[] strs)
    {
        int retVal = 0;
        int wordLength = strs[0].Length;
        int arrayLength = strs.Length;
        List<RemoveState> CompareResult = [.. Enumerable.Repeat(RemoveState.Unknown, arrayLength)];
        int[] removedIdx = new int[wordLength];

        for (int i = 0; i < wordLength; i++)
        {
            bool HasEqualsIdx = false;
            for (int j = 1; j < arrayLength; j++)
            {
                if (CompareResult[j] == RemoveState.Greater)
                    continue;

                if (strs[j][i] < strs[j - 1][i])
                {
                    removedIdx[i] = 1;
                    retVal++;
                    break;
                }
                else if (strs[j][i] > strs[j - 1][i])
                {
                    if (CompareResult[j] == RemoveState.Unknown
                        || ((CompareResult[j] == RemoveState.GreaterNotConfirmed) && removedIdx[i - 1] == 1)
                        || CompareResult[j] == RemoveState.Equals)
                    {
                        CompareResult[j] = RemoveState.GreaterNotConfirmed;
                    }
                    else
                        CompareResult[j] = RemoveState.Greater;
                }
                else if (strs[j][i] == strs[j - 1][i])
                {
                    CompareResult[j] = RemoveState.Equals;
                    HasEqualsIdx = true;
                }
            }
            if (removedIdx[i] == 0 && !HasEqualsIdx)
                break;
            else if (removedIdx[i] == 0)
            {
                for (int i1 = 0; i1 < CompareResult.Count; i1++)
                {
                    if (CompareResult[i1] == RemoveState.GreaterNotConfirmed)
                        CompareResult[i1] = RemoveState.Greater;
                }
            }
        }

        return retVal;
    }
}