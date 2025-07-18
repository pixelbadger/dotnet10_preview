/// <summary>
/// Assignment to a potentially null instance can now be performed using the null conditional operator
/// </summary>
public static class NullConditionalAssignment
{
    public static void RunExample()
    {
        Message? message = null;

        // pre C# 14:
        if (message is not null)
        {
            message.Text = "Hello world!";
        }

        // now:
        message?.Text = "Hello world!";
    }

    private class Message
    {
        public string Text { get; set; } = string.Empty;
    }
}