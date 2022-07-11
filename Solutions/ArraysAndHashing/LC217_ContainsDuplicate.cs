//https://leetcode.com/problems/contains-duplicate/

namespace NeetCode.Solutions.ArraysAndHashing;

public class LC217_ContainsDuplicate
{
    public bool ContainsDuplicate(int[] nums)
    {
        return ContainsDuplicate_I(nums);
    }

    private static bool ContainsDuplicate_I(int[] nums)
    {
        var processedNumbers = new HashSet<int>();
        foreach (var number in nums)
        {
            if (processedNumbers.Contains(number))
                return true;
            processedNumbers.Add(number);
        }
        return false;
    }

    private static bool ContainsDuplicate_II(int[] nums)
    {
        var numbers = new HashSet<int>(nums);
        return numbers.Count != nums.Length;
    }

    private static bool ContainsDuplicate_III(int[] nums)
    {
        var processedNumbers = new HashSet<int>();
        for (var i = 0; i < nums.Length; i++)
        {
            var num = nums[i];
            if (processedNumbers.Contains(num))
                return true;
            processedNumbers.Add(num);
        }
        return false;
    }

    public void DoMeasurement()
    {
        var nums = new[] { 1, 2, 3, 4 };
        var measurement = new Measurement();
        measurement.Measure("ContainsDuplicate_I", () => { ContainsDuplicate_I(nums); });
        measurement.Measure("ContainsDuplicate_II", () => { ContainsDuplicate_II(nums); });
        measurement.Measure("ContainsDuplicate_III", () => { ContainsDuplicate_III(nums); });
    }
}