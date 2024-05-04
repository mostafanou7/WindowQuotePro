using System.Runtime.InteropServices;

namespace WindowQuoteProGUI.Interop
{
    public static class NativeImports
    {
        [DllImport("WindowQuoteProBusinessLogic.dll", PreserveSig = false)]
        public extern static void CreateNativeQuoteManager(out iQuoteManager d);
    }
}
