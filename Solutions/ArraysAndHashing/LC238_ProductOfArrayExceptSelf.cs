namespace NeetCode.Solutions.ArraysAndHashing;

public class LC238_ProductOfArrayExceptSelf
{
    public int[] ProductExceptSelf(int[] nums)
    {
        return ProductExceptSelf_III(nums);
    }

    private static int[] ProductExceptSelf_I(int[] nums)
    {
        var result = Enumerable.Repeat(1, nums.Length).ToArray();

        for (var i = 0; i < nums.Length; i++)
        {
            for (var j = 0; j < nums.Length; j++)
            {
                if (i != j)
                    result[j] *= nums[i];
            }
        }

        return result;
    }

    private static int[] ProductExceptSelf_II(int[] nums)
    {
        var numsFrequency = new Dictionary<int, int>();
        for (var i = 0; i < nums.Length; i++)
        {
            if (!numsFrequency.ContainsKey(nums[i]))
                numsFrequency.Add(nums[i], 0);
            numsFrequency[nums[i]]++;
        }

        var result = new int[nums.Length];
        for (var i = 0; i < nums.Length; i++)
        {
            var product = 1;
            foreach (var pair in numsFrequency)
            {
                if (pair.Key == 0 && (nums[i] != 0 || pair.Value > 1))
                {
                    product = 0;
                    break;
                }

                var numberFrequency = pair.Value;
                if (nums[i] == pair.Key)
                    numberFrequency--;

                if (numberFrequency > 0)
                    product *= (int)Math.Pow(pair.Key, numberFrequency);
            }

            result[i] = product;
        }

        return result;
    }

    private static int[] ProductExceptSelf_III(int[] nums)
    {
        var result = new int[nums.Length];

        var prefix = 1;
        var suffix = 1;
        for (int i = 0, j = nums.Length - 1; i < nums.Length; i++, j--)
        {
            if (i <= j)
                result[i] = result[j] = 1;

            result[i] *= prefix;
            result[j] *= suffix;

            prefix *= nums[i];
            suffix *= nums[j];
        }

        return result;
    }
}