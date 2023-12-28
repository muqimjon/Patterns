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
