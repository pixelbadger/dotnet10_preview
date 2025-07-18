/// <summary>
/// New syntax for declaring extension methods. Supports properties and static methods.
/// </summary>
public static class ExtensionMembers
{
    // extension block for per-instance methods
    extension(string str)
    {
        // Implementing a standard
        public int CharCount(char chr) => str.Count(ch => ch == chr);

        // Extension properties now supported
        public int WordCount =>
            str.Split([' ', '.', '?', ','], StringSplitOptions.RemoveEmptyEntries).Length;
    }

    // extension block for static methods
    extension(string)
    {
        public static string Reverse(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        // this does allow some dubious practices...
        public static int Increment(int i) => i++;
    }

    public static void RunExample()
    {
        string testString = "Hello world!";

        // instance extension method calls
        int countOfL = testString.CharCount('l');
        int wordCount = testString.WordCount;

        // static extension method calls
        string reversed = string.Reverse(testString);
        // tremendously wrong!
        int two = string.Increment(1);
    }
}