namespace Singleton.Console;

internal class SingletonWithProperty1
{
    private SingletonWithProperty1() { }

    private static SingletonWithProperty1? instance;
    public static SingletonWithProperty1 Instance
    {
        get
        {
            instance ??= new SingletonWithProperty1();
            return instance;
        }
    }
}