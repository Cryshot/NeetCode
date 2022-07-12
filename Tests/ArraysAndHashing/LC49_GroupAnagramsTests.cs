using NeetCode.Solutions.ArraysAndHashing;

namespace NeetCode.Tests.ArraysAndHashing;

[TestClass]
public class LC49_GroupAnagramsTests
{
    [TestMethod]
    public void MultipleValidGroupAnagrams()
    {
        var strs = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };

        var result = GroupAnagrams(strs);

        var expected = new List<IList<string>>() { new List<string> { "bat" }, new List<string> { "nat", "tan" }, new List<string> { "ate", "eat", "tea" } };
        Assert(expected, result);
    }

    [TestMethod]
    public void EmptyString()
    {
        var strs = new string[] { "" };

        var result = GroupAnagrams(strs);

        var expected = new List<IList<string>>() { new List<string> { "" } };
        Assert(expected, result);
    }

    [TestMethod]
    public void SingleCharacter()
    {
        var strs = new string[] { "a" };

        var result = GroupAnagrams(strs);

        var expected = new List<IList<string>>() { new List<string> { "a" } };
        Assert(expected, result);
    }

    [TestMethod]
    public void MultipleEmptyStrings()
    {
        var strs = new string[] { "", "", "", "" };

        var result = GroupAnagrams(strs);

        var expected = new List<IList<string>>() { new List<string> { "" } };
        Assert(expected, result);
    }

    [TestMethod]
    public void TwoIdenticalWords()
    {
        var strs = new string[] { "car", "car" };

        var result = GroupAnagrams(strs);

        var expected = new List<IList<string>>() { new List<string> { "car" } };
        Assert(expected, result);
    }

    [TestMethod]
    public void SimilarWords()
    {
        var strs = new string[] { "carr", "car", "carrr" };

        var result = GroupAnagrams(strs);

        var expected = new List<IList<string>>() { new List<string> { "car" }, new List<string> { "carr" }, new List<string> { "carrr" } };
        Assert(expected, result);

    }
    private void Assert(IList<IList<string>> expected, IList<IList<string>> actual)
    {
        Utility.AssertCollectionOfCollections(expected.Cast<ICollection<string>>().ToList(), actual.Cast<ICollection<string>>().ToList());
    }

    private IList<IList<string>> GroupAnagrams(string[] strs)
    {
        var @object = new LC49_GroupAnagrams();
        var result = @object.GroupAnagrams(strs);
        return result;
    }
}