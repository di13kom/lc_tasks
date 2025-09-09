namespace LeetCode.Problems._2327;

public class Solution
{
    int[][] dayRecords;
    public int PeopleAwareOfSecret(int n, int delay, int forget)
    {
        dayRecords = new int[n][];
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
        dayRecords[step][0] = IntegerSub(IntegerSum(dayRecords[step - 1][0], dayRecords[step][1]), dayRecords[step][2]);
        if (n == step + 1)
        {
            return dayRecords[step][0];
        }

        int newUsers = dayRecords[step][1];
        for (int i = step + 1; i < n; i++)
        {
            if (i < step + delay)
                dayRecords[i][0] = IntegerSum(dayRecords[i][0], newUsers);
            else if (i >= step + delay && i < step + forget)
                dayRecords[i][1] = IntegerSum(dayRecords[i][1], newUsers);
            else//if (i == step + forget)
            {
                dayRecords[i][2] = IntegerSum(dayRecords[i][2], newUsers);
                break;
            }
        }

        return PeopleAwareOfSecretRecursive(n, delay, forget, step + 1);
    }

    private int IntegerSum(int int0, int int1)
    {
        return (int)((int0 + int1) % (Math.Pow(10, 9) + 7));
    }
    private int IntegerSub(int int0, int int1)
    {
        return (int)((int0 - int1 + Math.Pow(10, 9) + 7) % (Math.Pow(10, 9) + 7));
    }
}