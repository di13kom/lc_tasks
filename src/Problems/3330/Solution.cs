namespace LeetCode.Problems._3330;

public class Solution {
    public int PossibleStringCount(string word)
    {
        int retVal = 1;
        for (int i = 1; i < word.Length; i++)
        {
            if (word[i] == word[i - 1])
            {
                retVal++;
            }
        }

        return retVal;
        
    }
}