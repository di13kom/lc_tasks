
namespace LeetCode.Problems._2529;

public class Solution
{
    struct PositiveNegativeCount
    {
        public PositiveNegativeCount(int positive, int negative)
        {
            PositiveValuesCount = positive;
            NegativeValuesCount = negative;
        }
        public int PositiveValuesCount;
        public int NegativeValuesCount;
    };
    private enum Direction
    {
        Right = 0,
        Left = 1
    }
    public int MaximumCount(int[] nums)
    {
        PositiveNegativeCount positiveNegativeValues = FindMaxiumInArray(nums);

        return Math.Max(positiveNegativeValues.PositiveValuesCount, positiveNegativeValues.NegativeValuesCount);
    }

    private PositiveNegativeCount FindMaxiumInArray(int[] nums)
    {
        int cnt = nums.Length;
        int startIndx = 0;
        int endIndx = cnt - 1;

        PositiveNegativeCount positiveNegativeValues = CheckArray(nums, cnt, startIndx, endIndx);

        if (positiveNegativeValues.NegativeValuesCount == -1 && positiveNegativeValues.PositiveValuesCount == -1)
        {
            int mdlIndex = FindMiddleIndex(cnt);
            PositiveNegativeCount curValue;
            curValue = FindMaxiumInArray(nums[..mdlIndex]);
            positiveNegativeValues.PositiveValuesCount = curValue.PositiveValuesCount;
            positiveNegativeValues.NegativeValuesCount = curValue.NegativeValuesCount;
            curValue = FindMaxiumInArray(nums[mdlIndex..]);
            positiveNegativeValues.PositiveValuesCount += curValue.PositiveValuesCount;
            positiveNegativeValues.NegativeValuesCount += curValue.NegativeValuesCount;

        }

        return positiveNegativeValues;
    }

    private PositiveNegativeCount CheckArray(int[] nums, int cnt, int startIndx, int endIndx)
    {
        CheckMinMaxVal(nums, startIndx, endIndx, out int minValue, out int maxValue);
        if (minValue > 0 && maxValue > 0)
            return new PositiveNegativeCount(cnt, 0);
        if (minValue < 0 && maxValue < 0)
            return new PositiveNegativeCount(0, cnt);
        if (minValue == 0 && maxValue == 0)
            return new PositiveNegativeCount(0, 0);
        if (minValue < 0 && maxValue == 0)
            return new PositiveNegativeCount(0, cnt - StripZeros(nums, startIndx, endIndx, Direction.Left));
        if (minValue == 0 && maxValue > 0)
            return new PositiveNegativeCount(cnt - StripZeros(nums, startIndx, endIndx, Direction.Right), 0);
        return new PositiveNegativeCount(-1, -1);
    }

    private int StripZeros(int[] nums, int startIndx, int endIndx, Direction directionType)
    {
        int retVal = 0;
        int directionIncrement = directionType == Direction.Left ? -1 : 1;
        int curIndex = directionType == Direction.Left ? endIndx : startIndx;

        while (nums.ElementAt(curIndex) == 0)
        {
            retVal++;
            curIndex += directionIncrement;
        }

        return retVal;
    }

    private void CheckMinMaxVal(int[] nums,
                                int startIndx,
                                int endIndx,
                                out int minValue,
                                out int maxValue)
    {
        minValue = nums[startIndx];
        maxValue = nums[endIndx];
    }

    private int FindMiddleIndex(int cnt) => cnt / 2;


    public int MaximumCount2(int[] nums)
    {
        int positiveInts = nums.Length - LowerBound(nums, 1);
        int negativeInts = LowerBound(nums, 0);

        return Math.Max(positiveInts, negativeInts);
    }
    public int LowerBound(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length;

        while (left < right)
        {
            int mid = (left + right) / 2;
            if (nums[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid;
            }
        }
        return left;
    }
}
