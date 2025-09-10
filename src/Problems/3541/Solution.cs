namespace LeetCode.Problems._3541;

public class Solution
{
    private Dictionary<char, int> _vowels = new()
    {
        {'a',0},
        {'i',0},
        {'e',0},
        {'o',0},
        {'u',0}
    };
    public int MaxFreqSum(string s)
    {
        int vowelCount = 0;
        int consonantCount = 0;
        Dictionary<char, int> consonants = [];

        for (int i = 0; i < s.Length; i++)
        {
            if (_vowels.ContainsKey(s[i]))
            {
                _vowels[s[i]]++;

                vowelCount = Math.Max(vowelCount, _vowels[s[i]]);
            }
            else
            {
                if (!consonants.TryAdd(s[i], 1))
                {
                    consonants[s[i]]++;
                }

                consonantCount = Math.Max(consonantCount, consonants[s[i]]);
            }
        }


        return vowelCount + consonantCount;
    }
}
