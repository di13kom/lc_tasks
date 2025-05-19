using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace LeetCode.Problems.DivideAndConquer._1763;

public class Solution
{
    private struct CharDescription
    {
        public bool IsWithDiffCase = false;
        public int Count = 0;

        public CharDescription()
        {
        }
    };
    private const int AsciiLowUpDiff = 32;

    public string LongestNiceSubstring(string s)
    {
        Dictionary<char, List<int>> dict = [];
        List<string> retVal = [];

        for (int i = 0; i < s.Length; i++)
        {
            if (!dict.TryAdd(s[i], [i]))
            {
                dict[s[i]].Add(i);
            }
        }

        foreach (KeyValuePair<char, List<int>> dictItem in dict)
        {
            char key = (char)(dictItem.Key ^ AsciiLowUpDiff);
            if (dict.ContainsKey(key))
            {
                Console.WriteLine($"Key: '{dictItem.Key}' has counterPart with key: '{key}'");
            }
        }
        //isUpperCaseChar = (s[i] & AsciiLowUpDiff) == 0;


        return retVal.MaxBy(x => x.Length) ?? string.Empty;
    }
}