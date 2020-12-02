using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace BasicSample.Skia.Tizen
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new TizenHost(() => new BasicSample.App(), args);
            host.Run();
        }
    }
}
