namespace LeetCode.Problems._3349;

public class Solution
{
    const int emptyArrayStartFlag = int.MinValue;
    public bool HasIncreasingSubarrays(IList<int> nums, int k)
    {
        var length = nums.Count;
        int firstIncArrayStart = 0;
        int secondIncArrayStart = emptyArrayStartFlag;
        for (int i = 1; i < length; i++)
        {
            if (nums[i] <= nums[i - 1])
            {
                if (i - firstIncArrayStart < k)
                {
                    firstIncArrayStart = i;
                    secondIncArrayStart = emptyArrayStartFlag;
                }
                else if (i - secondIncArrayStart >= k || (secondIncArrayStart == emptyArrayStartFlag && (i - firstIncArrayStart - k) >= k))
                {
                    return true;
                }
                else if (secondIncArrayStart == emptyArrayStartFlag)
                {
                    secondIncArrayStart = i;
                }
                else
                {
                    firstIncArrayStart = i;
                    secondIncArrayStart = emptyArrayStartFlag;
                }
            }
        }
        if (secondIncArrayStart == emptyArrayStartFlag && firstIncArrayStart != emptyArrayStartFlag)
            return (length - firstIncArrayStart - k) >= k;
        if (secondIncArrayStart != emptyArrayStartFlag)
            return length - secondIncArrayStart >= k;

        return false;
    }
}