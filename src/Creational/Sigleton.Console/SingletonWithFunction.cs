namespace Sigleton.Console;

internal class SingletonWithFunction1
{
    private static SingletonWithFunction1? instance;

    private SingletonWithFunction1() { }

    public static SingletonWithFunction1 GetInstance()
    {
        instance ??= new SingletonWithFunction1();
        return instance;
    }

    // other methods
}

internal class SingletonWithFunction2
{
    private static SingletonWithFunction2 instance = new();

    private SingletonWithFunction2() { }

    public static SingletonWithFunction2 GetInstance()
        => instance;

    // other methods
}