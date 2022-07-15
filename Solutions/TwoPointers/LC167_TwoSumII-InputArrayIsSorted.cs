namespace NeetCode.Solutions.TwoPointers;

public class LC167_TwoSumII_InputArrayIsSorted
{
    public int[] TwoSum(int[] numbers, int target)
    {
        return TwoSum_II(numbers, target);
    }

    private static int[] TwoSum_I(int[] numbers, int target)
    {
        for (var i = 0; i < numbers.Length; i++)
        {
            var result = target - numbers[i];
            var resultIndex = IntervalHalvingSearch(numbers, i + 1, numbers.Length - 1, result);

            if (resultIndex != -1)
                return new int[] { i + 1, resultIndex + 1 };
        }

        throw new Exception($"Solution doesn't exist");
    }

    private static int IntervalHalvingSearch(int[] numbers, int start, int end, int result)
    {
        var half = start + (end - start) / 2;
        if (numbers[half] == result)
            return half;

        if (start == end || start + 1 == end)
            return (numbers[end] == result) ? end : -1;

        if (numbers[half] > result)
            return IntervalHalvingSearch(numbers, start, half, result);
        else
            return IntervalHalvingSearch(numbers, half, end, result);
    }

    private static int[] TwoSum_II(int[] numbers, int target)
    {
        var left = 0;
        var right = numbers.Length - 1;

        while (left < right)
        {
            var sum = numbers[left] + numbers[right];
            if (sum == target)
                return new int[] { left + 1, right + 1 };

            if (sum < target)
                left++;
            else if (sum > target)
                right--;
        }

        throw new Exception($"Solution doesn't exist");
    }
}
