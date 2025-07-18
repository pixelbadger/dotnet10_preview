/// <summary>
/// Finally, finally, you can use nameof with unbound generics!
/// </summary>
public static class NameofUnboundGenerics
{
    public static void RunExample()
    {
        // Both produce 'List'...
        // Pre C#14 (requires type parameter):
        string list = nameof(List<int>);

        // C#14 (no type parameter required):
        string list2 = nameof(List<>);
    }
}