namespace LeetCode.Problems._20;

public class Solution
{
    public bool IsValid(string s)
    {
        Dictionary<char, char> charsDict = new Dictionary<char, char>
        {
            {'{','}'},
            {'[',']'},
            {'(',')'},
        };
        Stack<char> charsStack = [];


        foreach (var item in s)
        {
            if (charsDict.ContainsKey(item))
            {
                charsStack.Push(item);
            }
            else
            {
                if (charsStack.TryPop(out var result) && item == charsDict[result])
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }

        }
        return charsStack.Count == 0;
    }
}