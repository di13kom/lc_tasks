using System;

namespace LeetCode.Problems._955;

public class Solution2
{
    private enum RemoveState
    {
        Unknown,
        GreaterNotConfirmed,
        Greater
    }
    public int MinDeletionSize(string[] strs)
    {
        int wordLength = strs[0].Length;
        int arrayLength = strs.Length;
        List<int> removedIdx = [];
        List<RemoveState> CompareResult = [.. Enumerable.Repeat(RemoveState.Unknown, arrayLength)];
        bool isRemoved = false;
        bool isLastColumnRemoved = false;

        for (int i = 0; i < wordLength; i++)
        {
            isRemoved = false;
            for (int j = 1; j < arrayLength; j++)
            {
                if (CompareResult[j] == RemoveState.Greater)
                    continue;
                if (CompareResult[j] == RemoveState.GreaterNotConfirmed)
                {
                    if (isLastColumnRemoved == false)
                    {
                        CompareResult[j] = RemoveState.Greater;
                        continue;
                    }
                }

                if (strs[j][i] < strs[j - 1][i])
                {
                    removedIdx.Add(i);
                    isRemoved = true;
                    break;
                }
                else if (strs[j][i] > strs[j - 1][i])
                {
                    if (CompareResult[j] == RemoveState.Unknown || (CompareResult[j] == RemoveState.GreaterNotConfirmed) && isLastColumnRemoved)
                        CompareResult[j] = RemoveState.GreaterNotConfirmed;
                    else
                        CompareResult[j] = RemoveState.Greater;
                }
            }
            isLastColumnRemoved = isRemoved ? true : false;
        }

        return removedIdx.Count;
    }
}