namespace Example.Console;

internal class SingletonLocking
{
    private static SingletonLocking? instance;
    private static readonly object lockObject = new();

    private SingletonLocking() { }

    public static SingletonLocking GetInstance()
    {
        lock (lockObject)
        {
            instance ??= new SingletonLocking();
            return instance;
        }
    }
}
