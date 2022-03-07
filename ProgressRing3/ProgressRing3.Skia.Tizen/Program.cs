using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace ProgressRing3.Skia.Tizen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var host = new TizenHost(() => new ProgressRing3.App(), args);
            host.Run();
        }
    }
}
