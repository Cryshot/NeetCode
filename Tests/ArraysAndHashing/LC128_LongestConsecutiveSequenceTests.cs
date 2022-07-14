using NeetCode.Solutions.ArraysAndHashing;

namespace NeetCode.Tests.ArraysAndHashing;

[TestClass]
public class LC128_LongestConsecutiveSequenceTests
{
    [TestMethod]
    public void MutlipleNumbers_LongestSequenceFour()
    {
        var nums = new int[] { 100, 4, 200, 1, 3, 2 };
        
        var result = LongestConsecutive(nums);

        Assert.AreEqual(4, result);
    }

    [TestMethod]
    public void MutlipleNumbers_LongestSequenceNine()
    {
        var nums = new int[] { 0, 3, 7, 2, 5, 8, 4, 6, 0, 1 };

        var result = LongestConsecutive(nums);

        Assert.AreEqual(9, result);
    }

    [TestMethod]
    public void EmptyNumbers_LongestSequenceZero()
    {
        var nums = Array.Empty<int>();

        var result = LongestConsecutive(nums);

        Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void OneNumber_LongestSequenceOne()
    {
        var nums = new int[] { 200 };

        var result = LongestConsecutive(nums);

        Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void ThreeSameNumbers_LongestSequenceOne()
    {
        var nums = new int[] { 31, 31, 31 };

        var result = LongestConsecutive(nums);

        Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void NegativeToPositiveNumbers_LongestSequenceSix()
    {
        var nums = new int[] { -5, 0, -3, 2, 1, 0, 1, 1, 1, -1, 0, -3, -2, 4 };

        var result = LongestConsecutive(nums);

        Assert.AreEqual(6, result);
    }

    [TestMethod]
    public void MinMaxInt_LongestSequenceOne()
    {
        var nums = new int[] { int.MinValue, int.MaxValue };

        var result = LongestConsecutive(nums);

        Assert.AreEqual(1, result);
    }

    private static int LongestConsecutive(int[] nums)
    {
        var @object = new LC128_LongestConsecutiveSequence();
        var result = @object.LongestConsecutive(nums);
        return result;
    }
}