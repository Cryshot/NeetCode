using NeetCode.Solutions.ArraysAndHashing;

namespace NeetCode.Tests.ArraysAndHashing;

[TestClass]
public class LC217_ContainsDuplicateTests
{
    [TestMethod]
    public void HasDuplicity_ReturnsTrue()
    {
        var numbers = new int[] { 1, 2, 3, 1 };

        var result = ContainsDuplicate(numbers);

        Assert.IsTrue(result);
    }

    [TestMethod]
    public void NoDuplicity_ReturnsFalse()
    {
        var numbers = new int[] { 1, 2, 3, 4 };

        var result = ContainsDuplicate(numbers);

        Assert.IsFalse(result);
    }

    [TestMethod]
    public void HasMultipleDuplicities_ReturnsTrue()
    {
        var numbers = new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };

        var result = ContainsDuplicate(numbers);

        Assert.IsTrue(result);
    }

    [TestMethod]
    public void NoDuplicity_OnlyOneNumber_ReturnsFalse()
    {
        var numbers = new int[] { 5 };

        var result = ContainsDuplicate(numbers);

        Assert.IsFalse(result);
    }

    [TestMethod]
    public void NoDuplicity_NegativeNumbers_ReturnsFalse()
    {
        var numbers = new int[] { -1, 1, 2, -9, 3, -7, 4, 0 };

        var result = ContainsDuplicate(numbers);

        Assert.IsFalse(result);
    }

    [TestMethod]
    public void HasDuplicity_NegativeNumbers_ReturnsTrue()
    {
        var numbers = new int[] { -1, -2, -3, -4, -1 };

        var result = ContainsDuplicate(numbers);

        Assert.IsTrue(result);
    }

    [TestMethod]
    public void HasDuplicity_PositiveAndNegativeZero_ReturnsTrue()
    {
        var numbers = new int[] { 0, -0 };

        var result = ContainsDuplicate(numbers);

        Assert.IsTrue(result);
    }

    private bool ContainsDuplicate(int[] numbers)
    {
        var x = new LC217_ContainsDuplicate();
        var result = x.ContainsDuplicate(numbers);
        return result;
    }
}
