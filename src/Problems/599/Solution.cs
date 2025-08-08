namespace LeetCode.Problems._599;

public class Solution
{
    public string[] FindRestaurant(string[] list1, string[] list2)
    {
        var lst1Len = list1.Length;
        var lst2Len = list2.Length;
        var length = lst1Len > lst2Len ? lst1Len : lst2Len;
        int minIdxValue = int.MaxValue;
        List<string> retVal = [];

        Dictionary<string, int> dict = [];

        for (int i = 0; i < length; i++)
        {
            if (lst1Len > i && !dict.TryAdd(list1[i], i))
            {
                if (minIdxValue >= (i + dict[list1[i]]))
                {
                    if (minIdxValue > (i + dict[list1[i]]))
                        retVal.Clear();
                    retVal.Add(list1[i]);
                    minIdxValue = i + dict[list1[i]];
                }
            }
            if (lst2Len > i && !dict.TryAdd(list2[i], i))
            {
                if (minIdxValue >= (i + dict[list2[i]]))
                {
                    if (minIdxValue > (i + dict[list2[i]]))
                        retVal.Clear();
                    retVal.Add(list2[i]);
                    minIdxValue = i + dict[list2[i]];
                }
            }
        }

        return retVal.ToArray();
    }

}