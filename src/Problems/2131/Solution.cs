using System;

namespace LeetCode.Problems._2131;

public class Solution
{
    public int LongestPalindrome(string[] words)
    {
        int retVal = 0;
        int maxPalindromeCnt = 0;
        int strLength = words[0].Length;
        Dictionary<string, int> _charPairs = [];

        foreach (var item in words)
        {
            if (!_charPairs.TryAdd(item, 1))
            {
                _charPairs[item]++;
            }

        }
        foreach (var item in _charPairs)
        {
            if (item.Value == -1)
                continue;
            if (item.Key[0] == item.Key[1])
            {
                retVal += item.Value % 2 == 0 ? item.Value * strLength : (item.Value - 1) * strLength;
                maxPalindromeCnt = item.Value % 2 == 1 ? strLength : maxPalindromeCnt;
                continue;
            }
            var reverseKey = new string([item.Key[1], item.Key[0]]);
            int counterPairCnt = 0;
            if (_charPairs.TryGetValue(reverseKey, out int count))
            {
                counterPairCnt = Math.Min(count, item.Value);// * 2 * strLength;

                retVal += counterPairCnt * 2 * strLength;
                _charPairs[reverseKey] = -1;
            }

            //reset counter
            _charPairs[item.Key] = -1;

        }

        return retVal + maxPalindromeCnt;
    }
}