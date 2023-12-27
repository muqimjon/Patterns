namespace Singleton.Console;

internal class SingletonWithProperty
{
    private SingletonWithProperty() { }
    private static SingletonWithProperty? instance;

    public static SingletonWithProperty Instance
    {
        get
        {
            instance ??= new SingletonWithProperty();
            return instance;
        }
    }
}
