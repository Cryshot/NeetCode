namespace NeetCode.Solutions.TwoPointers;

public class LC042_TrappingRainWater
{
    public int Trap(int[] height)
    {
        return Trap_I(height);
    }

    private static int Trap_I(int[] height)
    {
        var waterSum = 0;

        var left = 0;
        var right = height.Length - 1;

        var leftMax = 0;
        var rightMax = 0;

        while (left < right)
        {
            if (height[left] < height[right])
            {
                if (leftMax < height[left])
                    leftMax = height[left];
                else
                    waterSum += leftMax - height[left];
                left++;
            }
            else
            {
                if (rightMax < height[right])
                    rightMax = height[right];
                else
                    waterSum += rightMax - height[right];
                right--;
            }
        }

        return waterSum;
    }
}
