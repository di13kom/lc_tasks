using System.Text;

namespace LeetCode.Problems._1678;

public class Solution
{
    public string Interpret(string command)
    {
        const string gStr = "G";
        const char gChr = 'G';
        Dictionary<string, string> dict = new Dictionary<string, string>
        {
            {gStr,gStr},
            {"()","o"},
            {"(al)","al"},
        };
        const char openBracket = '(';
        const char closeBracket = ')';

        StringBuilder sb = new StringBuilder();

        StringBuilder tmpStr = new StringBuilder();

        for (int i = 0; i < command.Length; i++)
        {
            if (command[i] == openBracket)
            {
                tmpStr.Append(command[i]);
            }
            else if (command[i] == closeBracket)
            {
                tmpStr.Append(command[i]);
                sb.Append(dict[tmpStr.ToString()]);
                tmpStr.Clear();
            }
            else if (command[i] == gChr)
            {
                sb.Append(dict[gStr]);
            }
            else
            {
                tmpStr.Append(command[i]);
            }
        }

        return sb.ToString();
    }
}