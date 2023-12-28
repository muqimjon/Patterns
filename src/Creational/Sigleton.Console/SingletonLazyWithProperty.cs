namespace Singleton.Console;

internal class SingletonLazyWithProperty
{
    private SingletonLazyWithProperty() { }

    private static SingletonLazyWithProperty? instance;
    public static SingletonLazyWithProperty Instance
    {
        get
        {
            instance ??= new SingletonLazyWithProperty();
            return instance;
        }
    }
}
