using System;
using System.Numerics;

namespace LeetCode.Problems._2327;

public class Solution1
{
    BigInteger[][] dayRecords;
    public int PeopleAwareOfSecret(int n, int delay, int forget)
    {
        dayRecords = new BigInteger[n][];
        for (int i = 0; i < n; i++)
        {
            if (i < delay)
            {
                dayRecords[i] = [1, 0, 0];
            }
            else if (i >= delay && i < forget)
            {
                dayRecords[i] = [0, 1, 0];
            }
            else if (i == forget)
            {
                dayRecords[i] = [0, 0, 1];
            }
            else
            {
                dayRecords[i] = [0, 0, 0];
            }
        }

        return PeopleAwareOfSecretRecursive(n, delay, forget, 1);
    }

    private int PeopleAwareOfSecretRecursive(int n, int delay, int forget, int step)
    {
        // dayRecords[step][0] = IntegerSub(IntegerSum(dayRecords[step - 1][0], dayRecords[step][1]), dayRecords[step][2]);
        dayRecords[step][0] = dayRecords[step - 1][0] + dayRecords[step][1] - dayRecords[step][2];
        if (n == step + 1)
        {
            return (int)(dayRecords[step][0] % (BigInteger)(Math.Pow(10, 9) + 7));
        }

        BigInteger newUsers = dayRecords[step][1];
        for (int i = step + 1; i < n; i++)
        {
            if (i < step + delay)
            {
                // dayRecords[i][0] = IntegerSum(dayRecords[i][0], newUsers);
                dayRecords[i][0] = dayRecords[i][0] + newUsers;
            }
            else if (i >= step + delay && i < step + forget)
            {
                // dayRecords[i][1] = IntegerSum(dayRecords[i][1], newUsers);
                dayRecords[i][1] = dayRecords[i][1] + newUsers;
            }
            else//if (i == step + forget)
            {
                dayRecords[i][2] = dayRecords[i][1] + newUsers;
                break;
            }
        }

        return PeopleAwareOfSecretRecursive(n, delay, forget, step + 1);
    }
}
