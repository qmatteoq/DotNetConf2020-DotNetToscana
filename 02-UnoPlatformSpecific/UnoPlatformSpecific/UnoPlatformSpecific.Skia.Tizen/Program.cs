﻿using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace UnoPlatformSpecific.Skia.Tizen
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new TizenHost(() => new UnoPlatformSpecific.App(), args);
            host.Run();
        }
    }
}
