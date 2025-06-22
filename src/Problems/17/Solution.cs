namespace LeetCode.Problems._17;

public class Solution
{
    Dictionary<char, List<char>> dict = new Dictionary<char, List<char>>
        {
            {'2',['a','b','c'] },
            {'3',['d','e','f'] },
            {'4',['g','h','i'] },
            {'5',['j','k','l'] },
            {'6',['m','n','o'] },
            {'7',['p','q','r','s'] },
            {'8',['t','u','v'] },
            {'9',['w','x','y','z'] },
        };
    public IList<string> LetterCombinations(string digits)
    {
        IList<string> retVal = [];

        if (digits.Length == 0)
            return [];


        for (int i = 0; i < dict[digits[0]].Count; i++)
        {
            if (digits.Length > 1)
            {
                for (int j = 0; j < dict[digits[1]].Count; j++)
                {
                    if (digits.Length > 2)
                    {

                        for (int k = 0; k < dict[digits[2]].Count; k++)
                        {
                            if (digits.Length > 3)
                            {
                                for (int h = 0; h < dict[digits[3]].Count; h++)
                                {
                                    retVal.Add(new string(
                                    [
                                        dict[digits[0]].ElementAt(i),
                                        dict[digits[1]].ElementAt(j),
                                        dict[digits[2]].ElementAt(k),
                                        dict[digits[3]].ElementAt(h)
                                    ]));
                                }
                            }
                            else
                            {
                                retVal.Add(new string(
                                [
                                    dict[digits[0]].ElementAt(i),
                                    dict[digits[1]].ElementAt(j),
                                    dict[digits[2]].ElementAt(k)
                                ]));
                            }
                        }
                    }
                    else
                    {
                        retVal.Add(new string(
                        [
                            dict[digits[0]].ElementAt(i),
                            dict[digits[1]].ElementAt(j)
                        ]));
                    }
                }
            }
            else
            {
                retVal.Add(new string([dict[digits[0]].ElementAt(i)]));
            }
        }

        return retVal;
    }
}