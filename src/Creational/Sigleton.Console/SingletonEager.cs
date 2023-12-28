namespace Sigleton.Console;

internal class SingletonEager
{
    private static readonly SingletonEager instance = new();

    private SingletonEager() { }

    public static SingletonEager GetInstance()
        => instance;

    // other methods
}