using System.Text.Json;

namespace Example.Console;

[Serializable]
internal class PrototypeWithSerialization : ICloneable
{
    public object Clone()
    {
        string jsonString = JsonSerializer.Serialize(this);
        return JsonSerializer.Deserialize<PrototypeWithSerialization>(jsonString)!;
    }
}
