using static MixrSharp.MixrNative;

namespace MixrSharp.Stream;

public class Opus : AudioStream
{
    public Opus(string path)
    {
        mxStreamLoadOpus(path, out Stream);
    }
}