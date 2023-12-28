using System.Text.Json;

namespace Prototype.Console;

[Serializable]
internal class PrototypeWithSerialization : ICloneable
{
    public object Clone()
    {
        string jsonString = JsonSerializer.Serialize(this);
        return JsonSerializer.Deserialize<PrototypeWithSerialization>(jsonString)!;
    }
}
