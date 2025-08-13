using System.Diagnostics.Contracts;

namespace LeetCode.Problems._2591;

public class Solution
{
    const int targetAmount = 8;
    const int forbiddenAmount = 4;
    const int negativeScenarioReturnValue = -1;
    public int DistMoney(int money, int children)
    {
        if ((money / children) < 1)
            return -1;

        if (money == targetAmount * children)
            return children;

        return 1 + DistributeMoney(money - targetAmount, children - 1);
    }

    private int DistributeMoney(int money, int children)
    {
        int curSum;
        if ((money / children) < 1)
            return -1;

        if (money == targetAmount * children)
            return children;
        if (children == 1)
        {
            if (money <= 0 || money == forbiddenAmount)
                return negativeScenarioReturnValue;
            else if (money == targetAmount)
                return 1;
            else
                return 0;
        }

        for (int i = 0; i < targetAmount; i++)
        {
            curSum = targetAmount - i;
            if (curSum == forbiddenAmount || curSum < 1)
                continue;

            var res = DistributeMoney(money - curSum, children - 1);
            if (res != negativeScenarioReturnValue)
            {
                if (curSum == targetAmount)
                    return 1 + res;
                else
                    return 0 + res;
            }
        }
        return negativeScenarioReturnValue;
    }
}