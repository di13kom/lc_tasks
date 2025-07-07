namespace LeetCode.Problems._6;

public class Solution
{
    public string Convert(string s, int numRows)
    {
        List<char>[] chars = new List<char>[numRows];
        int curListIdx = 0;
        bool IsLeftRightDirection = false;

        if (numRows == 1)
            return s;

        for (int i = 0; i < s.Length; i++)
        {
            if (curListIdx % (numRows - 1) == 0)
            {
                IsLeftRightDirection = !IsLeftRightDirection;
            }
            (chars[curListIdx] ??= []).Add(s[i]);
            curListIdx = IsLeftRightDirection ? curListIdx + 1 : curListIdx - 1;
        }

        return new string(chars.Where(x => x != null && x.Count > 0).SelectMany(x => x).ToArray());
    }
}