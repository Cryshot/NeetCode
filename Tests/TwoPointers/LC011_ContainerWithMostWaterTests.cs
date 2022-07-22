using NeetCode.Solutions.TwoPointers;

namespace NeetCode.Tests.TwoPointers;

[TestClass]
public class LC011_ContainerWithMostWaterTests
{
    [TestMethod]
    public void MultipleDifferentHeight_ReturnsFortyNine()
    {
        var height = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };

        var result = MaxArea(height);

        Assert.AreEqual(49, result);
    }

    [TestMethod]
    public void HeightOne_ReturnsOne()
    {
        var height = new int[] { 1, 1 };

        var result = MaxArea(height);

        Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void HeightTwoOne_ReturnsOne()
    {
        var height = new int[] { 2, 1 };

        var result = MaxArea(height);

        Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void HeightTwoZeroTwo_ReturnsFour()
    {
        var height = new int[] { 2, 0, 2 };

        var result = MaxArea(height);

        Assert.AreEqual(4, result);
    }

    [TestMethod]
    public void HeightOneZeroTwo_ReturnsTwo()
    {
        var height = new int[] { 1, 0, 2 };

        var result = MaxArea(height);

        Assert.AreEqual(2, result);
    }

    [TestMethod]
    public void HeightZero_ReturnsZero()
    {
        var height = new int[] { 0, 0 };

        var result = MaxArea(height);

        Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void BigHeightAtEnd_ReturnsFifty()
    {
        var height = new int[] { 1, 0, 1, 0, 1, 50, 50 };

        var result = MaxArea(height);

        Assert.AreEqual(50, result);
    }

    private int MaxArea(int[] height)
    {
        var @object = new LC011_ContainerWithMostWater();
        var result = @object.MaxArea(height);
        return result;
    }
}