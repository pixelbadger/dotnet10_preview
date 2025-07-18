/// <summary>
/// The field keyword removes the need for an explicit backing field by synthesising an implicit backing field.
/// </summary>
public class FieldKeyword
{
    // Pre C#14 (requires explicit backing field):
    private string _field = string.Empty;
    public string OldMessage
    {
        get => _field;
        set => _field = string.Reverse(value);
    }

    // Now (synthesised backing field via field keyword):
    // BREAKING CHANGE - cannot use an explicit backing field named 'field'
    private string field = string.Empty;
    public string Message
    {
        get;
        set => field = string.Reverse(value);
    }

    public static void RunExample()
    {
    }

    public FieldKeyword()
    {
        Message = string.Empty;
    }
}