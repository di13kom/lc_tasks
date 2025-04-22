namespace LeetCode.Problems._13;

public class Solution
{
    readonly Dictionary<char, int> dict = new(){
                                        {'I',1},
                                        {'V',5},
                                        {'X',10},
                                        {'L',50},
                                        {'C',100},
                                        {'D',500},
                                        {'M',1000}
    };
    public int RomanToInt(string s)
    {
        int retVal = 0;
        int curPos = s.Length - 1;
        char curValue;
        while (curPos >= 0)
        {
            curValue = s[curPos];
            if (CanContainPrefix(curValue) && curPos > 0) //it is guaranteed that s is a valid roman numeral in the range [1, 3999]
            {
                var suplChar = s[curPos - 1];
                if (dict[suplChar] < dict[curValue])
                {
                    retVal += dict[curValue] - dict[suplChar];
                    curPos--;//Additional move
                }
                else
                {
                    retVal += dict[curValue];
                }
            }
            else
            {
                retVal += dict[curValue];
            }
            curPos--;
        }


        return retVal;
    }

    private bool CanContainPrefix(char c)
    {
        switch (c)
        {
            case 'V':
            case 'X':
            case 'L':
            case 'C':
            case 'D':
            case 'M':
                return true;
            default:
                return false;
        }
    }
}
