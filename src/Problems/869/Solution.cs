namespace LeetCode.Problems._869;

public class Solution
{
    public bool ReorderedPowerOf2(int n)
    {
        List<int> lst = [];
        int power = 1;
        while (n > 0)
        {
            double d = n % Math.Pow(10, power);
            var target = (int)(d / Math.Pow(10, power - 1));
            lst.Add(target);
            n -= (int)d;
            power++;
        }
        lst = lst.Order().ToList();


        return BackTrack(lst, 0);
    }

    private bool BackTrack(List<int> ints, int idx)
    {
        var length = ints.Count;
        int n = LstToInteger(ints);
        if (ints.Last() != 0 && n > 0 && (n & (n - 1)) == 0)
            return true;

        for (int i = idx; i < length; i++)
        {
            if (i != idx && ints[i] == ints[i - 1])
                continue;
            (ints[i], ints[idx]) = (ints[idx], ints[i]);
            if (BackTrack(ints, idx + 1))
                return true;
            (ints[i], ints[idx]) = (ints[idx], ints[i]);
        }

        return false;
    }

    private int LstToInteger(IEnumerable<int> ints)
    {
        int retVal = 0;
        var length = ints.Count();
        for (int i = 0; i < length; i++)
        {
            retVal += (int)(ints.ElementAt(i) * Math.Pow(10, i));
        }

        return retVal;
    }
}