namespace ConsoleApp1;

public class Program
{
    public static bool IsPalindrome(string s)
    {
        if (string.IsNullOrEmpty(s))
        {
            return true;
        }

        var newStr = string.Concat(s.ToLowerInvariant().Where(c => !Char.IsWhiteSpace(c)));
        var reverseStr = Reverse(newStr);
        return newStr == reverseStr;
    }

    public static void Check(string s, bool shouldBePalindrome)
    {
        Console.WriteLine(IsPalindrome(s) == shouldBePalindrome ? "pass" : "FAIL");
    }

    public static void Main(string[] arg)
    {
        Check("abcba", true);
        Check("abcde", false);
        Check("Mr owl ate my metal worm", true);
        Check("Never Odd Or Even", true);
        Check("Never Even Or Odd", false);
    }

    public static string Reverse(string s)
    {
        var charArrayType = s.ToCharArray();
        Array.Reverse(charArrayType);
        return new string(charArrayType);
    }
}