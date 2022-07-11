namespace NeetCode.Solutions.ArraysAndHashing;

public class LC1_TwoSum
{
    public int[] TwoSum(int[] nums, int target)
    {
        return TwoSum_I(nums, target);
    }

    private static int[] TwoSum_I(int[] nums, int target)
    {
        if (nums.Length == 2)
            return new int[] { 0, 1 };

        //O(n^2)
        for (var i = 0; i < nums.Length; i++)
        {
            for (var j = 0; j < nums.Length; j++)
            {
                if (i == j)
                    continue;

                if (nums[i] + nums[j] == target)
                    return new int[] { i, j };
            }
        }

        throw new Exception($"Solution doesn't exist");
    }

    private static int[] TwoSum_II(int[] nums, int target)
    {
        if (nums.Length == 2)
            return new int[] { 0, 1 };

        //O(n)
        var numberToIndex = new Dictionary<int, int>();
        for (var i = 0; i < nums.Length; i++)
        {
            var requiredNumber = target - nums[i];
            if (numberToIndex.ContainsKey(requiredNumber))
                return new int[] { i, numberToIndex[requiredNumber] };
            else if (!numberToIndex.ContainsKey(nums[i]))
                numberToIndex.Add(nums[i], i);
        }

        throw new Exception($"Solution doesn't exist");
    }

    public void DoMeasurement()
    {
        var nums = new int[] { 1, 3, 99, 41, 85, 74, 21, 999, 72, 25, 48, 51, 947, 2, 7, 11, 15 };
        var target = 9;

        var measurement = new Measurement();
        measurement.Measure("TwoSum_I", () => { TwoSum_I(nums, target); });
        measurement.Measure("TwoSum_II", () => { TwoSum_II(nums, target); });
    }
}