using NeetCode.Solutions.ArraysAndHashing;

namespace NeetCode.Tests.ArraysAndHashing;

[TestClass]
public class LC347_TopKFrequentElementsTests
{
    [TestMethod]
    public void MultipleNumbers_TwoTopFrequent()
    {
        var nums = new int[] { 1, 1, 1, 2, 2, 3 };
        var k = 2;

        var result = TopKFrequent(nums, k);

        CollectionAssert.AreEquivalent(new int[] { 1, 2 }, result);
    }

    [TestMethod]
    public void OneNumber_OneTopFrequent()
    {
        var nums = new int[] { 1 };
        var k = 1;

        var result = TopKFrequent(nums, k);

        CollectionAssert.AreEquivalent(new int[] { 1 }, result);
    }

    [TestMethod]
    public void TwoNumbers_SameFrequency_TwoTopFrequent()
    {
        var nums = new int[] { 1, 1, 1, 2, 2, 2 };
        var k = 2;

        var result = TopKFrequent(nums, k);

        CollectionAssert.AreEquivalent(new int[] { 1, 2 }, result);
    }

    [TestMethod]
    public void MultipleNumbers_OneTopFrequent()
    {
        var nums = new int[] { 0, 4, 1, 4, 2, 4 };
        var k = 1;

        var result = TopKFrequent(nums, k);

        CollectionAssert.AreEquivalent(new int[] { 4 }, result);
    }

    [TestMethod]
    public void MultipleNumbers_FourTopFrequent()
    {
        var nums = new int[] { 1, 2, 3, 3, 3, 4, 5, 6, 1, 1, 2, 3, 4, 9, 7, 4, 8, 4, 4 };
        var k = 4;

        var result = TopKFrequent(nums, k);

        CollectionAssert.AreEquivalent(new int[] { 1, 2, 3, 4 }, result);
    }

    private int[] TopKFrequent(int[] nums, int k)
    {
        var @object = new LC347_TopKFrequentElements();
        var result = @object.TopKFrequent(nums, k);
        return result;
    }
}