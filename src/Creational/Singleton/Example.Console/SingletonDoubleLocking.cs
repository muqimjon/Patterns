namespace Example.Console;

internal class SingletonDoubleLocking
{
    private static SingletonDoubleLocking? instance;
    private static readonly object lockObject = new();

    private SingletonDoubleLocking() { }

    public static SingletonDoubleLocking GetInstance()
    {
        if (instance is null)
            lock (lockObject)
                instance ??= new SingletonDoubleLocking();

        return instance;
    }
}