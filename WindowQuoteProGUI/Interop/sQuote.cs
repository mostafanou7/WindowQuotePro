using System.Runtime.InteropServices;

namespace WindowQuoteProGUI.Interop
{
    [StructLayout(LayoutKind.Sequential)]
    public struct sQuote
    {
        public int quoteID;
        [MarshalAs(UnmanagedType.BStr)]
        public string quoteName;
        [MarshalAs(UnmanagedType.BStr)]
        public string customerName;
        public eDoorMaterial doorMaterial;
        public eDoorSize doorSize;
        public double price;
    }
}
