namespace LeetCode.Problems._1390;

public class Solution
{
    private const int MaxNumberDivisor = 4;
    public int SumFourDivisors(int[] nums)
    {
        Dictionary<int, int> dp = [];
        int retVal = 0;
        int length = nums.Length;
        for (int i = 0; i < length; i++)
        {
            if (!dp.TryAdd(nums[i], 0))
            {
                retVal += dp[nums[i]];
                continue;
            }
            int numberDivisors = 2;//1&self
            int sum = 1 + nums[i];
            int vl = (int)Math.Sqrt(nums[i]);
            for (int j = vl; j >= 2; j--)
            {
                if (nums[i] % j == 0)
                {
                    if (j * j == nums[i])
                    {
                        sum += j;
                        numberDivisors++;
                    }
                    else
                    {
                        sum += j;
                        sum += nums[i] / j;
                        numberDivisors += 2;
                    }
                }
                if (numberDivisors > MaxNumberDivisor)
                {
                    dp[nums[i]] = 0;
                    break;
                }
            }
            if (numberDivisors == MaxNumberDivisor)
            {
                dp[nums[i]] = sum;
                retVal += sum;
            }
        }

        return retVal;
    }
}