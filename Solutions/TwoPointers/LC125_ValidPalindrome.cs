namespace NeetCode.Solutions.TwoPointers;

public class LC125_ValidPalindrome
{
    public bool IsPalindrome(string s)
    {
        return IsPalindrome_I(s);
    }

    private static bool IsPalindrome_I(string s)
    {
        var letters = new List<char>(s.Length);
        for (var i = 0; i < s.Length; i++)
        {
            var @char = char.ToLower(s[i]);
            if ((@char >= 'a' && @char <= 'z') || (@char >= '0' && @char <= '9'))
                letters.Add(@char);
        }

        if (letters.Count == 0)
            return true;

        for (var i = 0; i < letters.Count; i++)
        {
            if (letters[i] != letters[letters.Count - 1 - i])
                return false;
        }

        return true;
    }
}