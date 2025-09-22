namespace LeetCode.Problems._11;

public class Solution
{
    public int MaxArea(int[] height)
    {
        int leftPointer = 0;
        int rightPointer = height.Length - 1;
        int retVal = (rightPointer - leftPointer) * Math.Min(height[leftPointer], height[rightPointer]);
        while (leftPointer != rightPointer)
        {
            if (height[leftPointer] > height[rightPointer])
                rightPointer--;
            else
                leftPointer++;
            retVal = Math.Max(retVal, (rightPointer - leftPointer) * Math.Min(height[leftPointer], height[rightPointer]));
        }
        return retVal;
    }
}