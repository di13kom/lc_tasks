namespace LeetCode.Problems.PrefixSum._3147;

public class Solution
{
    public int MaximumEnergy(int[] energy, int k)
    {
        int retVal = int.MinValue;
        int length = energy.Length;
        int[] prefixSum = new int[length];

        for (int i = 0; i < length; i++)
        {
            prefixSum[i] = i < k ? energy[i] : Math.Max(energy[i] + prefixSum[i - k], energy[i]);
        }

        var targetLength = length > k ? length - k : 0;
        for (int i = length - 1; i >= targetLength; i--)
        {
            retVal = Math.Max(retVal, prefixSum[i]);
        }


        return retVal;
    }
}