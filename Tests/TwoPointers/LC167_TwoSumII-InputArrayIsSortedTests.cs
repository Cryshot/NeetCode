using NeetCode.Solutions.TwoPointers;

namespace NeetCode.Tests.TwoPointers;

[TestClass]
public class LC167_TwoSumII_InputArrayIsSortedTests
{
    [TestMethod]
    public void FourPositiveNumbers()
    {
        var numbers = new int[] { 2, 7, 11, 15 };
        var target = 9;

        var result = TwoSum(numbers, target);

        CollectionAssert.AreEquivalent(new int[] { 1, 2 }, result);
    }

    [TestMethod]
    public void ThreePositiveNumbers()
    {
        var numbers = new int[] { 2, 3, 4 };
        var target = 6;

        var result = TwoSum(numbers, target);

        CollectionAssert.AreEquivalent(new int[] { 1, 3 }, result);
    }

    [TestMethod]
    public void ZeroAndNegativeNumber()
    {
        var numbers = new int[] { -1, 0 };
        var target = -1;

        var result = TwoSum(numbers, target);

        CollectionAssert.AreEquivalent(new int[] { 1, 2 }, result);
    }

    [TestMethod]
    public void NegativeNumbers()
    {
        var numbers = new int[] { -4, -3, -2, -1 };
        var target = -3;

        var result = TwoSum(numbers, target);

        CollectionAssert.AreEquivalent(new int[] { 3, 4 }, result);
    }

    [TestMethod]
    public void NegativeAndPositiveNumbers()
    {
        var numbers = new int[] { -3, -2, 0, 2 };
        var target = 0;

        var result = TwoSum(numbers, target);

        CollectionAssert.AreEquivalent(new int[] { 2, 4 }, result);
    }

    [TestMethod]
    public void BigNumberTarget()
    {
        var numbers = new int[] { 3, 24, 50, 79, 88, 150, 345 };
        var target = 200;

        var result = TwoSum(numbers, target);

        CollectionAssert.AreEquivalent(new int[] { 3, 6 }, result);
    }

    [TestMethod]
    public void InputContainsSameNumbers()
    {
        var numbers = new int[] { 1, 3, 4, 4 };
        var target = 8;

        var result = TwoSum(numbers, target);

        CollectionAssert.AreEquivalent(new int[] { 3, 4 }, result);
    }

    [TestMethod]
    [Ignore("Task constraint eliminates overflow")]
    [ExpectedException(typeof(OverflowException))]
    public void NegativeOverflow_ThrowsOverflowException()
    {
        var numbers = new int[] { int.MinValue, -2, 0, 1 };
        var target = int.MinValue;

        var result = TwoSum(numbers, target);
    }

    [TestMethod]
    [Ignore("Task constraint eliminates overflow")]
    [ExpectedException(typeof(OverflowException))]
    public void PositiveOverflow_NoSolution_ThrowsOverflowException()
    {
        var numbers = new int[] { 1, 2, int.MaxValue };
        var target = int.MaxValue;

        var result = TwoSum(numbers, target);
    }

    private static int[] TwoSum(int[] numbers, int target)
    {
        var @object = new LC167_TwoSumII_InputArrayIsSorted();
        var result = @object.TwoSum(numbers, target);
        return result;
    }
}
