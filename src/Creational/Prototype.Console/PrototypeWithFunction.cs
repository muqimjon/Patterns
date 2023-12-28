namespace Prototype.Console;

internal class PrototypeWithFunction
{
    public PrototypeWithFunction Clone()
        => (PrototypeWithFunction)MemberwiseClone();
}
