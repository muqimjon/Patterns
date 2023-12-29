namespace Example.Console;

internal class PrototypeWithFunction
{
    public PrototypeWithFunction Clone()
        => (PrototypeWithFunction)MemberwiseClone();
}
