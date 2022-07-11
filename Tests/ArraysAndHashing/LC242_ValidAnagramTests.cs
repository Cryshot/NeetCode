using NeetCode.Solutions.ArraysAndHashing;

namespace Tests.ArraysAndHashing;

[TestClass]
public class LC242_ValidAnagramTests
{
    [TestMethod]
    public void ValidAnagram_ReturnsTrue()
    {
        var result = IsAnagram("anagram", "nagaram");

        Assert.IsTrue(result);
    }

    [TestMethod]
    public void NotAnagram_ReturnsFalse()
    {
        var result = IsAnagram("rat", "car");

        Assert.IsFalse(result);
    }

    [TestMethod]
    public void NotAnagram_DifferentLength_ReturnsFalse()
    {
        var result = IsAnagram("qwer", "as");

        Assert.IsFalse(result);
    }

    [TestMethod]
    public void NotAnagram_DifferentLength2_ReturnsFalse()
    {
        var result = IsAnagram("ab", "a");

        Assert.IsFalse(result);
    }

    [TestMethod]
    public void NotAnagram_DifferentLength3_ReturnsFalse()
    {
        var result = IsAnagram("a", "ab");

        Assert.IsFalse(result);
    }

    [TestMethod]
    public void NotAnagram_NullAndWhiteSpaceString_ReturnsFalse()
    {
        var result = IsAnagram(null, "  \t");

        Assert.IsFalse(result);
    }

    [TestMethod]
    public void NotAnagram_SecondStringNull_ReturnsFalse()
    {
        var result = IsAnagram("asdf", null);

        Assert.IsFalse(result);
    }

    [TestMethod]
    public void ValidAnagram_MultipleWordsWithSpaces_ReturnsTrue()
    {
        var result = IsAnagram("eleven plus two", "twelve plus one");

        Assert.IsTrue(result);
    }

    private bool IsAnagram(string word1, string word2)
    {
        var lc242 = new LC242_ValidAnagram();
        var result = lc242.IsAnagram(word1, word2);
        return result;
    }
}