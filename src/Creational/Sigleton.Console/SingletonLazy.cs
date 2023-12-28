namespace Sigleton.Console;

internal class SingletonLazy
{
    private static SingletonLazy? instance;

    private SingletonLazy() { }

    public static SingletonLazy GetInstance()
    {
        instance ??= new SingletonLazy();
        return instance;
    }

    // other methods
}
