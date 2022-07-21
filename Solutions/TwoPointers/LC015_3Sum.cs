namespace NeetCode.Solutions.TwoPointers;

public class LC015_3Sum
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        return ThreeSum_II(nums);
    }

    private static IList<IList<int>> ThreeSum_I(int[] nums)
    {
        var result = new List<IList<int>>();

        for (var i = 0; i < nums.Length - 2; i++)
        {
            for (var j = i + 1; j < nums.Length - 1; j++)
            {
                if (i == j)
                    continue;
                for (var k = j + 1; k < nums.Length; k++)
                {
                    if (k == j)
                        continue;

                    if (nums[i] + nums[j] + nums[k] == 0)
                        result.Add(new List<int> { nums[i], nums[j], nums[k] });
                }
            }
        }


        for (var i = 0; i < result.Count - 1; i++)
        {
            for (var j = i + 1; j < result.Count; j++)
            {
                var dict = new Dictionary<int, int>();
                for (var k = 0; k < result[i].Count; k++)
                {
                    if (!dict.ContainsKey(result[i][k]))
                        dict.Add(result[i][k], 0);
                    dict[result[i][k]]++;

                    if (!dict.ContainsKey(result[j][k]))
                        dict.Add(result[j][k], 0);
                    dict[result[j][k]]--;
                }
                if (dict.Values.Any(x => x != 0))
                    continue;

                result.RemoveAt(j--);
            }
        }

        return result;
    }

    private static IList<IList<int>> ThreeSum_II(int[] nums)
    {
        var sortedNums = new int[nums.Length];
        Array.Copy(nums, sortedNums, nums.Length);
        Array.Sort(sortedNums);

        var result = new List<IList<int>>();

        for (var i = 0; i < sortedNums.Length - 2; i++)
        {
            if (i > 0 && sortedNums[i] == sortedNums[i - 1])
                continue;

            int left = i + 1, right = sortedNums.Length - 1;

            while (left < right)
            {
                var sum = sortedNums[i] + sortedNums[left] + sortedNums[right];
                if (sum == 0)
                    result.Add(new List<int> { sortedNums[i], sortedNums[left++], sortedNums[right--] });
                else if (sum > 0)
                    right--;
                else
                    left++;


                while (left < right && left > i + 1 && sortedNums[left] == sortedNums[left - 1])
                    left++;
                while (right > left && right < sortedNums.Length - 1 && sortedNums[right] == sortedNums[right + 1])
                    right--;
            }
        }

        return result;
    }
}