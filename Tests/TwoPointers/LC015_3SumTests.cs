using NeetCode.Solutions.TwoPointers;

namespace NeetCode.Tests.TwoPointers;

[TestClass]
public class LC015_3SumTests
{
    [TestMethod]
    public void TwoValidTriplets()
    {
        var nums = new int[] { -1, 0, 1, 2, -1, -4 };

        var result = ThreeSum(nums);

        var expected = new int[][] { new[] { -1, -1, 2 }, new[] { -1, 0, 1 } };
        Assert(expected, result);
    }

    [TestMethod]
    public void NoValidTriplet()
    {
        var nums = new int[] { 0, 1, 1 };

        var result = ThreeSum(nums);

        var expected = new int[][] { };
        Assert(expected, result);
    }

    [TestMethod]
    public void OneValidTriplet()
    {
        var nums = new int[] {  0, 0, 0 };

        var result = ThreeSum(nums);

        var expected = new int[][] { new[] { 0, 0, 0 } };
        Assert(expected, result);
    }

    [TestMethod]
    public void MultipleTriplets()
    {
        var nums = new int[] { -4, -2, 1, -5, -4, -4, 4, -2, 0, 4, 0, -2, 3, 1, -5, 0 };

        var result = ThreeSum(nums);

        var expected = new int[][] { new[] { -5, 1, 4 }, new int[] { -4, 0, 4 }, new int[] { -4, 1, 3 }, new int[] { -2, -2, 4 }, new int[] { -2, 1, 1 }, new int[] { 0, 0, 0 } };
        Assert(expected, result);
    }

    [TestMethod]
    public void MultipleTriplets2()
    {
        var nums = new int[] { -4, -2, 1, -5, -4, -4, 4, -2, 0, 4, 0, 0 };

        var result = ThreeSum(nums);

        var expected = new int[][] { new[] { -5, 1, 4 }, new int[] { -4, 0, 4 },new int[] { -2, -2, 4 }, new int[] { 0, 0, 0 } };
        Assert(expected, result);
    }

    private void Assert(int[][] expected, IList<IList<int>> actual)
    {
        var exp = expected.Select(x => x.ToList()).Cast<ICollection<int>>().ToList();
        Utility.AssertCollectionOfCollectionsEquivalent(exp, actual.Cast<ICollection<int>>().ToList());
    }

    private static IList<IList<int>> ThreeSum(int[] nums)
    {
        var @object = new LC015_3Sum();
        var result = @object.ThreeSum(nums);
        return result;
    }
}