using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace DigitalSpeakerAssistant.Skia.Tizen
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new TizenHost(() => new DigitalSpeakerAssistant.App(), args);
            host.Run();
        }
    }
}
