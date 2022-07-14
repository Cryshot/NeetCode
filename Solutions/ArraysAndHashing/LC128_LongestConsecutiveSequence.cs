namespace NeetCode.Solutions.ArraysAndHashing;

public class LC128_LongestConsecutiveSequence
{
    public int LongestConsecutive(int[] nums)
    {
        return LongestConsecutive_I(nums);
    }

    private static int LongestConsecutive_I(int[] nums)
    {
        if (nums.Length == 0 || nums.Length == 1)
            return nums.Length;

        var highToLow = new Dictionary<int, int>();
        var lowToHigh = new Dictionary<int, int>();
        var visited = new HashSet<int>();
        var longest = 0;
        foreach (var number in nums)
        {
            if (!visited.Add(number))
                continue;

            if (!highToLow.Remove(number == int.MinValue ? number : number - 1, out int low))
                low = number;
            if (!lowToHigh.Remove(number == int.MaxValue ? number : number + 1, out int high))
                high = number;

            highToLow[high] = low;
            lowToHigh[low] = high;
            longest = Math.Max(longest, high - low + 1);
        }
        return longest;
    }
}