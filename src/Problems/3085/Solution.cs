namespace LeetCode.Problems._3085;

public class Solution
{
    public int MinimumDeletions(string word, int k)
    {
        int retVal = int.MaxValue;
        int removesByChar;
        Dictionary<char, int> dict = [];
        foreach (var chr in word)
        {
            if (!dict.TryAdd(chr, 1))
            {
                dict[chr]++;
            }
        }

        var min = dict.Values.Max();
        var max = dict.Values.Min();

        if (Math.Abs(max - min) <= k)
            return 0;

        foreach (var currentValue in dict)
        {
            removesByChar = 0;
            foreach (var subItem in dict)
            {
                if (currentValue.Key == subItem.Key)
                    continue;
                var diff = Math.Abs(currentValue.Value - subItem.Value);
                if (currentValue.Value > subItem.Value)
                    removesByChar += subItem.Value;
                else
                    removesByChar += diff <= k ? 0 : (diff - k <= subItem.Value ? diff - k : subItem.Value);
            }
            retVal = Math.Min(removesByChar, retVal);
        }

        return retVal;
    }
}