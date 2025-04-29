namespace LeetCode.Problems._416;

public class Solution
{
    public bool CanPartition(int[] nums)
    {
        HashSet<int> sumHash = [0];

        if (nums.Length == 1)
            return false;
        if (nums.Sum() % 2 == 1)
            return false;

        var leftPart = nums.Order().ToList();
        List<int> rightPart = [];
        int nextIndexToPop = leftPart.Count - 1;

        rightPart.Add(leftPart.ElementAt(nextIndexToPop));
        leftPart.RemoveAt(nextIndexToPop);

        var leftPartSum = leftPart.Sum();
        var rightPartSum = rightPart.Sum();

        if (rightPartSum > leftPartSum || (leftPartSum - rightPartSum) % 2 == 1)
            return false;

        if (rightPartSum == leftPartSum)
            return true;

        var targetValue = (leftPartSum - rightPartSum) / 2;

        if (leftPart.Contains(targetValue))
            return true;

        var elemsToIterate = leftPart.Where(x => x <= targetValue);

        //var elmesList = new List<List<int?>> { null };

        int iterCount = 0;
        foreach (int elem in elemsToIterate)
        {
            List<int> newList = [];
            foreach (var uniqSum in sumHash)
            {
                iterCount++;
                //Console.Write(uniqSum);
                if (elem + uniqSum == targetValue)
                    return true;

                newList.Add(elem + uniqSum);
                //elmesList.Add(elem);
            }
            sumHash.UnionWith(newList);

        }
        Console.WriteLine($"uniqSum.count: {sumHash.Count()}");
        Console.WriteLine($"iteration: {iterCount}");
        //PrintListList(elmesList);

        return false;

    }

    private void PrintEnumerable(IEnumerable<int?> ints)
    {
        foreach (var item in ints)
        {
            Console.Write(item);
        }
        Console.WriteLine("");

    }

    public bool CanPartition2(int[] nums)
    {
        int arrLength = nums.Length;
        IOrderedEnumerable<int> newArray = nums.Order();
        int middle = arrLength / 2;
        int[] visitedMiddleIndex = new int[arrLength];

        int leftSum = 0;
        int rightSum = 0;

        if (arrLength == 1)
            return false;

        while (middle > 0 && middle < arrLength)
        {
            if (visitedMiddleIndex[middle] == 1)
                return false;
            visitedMiddleIndex[middle] = 1;
            leftSum = newArray.Take(middle).Aggregate(0, (x, y) => x + y);
            rightSum = newArray.Skip(middle).Aggregate(0, (x, y) => x + y);
            if (leftSum == rightSum)
                return true;
            if (leftSum > rightSum)
            {
                middle--;
            }
            else
            {
                middle++;
            }
        }

        return false;
    }

    private void PrintListList(List<List<int?>> IncludeArray)
    {
        foreach (var item in IncludeArray)
        {
            foreach (var subItem in item)
            {
                Console.Write(subItem);
                Console.Write("|");
            }
            Console.WriteLine();
        }

    }
}
