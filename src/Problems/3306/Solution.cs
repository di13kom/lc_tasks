namespace LeetCode.Problems._3306;
public class Solution
{
    readonly Dictionary<char, int> _vowels;
    readonly int _allVowelInSequenseSum;

    public Solution()
    {
        _vowels = new Dictionary<char, int>{
        { 'a',1 << 0},
        { 'i',1 << 1},
        { 'e',1 << 2},
        { 'o',1 << 3},
        { 'u',1 << 4}
        };

        _allVowelInSequenseSum = _vowels.Aggregate(0, (total, next) =>
                            total |= next.Value
            );

    }

    public long CountOfSubstrings(string word, int k)
    {
        long retVal = 0;
        int sequenceHash = 0;
        uint consonantsSeqCount = 0;
        bool isPreviousVowel = false;
        foreach (char chr in word)
        {
            int vowelKey = 0;
            if (_vowels.TryGetValue(chr, out vowelKey))
            {
                if (!isPreviousVowel)
                    sequenceHash = 0;
                sequenceHash |= vowelKey;
                isPreviousVowel = true;
            }
            else
            {
                if (sequenceHash > 0 && isPreviousVowel)
                {
                    consonantsSeqCount = 0;
                }
                consonantsSeqCount++;
                isPreviousVowel = false;
            }

            if (_allVowelInSequenseSum == sequenceHash && consonantsSeqCount == k)
            {
                retVal++;
                consonantsSeqCount = 0;
                if (!isPreviousVowel)
                    sequenceHash = 0;
            }

        }
        return retVal;
    }
}