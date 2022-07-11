//https://leetcode.com/problems/contains-duplicate/

namespace NeetCode.Solutions.ArraysAndHashing;

public class LC217_ContainsDuplicate
{
    public bool ContainsDuplicate(int[] nums)
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

    public bool FancyContainsDuplicate(int[] nums)
    {
        var numbers = new HashSet<int>(nums);
        return numbers.Count != nums.Length;
    }

    public bool FasterContainsDuplicate(int[] nums)
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
        measurement.Measure("ContainsDuplicate", () => { ContainsDuplicate(nums); });
        measurement.Measure("FasterContainsDuplicate", () => { FasterContainsDuplicate(nums); });
        measurement.Measure("FancyContainsDuplicate", () => { FancyContainsDuplicate(nums); });
    }
}