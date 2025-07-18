/// <summary>
/// Implicit lambda parameter types can now be used with parameter modifiers (out, ref, etc.)
/// </summary>
public class SimpleLambdaParameters
{
    delegate void TryParse<T>(string text, out T result, out bool success);

    public static void RunExample()
    {
        // pre C#14 (parameter types must be declared when using out modifiers):
        TryParse<int> tryParse = (string text, out int result, out bool success) => success = int.TryParse(text, out result);

        // C#14 (implicit parameter types even though out modifiers used):
        TryParse<bool> tryParse2 = (text, out result, out success) => success = bool.TryParse(text, out result);
    }
}