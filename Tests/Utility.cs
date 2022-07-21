using System.Reflection;

namespace NeetCode.Tests;

internal static class Utility
{
    public static void AssertCollectionOfCollectionsEquivalent<T>(ICollection<ICollection<T>> expected, ICollection<ICollection<T>> actual)
    {
        if (expected.Count != actual.Count)
            Assert.Fail("Actual and expected sublist count is different");

        foreach (var expectedSubList in expected)
        {
            var actualSubList = GetActualSubList(actual, expectedSubList);
            CollectionAssert.AreEquivalent(expectedSubList.ToList(), actualSubList?.ToList());
        }
    }

    private static ICollection<T> GetActualSubList<T>(ICollection<ICollection<T>> actual, ICollection<T> expectedSubList)
    {
        foreach (var actualSubList in actual)
            if (AreEquivalent(actualSubList, expectedSubList))
                return actualSubList;

        Assert.Fail("Actual sub list matching Expected sub list not found");
        return null;
    }

    private static bool AreEquivalent<T>(ICollection<T> col1, ICollection<T> col2)
    {
        if ((col1 == null) != (col2 == null))
            return false;

        if (ReferenceEquals(col1, col2) || col1 == null || col2 == null)
            return true;

        if (col1.Count != col2.Count)
            return false;

        if (col1.Count == 0)
            return true;

        var method = typeof(CollectionAssert).GetMethod("FindMismatchedElement", BindingFlags.Static | BindingFlags.NonPublic);
        return !(bool)(method?.Invoke(obj: null, parameters: new object?[] { col1, col2, 0, 0, null }) ?? false);
    }
}