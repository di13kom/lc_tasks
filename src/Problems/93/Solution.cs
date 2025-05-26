using System.Text;

namespace LeetCode.Problems._93;

public class Solution
{
    const char dotChar = '.';
    const int maxOctetSize = 3;
    public IList<string> RestoreIpAddresses(string s)
    {
        IList<string> retVal = [];
        StringBuilder sb = new StringBuilder(s);

        if (s.Length < 4 || s.Length > 12)
            return [];

        for (int i = 1; i <= maxOctetSize; i++)
        {
            if (sb.Length - i > maxOctetSize * 3)
                continue;
            sb.Insert(i, dotChar);
            for (int j = i + 2; j <= i + 2 + maxOctetSize; j++)
            {
                if (j >= sb.Length)
                    continue;
                sb.Insert(j, dotChar);
                for (int k = sb.Length - 1; k > sb.Length - 1 - maxOctetSize; k--)
                {
                    if (k <= j + 1)
                        continue;
                    sb.Insert(k, dotChar);
                    if (IsValidIpAddress(sb.ToString()))
                        retVal.Add(sb.ToString());
                    sb.Remove(k, 1);
                }
                sb.Remove(j, 1);
            }
            sb.Remove(i, 1);
        }


        return retVal;
    }

    bool IsValidIpAddress(string sb)
    {
        Console.WriteLine(sb);
        var subs = sb.Split(dotChar);
        if (subs.Length < 4)
            return false;
        foreach (var subString in subs)
        {
            if (subString.StartsWith('0') && subString.Length > 1)
                return false;
            if (subString.Length > maxOctetSize)
                return false;
            if (!byte.TryParse(subString, out byte result))
                return false;
        }

        return true;
    }
}