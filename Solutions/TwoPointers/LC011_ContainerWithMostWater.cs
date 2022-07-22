namespace NeetCode.Solutions.TwoPointers;

public class LC011_ContainerWithMostWater
{
    public int MaxArea(int[] height)
    {
        return MaxArea_III(height);
    }

    private static int MaxArea_I(int[] height)
    {
        var maxArea = int.MinValue;
        for (var i = 0; i < height.Length - 1; i++)
        {
            for (var j = i + 1; j < height.Length; j++)
            {
                var area = (j - i) * Math.Min(height[i], height[j]);
                if (area > maxArea)
                    maxArea = area;
            }
        }

        return maxArea;
    }

    private static int MaxArea_II(int[] height)
    {
        var dict = new SortedDictionary<int, int>();
        for (var i = 0; i < height.Length; i++)
        {
            if (!dict.ContainsKey(height[i]))
                dict.Add(height[i], 0);
            dict[height[i]] = i;
        }

        var maxArea = 0;
        for (var i = 0; i < height.Length; i++)
        {
            if (height[i] == 0)
                continue;

            for (var j = dict.Count - 1; j >= 0; j--)
            {
                var key = dict.Keys.ElementAt(j);
                var minHeight = Math.Min(height[i], key);

                if (minHeight * (height.Length - 1 - i) <= maxArea)
                    break;

                var area = minHeight * Math.Abs(i - dict[key]);
                if (area > maxArea)
                    maxArea = area;
            }
        }

        return maxArea;
    }

    private static int MaxArea_III(int[] height)
    {
        var left = 0;
        var right = height.Length - 1;
        var maxArea = 0;

        while (left < right)
        {
            var minHeight = Math.Min(height[left], height[right]);
            var area = minHeight * (right - left);
            maxArea = Math.Max(maxArea, area);

            if (height[left] > height[right])
                right--;
            else
                left++;
        }

        return maxArea;
    }
}