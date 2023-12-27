namespace Sigleton.Console;

internal class SingletonWithFunction
{
    private static SingletonWithFunction? instance;

    private SingletonWithFunction() { }

    public static SingletonWithFunction GetInstance()
    {
        instance ??= new SingletonWithFunction();
        return instance;
    }

    // other methods
}
