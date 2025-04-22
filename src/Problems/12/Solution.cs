using System.Runtime.CompilerServices;
using System.Text;

namespace LeetCode.Problems._12;

public class Solution
{
    readonly Dictionary<int, char> dict = new(){
                                                {1,'I'},
                                                {5,'V'},
                                                {10,'X'},
                                                {50,'L'},
                                                {100,'C'},
                                                {500,'D'},
                                                {1000,'M'},
    };
    public string IntToRoman(int num)
    {
        StringBuilder sb = new StringBuilder();

        byte currentPower = 1;
        double minPowerValue;
        double maxPowerValue;


        while (num > 0)
        {
            minPowerValue = Math.Pow(10, currentPower - 1);
            maxPowerValue = Math.Pow(10, currentPower);
            double curVal = num % maxPowerValue;
            var cuStr = sb.ToString();
            sb.Clear();
            sb.AppendJoin(string.Empty, TryIterateDigit(curVal, minPowerValue, maxPowerValue), cuStr);

            num -= (int)curVal;

            currentPower++;
        }

        return sb.ToString();
    }

    private string TryIterateDigit(double curVal, double minPowerValue, double MaxPowerValue)
    {
        string retVal = string.Empty;
        char charValue;
        if (curVal == 4 * minPowerValue)
        {
            _ = dict.TryGetValue((int)minPowerValue, out charValue);
            retVal += charValue;
            _ = dict.TryGetValue((int)(5 * minPowerValue), out charValue);
            retVal += charValue;
            curVal -= 4 * minPowerValue;
        }
        if (curVal == 9 * minPowerValue)
        {
            _ = dict.TryGetValue((int)minPowerValue, out charValue);
            retVal += charValue;
            _ = dict.TryGetValue((int)MaxPowerValue, out charValue);
            retVal += charValue;
            curVal -= MaxPowerValue - minPowerValue;
        }
        if (curVal >= 5 * minPowerValue)
        {
            _ = dict.TryGetValue((int)(5 * minPowerValue), out charValue);
            retVal += charValue;
            curVal -= 5 * minPowerValue;
        }

        while (curVal > 0)
        {
            _ = dict.TryGetValue((int)minPowerValue, out charValue);
            retVal += charValue;
            curVal -= minPowerValue;
        }

        return retVal;

    }
}
