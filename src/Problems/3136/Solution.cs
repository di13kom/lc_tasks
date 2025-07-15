namespace LeetCode.Problems._3136;

public class Solution
{
    public bool IsValid(string word)
    {
        bool IsDigitExists = false;
        bool IsUpperCaseLeterExists = false;
        bool IsLowerCaseLeterExists = false;
        bool IsVowelLeterExists = false;
        bool IsConsonatLetterExists = false;
        const int AsciiLowUpDiff = 32;

        List<int> vowels = ['a', 'e', 'i', 'o', 'u'];

        var length = word.Length;
        if (length < 3)
            return false;

        for (int i = 0; i < length; i++)
        {
            if (word[i] >= '0' && word[i] <= '9')
            {
                IsDigitExists = true;
            }
            else if ((word[i] >= 'a' && word[i] <= 'z') || word[i] >= 'A' && word[i] <= 'Z')
            {
                if (word[i] >= 'a')
                    IsLowerCaseLeterExists = true;
                else
                    IsUpperCaseLeterExists = true;

                if (vowels.Contains(word[i] ^ AsciiLowUpDiff) || vowels.Contains(word[i]))
                {
                    IsVowelLeterExists = true;
                }
                else
                {
                    IsConsonatLetterExists = true;
                }
            }
            else
                return false;
        }

        return (IsDigitExists || IsLowerCaseLeterExists || IsUpperCaseLeterExists) && IsVowelLeterExists && IsConsonatLetterExists;
    }
}