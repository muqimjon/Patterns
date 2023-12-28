namespace Sigleton.Console;

internal class SingletonWithEager
{
    private static readonly SingletonWithEager instance = new();

    private SingletonWithEager() { }

    public static SingletonWithEager GetInstance()
        => instance;

    // other methods
}