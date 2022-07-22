using NeetCode.Solutions.TwoPointers;

namespace NeetCode.Tests.TwoPointers;

[TestClass]
public class LC042_TrappingRainWaterTests
{
    [TestMethod]
    public void Example1()
    {
        var height = new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };

        var result = Trap(height);

        Assert.AreEqual(6, result);
    }

    [TestMethod]
    public void Example2()
    {
        var height = new int[] { 4, 2, 0, 3, 2, 5 };

        var result = Trap(height);

        Assert.AreEqual(9, result);
    }

    [TestMethod]
    public void Example3()
    {
        var height = new int[] { 4, 2, 3, 2 };

        var result = Trap(height);

        Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Example4()
    {
        var height = new int[] { 4, 2, 2, 3 };

        var result = Trap(height);

        Assert.AreEqual(2, result);
    }

    private static int Trap(int[] height)
    {
        var @object = new LC042_TrappingRainWater();
        var result = @object.Trap(height);
        return result;
    }
}