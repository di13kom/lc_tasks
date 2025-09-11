namespace LeetCode.Problems._1935;

public class Solution
{
    public int CanBeTypedWords(string text, string brokenLetters)
    {
        HashSet<char> brokenKeys = [.. brokenLetters];
        bool isAccepteableWord;
        int retVal = 0;

        foreach (var item in text.Split(' '))
        {
            isAccepteableWord = true;
            for (int i = 0; i < item.Length; i++)
            {
                if (brokenKeys.Contains(item[i]))
                {
                    isAccepteableWord = false;
                    break;
                }
            }
            if (isAccepteableWord)
                retVal++;
        }
        return retVal;
    }
}