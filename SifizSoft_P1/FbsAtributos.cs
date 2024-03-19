using Dumpify;

using MethodBoundaryAspect.Fody.Attributes;
using System.Drawing;

namespace SifizSoft_P1
{
    public sealed class FbsPruebaAttribute : OnMethodBoundaryAspect
    {
        public override void OnEntry(MethodExecutionArgs args)
        {
            "===============================================================".Dump(colors: new ColorConfig { PropertyValueColor = new DumpColor(Color.RoyalBlue) });
        }

        public override void OnExit(MethodExecutionArgs args)
        {
            "===============================================================".Dump();


        }

        public override void OnException(MethodExecutionArgs args)
        {

        }
    }
}
