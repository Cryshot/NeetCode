using NeetCode.Solutions.ArraysAndHashing;

namespace NeetCode.Tests.ArraysAndHashing;

[TestClass]
public class LC1_TwoSumTests
{
    [TestMethod]
    public void TwoSum_Test1()
    {
        var nums = new int[] { 2, 7, 11, 15 };
        var target = 9;

        var result = TwoSum(nums, target);

        CollectionAssert.AreEqual(new int[] { 0, 1 }, result);
    }

    [TestMethod]
    public void TwoSum_Test2()
    {
        var nums = new int[] { 3, 2, 4 };
        var target = 6;

        var result = TwoSum(nums, target);

        CollectionAssert.AreEqual(new int[] { 1, 2 }, result);
    }

    [TestMethod]
    public void TwoSum_Test3()
    {
        var nums = new int[] { 3, 3 };
        var target = 6;

        var result = TwoSum(nums, target);

        CollectionAssert.AreEqual(new int[] { 0, 1 }, result);
    }

    [TestMethod]
    public void TwoSum_Test4()
    {
        var nums = new int[] { 2, 7, 11, 15, 3, 8, 9, 3 };
        var target = 6;

        var result = TwoSum(nums, target);

        CollectionAssert.AreEqual(new int[] { 4, 7 }, result);
    }

    private int[] TwoSum(int[] nums, int target)
    {
        var @object = new LC1_TwoSum();
        var result = @object
            .TwoSum(nums, target)
            .OrderBy(x => x)
            .ToArray();
        return result;
    }
}