//namespace PluginWorld.wit.exports.wasmio.samples;

namespace PluginWorld;

public class PluginWorldImpl : IPluginWorld
{
    public static string Transform(string input)
    {
        return input.ToUpperInvariant();
    }
}