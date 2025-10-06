namespace LeetCode.Problems._1015;

public class Solution
{
    public int SmallestRepunitDivByK(int k)
    {
        int OneReminder = 1;
        int i = 2;
        if (k == 1)
            return 1;
        if (k % 2 == 0 || k % 5 == 0)
            return -1;
        while (true)
        {
            if ((OneReminder * 10 + 1) % k == 0)
            {
                return i;
            }
            else if (i > 1 && (OneReminder * 10 + 1) % k == OneReminder)
            {
                return -1;
            }
            OneReminder = (OneReminder * 10 + 1) % k;
            i++;
        }
    }
}