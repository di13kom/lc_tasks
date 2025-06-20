namespace LeetCode.Problems._3085;

public class Solution1
{
    public int MinimumDeletions(string word, int k)
    {
        int retVal = int.MaxValue;
        int removesByChar;
        int[] dict = new int['z' - 'a' + 1];
        int prevCount;
        int lastSubstract;
        foreach (var chr in word)
        {
            dict[chr - 'a']++;
        }
        Array.Sort(dict);

        for (int i = 0; i < dict.Length; i++)
        {
            if (dict[i] == 0)
                continue;
            int currentValue = dict[i];
            removesByChar = 0;
            prevCount = currentValue;
            lastSubstract = 0;
            for (int i1 = 0; i1 < dict.Length; i1++)
            {
                int subItem = dict[i1];
                if (subItem == 0)
                    continue;
                if (subItem == prevCount)
                {
                    removesByChar += lastSubstract;
                    continue;
                }

                prevCount = subItem;
                var diff = Math.Abs(currentValue - subItem);
                if (currentValue > subItem)
                    lastSubstract = subItem;
                else
                    lastSubstract = diff <= k ? 0 : (diff - k <= subItem ? diff - k : subItem);

                removesByChar += lastSubstract;
            }
            retVal = Math.Min(removesByChar, retVal);
        }

        return retVal;
    }
}