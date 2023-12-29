namespace Example.Console;

internal class SingletonEagerWithProperty
{
    private SingletonEagerWithProperty() { }

    private static readonly SingletonEagerWithProperty instance = new();
    public static SingletonEagerWithProperty Instance
    {
        get { return instance; }
    }

    // other members
}