namespace NeetCode.Tests;

internal static class Utility
{
    public static void AssertCollectionOfCollections(ICollection<ICollection<string>> expected, ICollection<ICollection<string>> actual)
    {
        foreach (var expectedSubList in expected)
        {
            var actualSubList = actual.FirstOrDefault(x => x.Contains(expectedSubList.ElementAt(0)));
            CollectionAssert.AreEquivalent(expectedSubList.ToList(), actualSubList?.ToList());
        }
    }
}
