//https://leetcode.com/problems/valid-anagram/

namespace NeetCode.Solutions.ArraysAndHashing;

public class LC242_ValidAnagram
{
    public bool IsAnagram(string s, string t)
    {
        return IsAnagram_I(s, t);
    }

    private static bool IsAnagram_I(string s, string t)
    {
        if (s == null || t == null)
            return false;

        var charsCounter = new Dictionary<char, int>();
        foreach (var character in s)
        {
            if (!charsCounter.ContainsKey(character))
                charsCounter.Add(character, 0);
            charsCounter[character]++;
        }

        foreach (var character in t)
        {
            if (!charsCounter.ContainsKey(character))
                return false;

            if (--charsCounter[character] < 0)
                return false;
        }

        foreach (var charCount in charsCounter)
        {
            if (charCount.Value != 0)
                return false;
        }

        return true;
    }

    private static bool IsAnagram_II(string s, string t)
    {
        if (s == null || t == null ||
            s.Length != t.Length)
            return false;

        var charsCounter = new Dictionary<char, int>();
        for (var i = 0; i < s.Length; i++)
        {
            var sChar = s[i];
            if (!charsCounter.ContainsKey(sChar))
                charsCounter.Add(sChar, 0);
            charsCounter[sChar]++;

            var tChar = t[i];
            if (!charsCounter.ContainsKey(tChar))
                charsCounter.Add(tChar, 0);
            charsCounter[tChar]--;
        }

        var isAnagram = !charsCounter.Any(x => x.Value != 0);
        return isAnagram;
    }

    private static bool IsAnagram_III(string s, string t)
    {
        if (s == null || t == null ||
            s.Length != t.Length)
            return false;

        var charsCounter = new Dictionary<char, int>();
        for (var i = 0; i < s.Length; i++)
        {
            var sChar = s[i];
            if (charsCounter.ContainsKey(sChar))
            {
                charsCounter[sChar]++;
                if (charsCounter[sChar] == 0)
                    charsCounter.Remove(sChar);
            }
            else
                charsCounter.Add(sChar, 1);

            var tChar = t[i];
            if (charsCounter.ContainsKey(tChar))
            {
                charsCounter[tChar]--;
                if (charsCounter[tChar] == 0)
                    charsCounter.Remove(tChar);
            }
            else
                charsCounter.Add(tChar, -1);
        }

        var isAnagram = charsCounter.Count == 0;
        return isAnagram;
    }

    private static bool IsAnagram_IV(string s, string t)
    {
        if (s == null || t == null ||
            s.Length != t.Length)
            return false;

        var sOrdered = new string(s.OrderBy(x => x).ToArray());
        var tOrdered = new string(t.OrderBy(x => x).ToArray());
        return sOrdered == tOrdered;
    }

    public void DoMeasurement()
    {
        var word1 = "the morse code";
        var word2 = "here come dots";

        var measurement = new Measurement();
        measurement.Measure("IsAnagram I", () => { IsAnagram_I(word1, word2); });
        measurement.Measure("IsAnagram II", () => { IsAnagram_II(word1, word2); });
        measurement.Measure("IsAnagram III", () => { IsAnagram_III(word1, word2); });
        measurement.Measure("IsAnagram IV", () => { IsAnagram_IV(word1, word2); });
    }
}