namespace Singleton.Console;

internal class SingletonWithFunction
{
    private static SingletonWithFunction? instance;

    private SingletonWithFunction() { }

    public static SingletonWithFunction GetInstance()
    {
        instance ??= new SingletonWithFunction();
        return instance;
    }

    // yana boshqa static bo'lmagan public funksiyalarni yozib foydalanish mumkin
}
