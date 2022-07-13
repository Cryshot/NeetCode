using NeetCode.Solutions.ArraysAndHashing;

namespace NeetCode.Tests.ArraysAndHashing;

[TestClass]
public class LC238_ProductOfArrayExceptSelfTests
{
    [TestMethod]
    public void BasicMultiplication()
    {
        var nums = new int[] { 1, 2, 3, 4 };
        var expected = new int[] { 24, 12, 8, 6 };
        DoTest(nums, expected);
    }

    [TestMethod]
    public void MultiplicationWithZero_OnlyOneProductNotZero()
    {
        var nums = new int[] { -1, 1, 0, -3, 3 };
        var expected = new int[] { 0, 0, 9, 0, 0 };
        DoTest(nums, expected);
    }

    [TestMethod]
    public void MinAmountOfNumbers_Zeroes()
    {
        var nums = new int[] { 0, 0 };
        var expected = new int[] { 0, 0 };
        DoTest(nums, expected);
    }

    [TestMethod]
    public void MultiplicationWithOnes()
    {
        var nums = new int[] { 1, 1, 1 };
        var expected = new int[] { 1, 1, 1 };
        DoTest(nums, expected);
    }

    [TestMethod]
    public void NegativeMultiplication()
    {
        var nums = new int[] { -1, -2, -3, 4 };
        var expected = new int[] { 24, 12, 8, -6 };
        DoTest(nums, expected);
    }

    private void DoTest(int[] nums, int[] expected)
    {
        var result = ProductExceptSelf(nums);
        CollectionAssert.AreEqual(expected, result);
    }

    private int[] ProductExceptSelf(int[] nums)
    {
        var @object = new LC238_ProductOfArrayExceptSelf();
        var result = @object.ProductExceptSelf(nums);
        return result;
    }
}