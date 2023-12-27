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

internal class SingletonWithProperty2
{
    private SingletonWithProperty2() { }

    private static readonly SingletonWithProperty2 instance = new();
    public static SingletonWithProperty2 Instance
    {
        get { return instance; }
    }

    // other members
}