using NeetCode.Solutions.TwoPointers;

namespace NeetCode.Tests.TwoPointers;

[TestClass]
public class LC125_ValidPalindromeTests
{
    [TestMethod]
    public void ValidPalindrome_ReturnsTrue()
    {
        var s = "A man, a plan, a canal: Panama";

        var result = IsPalindrome(s);

        Assert.IsTrue(result);
    }

    [TestMethod]
    public void InvalidPalindrome_ReturnsFalse()
    {
        var s = "race a car";

        var result = IsPalindrome(s);

        Assert.IsFalse(result);
    }

    [TestMethod]
    public void WhiteSpaceInput_ReturnsTrue()
    {
        var s = " ";

        var result = IsPalindrome(s);

        Assert.IsTrue(result);
    }

    [TestMethod]
    public void NonAlphaNumericInput_ReturnsTrue()
    {
        var s = "--....-¨§§)))===.¨´´´¨¨";

        var result = IsPalindrome(s);

        Assert.IsTrue(result);
    }

    [TestMethod]
    public void MultipleWhiteSpaceInput_ReturnsTrue()
    {
        var s = "                 ";

        var result = IsPalindrome(s);

        Assert.IsTrue(result);
    }

    [TestMethod]
    public void ComplexValidPalindrome_ReturnsTrue()
    {
        var s = "Are we not pure? “No, sir!” Panama’s moody Noriega brags. “It is garbage!” Irony dooms a man—a prisoner up to new era.";

        var result = IsPalindrome(s);

        Assert.IsTrue(result);
    }

    [TestMethod]
    public void LongValidPalindrome_ReturnsTrue()
    {
        var s = "Dennis, Nell, Edna, Leon, Nedra, Anita, Rolf, Nora, Alice, Carol, Leo, Jane, Reed, Dena, Dale, Basil, Rae, Penny, Lana, Dave, Denny, Lena, Ida, Bernadette, Ben, Ray, Lila, Nina, Jo, Ira, Mara, Sara, Mario, Jan, Ina, Lily, Arne, Bette, Dan, Reba, Diane, Lynn, Ed, Eva, Dana, Lynne, Pearl, Isabel, Ada, Ned, Dee, Rena, Joel, Lora, Cecil, Aaron, Flora, Tina, Arden, Noel, and Ellen sinned.";

        var result = IsPalindrome(s);

        Assert.IsTrue(result);
    }

    [TestMethod]
    public void AlphaNumericValidPalindrome_ReturnsTrue()
    {
        var s = "123aha321";

        var result = IsPalindrome(s);

        Assert.IsTrue(result);
    }

    [TestMethod]
    public void AlphaNumericValidPalindrome_ReturnsFalse()
    {
        var s = "12aha321";

        var result = IsPalindrome(s);

        Assert.IsFalse(result);
    }

    private static bool IsPalindrome(string s)
    {
        var @object = new LC125_ValidPalindrome();
        var result = @object.IsPalindrome(s);
        return result;
    }
}